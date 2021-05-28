using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExamples
{
    public class LinqJoin
    {
        public void Join()
        {
            var cards = new List<Card>
            {
                new Card {CardNo = "6519515191", Id = 10000, ClientId = 1},
                new Card {CardNo = "324256546", Id = 10000, ClientId = 2},
            };
            var clients = new List<Client>() { new Client() { Name = "Nika C.", ClientId = 1 } };

            //join jt in _db.JobTranslators on j.Id equals jt.JobId into jts
            //from jtResult in jts.DefaultIfEmpty()

            //cards.Join()
            var res = (from card in cards
                       join cl in clients on card.ClientId equals cl.ClientId
                       select new { card.CardNo, cl.Name });


            var leftResult = (from card in cards
                              join cl in clients on card.ClientId equals cl.ClientId into ljl
                              from jtResult in ljl.DefaultIfEmpty()
                              select new { card.CardNo, Name = jtResult?.Name });


            foreach (var it in leftResult)
            {
                Console.WriteLine(it.CardNo + it.Name);
            }
        }
    }

    public class Card
    {
        public int Id { set; get; }
        public string CardNo { set; get; }
        public int ClientId { set; get; }
    }


    public class Client
    {
        public int ClientId { set; get; }
        public string Name { set; get; }

    }
}
