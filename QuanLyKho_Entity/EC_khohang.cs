using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho_Entity
{
    public class EC_khohang
    {
        private string mahang;
        private string tenhang;
        private int soluong;
        private int gianhap;
        private int giaxuat;
        private string macc;
        private string maloaihang;

        public string Mahang
        {
            get
            {
                return mahang;
            }

            set
            {
                mahang = value;
            }
        }

        public string Tenhang
        {
            get
            {
                return tenhang;
            }

            set
            {
                tenhang = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string Macc
        {
            get
            {
                return macc;
            }

            set
            {
                macc = value;
            }
        }

        public string Maloaihang
        {
            get
            {
                return maloaihang;
            }

            set
            {
                maloaihang = value;
            }
        }

        public int Gianhap
        {
            get
            {
                return gianhap;
            }

            set
            {
                gianhap = value;
            }
        }

        public int Giaxuat
        {
            get
            {
                return giaxuat;
            }

            set
            {
                giaxuat = value;
            }
        }
    }
}
