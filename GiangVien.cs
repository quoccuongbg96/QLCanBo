using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanBo
{
    class GiangVien : Nguoi
    {
        public enum TrinhDo
        {
            CuNhan, ThacSi, TienSi
        };
        public string khoa { get; set; }
        public float soTiet { get; set; }
        public TrinhDo trinhDo { get; set; }
        public GiangVien(string _hoTen, float _phuCap, float _heSoLuong, string _khoa, TrinhDo _tringDo, float _soTiet):base()
        {
            khoa = _khoa;
            trinhDo = _tringDo;
            soTiet = _soTiet;
        }
        public override void Luong(int _heSoLuong, int _phuCap, float _cong, int _heSo)
        {
            base.Luong(_heSoLuong, _phuCap, _cong = soTiet, _heSo = 45);
        }
    }
}
