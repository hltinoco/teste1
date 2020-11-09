using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace YClient_htinoco2.Models
{
    public class Valorestab : PageModel
    {
        //public Valorestab()
        //{

        //}
        public int NumeId { get; set; }
        public decimal Ndecimal { get; set; }

        //public Valorestab(int numeId, decimal ndecimal)
        //{
        //    this.NumeId = numeId;
        //    this.Ndecimal = ndecimal;
        //}
    }
}
    

