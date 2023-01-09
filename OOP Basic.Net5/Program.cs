using System;

namespace OOP_Basic.Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an onject of my class
            //an instance of Human
            Human tim = new Human();

            //access public variable from outside, and even change it
            tim.firstName = "Tim";
            //call methods of the class
            tim.IntroduceMyself();


            Console.ReadKey();
        }
    }
}
