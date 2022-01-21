namespace Web_mvc.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiamGia")]
    public partial class GiamGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiamGia()
        {
            TenDanhMuc = new HashSet<TenDanhMuc>();
        }

        [Key]
        public int MaGiamGia { get; set; }

        [StringLength(100)]
        public string TenGiamGia { get; set; }

        public int? TyLe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenDanhMuc> TenDanhMuc { get; set; }
    }
}
