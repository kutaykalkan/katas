using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMunging
{
    public class Reader
    {
        private string _path;
        protected int _startLine;
        private List<string> _values = new List<string>();

        public Reader(string path, int startLine) {
            _path = path;
            _startLine = startLine;
        }

        public List<string> ReadToEnd() {
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(_path)) {
                while (sr.Peek() > -1) {
                    lines.Add(sr.ReadLine());
                }
            }

            return lines as List<string>;
        }

        protected static List<string> Split(string inputString) {
            List<string> values = new List<string>();
            StringBuilder s = new StringBuilder();
            char previous = ' ';
            for (int i = 0; i < inputString.Length; i++) {
                char c = inputString[i];
                if (c != ' ')
                    s.Append(c);
                if (c == ' ' && previous != ' ') {
                    values.Add(s.ToString());
                    s.Clear();
                }

                previous = c;
            }

            return values;
        }
    }
}
