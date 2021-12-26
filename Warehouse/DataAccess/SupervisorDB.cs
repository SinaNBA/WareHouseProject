using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Entity;
using EntityLayer;

namespace DataAccess
{
    public class SupervisorDB
    {
        static EntityLayer.StoreEntities db = new EntityLayer.StoreEntities();
        public MotesadiTbl seletItem(int code)
        {
            MotesadiTbl item = null;
            item = (from b in db.MotesadiTbl
                    where b.motesadicode == code
                    select b).SingleOrDefault();
            return item;
        }
        public List<MotesadiTbl> selectList()
        {
            List<MotesadiTbl> item = null;
            item = (from b in db.MotesadiTbl
                    select b).ToList();
            return item;
        }
        public Int64 insert(MotesadiTbl item)
        {
            db.MotesadiTbl.AddObject(item);
            db.SaveChanges();
            return item.motesadicode;
        }
        public Int64 update(MotesadiTbl item)
        {
            MotesadiTbl q = new MotesadiTbl();
            q = (from b in db.MotesadiTbl
                 where b.motesadicode == item.motesadicode
                 select b).SingleOrDefault();
            q.name = item.name;
            q.family = item.family;
            q.address = item.address;
            q.tell = item.tell;
            db.SaveChanges();
            return q.motesadicode;
        }
        public Int64 delete(int code)
        {
            MotesadiTbl q = new MotesadiTbl();
            q = (from b in db.MotesadiTbl
                 where b.motesadicode == code
                 select b).SingleOrDefault();
            db.MotesadiTbl.DeleteObject(q);
            db.SaveChanges();
            return q.motesadicode;
        }
    }
}
