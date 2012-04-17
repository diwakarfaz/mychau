using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class LoaiDMProvider:COBAOProvider<LoaiDauMay>
    {
        public override void Insert(LoaiDauMay entity)
        {
            Guid? maLoai = entity.MaLoai;
            Db.sp_InsertLoaiDauMay(entity.TenLoai, entity.TanSoThap, entity.Trongluong, ref maLoai);
        }

        public override void Update(LoaiDauMay entity)
        {
            Db.sp_UpdateLoaiDauMay(entity.MaLoai, entity.TenLoai, entity.TanSoThap, entity.Trongluong);
        }

        public override void Delete(LoaiDauMay entity)
        {
            Db.sp_DeleteLoaiDauMay(entity.MaLoai);
        }

        public override List<LoaiDauMay> GetAll()
        {
            return Db.sp_SelectLoaiDauMaysAll().ToList();
        }

        public override bool IsExisted(LoaiDauMay entity)
        {
            return Db.LoaiDauMays.Any(ldm => ldm.TenLoai.Equals(entity.TenLoai));
            
        }
       
    }
}
