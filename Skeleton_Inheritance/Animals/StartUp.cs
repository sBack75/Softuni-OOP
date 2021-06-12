using System;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string curObject = Console.ReadLine();
                if (curObject == "Beast!")
                {
                    break;
                }
                string[] curInformation = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = curInformation[0];
                int age = int.Parse(curInformation[1]);
                string gender = curInformation[1];

                if (curObject == "Cat")
                {
                    Cat obj = new Cat(name, age, gender);
                    Console.WriteLine(obj);
                    obj.ProduceSound();
                }
                else if (curObject == "Dog")
                {
                    Dog obj = new Dog(name, age, gender);
                    obj.ProduceSound();
                }
                else if (curObject == "Tomcat")

                {
                    Tomcat obj = new Tomcat(name, age, gender);
                    obj.ProduceSound();
                }
                else if (curObject == "Kitten")
                {
                    Kitten obj = new Kitten(name, age, gender);
                    obj.ProduceSound();
                }
                else if (curObject == "Frog")
                {
                    Frog obj = new Frog(name, age, gender);
                    obj.ProduceSound();
                }
            }
        }
    }
}
