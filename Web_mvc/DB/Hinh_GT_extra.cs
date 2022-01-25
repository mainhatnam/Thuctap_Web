namespace Web_mvc.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hinh_GT_extra
    {
        [Key]
        public int Mahinh_extra { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Link_hinh_extra { get; set; }

        public int Id_DanhMuc { get; set; }

        public bool trangthai { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
