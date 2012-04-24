using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  COBAO.DAL;
namespace COBAO.BLL
{
    class ChiTietKhamXetProvider : COBAOProvider<ChiTietKhamXet>
    {
        public override void Insert(ChiTietKhamXet entity)
        {
            Db.sp_InsertChiTietKhamXet(entity.MaKhamXet, entity.MaTaiXe, entity.Tai);
        }

        public override void Update(ChiTietKhamXet entity)
        {
            Db.sp_UpdateChiTietKhamXet(entity.MaKhamXet, entity.MaTaiXe, entity.Tai);
        }

        public override void Delete(ChiTietKhamXet entity)
        {
            Db.sp_DeleteChiTietKhamXet(entity.MaKhamXet, entity.MaTaiXe);
        }

        public override List<ChiTietKhamXet> GetAll()
        {
            return Db.sp_SelectChiTietKhamXetsAll().ToList();
        }

        public override bool IsExisted(ChiTietKhamXet entity)
        {
            throw new NotImplementedException();
        }
                
    }
}
