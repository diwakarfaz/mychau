using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;
namespace COBAO.BLL
{
    public class DonGiaLuongXLProvider:COBAOProvider<DonGiaLuongXL>
    {
        public override void Insert(DonGiaLuongXL entity)
        {
            Guid? maLuongXL = entity.MaLuongXL;
            Db.sp_InsertDonGiaLuongXL(entity.MoTa, entity.DonViTinh, ref maLuongXL);
        }

        public override void Update(DonGiaLuongXL entity)
        {
            Db.sp_UpdateDonGiaLuongXL(entity.MaLuongXL, entity.MoTa, entity.DonViTinh);
        }

        public override void Delete(DonGiaLuongXL entity)
        {
            Db.sp_DeleteDonGiaLuongXL(entity.MaLuongXL);
        }

        public override List<DonGiaLuongXL> GetAll()
        {
          return Db.sp_SelectDonGiaLuongXLsAll().ToList();
        }

        public override bool IsExisted(DonGiaLuongXL entity)
        {
            return Db.DonGiaLuongXLs.Any(t => t.MoTa.Equals(entity.MoTa));
        }
        public DonGiaLuongXL GetDonGiaByMaDG(Guid madg)
        {
            try
            {
                var dongiaxl = (from c in Db.DonGiaLuongXLs
                             where c.MaLuongXL==@madg
                             select c).ToList();
                return dongiaxl.Single();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DonGiaLuongXL GetDonGiaByMoTa(string mota)
        {
            try
            {
                var dongiaxl = (from c in Db.DonGiaLuongXLs
                                where c.MoTa == mota
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
