using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class NhanVienProvider: COBAOProvider<NhanVien>
    {
        
        public override void Insert(NhanVien entity)
        {
            Db.sp_InsertNhanVien(entity.MaNV, entity.TenNV, entity.DiaChi, entity.Pass, entity.DienThoai, entity.ChucDanh);
        }

        public override void Update(NhanVien entity)
        {
            Db.sp_UpdateNhanVien(entity.MaNV, entity.TenNV, entity.DiaChi, entity.Pass, entity.DienThoai, entity.ChucDanh);
        }

        public override void Delete(NhanVien entity)
        {
            Db.sp_DeleteNhanVien(entity.MaNV);
        }

        public override List<NhanVien> GetAll()
        {
            return Db.sp_SelectNhanViensAll().ToList();
        }

        public override bool IsExisted(NhanVien entity)
        {
            return Db.NhanViens.Any(nv => nv.MaNV.Equals(entity.MaNV));
        }
         public NhanVien DangNhap(string manv, string matkhau)
        {
            return Db.NhanViens.Single(nv => nv.MaNV.Equals(manv) && nv.Pass.Equals(matkhau));
        }
         public List<NhanVien> nvlist(string manv)
         {
             return Db.sp_SelectNhanViensByAndMaNV(manv).ToList();
         }

    }
}
