using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExamples
{
    static class MyMethodExtension
    {
        // 159 -> 951
        public static int ReverseDigits(this int i)
        {
            var digits = i.ToString().ToCharArray();

            Array.Reverse(digits);

            string newDigits = new string(digits);

            
            //int.TryParse("ra", out var cast);
            //var test = int.Parse("ra");
            return int.Parse(newDigits);
        }
    }
}
