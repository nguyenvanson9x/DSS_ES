using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_TuVan
    {
        private DAL_TuVan dal;

        public BUS_TuVan()
        {
            dal = new DAL_TuVan();
        }

        public DataTable getTuVan()
        {
            return dal.getTuVan();
        }
    }

}
