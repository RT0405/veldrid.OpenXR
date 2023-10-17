using System.Text;

namespace Veldrid.OpenXR;
public static partial class OpenXRUtils
{
    private static unsafe string GetString(byte* stringStart)
    {
        int characters = 0;
        while (stringStart[characters] != 0)
        {
            characters++;
        }

        return Encoding.UTF8.GetString(stringStart, characters);
    }
}