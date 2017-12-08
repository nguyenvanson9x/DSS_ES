using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_Truong
    {
        private string maTruong, tenTruong, diaChi, website;

        public DTO_Truong()
        {
        }

        public DTO_Truong(string ma_truong, string ten_truong, string dia_chi, string website)
        {
            this.maTruong = ma_truong;
            this.tenTruong = ten_truong;
            this.diaChi = dia_chi;
            this.website = website;

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
    }
}
