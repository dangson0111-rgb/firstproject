using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codethuanC_
{
    public class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        // Các trường private
        private int speed;      // mặc định SLOW
        private bool on;        // mặc định false
        private double radius;  // mặc định 5
        private string color;   // mặc định b

        public Fan()
        {
            this.speed = SLOW;
            this.on = false;
            this.radius = 5;
            this.color = "blue";
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public bool On
            {
             get { return on; } set { on = value; }
            }
        public double Radius { get { return radius; } set { radius = value; } }
        public string Color { get { return color; } set { color = value; } }    
        public override string ToString()
        {
            if (on)
            {
                return $"Speed: {speed}, Color: {color}, Radius: {radius} => fan is on";
            }
            else
            {
                return $"Color: {color}, Radius: {radius} => fan is off";
            }
        }
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            fan1.Speed = Fan.FAST;
            fan1.Radius = 10;
            fan1.Color = "yellow";
            fan1.On = true;
            Fan fan2 = new Fan();
            fan2.Speed = Fan.MEDIUM;  
            fan2.Radius = 5;
            fan2.Color = "red";
            fan2.On = false;
            Console.WriteLine("Fan1:" + fan1.ToString());
            Console.WriteLine("Fan2:"+fan2.ToString());

        }
    }
}
