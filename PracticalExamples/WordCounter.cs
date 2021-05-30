using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExamples
{
    class WordCounter
    {
        public static void Counter()
        {
            var words = "the real things is the the things witch thing happened in real".Split(' ');

            var data = from word in words
                                            group word by word[0]
                                            into gr
                                               select new 
                                               {
                                                   Character = gr.Key,
                                                   Count = gr.Count()
                                               };

            var max = data.OrderByDescending(a => a.Count).FirstOrDefault();

            foreach (var it in data)
            {
                Console.WriteLine(it);
            }
            Console.WriteLine(max);

        }
    }

    //class WordHelper
    //{
    //    public string Character { set; get; }

    //    public int Count { set; get; }
    //}
}
