using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;
namespace COBAO.BLL
{
    public class NhatKyLuongBoSungProvider: COBAOProvider<NhatKyThayDoiDonGiaBoSung>
    {
        public override void Insert(NhatKyThayDoiDonGiaBoSung entity)
        {
            Guid? maNhatKy = entity.MaNhayKyBS;
            Db.sp_InsertNhatKyThayDoiDonGiaBoSung(entity.MaDonGia,entity.MaNV, entity.DonGiaCu, entity.DonGiaMoi, entity.NgayThayDoi, ref maNhatKy);
        }

        public override void Update(NhatKyThayDoiDonGiaBoSung entity)
        {
            Db.sp_UpdateNhatKyThayDoiDonGiaBoSung(entity.MaNhayKyBS, entity.MaDonGia, entity.MaNV, entity.DonGiaCu, entity.DonGiaMoi, entity.NgayThayDoi);
        }

        public override void Delete(NhatKyThayDoiDonGiaBoSung entity)
        {
            Db.sp_DeleteNhatKyThayDoiDonGiaBoSung(entity.MaNhayKyBS);
        }

        public override List<NhatKyThayDoiDonGiaBoSung> GetAll()
        {
            return Db.sp_SelectNhatKyThayDoiDonGiaBoSungsAll().ToList();
        }

        public override bool IsExisted(NhatKyThayDoiDonGiaBoSung entity)
        {
            throw new NotImplementedException();
        }
        public List<NhatKyThayDoiDonGiaBoSung> GetNhatKyThayDoiLuongBSByTheoDonGiaLuongBS(DonGiaLuongBoSung entity)
        {
            Guid? maDonGiaLuongBS = entity.MaDonGia;
            return Db.sp_SelectNhatKyThayDoiDonGiaBoSungsByAndMaDonGia(maDonGiaLuongBS).ToList();
        }

        public NhatKyThayDoiDonGiaBoSung nhomNhatKy(Guid maluong)
        {
            try
            {
                var lastNhatKy = (from lnk in Db.NhatKyThayDoiDonGiaBoSungs
                                  where lnk.MaDonGia.Equals(maluong)
                                  orderby lnk.NgayThayDoi ascending
                                  select lnk).ToList().Last();
                return lastNhatKy;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
