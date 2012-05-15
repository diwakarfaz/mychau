using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public class TheoTauProvider: COBAOProvider<TheoTau>
    {
        public override void Insert(TheoTau entity)
        {
            Db.sp_InsertTheoTau(entity.SoCoBao, entity.MaTaiXe, entity.Tai, entity.GioTheoTau, entity.GioLuuTru);
        }

        public void Insert(List<TheoTau> listChiTiet)
        {
            foreach (var l in listChiTiet)
            {
                Insert(l);
            }
        }

        public override void Update(TheoTau entity)
        {
            Db.sp_UpdateTheoTau(entity.SoCoBao, entity.MaTaiXe, entity.Tai, entity.GioTheoTau, entity.GioLuuTru);
        }
        public void UpdateList(List<TheoTau> listTheoTau)
        {
            foreach (var item in listTheoTau)
            {
                Update(item);
            }
        }

        public override void Delete(TheoTau entity)
        {
            Db.sp_DeleteTheoTau(entity.SoCoBao, entity.MaTaiXe);
        }
        public void DeleteList(List<TheoTau> listXoaTheoTau)
        {
            foreach (var item in listXoaTheoTau)
            {
                Delete(item);
            }
        }

        public override List<TheoTau> GetAll()
        {
            return Db.sp_SelectTheoTausAll().ToList();
        }

        public override bool IsExisted(TheoTau entity)
        {
            return Db.TheoTaus.Any(tt => tt.SoCoBao.Equals(entity.SoCoBao) && tt.MaTaiXe.Equals(entity.MaTaiXe));
        }
        public List<TheoTau> GetTheoTauByTheoTaiXe(TaiXe entity)
        {
            return Db.sp_SelectTheoTausByAndMaTaiXe(entity.MaTaiXe).ToList();
        }
        public List<TheoTau> GetTheoTauByTheoCoBao(CoBao entity)
        {
            return Db.sp_SelectTheoTausByAndSoCoBao(entity.SoCoBao).ToList();
        }

        public TheoTau GetTheoTauTheoSoCoBao(string socobao, bool tai)
        {
            try
            {
                return (from theotau in Db.TheoTaus
                        where theotau.SoCoBao.Equals(socobao) && theotau.Tai == tai
                        select theotau).Single();
            }
            catch
            {
                return null;
            }
        }
    }
}
