using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho_Entity
{
    public class EC_nhaphang
    {
        private string mapn;
        private DateTime ngaynhap;
        private string manv;


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

        public DateTime Ngaynhap
        {
            get
            {
                return ngaynhap;
            }

            set
            {
                ngaynhap = value;
            }
        }
        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }


    }
}
