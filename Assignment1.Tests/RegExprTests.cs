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
    }
}
