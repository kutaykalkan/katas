using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMunging
{
    public class WeatherReader : Reader
    {
        public WeatherReader(string path, int startLine) : base(path, startLine) {

        }

        public int FindMaxSpreadId(List<string> lines) {
            int id = 0;
            int count = 0;
            double maxSpread = 0;
            foreach (string row in lines) {
                count++;
                if (count >= _startLine) {
                    List<string> values = Split(row.Substring(0, 18));

                    File f = new File();
                    int val;
                    if (Int32.TryParse(values[0], out val))
                        f.Id = val;
                    double d;
                    if (Double.TryParse(values[1], out d)) {
                        f.Max = d;
                    }

                    if (Double.TryParse(values[2], out d)) {
                        f.Min = d;
                    }

                    double spread = f.Max - f.Min;
                    if (spread > maxSpread) {
                        maxSpread = spread;
                        id = f.Id;
                    }
                }
            }

            return id;
        }
    }
}
