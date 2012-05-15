using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;
using System.Collections;

namespace COBAO.BLL
{
    class TaiXeProvider : COBAOProvider<TaiXe>
    {
        public override void Insert(TaiXe entity)
        {
            Db.sp_InsertTaiXe(entity.MaTaiXe, entity.TenTaiXe, entity.DiaChi, entity.DienThoai, entity.Tai, entity.HeSoLuong, entity.MaTo);
            //new guid()
        }

        public override void Update(TaiXe entity)
        {
            Db.sp_UpdateTaiXe(entity.MaTaiXe, entity.TenTaiXe, entity.DiaChi, entity.DienThoai, entity.Tai, entity.HeSoLuong, entity.MaTo);
        }

        public override void Delete(TaiXe entity)
        {
            Db.sp_DeleteTaiXe(entity.MaTaiXe);
        }

        public override bool IsExisted(TaiXe entity)
        {
            return Db.TaiXes.Any(tx => tx.MaTaiXe == entity.MaTaiXe);
        }
        public override List<TaiXe> GetAll()
        {
            return Db.sp_SelectTaiXesAll().ToList();
        }


        public List<TaiXe> GetTaiXeByTheoTo(To entity)
        {
            Guid? maTo = entity.MaTo;
            return Db.sp_SelectTaiXesByAndMaTo(maTo).ToList();
        }

        public List<TaiXe> txlist(string matx)
        {
            return Db.sp_SelectTaiXesByAndMaTaiXe(matx).ToList();
        }

        public List<TaiXe> TaiPhu(string mataixe)
        {
            try
            {
                var taiphu1 = (from tp in Db.TaiXes
                               where !tp.MaTaiXe.Equals(mataixe)
                               select tp).ToList();
                return taiphu1.ToList();
            }
            catch (Exception)
            {
                return null;
            }

        }
        public List<TaiXe> theotauchinh(string mataixe, string mataixe1)
        {
            try
            {
                var taiphu1 = (from tp in Db.TaiXes
                               where !tp.MaTaiXe.Equals(mataixe) && !tp.MaTaiXe.Equals(mataixe1) && tp.Tai.Equals(true)
                               select tp).ToList();
                return taiphu1.ToList();
            }
            catch (Exception)
            {
                return null;
            }

        }
        public List<TaiXe> theotauphu(string mataixe, string mataixe1, string mataixe2)
        {
            try
            {
                var taiphu1 = (from tp in Db.TaiXes
                               where !tp.MaTaiXe.Equals(mataixe) && !tp.MaTaiXe.Equals(mataixe1) && !tp.MaTaiXe.Equals(mataixe2)
                               select tp).ToList();
                return taiphu1.ToList();
            }
            catch (Exception)
            {
                return null;
            }

        }
        public List<TaiXe> TaiChinh(bool tai)
        {
            tai = true;
            try
            {
                var taichinh = (from tc in Db.TaiXes
                                where tc.Tai.Equals(tai)
                                select tc).ToList();
                return taichinh.ToList();
            }
            catch (Exception)
            {
                return null;
            }

        }
        public int Giolam(string mataixe, int thang, int nam)
        {
            try
            {
                int gio = new CoBao1Provider().giolv(mataixe, thang, nam)
                           + new CoBao1Provider().giotheotau(mataixe, thang, nam)
                           + new ThuongTrucProvider().giothuongtruc(mataixe, thang, nam)
                           + new KhamXetProvider().giokhamxet(mataixe, thang, nam)
                           + new HopPhepOmProvider().giohop(mataixe, thang, nam);
                return (int)gio;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public decimal luong(string mataixe, int thang, int nam)
        {
            var nkcaba = (from nhatkybs in Db.NhatKyThayDoiDonGiaBoSungs
                          join dgbs in Db.DonGiaLuongBoSungs on nhatkybs.MaDonGia equals dgbs.MaDonGia
                          where ((nhatkybs.NgayThayDoi.Month <= thang && nhatkybs.NgayThayDoi.Year == nam) || (nhatkybs.NgayThayDoi.Year < nam)) && dgbs.MoTa=="Ca ba"
                          orderby nhatkybs.NgayThayDoi ascending
                          select nhatkybs).ToList().Last();
            var nkluutru = (from nhatkybs in Db.NhatKyThayDoiDonGiaBoSungs
                          join dgbs in Db.DonGiaLuongBoSungs on nhatkybs.MaDonGia equals dgbs.MaDonGia
                          where ((nhatkybs.NgayThayDoi.Month <= thang && nhatkybs.NgayThayDoi.Year == nam) || (nhatkybs.NgayThayDoi.Year < nam)) && dgbs.MoTa=="Lưu trú"
                          orderby nhatkybs.NgayThayDoi ascending
                          select nhatkybs).ToList().Last();
            var nktrucdd = (from nhatkybs in Db.NhatKyThayDoiDonGiaBoSungs
                            join dgbs in Db.DonGiaLuongBoSungs on nhatkybs.MaDonGia equals dgbs.MaDonGia
                            where ((nhatkybs.NgayThayDoi.Month <= thang && nhatkybs.NgayThayDoi.Year == nam) || (nhatkybs.NgayThayDoi.Year < nam)) && dgbs.MoTa == "Trực dọc đường"
                            orderby nhatkybs.NgayThayDoi ascending
                            select nhatkybs).ToList().Last();
            var nktheotau = (from nhatkybs in Db.NhatKyThayDoiDonGiaBoSungs
                            join dgbs in Db.DonGiaLuongBoSungs on nhatkybs.MaDonGia equals dgbs.MaDonGia
                            where ((nhatkybs.NgayThayDoi.Month <= thang && nhatkybs.NgayThayDoi.Year == nam) || (nhatkybs.NgayThayDoi.Year < nam)) && dgbs.MoTa == "Theo tàu"
                            orderby nhatkybs.NgayThayDoi ascending
                            select nhatkybs).ToList().Last();
            var nkkhamxet = (from nhatkybs in Db.NhatKyThayDoiDonGiaBoSungs
                            join dgbs in Db.DonGiaLuongBoSungs on nhatkybs.MaDonGia equals dgbs.MaDonGia
                            where ((nhatkybs.NgayThayDoi.Month <= thang && nhatkybs.NgayThayDoi.Year == nam) || (nhatkybs.NgayThayDoi.Year < nam)) && dgbs.MoTa == "Khám xét"
                            orderby nhatkybs.NgayThayDoi ascending
                            select nhatkybs).ToList().Last();
            var nkthuongtruc = (from nhatkybs in Db.NhatKyThayDoiDonGiaBoSungs
                            join dgbs in Db.DonGiaLuongBoSungs on nhatkybs.MaDonGia equals dgbs.MaDonGia
                            where ((nhatkybs.NgayThayDoi.Month <= thang && nhatkybs.NgayThayDoi.Year == nam) || (nhatkybs.NgayThayDoi.Year < nam)) && dgbs.MoTa == "Thường trực"
                            orderby nhatkybs.NgayThayDoi ascending
                            select nhatkybs).ToList().Last();

            decimal cobao = 0;
            var a = (from sql in Db.CoBaos
                     where sql.NgayGioNhanMay.Date.Month == thang && sql.NgayGioNhanMay.Date.Year == nam
                   && (from sq in Db.CoBaoLaiTaus where sq.MaTaiXe == mataixe select sq.SoCoBao).Contains(sql.SoCoBao)
                     select sql).ToList();
            foreach (var item in a)
            {
                var mactau = item.MaMacTau;
                var b = (from sql in Db.MacTaus where sql.MaMacTau == item.MaMacTau select sql.MaLuongXL).Single();
                var nk = (from nhatky in Db.NhatKyThayDoiGiaXLs
                             where ((nhatky.NgayThayDoi.Month <= thang && nhatky.NgayThayDoi.Year == nam) || (nhatky.NgayThayDoi.Year < nam)) && nhatky.MaLuongXL == b
                             orderby nhatky.NgayThayDoi ascending
                             select nhatky).ToList().Last();
                decimal temp = 0;
                if (item.XepLoai == "A")
                {
                    temp = nk.LoaiAMoi;
                }
                else if (item.XepLoai == "B")
                {
                    temp = nk.LoaiBMoi;
                }
                else if (item.XepLoai == "C")
                {
                    temp = nk.LoaiCMoi;
                }
                else if (item.XepLoai == "BBH")
                {
                    var dg = (from dongia in Db.DonGiaLuongXLs
                              where dongia.MoTa.Equals("Thoi, Bất bình hành")
                              select dongia.MaLuongXL).Single();
                    var nkbbh = (from nhatky in Db.NhatKyThayDoiGiaXLs
                                 where ((nhatky.NgayThayDoi.Month <= thang && nhatky.NgayThayDoi.Year == nam) || (nhatky.NgayThayDoi.Year < nam)) && nhatky.MaLuongXL == dg
                                 orderby nhatky.NgayThayDoi ascending
                                 select nhatky).ToList().Last();
                    temp = (decimal)item.ThoiGianBBH/60 * nkbbh.LoaiBMoi ;
                }
               temp += (decimal)item.GioCaBa/60 * nkcaba.DonGiaMoi + (decimal)item.ThoiGianTruc/60 * nktrucdd.DonGiaMoi;
                var t = (from sql in Db.CoBaoLaiTaus where sql.SoCoBao == item.SoCoBao && sql.MaTaiXe==mataixe select sql).Single();
                if (t.Tai)
                {
                    cobao += temp + (decimal)t.GioLuuTru / 60 * nkluutru.DonGiaMoi ;
                }
                else
                {
                    cobao += (temp + (decimal)t.GioLuuTru / 60 * nkluutru.DonGiaMoi) * 70 / 100;
                }
                
            }

            decimal theotau = 0;
            var ttau = (from sql in Db.CoBaos
                        where sql.NgayGioNhanMay.Date.Month == thang && sql.NgayGioNhanMay.Date.Year == nam
                      && (from sq in Db.TheoTaus where sq.MaTaiXe == mataixe select sq.SoCoBao).Contains(sql.SoCoBao)
                        select sql).ToList();
            foreach (var item in ttau)
            {
                var t = (from sql in Db.TheoTaus where sql.SoCoBao == item.SoCoBao && sql.MaTaiXe == mataixe select sql).Single();
                if (t.Tai)
                {
                    theotau += (decimal)t.GioTheoTau / 60 * nktheotau.DonGiaMoi + (decimal)t.GioLuuTru / 60 * nkluutru.DonGiaMoi;
                }
                else
                {
                    theotau += ((decimal)t.GioTheoTau / 60 * nktheotau.DonGiaMoi + (decimal)t.GioLuuTru / 60 * nkluutru.DonGiaMoi) * 70 / 100;
                }

            }

            decimal khamxet = 0;
            var kx = (from sql in Db.KhamXets
                      where sql.NgayGioBatDau.Date.Month == thang && sql.NgayGioBatDau.Date.Year == nam
                    && (from sq in Db.ChiTietKhamXets where sq.MaTaiXe == mataixe select sq.MaKhamXet).Contains(sql.MaKhamXet)
                      select sql).ToList();
            foreach (var item in kx)
            {
                decimal temp = 0;
                temp = (decimal)item.ThoiGianKhamXet/60 * nkkhamxet.DonGiaMoi + (decimal)item.GioCaBa/60 *nkcaba.DonGiaMoi;
                var t = (from sql in Db.ChiTietKhamXets where sql.MaKhamXet == item.MaKhamXet && sql.MaTaiXe == mataixe select sql).Single();
                if (t.Tai)
                {
                    khamxet += temp;
                }
                else
                {
                    khamxet += temp * 70 / 100;
                }

            }

            decimal thuongtruc = 0;
            var ttruc = (from sql in Db.ThuongTrucs
                      where sql.NgayBatDau.Date.Month == thang && sql.NgayBatDau.Date.Year == nam
                    && (from sq in Db.ChiTietThuongTrucs where sq.MaTaiXe == mataixe select sq.MaThuongTruc).Contains(sql.MaThuongTruc)
                      select sql).ToList();
            foreach (var item in ttruc)
            {
                decimal temp = 0;
                temp = (decimal)item.ThoiGianTruc / 60 * nkthuongtruc.DonGiaMoi + (decimal)item.GioCaBa / 60 * nkcaba.DonGiaMoi;
                var t = (from sql in Db.ChiTietThuongTrucs where sql.MaThuongTruc == item.MaThuongTruc && sql.MaTaiXe == mataixe select sql).Single();
                if (t.Tai)
                {
                    thuongtruc += temp;
                }
                else
                {
                    thuongtruc += temp * 70 / 100;
                }

            }
            decimal luong=0;
            luong = cobao + khamxet + thuongtruc + theotau;
            return Math.Round((decimal)(luong)) ;
        }
    }

}