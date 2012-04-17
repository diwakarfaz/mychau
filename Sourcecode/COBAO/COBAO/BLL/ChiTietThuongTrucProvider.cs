using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;
namespace COBAO.BLL
{
    public class ChiTietThuongTrucProvider:COBAOProvider<ChiTietThuongTruc>
    {
        public override void Insert(ChiTietThuongTruc entity)
        {
            Db.sp_InsertChiTietThuongTruc(entity.MaThuongTruc, entity.MaTaiXe, entity.Tai);
        }
        public void Insert(List<ChiTietThuongTruc> listChiTiet)
        {
            foreach (var l in listChiTiet)
            {
                Insert(l);
            }
        }

        public override void Update(ChiTietThuongTruc entity)
        {
            Db.sp_UpdateChiTietThuongTruc(entity.MaThuongTruc, entity.MaTaiXe, entity.Tai);
        }
        public void UpdateList(List<ChiTietThuongTruc> listChiTietThuongTruc)
        {
            foreach (var item in listChiTietThuongTruc)
            {
                Update(item);
            }
        }

        public override void Delete(ChiTietThuongTruc entity)
        {
            Db.sp_DeleteChiTietThuongTruc(entity.MaThuongTruc, entity.MaTaiXe);
        }
        public void DeleteList(List<ChiTietThuongTruc> listXoaChiTietThuongTruc)
        {
            foreach (var item in listXoaChiTietThuongTruc)
            {
                Delete(item);
            }
        }
        public override List<ChiTietThuongTruc> GetAll()
        {
            return Db.sp_SelectChiTietThuongTrucsAll().ToList();
        }

        public override bool IsExisted(ChiTietThuongTruc entity)
        {
            return Db.ChiTietThuongTrucs.Any(cttt => cttt.MaThuongTruc.Equals(entity.MaThuongTruc) && cttt.MaTaiXe.Equals(entity.MaTaiXe));
        }

        public List<ChiTietThuongTruc> GetChiTietThuongTrucByTheoTaiXe(TaiXe entity)
        {
            return Db.sp_SelectChiTietThuongTrucsByAndMaTaiXe(entity.MaTaiXe).ToList();
        }
    }
}
