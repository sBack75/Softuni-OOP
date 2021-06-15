using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        private string name;
        private List<Players> firstTeam;
        private List<Players> lastTeam;

        public IReadOnlyCollection<Players> FirstTeam
        {
            get => firstTeam.AsReadOnly();
        }
        public IReadOnlyCollection<Players> LastTeam
        {
            get => lastTeam.AsReadOnly();
        }

        public void PlayerAdd(Players players)
        {
            if (players.Age < 40)
            {
                firstTeam.Add(players);
            }
            else if (players.Age >= 40)
            {
                lastTeam.Add(players);
            }
        }
    }
}
