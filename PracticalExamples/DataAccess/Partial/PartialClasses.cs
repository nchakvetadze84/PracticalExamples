﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExamples.DataAccess
{
    public partial class Client
    {

        public string FullName => $"{FirstName} {LastName}";
    }
}
