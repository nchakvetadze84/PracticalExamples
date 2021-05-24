using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExamples
{
    public class Account
    {
        public int Id { set; get; }
        public  string Name{ set; get; }

        public string GetAccHolder()
        {
            return Name ?? "Account Holder";
        }

    }
}
