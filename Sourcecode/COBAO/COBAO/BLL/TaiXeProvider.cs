using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    class TaiXeProvider: COBAOProvider<TaiXe>
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
    }

}