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
        //   public class Valoresc : DbContext
        //{

        //    public Valoresc(DbContextOptions<Valoresc> options) : base(options) { }
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        base.OnModelCreating(modelBuilder);
        //        modelBuilder.Entity<Valorestab>().HasNoKey();
        //    }
        //}

        public class Valorestab
        {
            //public Numero()
            //{

            //}
            public int NumeId { get; set; }
            public decimal Ndecimal { get; set; }

            //    public Numero(int numeId, decimal ndecimal)
            //    {
            //        this.NumeId = numeId;
            //        this.Ndecimal = ndecimal;
            //    }
            //}
        }
    }

