using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class ThuongTrucProvider:COBAOProvider<ThuongTruc>
    {
        public override void Insert(ThuongTruc entity)
        {
            Guid? maThuongTruc = entity.MaThuongTruc;
            Db.sp_InsertThuongTruc(entity.MaTram, entity.MaNV, entity.NgayBatDau ,entity.NgayKetThuc,  entity.ThoiGianTruc,entity.GioCaBa, ref maThuongTruc);
        }

        public override void Update(ThuongTruc entity)
        {
            Db.sp_UpdateThuongTruc(entity.MaThuongTruc, entity.MaTram, entity.MaNV, entity.NgayBatDau,entity.NgayKetThuc, entity.ThoiGianTruc, entity.GioCaBa);
        }

        public override void Delete(ThuongTruc entity)
        {
            Db.sp_DeleteThuongTruc(entity.MaThuongTruc);
        }

        public override List<ThuongTruc> GetAll()
        {
            return Db.sp_SelectThuongTrucsAll().ToList();
        }

        public override bool IsExisted(ThuongTruc entity)
        {
            throw new NotImplementedException();
        }
        public List<ThuongTruc> GetThuongTrucByTheoTram(Tram entity)
        {
            return Db.sp_SelectThuongTrucsByAndMaTram(entity.MaTram).ToList();
        }
        public List<ThuongTruc> GetThuongTrucByTheoNhanVien(NhanVien entity)
        {
            return Db.sp_SelectThuongTrucsByAndMaNV(entity.MaNV).ToList();
        }
    }
}
