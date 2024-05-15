using System.Security.Cryptography.X509Certificates;

namespace Functions_class
{
    public class Program
    {
        static void Main(string[] args)
        {
            // num = 5;
            //AddTwoNumbers(5,4);
            //ShowMyName();

            //int multiply = MultiplyTwoNumbers(3,5);
            //Console.WriteLine($"{multiply} is the answer");
            //Console.WriteLine($"{MultiplyTwoNumbers(10, 5)} is the answer");
            //Console.WriteLine($"{MultiplyTwoNumbers(10, 5)} is the answer");
            //Console.WriteLine($"{MultiplyTwoNumbers(10, 5)} is the answer");
            //Console.WriteLine($"{MultiplyTwoNumbers(10, 5)} is the answer");
            //Console.WriteLine($"{MultiplyTwoNumbers(10, 5)} is the answer");
            //argument
            //Console.WriteLine(IsEven(13));

            // Array
            //int[] numbers = { 2, 3, 4, 4, 55, 6, 6, 7, 7, 8, 8 };
            //string[] names = { "yudygdssdsdsd", "eyechbc", "Ade", "Bolu" };

            //int NumberLength = numbers.Length;
            ////Console.WriteLine(NumberLength);

            ////Console.WriteLine(numbers.Average());

            //// Linq =>
            //int howManySeven = numbers.Count(num => num == 7);
            //string startWithA = names.Where(x => x.StartsWith('A')).First();
            //Console.WriteLine(howManySeven);
            //Console.WriteLine(startWithA);
            
            // object 1
            Car car1 = new Car("Toyota","Yellow",150,2020);
            Car car2 = new Car();
            car2.Name = "Ford";
            car2.Color = "Blue";
            car2.Speed = 200;
            Car car3 = new Car();
            car3.Name = "BMW";
            car3.Color = "Yellow";
            car3.Speed = 250;
            car3.Year = 2002;

            Console.WriteLine($"Name: {car1.Name} Color: {car1.Color} Year: {car1.Year} Speed: {car1.Speed}");
            Console.WriteLine(car2.Year);
            Console.WriteLine(car3.Year);

            //car1.SpeedMovement(5);
            //car3.SpeedMovement(10);


            Console.ReadLine();
        }

        public static void AddTwoNumbers(int num1,int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static int MultiplyTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        public static void ShowMyName()
        {
            Console.WriteLine("Your name is Philip");
        }

        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
