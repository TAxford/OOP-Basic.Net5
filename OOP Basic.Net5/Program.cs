using System;

namespace OOP_Basic.Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human sissy = new Human();
            sissy.firstName = "Sissy";
            sissy.lastName = "Wagner";
            sissy.IntroduceMyself();

            Human franzl = new Human();
            franzl.firstName = "Franzl";
            franzl.lastName = "Muller";
            franzl.IntroduceMyself();


            Console.ReadKey();
        }
    }
}
