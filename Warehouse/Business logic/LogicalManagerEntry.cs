using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using EntityLayer;
using System.Data.Entity;

namespace Logical
{
    public static class LogicalManagerEntry
    {
        static EntryDB itemDB = new EntryDB();
        static public VorudTbl seletItem(int code)
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
        static public List<VorudTbl> seletlist()
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


        static public Int64 insert(VorudTbl item)
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
        static public Int64 update(VorudTbl item)
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
