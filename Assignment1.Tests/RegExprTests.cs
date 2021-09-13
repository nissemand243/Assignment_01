using Xunit;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void SplitLine_Given_Stream_Return_Stream_Of_Words()
        {
            //Assert
            var input = new string[]{"foo", "Bar", " foo", ". foo is bar, BAR No 1 fOO"};

            var expected = new string[]{"foo", "Bar", "foo", "foo", "is", "bar", "BAR", "No", "1", "fOO"};

            //Act
            var output = RegExpr.SplitLine(input);

            //Assert
            Assert.Equal(expected, output);
        }
         [Fact]
        public void Resolution_Given_Stream_Of_Resolutions()
        {
            //Assert

             var resolutions = new[] {
                "1920x1080",
                "1024x768, 800x600, 640x480",
                "320x200, 320x240, 800x600",
                "1280x960"
            };
        var expected = new[] { (1920, 1080),(1024, 768),(800, 600),(640, 480), (320, 200), (320, 240),  (800, 600),(1280, 960) };

            // Act
            var output = RegExpr.Resolution(resolutions);

            // Assert
            Assert.Equal(expected, output);
        }
          [Fact]
        public void InnerText_given_a() {
            //Assert

            var html = "<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";
            var expected = new[]{ "theoretical computer science", "formal language","characters", "pattern", "string searching algorithms", "strings"};
        
            //Act
            var output = RegExpr.InnerText(html, "a");

            //Assert
            Assert.Equal(expected , output);
        }
            [Fact]
        public void InnerText_given_p() {
            //Assert
            var html = "<div><p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p></div>";
            var expected =new[] {"The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."};
           
            //Act
            var output = RegExpr.InnerText(html, "p");
            
            //Assert
            Assert.Equal(expected, output);
        }
    }


}
