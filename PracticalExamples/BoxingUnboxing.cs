using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExamples
{
    public class BoxingUnboxing
    {
        public string Model { set; get; }

        public static void InitBoxingUnboxing()
        {
            decimal i = 10.7M;
            // implicit = Boxing
            object boxing = i;

            // Operation Failed
            //Console.WriteLine(boxing + 5);

            // explicit = Unboxing
            decimal unBoxing = (decimal)boxing;

            int unBoxingInt = (int)(decimal)boxing;

            Console.WriteLine(unBoxingInt);
        }

        public override string ToString()
        {
            if (Model != null)
                return Model.ToString();

            return "Lexus";
        }
    }
}
