using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_11
{     
    internal class Person
    {
        int age,id;
        string name, email,phone, gender;
        public Person( int age, int id,string name,string email,string phone, string gender) 
        
        { 
            this.id = id;   
            this.name = name;
            this.email = email;
            this.gender = gender;
            
            if (age > 60 || age < 18)
            { Console.WriteLine("age isn't valid "); this.age = 18; }
            else
            {
                this.age = age;
            }
            string temp=phone.Substring(0, 3);
            
            if (temp == "077" || temp == "078" || temp == "079")
            { this.phone = phone; }
            else 
            { Console.WriteLine("Wrong phone number"); this.phone = ""; }
            
            
            
        }
        void print() { Console.WriteLine(name + " "+ gender + " " + phone + " " + id + " " + age + " " + email); }
        static void Main(string[] args)

        {
            Console.WriteLine("Enter name ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter phone ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter gender ");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter email ");
            string email = Console.ReadLine();
            int id;
            int age;
            Console.WriteLine("Enter id");
            id= Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Person Amer = new Person(23,3,"Amer","Amer.m.amora@gmail.com","0789949499","Male");
            Amer.print();
            Person person = new Person(age,id,name,email,phone,gender);
            person.print();

        }
    }
}
