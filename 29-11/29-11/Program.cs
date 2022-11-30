using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _29_11
{
    class Employee 
    {
        public string name { get; set; }
        public int id { get; set; }
        public DateTime dateofbirth { get; set; }
        public Employee(string name,int id, DateTime d) 
        {   this.name = name;
            this.id = id;
            dateofbirth= d;

        }

        public void age() {
            DateTime now= DateTime.Now; TimeSpan value = now.Subtract(dateofbirth);
           
            Console.WriteLine((int)value.TotalDays/365);

        }
        public virtual void print() { Console.WriteLine(name + " " + id + " " + dateofbirth); }
    
    }
    class Manager : Employee
    {
        public Manager(string name, int id, DateTime d) : base(name, id, d)
        {
        }
        public override void print()
        {
              Console.WriteLine(name + " " + id + " " );
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d=new DateTime();
            d=Convert.ToDateTime( Console.ReadLine());
            Manager man = new Manager("Amer",3, d);
            man.print();
            man.age();
        }
    }
}
