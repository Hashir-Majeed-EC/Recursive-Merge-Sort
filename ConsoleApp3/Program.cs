
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<double> nums = new List<double>() { 9.8, 8.5, 7.1, 5.2, 2.7, 13.1, 10.5, 0.1 };
            nums = RecursiveMerge(nums);
            nums.ForEach(Console.WriteLine);
        }
        static List<double> RecursiveMerge(List<double> scores)
        {
            double pivot = scores[0];

            List<double> lower = new List<double>();
            List<double> higher = new List<double>();

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < pivot)
                {
                    lower.Add(scores[i]);
                }
                else
                {
                    higher.Add(scores[i]);
                }

            }

            if (lower.Count != 0)
            {
                lower = RecursiveMerge(lower);
            }
            if (higher.Count != 0)
            {
                higher = RecursiveMerge(higher);
            }
            
            lower.Add(pivot);
            lower.AddRange(higher);
            return lower;

        }
    }
}
