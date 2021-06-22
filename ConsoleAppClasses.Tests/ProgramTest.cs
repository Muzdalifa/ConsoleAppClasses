using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleAppClasses.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void GoffieDoubleMath()
        {
            //Arange
            double num1 = 99;
            double num2 = 0;

            //Act
            double result = Program.DivMath(num1, num2);

            //Assert
            //Assert.Equal(8,result); // is correct statement but  its not good to use here
            Assert.True(Double.IsInfinity(result));
        }

        [Fact]
        public void PrecissionDoubleMath()
        {
            //Arange
            double num1 = 1;
            double num2 = 3;
            double expected = 0.333;

            //Act
            double result = Program.DivMath(num1, num2);

            //Assert
           Assert.Equal(expected,result,3); //the last three is the precission when we work with double, Assert.Equal(expected,result) will fail
        }
    }
}
