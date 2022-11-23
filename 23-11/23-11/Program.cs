using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_11
{
    internal class Program
    {


        static void Task1(int[] arr)

        {
            float sum=0F;
            float counter=0;
            foreach (int x in arr)
            { 
                sum += x;
                counter++; 
            }
        
            Console.WriteLine($" The sum of the numbers is {sum} and the AVG is {sum/counter} ");
           
        
        }
        static void Task2()
        {
            Console.WriteLine("Enter a number");
            int t2Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= +t2Num; i++) 
            { 
                Console.WriteLine("Number is "+ i+"And the cube of the " + i + " is : "+ (i*i*i)); 

            } 
        
        }
        static void Task3(int[] years) { foreach (int x in years) { if (x > 1950) Console.WriteLine(x); } }
        static void Task4() 
        {
            Console.WriteLine("Enter your age ");
            int years= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" age in numbers  "+years*365);
        
        }
        static void Task5(int chickens, int cows, int pigs) 
        {
            Console.WriteLine(chickens*2+cows*4+pigs*4);
        }
        static string Task6(string userName,string password)
        {
            string[] usernames = {"Amer","Ahmad","Alaa","Momen","Razan","Qais" };
            string[] passwords = {"1111","2222","3333","4444","5555","6666" };
            bool flag=false;   
            for (int i = 0; i < usernames.Length; i++) 
            {
                if (userName == usernames[i] && password == passwords[i])
                {
                    flag = true;
                    break;
                }
            
            }
            if (flag) return "pass";
            return "failed";
        }
        static int Task7(int num,int pow) 
        {
            int temp = num;
            if (pow == 0) return 1;
            else if (pow == 1) return num;
            else 
            {
                
            for (int i = 1; i < pow; i++) 
            {
                num = num * temp;
            }
            return num;
            }
        }
        static void Task8(int year) 
        {
            if (year > 2024 || year < 1900) Console.WriteLine("invalid year");
            else if (year % 4 == 0) 
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0) 
                    { Console.WriteLine("This is a leap year"); }
                    else Console.WriteLine("This is not a leap year");
                }
                else Console.WriteLine("This is a leap year");
                    
                        }
            else 
            { 
                Console.WriteLine("Not a leap year");
            }
        
        
        }
        static void Task9(int num) {
            if (num == 2 || num == 3) Console.WriteLine(num+ " Is a prime number");
            else if (num % 2 == 0 || num % 3 == 0) 
                Console.WriteLine(num + " is not a prime number"); 
            else 
                Console.WriteLine(num + " Is a prime number"); 
        }
        static int Task10(string sentence) { 
            string[] slicer = sentence.Split(' ');
            int counter = 0;
            foreach(string s in slicer)
                counter++;
        
        return counter;
        }

        static void Main(string[] args)
        {
           
            Task8(1900);
            

        }
    }
}
