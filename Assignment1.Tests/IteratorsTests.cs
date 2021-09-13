using Xunit;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_Given_Matrix_Return_Array_ABCD()
        {
            //Arrange
            var in1 = new string[]{"A","B"};
            var in2 = new string[]{"C","D"};
            var in3 = new string[][]{in1,in2};

            var expected = new string[]{"A", "B", "C", "D"};

            //Act
            var output = Iterators.Flatten(in3);

            //Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Filter_Given_1_2_3_4_5_return_2_4(){
            //Arrange
            var input = new int[]{1,2,3,4,5};
            
            var expected = new int[]{2,4};

            //Act
            Predicate<int> predicate = Iterators.Even;
            var output = Iterators.Filter(input, predicate);

            Assert.Equal(expected, output);
        }
    }
}
