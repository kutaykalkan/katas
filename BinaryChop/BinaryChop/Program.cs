using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryChop
{
    class Program
    {
        static void Main(string[] args) {
            int[] arr = new int[] { 2, 3, 6, 12, 17, 18, 20, 24, 25, 27 };
            int result = BinaryChop.Search(arr, 18);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
