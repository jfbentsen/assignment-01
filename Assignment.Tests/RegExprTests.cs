using Xunit;
using System.Collections.Generic;

namespace Assignment.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void SplitLine_givenLines_returnWords()
        {
            List<string> expected = new List<string>(){"Seje", "reje", "Simon", "er", "god"};
            List<string> lines = new List<string>(){"Seje reje", "Simon er god"};
            var output = RegExpr.SplitLine(lines);

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ResolutiongivenResolutionStringReturnStreamAsTuples()
        {
            
            List<(int,int)> expected = new List<(int,int)>(){(1024,768),(800,600),(640,480)};
            string resolutions = "1024x768, 800x600, 640x480";
            IEnumerable<(int width,int height)> output = RegExpr.Resolution(resolutions);

            Assert.Equal(expected,output);
        }

        [Fact]
        public void InnerTextGivenSimpleHTML()
        {
            string html = @"<div>
                <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=""/wiki/Theoretical_computer_science"" title=""Theoretical computer science"">theoretical computer science</a> and <a href=""/wiki/Formal_language"" title=""Formal language"">formal language</a> theory, a sequence of <a href=""/wiki/Character_(computing)"" title=""Character (computing)"">characters</a> that define a <i>search <a href=""/wiki/Pattern_matching"" title=""Pattern matching"">pattern</a></i>. Usually this pattern is then used by <a href=""/wiki/String_searching_algorithm"" title=""String searching algorithm"">string searching algorithms</a> for ""find"" or ""find and replace"" operations on <a href=""/wiki/String_(computer_science)"" title=""String (computer science)"">strings</a>.</p>
            </div>";
            var expected = new List<string> { "theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings" };           
            var outputOfInnerText = RegExpr.InnerText(html, "a");
            var actual = new List<string>();
            foreach (var m in outputOfInnerText)
            {
                actual.Add(m);
            }
            Assert.Equal(expected,actual);
        }
    }
}