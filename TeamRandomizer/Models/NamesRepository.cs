using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamRandomizer.Models
{
    public static class NamesRepository
    {
        public static List<string> Names = new List<string>();


        public static void AddName(string name)
        {
            Names.Add(name);
        }
    }
}
