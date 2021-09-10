using Xunit;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_Given_Matrix_Return_Array_ABCD()
        {
            //Assert
            var in1 = new string[]{"A","B"};
            var in2 = new string[]{"C","D"};
            var in3 = new string[][]{in1,in2};

            var expected = new string[]{"A", "B", "C", "D"};

            //Act
            var output = Iterators.Flatten(in3);

            //Assert
            Assert.Equal(expected, output);
        }
    }
}
