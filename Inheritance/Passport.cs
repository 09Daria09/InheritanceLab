using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Passport
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Passport() : this("Ukraine", "Inna", 16)
        { }
        public Passport(string c,string n, int a )
        {
            Name = n;
            Age = a;
            Country = c;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Country: {Country} Name: {Name} Age: {Age} ");
        }
    }
    class ForeignPassport: Passport
    {
        public string Visa { get; set; }
        public string Number { get; set; }
        public ForeignPassport( string c, string n, int a, string v,string num): base(c, n, a)
        {
            Visa = v;
            Number = num;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Visa: {Visa} International passport number: {Number}");
        }
    }
}
