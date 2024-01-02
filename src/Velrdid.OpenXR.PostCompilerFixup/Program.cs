using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;

namespace Velrdid.OpenXR.PostCompilerFixup;
internal class Program
{
    private static string BinPath;
    private const string XRDll = @"\Veldrid.OpenXR.dll";

    static void Main(string[] args)
    {
        try
        {
            //File.Copy(BinPath + XRDll + '2', BinPath + XRDll);
            //return;
            BinPath = $@"..\Veldrid.OpenXR\bin\{args[0]}\net8.0";
            Console.WriteLine("Removing Base Cosntructors");
            ModuleDefinition velridOpenXr = ModuleDefinition.ReadModule(BinPath + XRDll + '2', new() { AssemblyResolver = new CustomResolver() });
            RemoveBaseConstructors(velridOpenXr);
            velridOpenXr.Write(BinPath + XRDll);
            Console.WriteLine("complete");
        }
        catch (Exception e)
        {
            Console.WriteLine();
            Console.WriteLine(e.ToString());
            Console.ReadKey();
        }
    }
    //private static void AddIgnoreAccessChecksToAttribute(ModuleDefinition module)
    //{
    //    module.Assembly.CustomAttributes.Add(
    //        new CustomAttribute(
    //            module.ImportReference(
    //                module.GetType("System.Runtime.CompilerServices", "IgnoresAccessChecksToAttribute")
    //                .GetConstructors()
    //                .Single((m) => m.Parameters.Count == 1 && m.Parameters[0].ParameterType.Name.Equals("string", StringComparison.OrdinalIgnoreCase)))));
    //}
    public static void RemoveBaseConstructors(ModuleDefinition module)
    {
        Instruction systemObjectConstructor;
        systemObjectConstructor = Instruction.Create(OpCodes.Call, module.ImportReference(module.ImportReference(typeof(object)).Resolve().GetConstructors().First()));

        ExecuteForeachMethod(module, (m) =>
        {
            if (m.CustomAttributes == null)
                return;
            if (!m.IsConstructor)
                return;
            bool remove = false;
            for (int i = 0; i < m.CustomAttributes.Count; i++)
            {
                if (m.CustomAttributes[i].AttributeType.FullName == "Veldrid.OpenXR.PostCompilerFixup.RemoveBaseConstructorCallAttribute")
                {
                    remove = true;
                    m.CustomAttributes.RemoveAt(i);
                }
            }
            if (remove)
                RemoveBaseConstructor(m);
        });
        void RemoveBaseConstructor(MethodDefinition constructor)
        {
            Console.WriteLine(constructor.FullName + " is indeed being modified");
            MethodBody body = constructor.Body;
            ILProcessor processor = body.GetILProcessor();
            Instruction prevInstruction = null;

            (int baseConstructorCallStart, int baseConstructorCallEnd) = IdentifyBaseConstructorCallInstructionRange(constructor);
            if (baseConstructorCallEnd >= body.Instructions.Count) // base constructor call not found
                throw new("Error: base constructor call not found");

            Instruction baseConstructorCallInstruction = body.Instructions[baseConstructorCallEnd];
            for (int i = baseConstructorCallStart; i <= baseConstructorCallEnd - baseConstructorCallStart; i++)
                processor.RemoveAt(baseConstructorCallStart);// if we were to use "i" here it would mess up since the index of the next instruction is moved back by one each time

            if (baseConstructorCallInstruction.OpCode == OpCodes.Call && baseConstructorCallInstruction.Operand is MethodReference reference)// we use baseConstructorCallStart here since the 
            {
                MethodDefinition baseConstructor = module.ImportReference(reference).Resolve();
                if (baseConstructor.ReturnType.Name == "object")
                {
                    throw new("Error: base constructor is system.object, ignoring");
                }
                CopyFieldAndPropertyInitilizationIL(baseConstructor);
            }
            else
            {
                throw new("Error: Hrmmmm");
            }


            void AddToStart(Instruction instruction)
            {
                if (prevInstruction == null)
                    processor.InsertBefore(processor.Body.Instructions[0], instruction);
                else
                    processor.InsertAfter(prevInstruction, instruction);
                prevInstruction = instruction;
            }
            Instruction ImportInstruction(Instruction instruction)
            {
                if (instruction.OpCode == OpCodes.Newobj || instruction.OpCode == OpCodes.Call)
                    return processor.Create(instruction.OpCode, module.ImportReference((MethodReference)instruction.Operand));
                else if (instruction.OpCode == OpCodes.Stfld)
                    return processor.Create(instruction.OpCode, module.ImportReference((FieldReference)instruction.Operand));
                else
                    return instruction;
            }
            void CopyFieldAndPropertyInitilizationIL(MethodDefinition baseConstructor)
            {
                Instruction prevInstructionR = prevInstruction;
                prevInstruction = null;
                (int InstructionCopyCount, int baseConstructorCallIndex) = IdentifyBaseConstructorCallInstructionRange(baseConstructor);
                for (int i = 0; i < InstructionCopyCount; i++)
                    AddToStart(ImportInstruction(baseConstructor.Body.Instructions[i]));

                if (baseConstructorCallIndex < baseConstructor.Body.Instructions.Count)
                    CopyFieldAndPropertyInitilizationIL(((MethodReference)baseConstructor.Body.Instructions[baseConstructorCallIndex].Operand).Resolve());
                prevInstruction = prevInstructionR;
            }
            (int, int) IdentifyBaseConstructorCallInstructionRange(MethodDefinition method)
            {
                int lastLdArg0 = 0;
                int i;
                for (i = 0; i < method.Body.Instructions.Count && !IsBaseConstructorCall(method.Body.Instructions[i]); i++)
                {
                    if (method.Body.Instructions[i].OpCode == OpCodes.Ldarg_0)
                        lastLdArg0 = i;
                }
                Console.WriteLine($"{lastLdArg0}, {i}");
                return (lastLdArg0, i);
            }
            bool IsBaseConstructorCall(Instruction instruction)
            {
                return instruction.OpCode == OpCodes.Call && instruction.Operand is MethodReference methodRef && methodRef.Resolve().IsConstructor;
            }
        }
    }
    public static void ExecuteForeachMethod(ModuleDefinition module, Action<MethodDefinition> PerMethod)
    {
        for (int t = 0; t < module.Types.Count; t++)
        {
            TypeDefinition type = module.Types[t];
            if (type.BaseType == null)
                continue;
            for (int m = 0; m < type.Methods.Count; m++)
            {
                PerMethod?.Invoke(type.Methods[m]);
            }
        }
    }
    private class CustomResolver : BaseAssemblyResolver
    {
        private readonly DefaultAssemblyResolver _defaultResolver;

        public CustomResolver()
        {
            _defaultResolver = new DefaultAssemblyResolver();
        }

        public override AssemblyDefinition Resolve(AssemblyNameReference name)
        {
            AssemblyDefinition assembly;
            try
            {
                assembly = _defaultResolver.Resolve(name);
            }
            catch
            {
                assembly = SearchDirectory(name, new string[] { BinPath }, new());
                if (assembly != null)
                    return assembly;
                else
                {
                    Console.WriteLine("oh noo");
                    throw;
                }
            }
            return assembly;
        }
    }
}