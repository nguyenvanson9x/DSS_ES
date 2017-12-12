using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_TuyenSinh
    {
        DAL_TuyenSinh dalTuyenSinh = new DAL_TuyenSinh();

        public DataTable getTuyenSinh()
        {
            return dalTuyenSinh.getTuyenSinh();
        }
        public DataTable search(string text)
        {
            return dalTuyenSinh.searchData(text);
        }
        public bool excuteSQL(string SQL)
        {
            return dalTuyenSinh.excuteSQL(SQL);
        }
        public bool themTuyenSinh(DTO_TuyenSinh tv)
        {
            return dalTuyenSinh.themTuyenSinh(tv);
        }

        public bool suaTuyenSinh(DTO_TuyenSinh tv)
        {
            return dalTuyenSinh.suaTuyenSinh(tv);
        }

        public bool xoaTuyenSinh(string MaTruong)
        {
            return dalTuyenSinh.xoaTuyenSinh(MaTruong);
        }
    }
}
