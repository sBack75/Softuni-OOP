﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Kitten : Cat
    {
        private const string curGender = "female";
        public Kitten(string name, int age, string gender) 
            : base(name, age, curGender)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
