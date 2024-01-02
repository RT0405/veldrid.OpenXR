//this file allows the nonsense with the XrVkGraphicsDevice to work, because that class has to access many private base class fields and members

using System.Runtime.CompilerServices;

[assembly: IgnoresAccessChecksTo("Veldrid")]
namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class IgnoresAccessChecksToAttribute(string assemblyName) : Attribute
{
    public string AssemblyName { get; } = assemblyName;
}