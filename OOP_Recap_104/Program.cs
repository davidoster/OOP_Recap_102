using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Recap_104
{
    class Program
    {
        static void Main(string[] args)
        {
            User<int> user = new User<int>();
            Console.WriteLine(user.add(1, 2));

            User<float> user2 = new User<float>();
            Console.WriteLine(user.add(1, 2));
        }
    }

    class User<T>
    {
        private T myVar;

        public T MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private T myVar2;

        public T MyProperty2
        {
            get { return myVar2; }
            set { myVar2 = value; }
        }

        public T add(T x, T y)
        {
            int i = (int)(object)x;
            int j = (int)(object)y;
            int k = i + j;
            T returnType = (T)(object)k;

            MyProperty = (T)(object)i;
            MyProperty2 = (T)(object)j;
            return (returnType);
        }

    }
}
