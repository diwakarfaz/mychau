using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;

namespace COBAO.BLL
{
    public abstract class COBAOProvider<T>
    {
        private COBAOLINQDataContext db;

        protected COBAOLINQDataContext Db
        {
            get { return db; }
            set { db = value; }
        }

        public COBAOProvider()
        {
            db = new COBAOLINQDataContext();
        }

        public COBAOProvider(string connection)
        {
            db = new COBAOLINQDataContext(connection);
        }

        public abstract void Insert(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);
        public abstract List<T> GetAll();
        public abstract bool IsExisted(T entity);
    }
}
