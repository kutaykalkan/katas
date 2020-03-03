using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMunging
{
    class Program
    {
        static void Main(string[] args) {

            WeatherReader r = new WeatherReader(@"C:\Users\kutay\OneDrive\Projects\VSProjects\Katas\DataMunging\DataMunging\Data\weather.dat", 3);
            int id = r.FindMaxSpreadId(r.ReadToEnd());

            SoccerReader sr = new SoccerReader(@"C:\Users\kutay\OneDrive\Projects\VSProjects\Katas\DataMunging\DataMunging\Data\football.dat", 2);
            string team = sr.FindMaxSpreadTeam(sr.ReadToEnd());
            Console.WriteLine(id);
            Console.WriteLine(team);
            Console.ReadLine();

        }
    }
}
