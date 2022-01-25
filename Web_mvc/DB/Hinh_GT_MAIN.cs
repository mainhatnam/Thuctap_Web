namespace Web_mvc.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hinh_GT_MAIN
    {
        [Key]
        public int Mahinh_main { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Link_hinh_mani { get; set; }

        public int Id_DanhMuc { get; set; }

        public bool trangthai { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
