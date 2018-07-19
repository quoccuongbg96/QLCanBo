using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanBo
{
    class Nguoi
    {
        public string hoTen { get; set; }
        public float phuCap { get; set; }
        public float heSoLuong { get; set; }
        public float luong { get; set; }
        public Nguoi()
        {

        }
        public Nguoi(string _hoTen, float _phuCap, float _heSoLuong)
        {
            hoTen = _hoTen;
            phuCap = _phuCap;
            heSoLuong = _heSoLuong;
        }
        public virtual void Luong(int _heSoLuong, int _phuCap,float _cong, int _heSo)
        {
            
        }

    }
}
