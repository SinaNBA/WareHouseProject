using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using EntityLayer;
using DataAccess;

namespace Logical
{
    public static class LogicalManagerGoods
    {
        static GoodsDB itemDB = new GoodsDB();
        static public KalaTbl selectItem(int code)
        {
            try
            {
                return itemDB.seletItem(code);
            }
            catch (Exception ex)
            {
                return null;
                //throw;
            }
        }
        static public List<KalaTbl> selectList()
        {
            try
            {
                return itemDB.selectList();
            }
            catch (Exception ex)
            {
                return null;
                //throw;
            }

        }
        static public Int64 insert(KalaTbl item)
        {
            try
            {
                return itemDB.insert(item);
            }
            catch (Exception ex)
            {
                return -1;
                //throw;
            }
        }
        static public Int64 update(KalaTbl item)
        {
            try
            {
                return itemDB.update(item);
            }
            catch (Exception ex)
            {
                return -1;
                //throw;
            }
        }
        static public Int64 delete(int code)
        {
            try
            {
                return itemDB.delete(code);
            }
            catch (Exception ex)
            {
                return -1;
                //throw;
            }
        }
    }
}
