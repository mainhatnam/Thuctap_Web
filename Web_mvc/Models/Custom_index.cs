using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using Web_mvc.DB;
namespace Web_mvc.Models
{
    public class Custom_index
    {
        public List<LoaiDanhMuc> Loaidanhmuc { get; set; }
        public List<LoaiDanhMuc> LoaiDanhMuc_index { get; set; }
        public List<DanhMucHoTro> DanhMucHoTro { get; set; }
        public List<Hinh_GT_MAIN> Hinh_GT_MAIN { get; set; }
        public List<Hinh_GT_extra> Hinh_GT_extra { get; set; }
        //test
        public List<DanhMuc> DanhMuc { get; set; }
    }

}