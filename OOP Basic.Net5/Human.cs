using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basic.Net5
{
    //this class is a blueprint for a datatype
    internal class Human
    {
        //member variable
        public string firstName;
        public string lastName;

        // member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}" ,firstName,lastName);
        }


    }
}
