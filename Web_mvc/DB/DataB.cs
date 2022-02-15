using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Web_mvc.DB
{
    public partial class DataB : DbContext
    {
        public DataB()
            : base("name=DataB")
        {
        }

        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<DonVi> DonVi { get; set; }
        public virtual DbSet<GiamGia> GiamGia { get; set; }
        public virtual DbSet<Hinh_GT_extra> Hinh_GT_extra { get; set; }
        public virtual DbSet<Hinh_GT_MAIN> Hinh_GT_MAIN { get; set; }
        public virtual DbSet<LoaiDanhMuc> LoaiDanhMuc { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.TienGoc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.TienGiamGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.Link)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonVi>()
                .Property(e => e.IP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonVi>()
                .HasMany(e => e.DanhMuc)
                .WithOptional(e => e.DonVi)
                .HasForeignKey(e => e.ID_DonVi);

            modelBuilder.Entity<Hinh_GT_extra>()
                .Property(e => e.Link_hinh_extra)
                .IsUnicode(false);

            modelBuilder.Entity<Hinh_GT_MAIN>()
                .Property(e => e.Link_hinh_mani)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiDanhMuc>()
                .HasMany(e => e.DanhMuc)
                .WithRequired(e => e.LoaiDanhMuc)
                .WillCascadeOnDelete(false);
        }
    }
}
