using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_11
{ class Car 
    
    {
        string make { get; set; }
        int year { get; set; }
        string type { get; set; }
        int price { get; set; }
        string model { get; set; }
        string palletNo { get; set; }
        string color { get; set; }
        bool engineCheck=false;
        public Car(string make,string type,string model,string palletNo,string color, int year , int price) 
        {
            this.make = make;
            this.type = type;
            this.model = model;
            this.palletNo= palletNo;
            this.color = color;
            this.year = year;
            this.price = price;
        }
        public void start() 
        { 
            Console.WriteLine("Engine started"); 
            engineCheck= true;
        }
        public void stop() { 
            if (!engineCheck) 

                Console.WriteLine("Engine isn't on already");
            else { 

                Console.WriteLine("Engine stopped");
                engineCheck= false;
            }

        }
        public void print() { Console.WriteLine(make+ " " +type + " " + model + " " + palletNo + " " + color + " " + year + " " + price); }
        public int Gas(int gasAmount) 
        { int distance=gasAmount*20;
            return distance; 
        }
    }
    class bmw : Car
    {
        public bmw(string make, string type, string model, string palletNo, string color, int year, int price) : base(make, type, model, palletNo, color, year, price)
{}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bmw car = new bmw("Amer","BMW","BMW","JOD199922","Blue",2022,19999);
            car.print();

            car.stop();
            car.start();
            car.stop();
        }
    }
}
