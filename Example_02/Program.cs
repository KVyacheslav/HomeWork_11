using System;

namespace Example_02
{
    interface I1
    {
        void M();
    }

    interface I2
    {
        void M();
    }

    class A : I1, I2
    {
        public void M()
        {
            Console.WriteLine("A.M()");
        }
        void I1.M()
        {
            Console.WriteLine("A - I1.M()");
        }

        void I2.M()
        {
            Console.WriteLine("A - I2.M()");
        }
    }

    class B : A
    {
        public void M()
        {
            Console.WriteLine("B.M()");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            A ab = new B();

            Console.WriteLine("a.M()");
            a.M();
            Console.WriteLine("\n\nb.M()");
            b.M();
            Console.WriteLine("\n\nab.M()");
            ab.M();
            Console.WriteLine("\n\n(b as A).M()");
            (b as A).M();
            Console.WriteLine("\n\n(b as A).M()");
            (ab as A).M();
            Console.WriteLine("\n\n(a as I1).M()");
            (a as I1).M(); ;
            Console.WriteLine("\n\n(b as I2).M()");
            (b as I2).M(); ;

        }
    }
}
