using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL
;
namespace COBAO.BLL
{
    public class DauMayProvider:COBAOProvider<DauMay>
    {
        public override void Insert(DauMay entity)
        {
            Db.sp_InsertDauMay(entity.MaDM, entity.MaLoai, entity.TenDM);
        }

        public override void Update(DauMay entity)
        {
            Db.sp_UpdateDauMay(entity.MaDM, entity.MaLoai, entity.TenDM);
        }

        public override void Delete(DauMay entity)
        {
            Db.sp_DeleteDauMay(entity.MaDM);
        }

        public override List<DauMay> GetAll()
        {
            return Db.sp_SelectDauMaysAll().ToList();
        }

        public override bool IsExisted(DauMay entity)
        {
            return Db.DauMays.Any(dm => dm.MaDM.Equals(entity.MaDM));
        }

        public List<DauMay> GetDauMayByTheoLoaiDauMay(LoaiDauMay entity)
        {
            return Db.sp_SelectDauMaysByAndMaLoai(entity.MaLoai).ToList();
        }
    }
}
