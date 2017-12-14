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
        private DAL_ThemDuLieu dal;
        public void excuteSQL(string SQL)
        {
            dal.excuteSQL(SQL);
        }
        public string getGroup(string tennganh)
        {
            return dal.getGroup(tennganh);
        }

    }
}
