using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            
            string regexSplitPattern = "[^A-Za-z0-9]";
            string regexMatchPattern = "[A-Za-z0-9]";

            foreach (string s in lines)
            {
                foreach (string splitString in Regex.Split(s, regexSplitPattern))
                {
                    if (Regex.Match(splitString, regexMatchPattern).Success) {
                        yield return splitString;
                    }
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions)
        {
            // (?<a>\d+) is named capture group, a and b is resolution numbers 
              var reg = @"((?<a>\d+)x(?<b>\d+))+"; 
         
           foreach (string line in resolutions) {
               foreach (Match m in Regex.Matches(line, reg))
               {

                   yield return (Int32.Parse(m.Groups["a"].Value), Int32.Parse(m.Groups["b"].Value));
               }
           }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            //divides the different tags up 
             var reg = $@"(<{tag}.*?>(?<innerText>.+?)<\/{tag}>)+";

            foreach (Match m in Regex.Matches(html, reg))
            {
                // looks at the tags and finds the inner text
                yield return Regex.Replace(m.Groups["innerText"].Value, @"(<.+?>)|(<\/.+?>)", "");
            }
        }
    }
}
