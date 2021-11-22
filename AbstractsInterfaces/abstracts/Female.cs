using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces.abstracts
{
    class Female : Human
    {
        public override void walk()
        {
            Console.WriteLine("Female walking!");
        }
    }
}
