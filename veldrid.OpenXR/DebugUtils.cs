namespace Veldrid.OpenXR
{
    public static class DebugUtils
    {
        public static void LogLine([System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0, [System.Runtime.CompilerServices.CallerFilePath] string file = "")
        {
            Console.WriteLine(file + ": " + lineNumber);
        }
    }
}