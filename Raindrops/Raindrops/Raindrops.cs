using System;

namespace Raindrops
{
    public static class Raindrops
    {
        /// <summary> Gets any number and converts it in to raindrops.</summary>
        /// <param name="n"></param>
        /// <returns>A string containing generated raindrops.</returns>
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
