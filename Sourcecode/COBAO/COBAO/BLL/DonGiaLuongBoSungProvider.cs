using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class DonGiaLuongBoSungProvider:COBAOProvider<DonGiaLuongBoSung>
    {
        public override void Insert(DonGiaLuongBoSung entity)
        {
            Guid? maDonGia = entity.MaDonGia;
            Db.sp_InsertDonGiaLuongBoSung(entity.MoTa,  entity.DonViTinh, ref maDonGia);
        }

        public override void Update(DonGiaLuongBoSung entity)
        {
            Db.sp_UpdateDonGiaLuongBoSung(entity.MaDonGia, entity.MoTa, entity.DonViTinh);
        }

        public override void Delete(DonGiaLuongBoSung entity)
        {
            Db.sp_DeleteDonGiaLuongBoSung(entity.MaDonGia);
        }

        public override List<DonGiaLuongBoSung> GetAll()
        {
            return Db.sp_SelectDonGiaLuongBoSungsAll().ToList();
        }

        public override bool IsExisted(DonGiaLuongBoSung entity)
        {
            return Db.DonGiaLuongBoSungs.Any(t => t.MoTa.Equals(entity.MoTa));
        }

        public DonGiaLuongBoSung GetDonGiaByMoTa(string mota)
        {
            try
            {
                var dongiaxl = (from c in Db.DonGiaLuongBoSungs
                                where c.MoTa == mota
                                select c).ToList();
                return dongiaxl.Single();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DonGiaLuongBoSung GetDonGiaByMaDG(Guid madg)
        {
            try
            {
                var dongiaxl = (from c in Db.DonGiaLuongBoSungs
                                where c.MaDonGia == @madg
                                select c).ToList();
                return dongiaxl.Single();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
