using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Web_mvc.DB
{
    public partial class DataB : DbContext
    {
        public DataB()
            : base("name=DataB2")
        {
        }

        public virtual DbSet<DanhMucHoTro> DanhMucHoTro { get; set; }
        public virtual DbSet<GiamGia> GiamGia { get; set; }
        public virtual DbSet<LoaiDanhMuc> LoaiDanhMuc { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TenDanhMuc> TenDanhMuc { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiDanhMuc>()
                .HasMany(e => e.DanhMucHoTro)
                .WithRequired(e => e.LoaiDanhMuc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiDanhMuc>()
                .HasMany(e => e.TenDanhMuc)
                .WithRequired(e => e.LoaiDanhMuc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TenDanhMuc>()
                .Property(e => e.TienGoc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TenDanhMuc>()
                .Property(e => e.TienGiamGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TenDanhMuc>()
                .Property(e => e.Link)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
