using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox" ,"over", "lazy", "dog" };
            //Task 2
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine(fruits[1]+" "+ fruits[0]);
            //Task 3
            string[] foods = {"Burger","Mansaf","Hotdog","Mandi","Pasta" };
            string[] Sports = { "Soccer", "Football", "basketball" };
            string[] Movies = { "Fight club", "Seven", "Harry potter", "The maze runner" };
            foreach (string food in foods) { Console.WriteLine(food); }
            foreach (string sport in Sports) { Console.WriteLine(sport); }
            foreach (string movie in Movies) { Console.WriteLine(movie); }
            //Task 4
            Console.WriteLine("Enter number separated by a comma");
            string s = Console.ReadLine();
            string[] subs = s.Split(',');
            int[] numbers = new int[3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            { numbers[i] = Convert.ToInt32(subs[i]); sum += numbers[i]; }
            Console.WriteLine("the sum of numbers" +sum);
            //Task 5
            int oddsum = 0;
            for(int i=1;i<=100;i++)
            { 
                if ((i % 2)!= 0) { oddsum = oddsum + i; }
                

            }
            Console.WriteLine("the sum of odd numbers for 1 too 100 is : "+ oddsum);
            //Task 6
            for (int row = 0; row <= 4; row++) 
            
            {
                for (int col = 0; col <= row; col++)
                { Console.Write("*"); }
                Console.WriteLine();
            
            }
            //Task 7
            int counter=1;
            for (int row = 0; row <= 4; row++)

            {
                for (int col = 0; col < row; col++)
                { Console.Write(counter); counter++; }
                Console.WriteLine("");

            }

        }
    }
}
