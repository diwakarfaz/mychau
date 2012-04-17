using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class HanhTrinhProvider: COBAOProvider<HanhTrinh>
    {

        public override void Insert(HanhTrinh entity)
        {
            Db.sp_InsertHanhTrinh(entity.SoCoBao, entity.MaGa, entity.TrangThaiGa, entity.NgayGioDen, entity.NgayGioDi);
        }

        public override void Update(HanhTrinh entity)
        {
            Db.sp_UpdateHanhTrinh(entity.SoCoBao, entity.MaGa, entity.TrangThaiGa, entity.NgayGioDen, entity.NgayGioDi);
        }

        public override void Delete(HanhTrinh entity)
        {
            Db.sp_DeleteHanhTrinh(entity.SoCoBao, entity.MaGa);
        }

        public override List<HanhTrinh> GetAll()
        {
            return Db.sp_SelectHanhTrinhsAll().ToList();
        }

        public override bool IsExisted(HanhTrinh entity)
        {
            return Db.HanhTrinhs.Any(ht => ht.SoCoBao.Equals(entity.SoCoBao) && ht.MaGa.Equals(entity.MaGa));
        }
        public List<HanhTrinh> GetHanhTrinhByTheoCoBao(CoBao entity)
        {
            return Db.sp_SelectHanhTrinhsByAndSoCoBao(entity.SoCoBao).ToList();
        }
    }
}
