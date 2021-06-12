using System;
namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = System.Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Child test = new Child(name, age);
            Console.WriteLine(test);

        }
    }
}