
using System;

namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //throw new Exception();
        }


        [Theory]
        [InlineData(10, 20, 30)]
        [InlineData(2, 2, 4)]
        [InlineData(10, 2, 12)]
        public void CanAddAnyTwoIntegers(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }
  
    }
    public void BasicOOPStuff()
    {
        string Name = "          Dil";

    }
}
