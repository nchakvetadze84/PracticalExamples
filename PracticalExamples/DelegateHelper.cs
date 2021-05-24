using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExamples
{
    class DelegateHelper
    {
        //Func<>

        public static void Init()
        {
            Action<string> print = x => Console.WriteLine(x);

            //Predicate<string> 
            //Func<>
            print("Print Obj");
        }
    }
}
