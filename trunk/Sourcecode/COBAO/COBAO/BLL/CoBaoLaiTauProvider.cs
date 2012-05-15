using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;
namespace COBAO.BLL
{
    public class CoBaoLaiTauProvider: COBAOProvider<CoBaoLaiTau>
    {
        public override void Insert(CoBaoLaiTau entity)
        {
            Db.sp_InsertCoBaoLaiTau(entity.SoCoBao, entity.MaTaiXe, entity.Tai, entity.GioLuuTru);
        }
        public void Insert(List<CoBaoLaiTau> listChiTiet)
        {
            foreach (var l in listChiTiet)
            {
                Insert(l);
            }
        }

        public override void Update(CoBaoLaiTau entity)
        {
            Db.sp_UpdateCoBaoLaiTau(entity.SoCoBao, entity.MaTaiXe, entity.Tai, entity.GioLuuTru);
        }
        public void UpdateList(List<CoBaoLaiTau> listCoBaoLaiTau)
        {
            foreach (var item in listCoBaoLaiTau)
            {
                Update(item);
            }
        }

        public override void Delete(CoBaoLaiTau entity)
        {
            Db.sp_DeleteCoBaoLaiTau(entity.SoCoBao, entity.MaTaiXe);
        }
        public void DeleteList(List<CoBaoLaiTau> listXoaCoBaoLaiTau)
        {
            foreach (var item in listXoaCoBaoLaiTau)
            {
                Delete(item);
            }
        }

        public override List<CoBaoLaiTau> GetAll()
        {
            return Db.sp_SelectCoBaoLaiTausAll().ToList();
        }

        public override bool IsExisted(CoBaoLaiTau entity)
        {
            return Db.CoBaoLaiTaus.Any(cblt => cblt.SoCoBao.Equals(entity.SoCoBao) && cblt.MaTaiXe.Equals(entity.MaTaiXe));
        }

        public List<CoBaoLaiTau> GetCoBaoLaiTauByTheoTaiXe(TaiXe entity)
        {
            return Db.sp_SelectCoBaoLaiTausByAndMaTaiXe(entity.MaTaiXe).ToList();
        }
        public List<CoBaoLaiTau> GetCoBaoLaiTauByTheoCoBao(CoBao entity)
        {
            return Db.sp_SelectCoBaoLaiTausByAndSoCoBao(entity.SoCoBao).ToList();
        }

        public CoBaoLaiTau GetCoBaoLaiTheoSoCoBao(string socobao, bool tai)
        {
            try
            {
                return (from cblt in Db.CoBaoLaiTaus
                        where cblt.SoCoBao.Equals(socobao) && cblt.Tai == tai
                        select cblt).Single();
            }
            catch
            {
                return null;
            }
        }
    }
}
