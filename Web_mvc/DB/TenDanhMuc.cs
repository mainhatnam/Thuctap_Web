namespace Web_mvc.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenDanhMuc")]
    public partial class TenDanhMuc
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoaiDanhMuc { get; set; }

        [Column("TenDanhMuc")]
        [StringLength(100)]
        public string TenDanhMuc1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TienGoc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TienGiamGia { get; set; }

        [StringLength(500)]
        public string MoTaNgan { get; set; }

        [StringLength(1000)]
        public string NoiDung { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Id_DanhMuc { get; set; }

        [StringLength(100)]
        public string Link { get; set; }

        public int? GiamGia { get; set; }

        public virtual GiamGia GiamGia1 { get; set; }

        public virtual LoaiDanhMuc LoaiDanhMuc { get; set; }
    }
}
