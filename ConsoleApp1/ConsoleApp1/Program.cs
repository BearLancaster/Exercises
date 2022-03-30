using System;

namespace ConsoleApp1
{
    using LT = levelTwo.testproject;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LT a = new LT();
            a.SpecialTest();
            Console.ReadKey();
        }
    }

    namespace levelTwo
    {
        class testproject
        {
            public void SpecialTest()
            {

                Console.WriteLine("Level Two!");
            }


        }
       
    
    }
}
