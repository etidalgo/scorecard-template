using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAlgorithmChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var reviewerCounts = new ReviewerCount { 
                { "alpha", 0 },
                { "beta", 0}
            };
            reviewerCounts.PrintCounts();
            Console.ReadLine();
        }
    }
}
