using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    class TinhChatProvider:COBAOProvider<TinhChat>
    {
        public override void Insert(TinhChat entity)
        {
            Db.sp_InsertTinhChat(entity.MaTinhChat, entity.TenTinhChat);
        }

        public override void Update(TinhChat entity)
        {
            Db.sp_UpdateTinhChat(entity.MaTinhChat, entity.TenTinhChat);
        }

        public override void Delete(TinhChat entity)
        {
            Db.sp_DeleteTinhChat(entity.MaTinhChat);
        }

        public override List<TinhChat> GetAll()
        {
            return Db.sp_SelectTinhChatsAll().ToList();
        }

        public override bool IsExisted(TinhChat entity)
        {
            return Db.TinhChats.Any(tc => tc.MaTinhChat.Equals(entity.MaTinhChat));
        }
        
        public bool IsExistedTenTinhChat(TinhChat entity)
        {
            return Db.TinhChats.Any(tc => tc.TenTinhChat.Equals(entity.TenTinhChat));
        }
    }
}
