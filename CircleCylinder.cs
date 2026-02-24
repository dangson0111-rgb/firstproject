using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static codethuanC_.Salary;

namespace Dahinh
{
    public class Circle
    {
        public int Radius { get; set; }
        public string Colour { get; set; }

        public Circle(int radius, string colour)
        {
            Radius = radius;
            Colour = colour;
        }
        public double Area
        {
            get { return Radius * Radius * Math.PI; }
        }

        public override string ToString()
        {
            return $"Circle - Radius: {Radius}, Colour: {Colour}, Area: {Area:F2}";
        }
    }

    public class Cylinder : Circle
    {
        public int Height { get; set; }
        public Cylinder(int radius, string colour, int height) : base(radius, colour)
        {
            Height = height;
        }
        public double Volume
        {
            get { return Area * Height; }
        }
        public override string ToString()
        {
            return $"Cylinder - Radius: {Radius}, Colour: {Colour}, Height: {Height}, Volume: {Volume:F2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle a = new Circle(2, "red");
            Cylinder b = new Cylinder(3, "blue", 2);

            Console.WriteLine(a);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b);
        }
    }
}


