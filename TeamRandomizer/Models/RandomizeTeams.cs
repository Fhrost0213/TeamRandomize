using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamRandomizer.Models
{
    public class RandomizeTeams
    {
        public List<Tuple<string, string>> Randomize(List<string> names)
        {
            var randomNames = names.OrderBy(a => Guid.NewGuid()).ToList();

            var tuples = new List<Tuple<string, string>>();

            string prevName = "";

            for (int i = 0; i < names.Count; i++ )
            {
                // Every even number create a tuple and insert record into list
                if (i % 2 == 0)
                {
                    var tuple = new Tuple<string, string>(prevName, randomNames[i]);
                    tuples.Add(tuple);

                    prevName = "";
                }
                else
                {
                    prevName = randomNames[i];
                }
            }

            return tuples;
        }
    }
}
