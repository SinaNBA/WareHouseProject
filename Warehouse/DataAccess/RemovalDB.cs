using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Entity;
using EntityLayer;

namespace DataAccess
{
    public class RemovalDB
    {
        static EntityLayer.StoreEntities db = new EntityLayer.StoreEntities();
        public KhorujTbl selectItem(int code)
        {
            KhorujTbl item = null;
            item = (from b in db.KhorujTbl
                    where b.khorujcode == code
                    select b).SingleOrDefault();
            return item;
        }
        public List<KhorujTbl> selectList()
        {
            List<KhorujTbl> item = null;
            item = (from b in db.KhorujTbl
                    select b).ToList();
            return item;
        }
        public Int64 insert(KhorujTbl item)
        {
            db.KhorujTbl.AddObject(item);
            db.SaveChanges();
            return item.khorujcode;
        }
        public Int64 update(KhorujTbl item)
        {
            KhorujTbl q = new KhorujTbl();
            q = (from b in db.KhorujTbl
                 where b.khorujcode == item.khorujcode
                 select b).SingleOrDefault();
            q.tahvilgirandecode = item.tahvilgirandecode;
            q.kalacode = item.kalacode;
            q.tedad = item.tedad;
            q.date = q.date;
            q.motesadicode = item.motesadicode;
            db.SaveChanges();
            return q.khorujcode;
        }
        public Int64 delete(int code)
        {
            KhorujTbl q = new KhorujTbl();
            q = (from b in db.KhorujTbl
                 where b.khorujcode == code
                 select b).SingleOrDefault();
            db.KhorujTbl.DeleteObject(q);
            db.SaveChanges();
            return q.khorujcode;
        }
    }
}
