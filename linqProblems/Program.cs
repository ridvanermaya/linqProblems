using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblemsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            var words = new List<string>() {"the", "bike", "this", "it", "thenth", "mathematics"};
            var containsTh = words.Where(word => word.Contains("th")).Select(word => word);
            foreach (var word in containsTh)
            {
                Console.WriteLine(word);
            }
        }
    }
}
