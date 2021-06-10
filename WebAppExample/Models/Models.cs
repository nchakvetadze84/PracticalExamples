using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppExample.Models
{
    public class Currency
    {
        public int Id { set; get; } = 1;
        [StringLength(3, ErrorMessage = "The {0} must be at least {2} characters long!!!", MinimumLength = 3)]
        public string Code { set; get;  }
        public string Description { set; get; }
    }



    public class CurrencyViewModel
    {
        public string FromCurrency { set; get; }
        public decimal FromAmount { set; get; }
        public string ToCurrency { set; get; }
        public decimal ToAmount { set; get; }

        public List<SelectListItem> Curnecies { set; get;  }
    }
}