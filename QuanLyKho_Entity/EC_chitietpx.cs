using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho_Entity
{
    public class EC_chitietpx
    {
        private string mapx;
        private string mahang;
        private int soluong;
        private int dongia;

        public string Mapx
        {
            get
            {
                return mapx;
            }

            set
            {
                mapx = value;
            }
        }

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
    }
}
