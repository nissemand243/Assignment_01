using Xunit;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_Given_Matrix_Return_Array_ABCD()
        {
            //Assign
            var input = new string[]{{"A","B"}, {"C", "D"}}

            var expected = new string[]{"A", "B", "C", "D"}

            var output = new string[] Iterators.Flatten<string[]>(input);

            Assert.Equal(expected, output);


        }
    }
}
