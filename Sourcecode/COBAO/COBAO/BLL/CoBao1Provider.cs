using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class CoBao1Provider :COBAOProvider<CoBao>
    {
        public override void Insert(CoBao entity)
        {
            Db.sp_InsertCoBao(entity.SoCoBao, entity.MaNV, entity.MaDM, entity.MaMacTau, entity.NgayGioNhanMay, entity.NgayGioGiaoMay, entity.XepLoai, entity.LyDoXL,entity.GioLamViec, entity.ThoiGianBBH, entity.ThoiGianTruc, entity.GioCaBa);
        }

        public override void Update(CoBao entity)
        {
            Db.sp_UpdateCoBao(entity.SoCoBao, entity.MaNV, entity.MaDM, entity.MaMacTau, entity.NgayGioNhanMay, entity.NgayGioGiaoMay, entity.XepLoai, entity.LyDoXL, entity.GioLamViec, entity.ThoiGianBBH, entity.ThoiGianTruc, entity.GioCaBa);
        }

        public override void Delete(CoBao entity)
        {
            Db.sp_DeleteCoBao(entity.SoCoBao);
        }

        public override List<CoBao> GetAll()
        {
            return Db.sp_SelectCoBaosAll().ToList();
        }

        public override bool IsExisted(CoBao entity)
        {
            return Db.CoBaos.Any(cb => cb.SoCoBao.Equals(entity.SoCoBao));
        }
        public List<CoBao> GetCoBaoByTheoNhanVien(NhanVien entity)
        {
            return Db.sp_SelectCoBaosByAndMaNV(entity.MaNV).ToList();
        }
        public List<CoBao> GetCoBaoByTheoDauMay(DauMay entity)
        {
            return Db.sp_SelectCoBaosByAndMaDM(entity.MaDM).ToList();
        }
        public List<CoBao> GetCoBaoByTheoMacTau(MacTau entity)
        {
            return Db.sp_SelectCoBaosByAndMaMacTau(entity.MaMacTau).ToList();
        }
        public List<ChiTietThuongTruc> GetChiTietThuongTrucByTheoTaiXe(TaiXe entity)
        {
            return Db.sp_SelectChiTietThuongTrucsByAndMaTaiXe(entity.MaTaiXe).ToList();
        }

        public int giolv(string mataixe, int thang, int nam)
        {
            try
            {
                long GioDiTau = (from cobao in Db.CoBaos
                                join cobaolai in Db.CoBaoLaiTaus on cobao.SoCoBao equals cobaolai.SoCoBao
                                where (cobao.NgayGioGiaoMay.Month == thang && cobao.NgayGioGiaoMay.Year == nam
                                     && cobaolai.MaTaiXe == mataixe)
                                select (long)cobao.GioLamViec).Sum();
                return (int)GioDiTau/60;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int giotheotau(string mataixe, int thang, int nam)
        {
            try
            {
                long giotheotau = (from cobao in Db.CoBaos
                                 join theotau in Db.TheoTaus on cobao.SoCoBao equals theotau.SoCoBao
                                 where (cobao.NgayGioGiaoMay.Month == thang && cobao.NgayGioGiaoMay.Year == nam
                                      && theotau.MaTaiXe == mataixe)
                                 select (long)theotau.GioTheoTau).Sum();
                return (int)giotheotau / 60;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public CoBao GetSoGetCoBaoBySoCoBao(string socobao)
        {
            try
            {
                return (from sql in Db.CoBaos
                        where sql.SoCoBao.Equals(socobao)
                        select sql).Single();
            }
            catch
            {
                return null;
            }
        }
    }
}
