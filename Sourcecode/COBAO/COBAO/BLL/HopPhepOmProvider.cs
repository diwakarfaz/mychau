using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;
namespace COBAO.BLL
{
    public class HopPhepOmProvider: COBAOProvider<HopPhepOm>
    {
        public override void Insert(HopPhepOm entity)
        {
            Guid? maHPO = entity.MaHPO;
            Db.sp_InsertHopPhepOm(entity.MaTaiXe, entity.TrangThai, entity.NgayBatDau, entity.SoNgay, ref maHPO);
        }

        public override void Update(HopPhepOm entity)
        {
            Db.sp_UpdateHopPhepOm(entity.MaHPO, entity.MaTaiXe, entity.TrangThai, entity.NgayBatDau, entity.SoNgay);
        }

        public override void Delete(HopPhepOm entity)
        {
            Db.sp_DeleteHopPhepOm(entity.MaHPO);
        }

        public override List<HopPhepOm> GetAll()
        {
            return Db.sp_SelectHopPhepOmsAll().ToList();
        }

        public override bool IsExisted(HopPhepOm entity)
        {
            throw new NotImplementedException();
        }
        public List<HopPhepOm> GetNgayCongByTheoTaiXe(TaiXe entity)
        {
            return Db.sp_SelectHopPhepOmsByAndMaTaiXe(entity.MaTaiXe).ToList();
        }
    }
}
