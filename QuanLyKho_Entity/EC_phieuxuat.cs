using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho_Entity
{
    public class EC_phieuxuat
    {
        private string mapx;
        private DateTime ngayxuat;
        private string manv;
        private string makh;

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

        public DateTime Ngayxuat
        {
            get
            {
                return ngayxuat;
            }

            set
            {
                ngayxuat = value;
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

        public string Makh
        {
            get
            {
                return makh;
            }

            set
            {
                makh = value;
            }
        }
    }
}
