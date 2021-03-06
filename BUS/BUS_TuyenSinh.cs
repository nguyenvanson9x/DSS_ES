﻿using System;
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
        public string getMaTruong(string TenTruong)
        {
            return dalTuyenSinh.getMaTruong(TenTruong);
        }
        public bool themTuyenSinh(DTO_TuyenSinh tv)
        {
            return dalTuyenSinh.themTuyenSinh(tv);
        }
        public int getGroup(string tennganh)
        {
            return dalTuyenSinh.getGroup(tennganh);
        }
        public bool suaTuyenSinh(DTO_TuyenSinh tv, string tentruong, string matruong, string manganh,int group,string tennganh)
        {
            return dalTuyenSinh.suaTuyenSinh(tv, tentruong, matruong, manganh, group, tennganh);
        }

        public bool xoaTuyenSinh(string MaTruong,string manganh)
        {
            return dalTuyenSinh.xoaTuyenSinh(MaTruong, manganh);
        }
    }
}
