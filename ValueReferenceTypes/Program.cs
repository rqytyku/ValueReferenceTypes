using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceTypes
{
    class ReferenceValue
     {
        public int vlere;
     }

    class Shembull
    {
        static void Llogarit(ReferenceValue a, ReferenceValue b)
        {
            a.vlere = a.vlere * a.vlere;
            b.vlere = b.vlere * b.vlere;
            Console.WriteLine(a.vlere + " " + b.vlere);
        }
        static void Main(string[] args)
        {
            ReferenceValue p1 = new ReferenceValue();
            ReferenceValue p2 = new ReferenceValue();
            p1.vlere = 5;
            p2.vlere = 10;
            Console.WriteLine("Vlerat para metodes");
            Console.WriteLine(p1.vlere + " " + p2.vlere);
            Console.WriteLine("Vlerat pasi thirret metoda");
            Llogarit(p1, p2);
            Console.WriteLine("Vlerat finale");
            Console.WriteLine(p1.vlere + " " + p2.vlere);
  
            Console.ReadLine();
        }
    }
}