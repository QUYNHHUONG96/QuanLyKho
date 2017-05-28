using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho_Entity
{
    public class EC_chitietpn
    {
        private string mapn;
        private string macc;
        private string maloaihang;
        private int sltheoLT;
        private int slThuc;
        private int dongia;
        private double thanhtien;
        private string tenhang;

        public string Mapn
        {
            get
            {
                return mapn;
            }

            set
            {
                mapn = value;
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

        public int SltheoLT
        {
            get
            {
                return sltheoLT;
            }

            set
            {
                sltheoLT = value;
            }
        }

        public int SlThuc
        {
            get
            {
                return slThuc;
            }

            set
            {
                slThuc = value;
            }
        }

        public int Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
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

        public double Thanhtien
        {
            get
            {
                return thanhtien;
            }

            set
            {
                thanhtien = value;
            }
        }
    }
}
