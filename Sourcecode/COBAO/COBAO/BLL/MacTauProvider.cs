using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class MacTauProvider : COBAOProvider<MacTau>
    {
        public override void Insert(MacTau entity)
        {
            Db.sp_InsertMacTau(entity.MaMacTau, entity.MaCT, entity.MaLuongXL, entity.TenMacTau);
        }

        public override void Update(MacTau entity)
        {
            Db.sp_UpdateMacTau(entity.MaMacTau, entity.MaCT, entity.MaLuongXL, entity.TenMacTau);
        }

        public override void Delete(MacTau entity)
        {
            Db.sp_DeleteMacTau(entity.MaMacTau);
        }

        public override List<MacTau> GetAll()
        {
            return Db.sp_SelectMacTausAll().ToList();
        }

        public override bool IsExisted(MacTau entity)
        {
            return Db.MacTaus.Any(mt => mt.MaMacTau.Equals(entity.MaMacTau));
        }
        public List<MacTau> GetMacTauByTheoCongTy(CongTy entity)
        {
            Guid? maCT = entity.MaCT;
            return Db.sp_SelectMacTausByAndMaCT(maCT).ToList();
        }
    }
}
