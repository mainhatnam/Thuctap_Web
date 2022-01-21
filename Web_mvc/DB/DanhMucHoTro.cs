namespace Web_mvc.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucHoTro")]
    public partial class DanhMucHoTro
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoaiDanhMuc { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Id_GoiHoTro { get; set; }

        [StringLength(100)]
        public string TenGoiHoTro { get; set; }

        [StringLength(100)]
        public string Link { get; set; }

        public virtual LoaiDanhMuc LoaiDanhMuc { get; set; }
    }
}
