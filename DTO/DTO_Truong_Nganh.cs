using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_Truong_Nganh
    {
        private string maTruong, maNganh;
        private int namDaoTao, soCanBo;

        public DTO_Truong_Nganh()
        {

        }

        public DTO_Truong_Nganh(string ma_truong, string ma_chuyen_nganh, int nam_dao_tao, int so_can_bo)
        {
            this.maTruong = ma_truong;
            this.maNganh = ma_chuyen_nganh;
            this.namDaoTao = nam_dao_tao;
            this.soCanBo = so_can_bo;
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

        public string MaChuyenNganh
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

        public int NamDT
        {
            get
            {
                return namDaoTao;   
            }
            set
            {
                namDaoTao = value;
            }
        }

        public int SoCB
        {
            get
            {
                return soCanBo;
            }
            set
            {
                soCanBo = value;
            }
        }
    }
}
