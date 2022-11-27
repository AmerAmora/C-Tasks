using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_11practice
{
    
    internal class Program
    {
        static double Add(double num1, double num2)

        {  
            return num1+num2; 
        }
        static double Sub(double num1, double num2)

        {
            return num1 - num2;
        }
        static double Mult(double num1, double num2)

        {
            return num1 * num2;
        }
        static double Div(double num1, double num2)

        {
            return num1 / num2;
        }
        static double Mod(double num1, double num2)

        {
            return num1 % num2;
        }
        static string Welcome( string name) 
        { 
            return "Welcome " + name; 
        }
        static string Goodbye(string name) 
        { 
            return "Goodbye " + name;
        }
        static void Main(string[] args)
        {
            int x = 5; 
            int y = 5;
            Console.WriteLine(Add(x,y));
            Console.WriteLine(Sub(x, y));
            Console.WriteLine(Mult(x, y));
            Console.WriteLine(Div(x, y));
            Console.WriteLine(Mod(x, y));
            Console.WriteLine(Welcome("Amer"));
            Console.WriteLine(Goodbye("Amer"));


        }
    }
}
