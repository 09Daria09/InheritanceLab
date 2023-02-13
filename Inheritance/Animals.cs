using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Animals
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void Print();

    }
    class Tiger : Animals
    {
        public double AteMeat { get; set; }
        public Tiger(string n, int a, int eat)
        {
            Name = n;
            Age = a;
            AteMeat = eat;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Age: {Age} Ate meal: {AteMeat} kg");
        }
    }
    class Crocodile : Animals
    {
        public double TailLength { get; set; }
        public Crocodile(string n, int a, double tail)
        {
            Name = n;
            Age = a;
            TailLength = tail;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Age: {Age} Tail length: {TailLength}");
        }
    }
    class Kangaroo : Animals
    {
        public double JumpHeight { get; set; }
        public Kangaroo(string n, int a, double jump)
        {
            Name = n;
            Age = a;
            JumpHeight = jump;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Age: {Age} Jump height: {JumpHeight}");
        }
    }
}
