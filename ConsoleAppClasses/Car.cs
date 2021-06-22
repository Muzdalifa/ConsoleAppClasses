using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppClasses
{
    public class Car
    {
        //default sccess modifier is private inside a class
        static int idCounter = 0;
        public static int IdCounter { get { return idCounter; } } //if we want to read Id counter outside this class
        readonly int id;

        public int Id { get { return id; } } //Id of individual car
        //public readonly string brand = "902s"; // we can initialize read only here or in the constructor
        public readonly string brand; //field

        private string model;
        public string Model //property
        { 
            get
            { 
                return model; 
            } 
            private set
            {
                //if(value.Equals("") || value.Equals(" "))
                if (string.IsNullOrWhiteSpace(value))
                    {
                    throw new ArgumentException("Model can't be empty.");
                }
                model = value;
            }
        }
        public string color;
        public int year;
        public int hp;

        //if you dont make a constructor, C# will add a zero constructo/default constructor for you
        public Car(string brand, string carModel, string color, int year, int hp)
        {
            id = ++idCounter; //we put ++ before because we want the first id to be 1.
            this.brand = brand;
            Model = carModel;
            this.color = color;
            this.year = year;
            this.hp = hp;
        }

        public string Info()
        {
            //Console.WriteLine($"-----Car Info-----\nId : {id}\nbrand : {brand}\tmodel : {model}\ncolor : {color}\tYear : {year}\tHP : {hp}");
            return $"-----Car Info-----\nId : {id}\nbrand : {brand}\nmodel : {model}\ncolor : {color}\nYear : {year}\nHP : {hp}";
        }

        public override string ToString()
        {
            return Info();
        }
    }

    
}
