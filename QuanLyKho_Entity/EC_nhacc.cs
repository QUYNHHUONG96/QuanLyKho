using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho_Entity
{
    public class EC_nhacc
    {
        private string macc;
        private string tencc;
        private string diachi;
        private string sdt;
        private string nuocsx;

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

        public string Tencc
        {
            get
            {
                return tencc;
            }

            set
            {
                tencc = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Nuocsx
        {
            get
            {
                return nuocsx;
            }

            set
            {
                nuocsx = value;
            }
        }
    }
}
