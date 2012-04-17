using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class TramProvider:COBAOProvider<Tram>
    {
        public override void Insert(Tram entity)
        {
            Guid? maTram = entity.MaTram;
            Db.sp_InsertTram(entity.TenTram, ref maTram);           
        }

        public override void Update(Tram entity)
        {
            Db.sp_UpdateTram(entity.MaTram, entity.TenTram);
        }

        public override void Delete(Tram entity)
        {
            Db.sp_DeleteTram(entity.MaTram);
        }

        public override List<Tram> GetAll()
        {
            return Db.sp_SelectTramsAll().ToList();
        }

        public override bool IsExisted(Tram entity)
        {
            return Db.Trams.Any(t => t.TenTram.Equals(entity.TenTram));
        }
    }
}
