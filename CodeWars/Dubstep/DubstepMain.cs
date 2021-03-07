using System.Text.RegularExpressions;

namespace Dubstep
{
    public class DubstepMain
    {
        public static string SongDecoder(string input)
        {
            return Regex.Replace(input.Replace("WUB", " ").Trim(), @"\s+", " ");

        }
    }
}
