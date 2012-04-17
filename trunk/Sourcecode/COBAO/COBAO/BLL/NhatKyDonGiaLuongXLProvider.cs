using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class NhatKyDonGiaLuongXLProvider: COBAOProvider<NhatKyThayDoiGiaXL>
    {
        public override void Insert(NhatKyThayDoiGiaXL entity)
        {
            Guid? maNhatKyXL = entity.MaNhatKyXL;
            Db.sp_InsertNhatKyThayDoiGiaXL(entity.MaLuongXL, entity.MaNV, entity.LoaiACu, entity.LoaiBCu, entity.LoaiCCu, entity.LoaiAMoi, entity.LoaiBMoi, entity.LoaiCMoi, entity.NgayThayDoi, ref maNhatKyXL);
        }

        public override void Update(NhatKyThayDoiGiaXL entity)
        {
            Db.sp_UpdateNhatKyThayDoiGiaXL(entity.MaNhatKyXL, entity.MaLuongXL, entity.MaNV, entity.LoaiACu, entity.LoaiBCu, entity.LoaiCCu, entity.LoaiAMoi, entity.LoaiBMoi, entity.LoaiCMoi, entity.NgayThayDoi);
        }

        public override void Delete(NhatKyThayDoiGiaXL entity)
        {
            try { Db.sp_DeleteNhatKyThayDoiGiaXL(entity.MaNhatKyXL); }
            catch { }

        }

        public override List<NhatKyThayDoiGiaXL> GetAll()
        {
            return Db.sp_SelectNhatKyThayDoiGiaXLsAll().ToList();
        }

        public override bool IsExisted(NhatKyThayDoiGiaXL entity)
        {
            throw new NotImplementedException();
        }
        public List<NhatKyThayDoiGiaXL> GetNhatKyThayDoiLuongXLByTheoDonGiaLuongXL(DonGiaLuongXL entity)
        {
            Guid? maDonGiaLuongXL = entity.MaLuongXL;
            return Db.sp_SelectNhatKyThayDoiGiaXLsByAndMaLuongXL(maDonGiaLuongXL).ToList();
        }
        public NhatKyThayDoiGiaXL nhomNhatKy(Guid maluongxl)
        {
            try
            {
                var lastNhatKy = (from lnk in Db.NhatKyThayDoiGiaXLs
                                  where lnk.MaLuongXL.Equals(maluongxl)
                                  orderby lnk.NgayThayDoi ascending
                                  select lnk).ToList().Last();
                return lastNhatKy;
            }
            catch (Exception)
            {
                return null;
            }
            
        }



        internal void DeleteMaNK(Guid mankdglxl)
        {
            Db.sp_DeleteNhatKyThayDoiGiaXL(mankdglxl);
        }
    }
}
