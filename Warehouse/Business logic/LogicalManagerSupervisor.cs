using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityLayer;
using DataAccess;

namespace Logical
{
    static public class LogicalManagerSupervisor
    {
        static SupervisorDB itemDB = new SupervisorDB();
        static public MotesadiTbl seletItem(int code)
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
        static public List<MotesadiTbl> seletlist()
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


        static public Int64 insert(MotesadiTbl item)
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
        static public Int64 update(MotesadiTbl item)
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
