using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinistersdict = new Dictionary<int, string>
            {
                { 1998,"Atal Bihari Vajpayee"},
                { 2014,"Narendra Modi" },
                { 2004,"Manmohan Singh"}
            };

            Console.WriteLine(primeMinistersdict[2004]);

            primeMinistersdict.Add(2019,"Narendra Modi");

            var prime = new SortedDictionary<int, string>(primeMinistersdict);

            foreach (var minister in prime)
                Console.WriteLine(minister.Key + " " + minister.Value);
        }
    }
}
