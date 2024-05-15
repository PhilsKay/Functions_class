using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_class
{
    public class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public int Year { get; set; }

        public static int number = 50;

        private const int Number2 = 50;
        private readonly int Number3 = 50;


        // new Car()
        public Car()
        {
            Year = 2024;
            Number3 = 45;
        }
        public Car(string name, string color, int speed, int year)
        {
            Name = name;
            Color = color;  
            Speed = speed;
            Year = year;    
        }
        public void SpeedMovement(int distance)
        {
            Console.WriteLine($"The speed is {distance * Speed * number}");
        }

    }

}
