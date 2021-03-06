namespace Web_mvc.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiDanhMuc")]
    public partial class LoaiDanhMuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiDanhMuc()
        {
            DanhMuc = new HashSet<DanhMuc>();
        }

        [Key]
        public int MaLoaiDanhMuc { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLoaiDanhMuc { get; set; }

        public bool? Trangthai_ldm { get; set; }

        public int? id_cha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhMuc> DanhMuc { get; set; }
    }
}
