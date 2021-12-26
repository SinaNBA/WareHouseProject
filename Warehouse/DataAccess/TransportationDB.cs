using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Linq;
using EntityLayer;

namespace DataAccess
{
    public class TransportationDB
    {
        static EntityLayer.StoreEntities db = new EntityLayer.StoreEntities();
        public TahvilgirandeTbl seletItem(int code)
        {
            TahvilgirandeTbl item = null;
            item = (from b in db.TahvilgirandeTbl
                    where b.code == code
                    select b).SingleOrDefault();
            return item;
        }
        public List<TahvilgirandeTbl> selectList()
        {
            List<TahvilgirandeTbl> item = null;
            item = (from b in db.TahvilgirandeTbl
                    select b).ToList();
            return item;
        }
        public Int64 insert(TahvilgirandeTbl item)
        {
            db.TahvilgirandeTbl.AddObject(item);
            db.SaveChanges();
            return item.code;
        }
        public Int64 update(TahvilgirandeTbl item)
        {
            TahvilgirandeTbl q = new TahvilgirandeTbl();
            q = (from b in db.TahvilgirandeTbl
                 where b.code == item.code
                 select b).SingleOrDefault();
            q.name = item.name;
            q.family = item.family;
            q.address = item.address;
            q.tell = item.tell;
            db.SaveChanges();
            return q.code;
        }
        public Int64 delete(int code)
        {
            TahvilgirandeTbl q = new TahvilgirandeTbl();
            q = (from b in db.TahvilgirandeTbl
                 where b.code == code
                 select b).SingleOrDefault();
            db.TahvilgirandeTbl.DeleteObject(q);
            db.SaveChanges();
            return q.code;
        }
    }
}
