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
            DanhMucHoTro = new HashSet<DanhMucHoTro>();
            TenDanhMuc = new HashSet<TenDanhMuc>();
        }

        [Key]
        public int MaLoaiDanhMuc { get; set; }

        [StringLength(100)]
        public string TenLoaiDanhMuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhMucHoTro> DanhMucHoTro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenDanhMuc> TenDanhMuc { get; set; }
    }
}
