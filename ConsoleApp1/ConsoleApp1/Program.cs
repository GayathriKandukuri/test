using System;

namespace ConsoleApp1
{
    class Program
    {
        public int a; 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.hello();
        }

        public void hello()
        {
            Console.WriteLine("Cloud azure training");
        }
    }
}
