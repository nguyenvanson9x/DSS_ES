using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_TuyenSinh
    {
        private string maTruong, maNganh;
        private double diemChuan;
        private int chiTieu, soLuongTuyen;

        public DTO_TuyenSinh()
        {
        }

        public DTO_TuyenSinh(string ma_truong, string ma_chuyen_nganh, double diem_chuan, int chi_tieu, int so_luong_tuyen)
        {
            this.maTruong = ma_truong;
            this.maNganh = ma_chuyen_nganh;
            this.diemChuan = diem_chuan;
            this.chiTieu = chi_tieu;
            this.soLuongTuyen = so_luong_tuyen;
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

        public string MaNganh
        {
            get
            {
                return maNganh;
            }
            set
            {
                maNganh = value;
            }
        }

        public double DiemChuan
        {
            get
            {
                return diemChuan;
            }
            set
            {
                diemChuan = value;
            }
        }

        public int ChiTieu
        {
            get
            {
                return chiTieu;
            }
            set
            {
                chiTieu = value;
            }
        }

        public int SLDaTuyen
        {
            get
            {
                return soLuongTuyen;
            }
            set
            {
                soLuongTuyen = value;
            }
        }
    }
}
