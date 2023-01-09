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
            tim.firstName = "Tim";
            tim.IntroduceMyself();
        }
    }
}
