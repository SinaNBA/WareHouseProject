using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityLayer;
using DataAccess;

namespace Logical
{
    static public class LogicalManagerRemoval
    {
        static RemovalDB itemDB = new RemovalDB();
        static public KhorujTbl seletItem(int code)
        {
            try
            {
                return itemDB.selectItem(code);
            }
            catch (Exception ex)
            {
                return null;
                //throw;
            }
        }
        static public List<KhorujTbl> seletlist()
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


        static public Int64 insert(KhorujTbl item)
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
        static public Int64 update(KhorujTbl item)
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
