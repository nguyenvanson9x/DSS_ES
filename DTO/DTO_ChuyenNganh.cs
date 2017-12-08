using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_ChuyenNganh
    {
        private string ma_nganh;
        private int nhom_nganh;

        public DTO_ChuyenNganh()
        {
        }

        public DTO_ChuyenNganh(string ma_chuyen_nganh, int ma_nhom_nganh)
        {
            this.ma_nganh = ma_chuyen_nganh;
            this.nhom_nganh = ma_nhom_nganh;
        }

        public string MaNganh
        {
            get
            {
                return ma_nganh;
            }
            set
            {
                ma_nganh = value;
            }
        }

        public int NhomNganh
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

    }
}
