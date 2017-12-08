using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_NhomNganh
    {
        private int nhom_nganh;
        private string ten_chuyen_nganh;

        public DTO_NhomNganh()
        {
        }

        public DTO_NhomNganh(int ma_nhom_nganh, string ten_chuyen_nganh)
        {
            this.nhom_nganh = ma_nhom_nganh;
            this.ten_chuyen_nganh = ten_chuyen_nganh;
        }

        public int MaNhomNganh
        {
            get
            {
                return nhom_nganh;
            }
            set
            {
                nhom_nganh = value;
            }
        }

        public string TenChuyenNganh
        {
            get
            {
                return ten_chuyen_nganh;
            }
            set
            {
                ten_chuyen_nganh = value;
            }
        }
    }
}
