using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HoangDucManh.Models
{

    public partial class LHContext : DbContext
    {
        static string LTQLDb = "name=LTQLDbContext";
        public LHContext() : base(LTQLDb)
        {

        }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LopHoc>().Property(x => x.TenLop).IsUnicode(true);
        }
    }
      
}


