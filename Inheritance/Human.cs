using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Human() : this("Human", 0)
        {}
        public Human(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public abstract void Print();       
    }

    class Builder : Human
    {
        public string Company { get; set; }
       public Builder(string n, int a, string c): base(n,a)
        {
            Company = c;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Age: {Age} Company: {Company}");
        }
    }
    class Sailor : Human
    {
       public string NameShip { get; set; }
       public Sailor(string n, int a, string c) : base(n, a)
        {
            NameShip = c;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Age: {Age} Ship name: {NameShip}");
        }
    }
    class Pilot : Human
    {
        public string NameAir { get; set; }
       public Pilot(string n, int a, string c) : base(n, a)
        {
            NameAir = c;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Age: {Age} Aircraft name: {NameAir}");
        }
    }
}
