using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;
namespace COBAO.BLL
{
    public class DoiProvider:COBAOProvider<Doi>
    {
        public override void Insert(Doi entity)
        {
            Guid? maDoi = entity.MaDoi;
            Db.sp_InsertDoi(entity.TenDoi,entity.MaTram, ref maDoi);
        }

        public override void Update(Doi entity)
        {           
            Db.sp_UpdateDoi(entity.MaDoi, entity.TenDoi, entity.MaTram);
        }

        public override void Delete(Doi entity)
        {
            Db.sp_DeleteDoi(entity.MaDoi);
        }

        public override List<Doi> GetAll()
        {
            return Db.sp_SelectDoisAll().ToList();
        }

        public override bool IsExisted(Doi entity)
        {
            return Db.Dois.Any(d => d.TenDoi.Equals(entity.TenDoi) && d.MaTram.Equals(entity.MaTram));
        }

        public List<Doi> GetDoiByTheoTram(Tram entity)
        {
            Guid? maTram = entity.MaTram;
            return Db.sp_SelectDoisByAndMaTram(maTram).ToList();
        }
    }
}
