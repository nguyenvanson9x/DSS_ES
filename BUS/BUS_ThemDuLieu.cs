using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_ThemDuLieu
    {
        private DAL_ThemDuLieu dal=new DAL_ThemDuLieu();
        public void excuteSQL(string SQL)
        {
            dal.excuteSQL(SQL);
        }
        public bool checkSQL(string SQL)
        {
            return dal.checkSQL(SQL);
        }
        public int getGroup(string tennganh)
        {
            return dal.getGroup(tennganh);
        }
        public int getNumberRow()
        {
            return dal.getNumberRow();
        }


        public List<string> auto_complete(string type)
        {
            return dal.auto_complete(type);
        }
    }
}
