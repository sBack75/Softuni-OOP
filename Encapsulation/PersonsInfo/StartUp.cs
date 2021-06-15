using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int howMany = int.Parse(Console.ReadLine());
            Person Stilqn = new Person();

            for (int i = 0; i < howMany; i++)
            {
                string[] curHuman = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string firstName = curHuman[0];
                string lastName = curHuman[1];
                int age = int.Parse(curHuman[2]);
                decimal salary = decimal.Parse(curHuman[2]);

                Players curPlayer = new Players(firstName, lastName, age, salary);
         
                Stilqn.PlayerAdd(curPlayer);
            }

            Console.WriteLine($"First team {Stilqn.FirstTeam.Count}");
            Console.WriteLine($"First team {Stilqn.LastTeam.Count}");
        }
    }
}
