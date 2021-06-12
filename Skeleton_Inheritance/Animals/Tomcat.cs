
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Tomcat : Cat
    {
        private const string curGender = "Male";
        public Tomcat(string name, int age, string gender)
            : base(name, age, curGender)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
