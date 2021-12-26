using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityLayer;
using System.Data.Entity;
using System.Data.Linq;

namespace DataAccess
{
    public class GoodsDB
    {
        static EntityLayer.StoreEntities db = new EntityLayer.StoreEntities();
        public KalaTbl seletItem(int code)
        {
            KalaTbl item = null;
            item = (from b in db.KalaTbl
                    where b.kalacode == code
                    select b).SingleOrDefault();
            return item;
        }
        public List<KalaTbl> selectList()
        {
            List<KalaTbl> item = null;
            item = (from b in db.KalaTbl
                    select b).ToList();
            return item;
        }
        public Int64 insert(KalaTbl item)
        {
            db.KalaTbl.AddObject(item);
            db.SaveChanges();
            return item.kalacode;
        }
        public Int64 update(KalaTbl item)
        {
            KalaTbl q = new KalaTbl();
            q = (from b in db.KalaTbl
                 where b.kalacode == item.kalacode
                 select b).SingleOrDefault();
            q.moshakhasat = item.moshakhasat;
            q.sherkat = item.sherkat;
            q.code = item.code;
            db.SaveChanges();
            return q.kalacode;
        }
        public Int64 delete(int code)
        {
            KalaTbl q = new KalaTbl();
            q = (from b in db.KalaTbl
                 where b.kalacode == code
                 select b).SingleOrDefault();
            db.KalaTbl.DeleteObject(q);
            db.SaveChanges();
            return q.kalacode;
        }
    }
}
