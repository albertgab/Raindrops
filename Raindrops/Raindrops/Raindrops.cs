using System;

namespace Raindrops
{
    public static class Raindrops
    {
        public static string GetRaindrops(int n)
        {
            var result = "";
            if (n % 3 == 0) { result += "Pling"; }
            if (n % 5 == 0) { result += "Plang"; }
            if (n % 7 == 0) { result += "Plong"; }
            return result == "" ? n.ToString() : result;
        }
    }
}
