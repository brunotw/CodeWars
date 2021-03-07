using System.Text;

namespace BreakCamelCase
{
    public class BreakCamelCase
    {
        public static string BreakCamelCaseString(string str)
        {
            StringBuilder SB = new StringBuilder();

            foreach (char C in str)
            {
                if (char.IsUpper(C))
                    SB.Append(' ');

                SB.Append(C);
            }

            return SB.ToString();
        }
    }
}
