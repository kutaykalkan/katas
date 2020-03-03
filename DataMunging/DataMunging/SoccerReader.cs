using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMunging
{
    public class SoccerReader : Reader
    {
        public SoccerReader(string path, int startLine) : base(path, startLine) {
        }

        public string FindMaxSpreadTeam(List<string> lines) {
            string name = "";
            int count = 0;
            double minSpread = 0;
            foreach (string row in lines) {
                count++;
                if (count >= _startLine && count != 19) {
                    List<string> values = Split(row);

                    File f = new File();
                    f.Name = values[1];

                    double d;
                    if (Double.TryParse(values[6], out d)) {
                        f.Max = d;
                    }

                    if (Double.TryParse(values[8], out d)) {
                        f.Min = d;
                    }

                    double spread = f.Max - f.Min;
                    if (minSpread == 0)
                        minSpread = spread;
                    if (spread <= minSpread) {
                        minSpread = spread;
                        name = f.Name;
                    }
                }
            }

            return name;
        }
    }
}
