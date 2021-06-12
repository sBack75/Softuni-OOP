using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Animal
    {
        public Animal(string name , int age , string gender)
        {
            this.Name = name;
            
            if (age <= 0)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                this.Age = age;
            }
            this.Gender = gender;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"{Name} {Age} {Gender}";
        }
        public virtual void ProduceSound()
        {

        }
    }
}
