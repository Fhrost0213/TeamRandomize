using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamRandomizer.Models
{
    public class RandomizeTeams
    {
        public List<Team> Randomize(List<string> names)
        {
            var randomNames = names.OrderBy(a => Guid.NewGuid()).ToList();

            var teams = new List<Team>();

            string prevName = "";

            for (int i = 0; i < names.Count; i++ )
            {
                // Every even number create a tuple and insert record into list
                if (i % 2 == 0)
                {
                    prevName = randomNames[i];
                }
                else
                {
                    var team = new Team { Player1 = prevName, Player2 = randomNames[i] };
                    teams.Add(team);

                    prevName = "";
                }
            }

            return teams;
        }
    }
}
