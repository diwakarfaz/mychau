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
        public int NgayCong(string mataixe, string trangthai, int thang, int nam)
        {
            try
            {
                long gio = (from ngaycong in Db.HopPhepOms
                            where (ngaycong.NgayBatDau.Month == thang && ngaycong.NgayBatDau.Year == nam
                                    && ngaycong.MaTaiXe == mataixe && ngaycong.TrangThai==trangthai)
                            select (long)ngaycong.SoNgay).Sum();
                return (int)gio;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int giohop(string mataixe, int thang, int nam)
        {
            try
            {
                long gio = (from ngaycong in Db.HopPhepOms
                            where (ngaycong.NgayBatDau.Month == thang && ngaycong.NgayBatDau.Year == nam
                                    && ngaycong.MaTaiXe == mataixe && ngaycong.TrangThai == "Họp tổ")
                            select (long)ngaycong.SoNgay*4).Sum();
                return (int)gio;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
