using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COBAO.DAL
{
    class HienThiThuongTruc
    {
        public Guid MaTram { get; set; }
        public string TenTram { get; set; }
        public string MaTaiXeChinh { get; set; }
        public string TenTaiXeChinh { get; set; }
        public string MaTaiXePhu { get; set; }
        public string TenTaiXePhu { get; set; }
        public string NgayBatDau { get; set; }
        public string GioBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public string GioKetThuc { get; set; }
        public string ThoiGianTruc { get; set; }
        public string GioCaBa { get; set; }

        public Guid MaThuongTruc { get; set; }
    }
}
