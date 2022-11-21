using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Task1
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2) Console.WriteLine(num1);
            else if (num2 > num1) Console.WriteLine(num2);
            else Console.WriteLine("Equal numbers");

            ////Task 2 
            Console.WriteLine("Enter singed number");
            int t2num = Convert.ToInt32(Console.ReadLine());
            if (t2num > 0) Console.WriteLine("+");
            else Console.WriteLine("-");
            ////Task3
            int t3num1 = Convert.ToInt32(Console.ReadLine());
            int t3num2 = Convert.ToInt32(Console.ReadLine());
            int t3num3 = Convert.ToInt32(Console.ReadLine());

            if (t3num2 > t3num1 && t3num2 > t3num3)
            {
                if (t3num1 > t3num3)
                    Console.WriteLine(t3num2 + " " + t3num1 + " " + t3num3);
                else
                {
                    Console.WriteLine(t3num2 + " " + t3num3 + " " + t3num1);
                }

            }
            else if (t3num3 > t3num1 && t3num3 > t3num2)
            {

                if (t3num1 > t3num2)
                    Console.WriteLine(t3num3 + " " + t3num1 + " " + t3num2);
                else
                {
                    Console.WriteLine(t3num3 + " " + t3num2 + " " + t3num1);
                }
            }
            else if (t3num1 > t3num2 && t3num1 > t3num3)
            {

                if (t3num2 > t3num3)
                    Console.WriteLine(t3num1 + " " + t3num2 + " " + t3num3);
                else
                {
                    Console.WriteLine(t3num1 + " " + t3num3 + " " + t3num2);
                }
            }
            ////Task4
            int[] t4num = new int[5];
            Console.WriteLine("enter num 1");
            t4num[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num 2");
            t4num[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num 3");
            t4num[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num 4");
            t4num[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num 5");
            t4num[4] = Convert.ToInt32(Console.ReadLine());
            int max = t4num[0];
            if (max < t4num[1]) max = t4num[1];
            if (max < t4num[2]) max = t4num[2];
            if (max < t4num[3]) max = t4num[3];
            if (max < t4num[4]) max = t4num[4];
            Console.WriteLine(max);


            //Task 5
            Console.WriteLine("Enter number in kilometers");
            double t5num = Convert.ToDouble(Console.ReadLine());
            t5num = t5num * 0.62137119;
            Console.WriteLine($"Number in miles  {t5num}");
            //Task 6
            Console.WriteLine("Enter the number of hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of minutes");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hours * 60 + minutes);
            //Task 7
            Console.WriteLine("Enter number of minutes");
            int t7min = Convert.ToInt32(Console.ReadLine());
            int temp = t7min % 60;
            Console.WriteLine(t7min / 60 + " Hours " + temp + " Minutes ");

            //Task 8
            string[] strings = {"a","aa","aaa","aaaa","aaaaa" };
            Console.WriteLine(strings[0].Substring(0,1));
            Console.WriteLine(strings[1].Substring(0, 1));
            Console.WriteLine(strings[2].Substring(0, 1));
            Console.WriteLine(strings[3].Substring(0, 1));
            Console.WriteLine(strings[4].Substring(0, 1));





        }
    }
}
