using System;

namespace ConsoleAppClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Car id counter {Car.IdCounter}");

            Car myCar1 = new Car("Saab","567","Dark blue",1989,320 );
            Console.WriteLine("Car id counter: " + Car.IdCounter);
            //myCar.brand = "KLO"; ERROR! a read only property could not be set except on the constructor or first during initialization
            Car myCar2 = new Car("Toyota", "900S", "Dark Green", 2009, 380);
            Console.WriteLine("Car id counter: " + Car.IdCounter);

            Car myCar3 = new Car("Volvo", "740", "Brun", 1981, 120);
            Console.WriteLine($"Car id counter {Car.IdCounter}");

            Car myCar4 = new Car("Volvo", "740", "Brun", 1981, 120);
            Console.WriteLine("Car id counter: " + Car.IdCounter);

            Car myCar5 = new Car("BMW", "525i", "Black", 2001, 420);
            Console.WriteLine("Car id counter: " + Car.IdCounter);

            Console.WriteLine(myCar1);
            Console.WriteLine(myCar2);
            Console.WriteLine(myCar3);
            Console.WriteLine(myCar4);
            Console.WriteLine(myCar5);   
        }

    }
}
