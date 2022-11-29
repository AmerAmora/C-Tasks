using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{ 
   abstract class A {

        public void StartEngine() { }
        public void StopEngine() { }
        public void OpenDoor() { }
        public void CloseDoor() { }
        public void Honk() { }
        public void IncreaseSpeed() { }
        public void DecreaseSpeed() { }
        public void Breaks() { }
        public void OpenWindow() { }
        public void CloseWindow() { }
        public void AdjustSeat() { }
        public void CleanGlass() { }
        public void ChangeGear() { }
        public void startlights() { }
        public void stoplights() { }

        public void startAC() { }
        public void stopAC() { }
        public void startradio() { }
        public void stopradio() { }



    }
    class B : A {
       //override public void print() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B amer=new B();
        }
    }
}
