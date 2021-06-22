using System;
using Xunit;
using ConsoleAppClasses; // you need to add dependences first and then to add this line to be able to access Car class, and it must be public

namespace ConsoleAppClasses.Tests
{
    public class CarTests
    {
        /*
        *1. Constructor sets all relevant data right 
        * 2. Model prop prevent null empty whitespace
        * 3. All info in string from Info method
        */

        [Fact]
        public void Constructor()
        {
            //Arrange
            string brand = "Saab";
            string model = "9-5";
            string color = "blue";
            int year = 1987;
            int hp = 210;
            Car testCar = null;

            //Act
            testCar = new Car(brand, model, color, year, hp);

            //Assert
            Assert.NotNull(testCar);
            Assert.Equal(brand, testCar.brand);
            Assert.Equal(model, testCar.Model);
            Assert.Equal(color, testCar.color);
            Assert.Equal(year, testCar.year);
            Assert.Equal(hp, testCar.hp);
        }
    }
}
