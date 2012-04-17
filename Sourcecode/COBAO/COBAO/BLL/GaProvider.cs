using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;
namespace COBAO.BLL
{
    public class GaProvider:COBAOProvider<Ga>
    {
        public override void Insert(Ga entity)
        {
            Db.sp_InsertGa(entity.MaGa, entity.TenGa, entity.Km);
        }

        public override void Update(Ga entity)
        {
            Db.sp_UpdateGa(entity.MaGa, entity.TenGa, entity.Km);
        }

        public override void Delete(Ga entity)
        {
            Db.sp_DeleteGa(entity.MaGa);
        }

        public override List<Ga> GetAll()
        {
            return Db.sp_SelectGasAll().ToList();
        }

        public override bool IsExisted(Ga entity)
        {
            bool ret = false;
            var timtrungtheoma = (from item in Db.Gas
                                  where item.MaGa == entity.MaGa
                                  select item).Count();
            var timtrungtheoten = (from item in Db.Gas
                                   where item.TenGa== entity.TenGa
                                   select item).Count();
            if (timtrungtheoma > 1 || timtrungtheoten > 1)
            {
                ret = true;
            }
            return ret;
        }
        public  bool IsExistedMaGa(Ga entity)
        {
            return Db.Gas.Any(g => g.MaGa.Equals(entity.MaGa));
        }
        public bool IsExistedTenGa(Ga entity)
        {
            return Db.Gas.Any(g => g.TenGa.Equals(entity.TenGa));
        }
    }
}
