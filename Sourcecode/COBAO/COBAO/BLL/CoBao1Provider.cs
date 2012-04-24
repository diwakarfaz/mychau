using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class CoBao1Provider :COBAOProvider<CoBao>
    {
        public override void Insert(CoBao entity)
        {
            Db.sp_InsertCoBao(entity.SoCoBao, entity.MaNV, entity.MaDM, entity.MaMacTau, entity.NgayGioNhanMay, entity.NgayGioGiaoMay, entity.XepLoai, entity.LyDoXL,entity.GioLamViec, entity.ThoiGianBBH, entity.ThoiGianTruc, entity.GioCaBa);
        }

        public override void Update(CoBao entity)
        {
            Db.sp_UpdateCoBao(entity.SoCoBao, entity.MaNV, entity.MaDM, entity.MaMacTau, entity.NgayGioNhanMay, entity.NgayGioGiaoMay, entity.XepLoai, entity.LyDoXL, entity.GioLamViec, entity.ThoiGianBBH, entity.ThoiGianTruc, entity.GioCaBa);
        }

        public override void Delete(CoBao entity)
        {
            Db.sp_DeleteCoBao(entity.SoCoBao);
        }

        public override List<CoBao> GetAll()
        {
            return Db.sp_SelectCoBaosAll().ToList();
        }

        public override bool IsExisted(CoBao entity)
        {
            return Db.CoBaos.Any(cb => cb.SoCoBao.Equals(entity.SoCoBao));
        }
        public List<CoBao> GetCoBaoByTheoNhanVien(NhanVien entity)
        {
            return Db.sp_SelectCoBaosByAndMaNV(entity.MaNV).ToList();
        }
        public List<CoBao> GetCoBaoByTheoDauMay(DauMay entity)
        {
            return Db.sp_SelectCoBaosByAndMaDM(entity.MaDM).ToList();
        }
        public List<CoBao> GetCoBaoByTheoMacTau(MacTau entity)
        {
            return Db.sp_SelectCoBaosByAndMaMacTau(entity.MaMacTau).ToList();
        }
          public List<ChiTietThuongTruc> GetChiTietThuongTrucByTheoTaiXe(TaiXe entity)
        {
            return Db.sp_SelectChiTietThuongTrucsByAndMaTaiXe(entity.MaTaiXe).ToList();
        }
    }
}
