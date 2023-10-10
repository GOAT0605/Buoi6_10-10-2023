using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class NanNhan : DbContext
    {
        public NanNhan()
            : base("name=NanNhan")
        {
        }

        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TinhTrang> TinhTrangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TinhTrang>()
                .HasMany(e => e.BenhNhans)
                .WithRequired(e => e.TinhTrang)
                .WillCascadeOnDelete(false);
        }
    }
}
