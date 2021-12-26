using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Linq;
using EntityLayer;

namespace DataAccess
{
    public class SellerDB
    {
        static EntityLayer.StoreEntities db = new EntityLayer.StoreEntities();
        public ForushandeTbl seletItem(int code)
        {
            ForushandeTbl item = null;
            item = (from b in db.ForushandeTbl
                    where b.forushandecode == code
                    select b).SingleOrDefault();
            return item;
        }
        public List<ForushandeTbl> selectList()
        {
            List<ForushandeTbl> item = null;
            item = (from b in db.ForushandeTbl
                    select b).ToList();
            return item;
        }
        public Int64 insert(ForushandeTbl item)
        {
            db.ForushandeTbl.AddObject(item);
            db.SaveChanges();
            return item.forushandecode;
        }
        public Int64 update(ForushandeTbl item)
        {
            ForushandeTbl q = new ForushandeTbl();
            q = (from b in db.ForushandeTbl
                 where b.forushandecode == item.forushandecode
                 select b).SingleOrDefault();
            q.name = item.name;
            q.family = item.family;
            q.address = item.address;
            q.tell = item.tell;
            db.SaveChanges();
            return q.forushandecode;
        }
        public Int64 delete(int code)
        {
            ForushandeTbl q = new ForushandeTbl();
            q = (from b in db.ForushandeTbl
                 where b.forushandecode == code
                 select b).SingleOrDefault();
            db.ForushandeTbl.DeleteObject(q);
            db.SaveChanges();
            return q.forushandecode;
        }
    }
}
