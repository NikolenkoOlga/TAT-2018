using System;
using System.Text;
using Xunit;
using Task_2;



namespace xUnitTestProject2
{
    public class Test
    {
        [Fact]
        public void EmptyStringTest()
        {
            //act
            OutputEvenIndex inputString = new OutputEvenIndex(String.Empty);
            //assert
            Assert.Null(inputString.DeleteAndPrintEvenIndex());
        }

        [Fact]
        public void EvenIndexTest()
        {
            //arrange
            string str = "rjnbrb";
            string result = "rnr";            
            //act
            OutputEvenIndex inputString = new OutputEvenIndex(str);
            //assert
            Assert.Equal(result, inputString.DeleteAndPrintEvenIndex());
        }

        [Fact]
        public void EvenIndexWithSymbolsTest()
        {
            //arrange
            string str = "r*2**jn// b _R _bBR_' ";
            string result = "r2*n/b_ bR'";
            //act
            OutputEvenIndex inputString = new OutputEvenIndex(str);
            //assert
            Assert.Equal(result, inputString.DeleteAndPrintEvenIndex());
        }
    }
}
