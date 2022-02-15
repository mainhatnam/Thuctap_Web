namespace Web_mvc.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMuc")]
    public partial class DanhMuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMuc()
        {
            Hinh_GT_MAIN = new HashSet<Hinh_GT_MAIN>();
            Hinh_GT_extra = new HashSet<Hinh_GT_extra>();
        }

        public int MaLoaiDanhMuc { get; set; }

        [StringLength(100)]
        public string TenDanhMuc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TienGoc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TienGiamGia { get; set; }

        [StringLength(500)]
        public string MoTaNgan { get; set; }

        [StringLength(1000)]
        public string NoiDung { get; set; }

        [Key]
        public int Id_DanhMuc { get; set; }

        [StringLength(100)]
        public string Link { get; set; }

        public int? MaGiamGia { get; set; }

        public int? ID_DonVi { get; set; }

        public virtual DonVi DonVi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hinh_GT_MAIN> Hinh_GT_MAIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hinh_GT_extra> Hinh_GT_extra { get; set; }

        public virtual GiamGia GiamGia { get; set; }

        public virtual LoaiDanhMuc LoaiDanhMuc { get; set; }
    }
}
