using AbstractsInterfaces.abstracts;
using AbstractsInterfaces.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractsInterfaces.abstracts.Female female = new AbstractsInterfaces.abstracts.Female();
            female.walk();
            female.FirstName = "Maria";
            female.LastName = "Pentagiotissa";
            Console.WriteLine(female.Name);


        }
    }
}
