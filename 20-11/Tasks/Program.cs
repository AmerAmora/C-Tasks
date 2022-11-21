using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string yourName;
            Console.WriteLine("Enter your name");
            yourName = Console.ReadLine();
            Console.WriteLine("Name = " + yourName);
            //Task 2
            double doublenum = 10.5;
            string name = "Amer";
            char character = 'A';
            bool flag = true;
            int num = 1;
            const int num2 = 2;
            Console.WriteLine("Double " + doublenum + " String " + name + " Char " + character + " Bool " + flag + " Int " + num + " Const " + num2);



            //Task 3

            string[] car = { "BMW", "Volvo", "Toyoto", "Mazda" };
            Console.WriteLine(car[0] + " " + car[1] + " " + car[2] + " " + car[3] + " Length " + car.Length);
            //Task 4
            string firstName, surName;
            int yearOfBirth;

            Console.WriteLine("Enter your first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            surName = Console.ReadLine();
            Console.WriteLine("Enter your year of birth");
            yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(firstName + " " + surName + " " + yearOfBirth);
            //Task 5
            int[] numbers = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            //Task6


            int[] elements = { 1, 2, 3, };
            int sum;
            sum = elements[0] + elements[1] + elements[2];
            Console.WriteLine("Sum = " + sum);


        }
    }
}
