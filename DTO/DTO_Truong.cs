using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_Truong
    {
        private string maTruong, tenTruong, diaChi, website, tinhThanh, dvChuQuan;

        public DTO_Truong()
        {
        }

        public DTO_Truong(string ma_truong, string ten_truong, string dia_chi, string website, string tinh_thanh, string dv_chu_quan)
        {
            this.maTruong = ma_truong;
            this.tenTruong = ten_truong;
            this.diaChi = dia_chi;
            this.website = website;
            this.tinhThanh = tinh_thanh;
            this.dvChuQuan = dv_chu_quan;
        }

        public string MaTruong
        {
            get
            {
                return maTruong;
            }
            set
            {
                maTruong = value;
            }
        }
        public string TenTruong
        {
            get
            {
                return tenTruong;
            }
            set
            {
                tenTruong = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }
        public string Website
        {
            get
            {
                return website;
            }
            set
            {
                website = value;
            }
        }
        public string TinhThanh
        {
            get
            {
                return tinhThanh;
            }
            set
            {
                tinhThanh = value;
            }
        }
        public string DVChuquan
        {
            get
            {
                return dvChuQuan;
            }
            set
            {
                dvChuQuan = value;
            }
        }
    }
}
