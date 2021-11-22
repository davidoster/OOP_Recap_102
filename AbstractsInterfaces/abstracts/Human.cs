using AbstractsInterfaces.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces.abstracts
{
    abstract class Human : IHumanActions
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Name { 
            get { 
                return (_firstName + " " + _lastName); 
            }
            private set { } 
        }

        public abstract void walk();
    }
}
