using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_NhomNganh
    {
        private DAL_NhomNganh dal = new DAL_NhomNganh();

        public bool add(string ten_nhom_nganh)
        {
            return dal.add(ten_nhom_nganh);
        }

        public DataTable getNhomNganh()
        {
            return dal.getNhomNganh();
        }

        public bool edit(int id, string p)
        {
            return dal.edit(id, p);
        }

        public bool delete(int id)
        {
            return dal.delete(id);
        }
    }
}
