using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class ToProvider:COBAOProvider<To>
    {
        public override void Insert(To entity)
        {
            Guid? maTo = entity.MaTo;
            Db.sp_InsertTo(entity.TenTo, entity.MaDoi, ref maTo);
        }

        public override void Update(To entity)
        {
            Db.sp_UpdateTo(entity.MaTo, entity.TenTo, entity.MaDoi);
        }

        public override void Delete(To entity)
        {
            Db.sp_DeleteTo(entity.MaTo);
        }

        public override List<To> GetAll()
        {
            return Db.sp_SelectTosAll().ToList();
        }

        public override bool IsExisted(To entity)
        {
            return Db.Tos.Any(t => t.TenTo.Equals(entity.TenTo) && t.MaDoi.Equals(entity.MaDoi));
        }

        public List<To> GetToByTheoDoi(Doi entity)
        {
            Guid? maDoi = entity.MaDoi;
            return Db.sp_SelectTosByAndMaDoi(maDoi).ToList();
        }
    }
}
