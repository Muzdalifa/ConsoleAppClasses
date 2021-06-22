using System;
using Xunit;

namespace ConsoleAppClasses.Tests
{
    public class CarTests
    {
        /*
        *1. Constructor sets all relevant data right 
        * 2. Model prop prevent null empty whitespace
        * 3. All info in string from Info method
        */

        [Fact]//if we have many data we use theory instead
        public void Constructor()
        {
            //Arrange: prepare the things we need to do the test
            string brand = "Saab";
            string model = "9-5";
            string color = "blue";
            int year = 1987;
            int hp = 210;
            Car testCar = null;

            //Act: run the method we are testing and collect data needed to verify what effect it hade
            testCar = new Car(brand, model, color, year, hp);

            //Assert: validate if the method did what it was supposed to do.
            Assert.NotNull(testCar);
            Assert.Equal(brand, testCar.brand);
            Assert.Equal(model, testCar.Model);
            Assert.Equal(color, testCar.color);
            Assert.Equal(year, testCar.year);
            Assert.Equal(hp, testCar.hp);
        }

        [Theory]
        [InlineData("900")]
        [InlineData("900S")]
        [InlineData("9-5")]
        [InlineData("9-X")]
        [InlineData("Kadett")]
        [InlineData("X3")]
        [InlineData("Diablo")]
        [InlineData("Model 3")]
        public void ModelPropValidInputs(string modelInput)
        {
            //Arrange
            string brand = "Saab";            
            string color = "blue";            
            int year = 1987;
            int hp = 210;
            Car testCar = null;

            //Act
            testCar = new Car(brand, modelInput, color, year, hp);

            //Assert
            Assert.Equal(modelInput, testCar.Model);
        }
        //testing bad input
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ModelPropBadInputs(string modelInput)
        {
            //Arrange
            string brand = "Saab";
            string color = "blue";
            int year = 1987;
            int hp = 210;

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(
                                       ()=> new Car(brand, modelInput, color,year,hp));

            //Assert
            Assert.Equal("Model can't be empty.", result.Message);
        }
    }
}
