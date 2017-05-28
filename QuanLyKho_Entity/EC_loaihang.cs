using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho_Entity
{
    public class EC_loaihang
    {
        private string maloaihang;
        private string tenloaihang;
        private string chitietloaihang;
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

        public string Tenloaihang
        {
            get
            {
                return tenloaihang;
            }

            set
            {
                tenloaihang = value;
            }
        }

        public string Chitietloaihang
        {
            get
            {
                return chitietloaihang;
            }

            set
            {
                chitietloaihang = value;
            }
        }
    }
}
