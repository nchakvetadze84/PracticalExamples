using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;

namespace PracticalExamples.DataAccess
{
    class EFDemo
    {
        public static void PrintBankInfo()
        {
            using (var context = new BANKEntities())
            {
                //var accounts1 = from n in context.Accounts select n;

                //if (DateTime.Now.Minute == 35)
                //{
                //    accounts1 = accounts1.Where(a => a.AccNo == "GE74BR02056060565000000");
                //}
                //accounts1 = accounts1.OrderBy(a => a.CreateDate);

                //accounts1 = accounts1.Skip(0).Take(1);

                //var result = accounts1.ToList();


                #region Explicit Loading 
                ////var firstClient = accounts.FirstOrDefault()?.Client;
                //var account1 = accounts.FirstOrDefault();
                //context.Entry(account1).Reference(s => s.Client).Load(); // loads StudentAddress

                ////AsNoTracking().
                //var clients = context.Clients.AsNoTracking().ToList();
                //var client1 = clients.FirstOrDefault();

                //context.Entry(client1).Collection(s => s.Accounts).Load(); // loads Courses collection 

                //var acc = accts.FirstOrDefault().Client;
                //var acctounts = context.Accounts.Include(a => a.Client).ToList();

                #endregion Explicit Loading

                #region Add & attach

                var newAccount = new Account { AccNo = "6GE666PR78970000000", ClientId = 1002, Status = "A", CreateDate = DateTime.Now };
                context.Accounts.Add(newAccount);
                //var newAccountAttach = new Account { AccNo = "6GE666PR78933333", ClientId = 1001, Status = "A", CreateDate = DateTime.Now };
                //context.Accounts. (newAccountAttach);

                //var account = context.Accounts.Single(a => a.Id == 8000);

                //account.AccNo = "GE74BR02056060565000000";

                //foreach (var entry in context.ChangeTracker.Entries())
                //{
                //    Console.WriteLine("Entity Name: {0}", entry.Entity.GetType().FullName);
                //    Console.WriteLine("Status: {0}", entry.State);
                //}

                #endregion


                context.SaveChanges();
            }
        }
    }
}
