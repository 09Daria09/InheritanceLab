using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] ptr = new Human[3];
            ptr[0] = new Builder("Ivan", 32, "CBV Corporation");
            ptr[1] = new Pilot("Serafim", 34, "UK23-G");
            ptr[2] = new Sailor("Dmitriy", 48, "Cruiser Ukraine");

            foreach(Human a in ptr)
            {
                a.Print();
            }

            Console.WriteLine();

            Passport passport = new Passport("Ukraine", "Lera", 23);
            passport.Print();
            ForeignPassport foreignPassport = new ForeignPassport("Ukraine", "Lera", 23, "Germany", "NK234785");
            foreignPassport.Print();

            Console.WriteLine();

            Animals[] ptr1 = new Animals[3];
            ptr1[0] = new Tiger("Lycas", 3, 2);
            ptr1[1] = new Crocodile("Niks",3, 1.5);
            ptr1[2] = new Kangaroo("Lyna", 4, 2.3);

            foreach (Animals a in ptr1)
            {
                a.Print();
            }

            Console.WriteLine();
            Figure[] ptr2 = new Figure[4];
            ptr2[0] = new Trapezion();
            ptr2[1] = new Circle();
            ptr2[2] = new RightTriangle();
            ptr2[3] = new Rectangle();

            foreach (Figure a in ptr2)
            {
               Console.WriteLine(a.Square(2.3,5.4));
            }
        }
    }
}
