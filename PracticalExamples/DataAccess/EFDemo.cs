using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExamples.DataAccess
{
    class EFDemo
    {
        public static void PrintBankInfo()
        {
            using (var context = new BANKEntities())
            {
                foreach (var account in context.Accounts)
                {
                    Console.WriteLine(account);
                }

                foreach (var client in context.Clients)
                {
                    Console.WriteLine($"ClientName {client.FullName };  FromDate {client.CreateDate}");
                }
            }
            ;


            
        }
    }
}
