using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblemsProject
{
    public class linqProblems
    {
        // Problem 1
        public IEnumerable<string> Contains(string s) {
            var words = new List<string>() {"the", "bike", "this", "it", "thenth", "mathematics"};
            var contains = words.Where(word => word.Contains(s)).Select(word => word);
            return contains;

            // Testing
            // foreach (var word in containsTh)
            // {
            //     Console.WriteLine(word);
            // }
        }

        // Problem 2
        public IEnumerable<string> ShowEachItemOnlyOnce()
        {
            // Problem 2
            var names = new List<string>() {"Mike", "Brad", "Nevin", "Ian", "Mike"};
            var namesWithoutDuplicates = names.Distinct();
            return namesWithoutDuplicates;

            // Testing
            // foreach (var name in namesWithoutDuplicates)
            // {
            //     Console.WriteLine(name);
            // }
        }

        // Problem 3
        public static double getAverage(List<string> grades)
        {
            Func<string, IEnumerable<double>> convertToNumbers = (string g) =>
           {
                List<double> ret = new List<double>();

            //Use tryParse here
            for(int i=0; i<g.Count(); i++)
            {
                try
                {
                    ret.Add(double.Parse(Char.ToString(g[i]) + Char.ToString(g[i + 1]) + Char.ToString(g[i + 2])));
                    i+=2;
                } catch(Exception E)
                {
                    try
                    {
                        ret.Add(double.Parse(Char.ToString(g[i]) + Char.ToString(g[i + 1])));
                        i++;
                    } catch(Exception F)
                    {
                        continue;
                    }
                }
            }
            return ret;
        };

            Func<IEnumerable<double>, double> averaged = (IEnumerable<double> g) =>
            {
                double total = 0;
                foreach (var n in g)
                {
                    total += n;
                }

                return total / g.Count();
            };

           List<double> averages = new List<double>();

            foreach (var Class in grades){
                var classNumbers = convertToNumbers(Class);
                IEnumerable<double> woMin = from c in classNumbers where c > classNumbers.Min() select c;

                averages.Add(averaged(
                    woMin
                ));
            }

            return averaged(averages);
        }

        // Problem 4
        public string OrderedLetterFrequency(string input)
        {
            // Problem 4
            var inputList = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                inputList.Add(input[i].ToString().ToLower());
            }

            var orderByResult = from str in inputList
                                orderby str
                                select str;
            
            var lettersInStr = orderByResult.Distinct();

            string letters = "";
            foreach (var item in lettersInStr)
            {
                letters += item.ToString();
            }

            string orderedStr = "";
            foreach (var item in orderByResult)
            {
                orderedStr += item;
            }

            string compressedStr = "";

            for (int i = 0; i < letters.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < orderedStr.Length; j++)
                {
                    if (letters[i] == orderedStr[j]) {
                        count++;
                    }
                }
                compressedStr += letters[i] + count.ToString();
            }

            return compressedStr;
        }
    }
}