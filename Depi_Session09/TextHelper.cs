using System.Text;

namespace Depi_Session09
{
    public static class TextHelper
    {
        // Bonus) Step 1: first we write it as a NORMAL static method:
        //
        //     public static bool IsShorterThan(string value, int length)
        //     {
        //         return value.Length < length;
        //     }
        //     ... and we call it like this:  TextHelper.IsShorterThan("Stethoscope", 5);
        //
        // Step 2: add the "this" keyword before the first parameter -> it becomes an EXTENSION method,
        // and we can call it as if it belongs to string:  "Stethoscope".IsShorterThan(5);

        // Q9-1) true if the string length is less than the given length
        public static bool IsShorterThan(this string value, int length)
        {
            return value.Length < length;
        }

        // Q9-2) "Ha".Repeat(3) -> "HaHaHa"
        public static string Repeat(this string value, int times)
        {
            if (times <= 0)
                return string.Empty;

            return new StringBuilder().Insert(0, value, times).ToString();
        }
    }
}
