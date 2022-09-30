using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            foreach (var item in lines)
            {
                String[] words = item.Split(" ");
                foreach (var word in words)
                {
                    yield return word;
                };
            }
        }
        
        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            Match m = Regex.Match(resolutions, "(?<width>[0-9]*)x(?<height>[0-9]*)");
            var matches = Regex.Matches(resolutions, @"(?<width>[0-9]+)x(?<height>[0-9]+)");
            string[] splitResolutions = resolutions.Split("x");
            foreach (Match match in matches)
            {
                int height = Int32.Parse(match.Groups["height"].Value);
                int width = Int32.Parse(match.Groups["width"].Value);
                yield return (width, height);
            }   
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            String regex1 = $@"(?<{tag}><[^b](?:\s|>)[^<>]+>(?<text>[^<]+))";
            String regex2 = @"(?<partTwo>(?<statTag>[<]{0,4}[>])|(?<endTag>[<\/].{0,4}[>]))";
        
            if (Regex.IsMatch(html, regex1)) {
                foreach (Match m in Regex.Matches(html, regex1)) {
                    GroupCollection gc = m.Groups;
                    yield return gc["text"].ToString();
                }
            } else {
                yield return Regex.Replace(html, regex2, "").Trim();
            }

        }
        
    }   
}