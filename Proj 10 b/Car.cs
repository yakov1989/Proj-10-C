using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_10_b
{
    class Car
    {
        //Fields
        private string model;
        private int speed;
        private double engine;
        private bool isAutoGear;
        //Methods
        public Car() : this("Mazda", 280, 2.5, false)
        {

        }

        public Car(string model, int s, double e, bool iAG)
        {
            this.model = model;
            SetSpeed(s);
            engine = e;
            SetGear(iAG);


        }
        public void Print(){
            Console.WriteLine($"Car Model= {model} , Car Speed= {speed}, Car Engine= {engine}, Car Gear= {isAutoGear}");
        }
        
        public void SetSpeed(int s)
        {
            if (s >0&&s<300)
            {
                speed=s;
            }
            else
                Console.WriteLine("Eroor!");
        }
        public int GetSpeed()
        {
            return speed;
        }
        public void SetGear(bool G)
        {
            isAutoGear = G;
        }
        public bool GetGear()
        {
            return isAutoGear;
        }

    }
}

