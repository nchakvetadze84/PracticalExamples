using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExamples
{
    class Lambda
    {
        public static void Init()
        {
            var accounts = new List<Account>
            {
                new Account {Id = 100, Name = "Levan"},
                new Account {Id = 101, Name = "Anano"},
                new Account {Id = 102, Name = "Mariam"},
                new Account {Id = 103, Name = "Tamar"},
                new Account {Id = 104, Name = "Nika"}
            };

            var resultAnonymous = accounts.Find(delegate (Account acc) { return acc.Id == 103; });


            var resultLambda = accounts.Find(acc => acc.Id == 103);

            Console.WriteLine($"resultAnonymous {resultAnonymous.Id} & resultLambda {resultLambda.Id }");

        }
    }


}
