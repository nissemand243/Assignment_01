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

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
