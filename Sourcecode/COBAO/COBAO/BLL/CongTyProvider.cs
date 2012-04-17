using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class CongTyProvider :COBAOProvider<CongTy>
    {
        public override void Insert(CongTy entity)
        {
            Guid? maCT = entity.MaCT;
            Db.sp_InsertCongTy(entity.TenCT, ref maCT);
        }

        public override void Update(CongTy entity)
        {
            Db.sp_UpdateCongTy(entity.MaCT, entity.TenCT);
        }

        public override void Delete(CongTy entity)
        {
            Db.sp_DeleteCongTy(entity.MaCT);
        }

        public override List<CongTy> GetAll()
        {
            return Db.sp_SelectCongTiesAll().ToList();
        }

        public override bool IsExisted(CongTy entity)
        {
            return Db.CongTies.Any(ct => ct.TenCT.Equals(entity.TenCT));
        }
    }
}
