using EntityLayer;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class EntryDB
    {
        static StoreEntities db = new StoreEntities();
        public VorudTbl selectItem(int code)
        {
            VorudTbl item = null;
            item = (from b in db.orudTbls
                    where b.vorudcode == code
                    select b).SingleOrDefault();
            return item;
        }
        public List<VorudTbl> selectList()
        {
            List<VorudTbl> item = null;
            item = (from b in db.VorudTbls
                    select b).ToList();
            return item;
        }
        public Int64 insert(VorudTbl item)
        {
            db.VorudTbls.AddObject(item);
            db.VorudTbls.SaveChanges();
            return item.vorudcode;
        }
        public Int64 update(VorudTbl item)
        {
            VorudTbl q = new VorudTbl();
            q = (from b in db.VorudTbls
                 where b.vorudcode == item.vorudcode
                 select b).SingleOrDefault();
            q.forushandecode = item.forushandecode;
            q.kalacode = item.kalacode;
            q.tedad = item.tedad;
            q.date = q.date;
            q.motesadicode = item.motesadicode;
            db.VorudTbls.SaveChanges();
            return q.vorudcode;
        }
        public Int64 delete(int code)
        {
            VorudTbl q = new VorudTbl();
            q = (from b in db.VorudTbls
                 where b.vorudcode == code
                 select b).SingleOrDefault();
            db.VorudTbls.DeleteObject(q);
            db.VorudTbls.SaveChanges();
            return q.vorudcode;
        }
    }
}
