namespace Veldrid.OpenXR.PostCompilerFixup;

[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
internal sealed class RemoveBaseConstructorCallAttribute : Attribute
{
    public bool KeepInitialization = true;
    public string ReplaceWith;
    public RemoveBaseConstructorCallAttribute() { }
}