using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class ChiTietKhamXetProvider: COBAOProvider<ChiTietKhamXet>
    {
        public override void Insert(ChiTietKhamXet entity)
        {
            Db.sp_InsertChiTietKhamXet(entity.MaKhamXet, entity.MaTaiXe, entity.Tai);
        }
        public void Insert(List<ChiTietKhamXet> listChiTiet)
        {
            foreach (var l in listChiTiet)
            {
                Insert(l);
            }
        }

        public override void Update(ChiTietKhamXet entity)
        {
            Db.sp_UpdateChiTietKhamXet(entity.MaKhamXet, entity.MaTaiXe, entity.Tai);
        }
        public void UpdateList(List<ChiTietKhamXet> listChiTietKhamXet)
        {
            foreach (var item in listChiTietKhamXet)
            {
                Update(item);
            }
        }

        public override void Delete(ChiTietKhamXet entity)
        {
            Db.sp_DeleteChiTietKhamXet(entity.MaKhamXet, entity.MaTaiXe);
        }
        public void DeleteList(List<ChiTietKhamXet> listXoaChiTietKhamXet)
        {
            foreach (var item in listXoaChiTietKhamXet)
            {
                Delete(item);
            }
        }
        public override List<ChiTietKhamXet> GetAll()
        {
            return Db.sp_SelectChiTietKhamXetsAll().ToList();
        }

        public override bool IsExisted(ChiTietKhamXet entity)
        {
            return Db.ChiTietKhamXets.Any(ctkx => ctkx.MaKhamXet.Equals(entity.MaKhamXet) && ctkx.MaTaiXe.Equals(entity.MaTaiXe)); 
        }
        public List<ChiTietKhamXet> GetChiTietKhamXetByTheoTaiXe(TaiXe entity)
        {
            return Db.sp_SelectChiTietKhamXetsByAndMaTaiXe(entity.MaTaiXe).ToList();
        }
    }
}
