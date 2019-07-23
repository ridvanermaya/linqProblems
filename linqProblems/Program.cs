using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblemsProject
{
    class Program
    {
        // Problem 1
        static void Main(string[] args)
        {
            // Problem 1
            var words = new List<string>() {"the", "bike", "this", "it", "thenth", "mathematics"};
            var containsTh = words.Where(word => word.Contains("th")).Select(word => word);
            foreach (var word in containsTh)
            {
                Console.WriteLine(word);
            }

            // Problem 2
            var names = new List<string>() {"Mike", "Brad", "Nevin", "Ian", "Mike"};
            var namesWithoutDuplicates = names.Distinct();
            foreach (var name in namesWithoutDuplicates)
            {
                Console.WriteLine(name);
            }

            // Problem 3
            var classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            var classGradesArrStr = classGrades.ToArray();
            var classGradesSplitted = new List<Array>();
            // for (int i = 0; i < classGradesArrStr.Length; i++)
            // {
            //     (classGradesArrStr[i].Split(","));
            // }


            // for (int i = 0; i < classGradesArrStr.Length; i++)
            // {
            //     var item[] = new string[5];
            //     var a[] = new string[5]() = classGradesArrStr[i].Split(",");
            // }
            // foreach (var student in classGradesArrStr)
            // {
            //     Console.WriteLine(student);
            // }

            // Problem 4
            string input = "Terrill";
            var inputList = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                inputList.Add(input[i].ToString().ToLower());
            }

            var orderByResult = from str in inputList
                                orderby str
                                select str;
            
            var lettersInStr = orderByResult.Distinct();

            string compressedStr = "";
            string orderedStr = "";

            foreach (var item in orderByResult)
            {
                orderedStr += item;
            }

            for (int i = 0; i < orderedStr.Length; i++)
            {
                int count = 1;
                for (int j = 1; j < orderedStr.Length; j++)
                {
                    if (orderedStr[i] == orderedStr[j]) {
                        count++;
                    }
                }
                compressedStr += count + orderedStr[i];
            }

            Console.WriteLine(compressedStr);
        }
    }
}