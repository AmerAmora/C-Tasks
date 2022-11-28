using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_11practice
{

    // C# program to
    // define Sealed Class
    using System;

    class Printer
    {

        // Display Function for
        // Dimension printing

        // Display Function
        public virtual void print()
        {
            Console.WriteLine("printer printing....\n");
        }
    }

    // inheriting class
    sealed class  LaserJet : Printer
    {

       
        override public void print()
        {
            Console.WriteLine("Laserjet printer printing....\n");
        }
    }

    // Officejet class cannot override show
    // function as it is sealed in LaserJet class.
    //class Officejet : LaserJet
    //{ 
    //    // can not override show function or else
    //    // compiler error : 'Officejet.show()' :
    //    // cannot override inherited member
    //    // 'LaserJet.show()' because it is sealed.

    //    override public void print()
    //    {
    //        Console.WriteLine("Officejet printer printing....");
    //    }
    //}

    // Driver Class
    class Program
    {

        // Driver Code
        static void Main(string[] args)
        {

            Printer p = new Printer();
            p.print();

            Printer ls = new LaserJet();
            ls.print();

            
        }
    }

}
