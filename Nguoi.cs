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
        public void PhuCap(GiangVien.TrinhDo trinhDo, NVHanhChinh.ChucVu chucVu)
        {
            if (trinhDo == GiangVien.TrinhDo.CuNhan)
            {
                phuCap = 300;
            }
            else if (trinhDo == GiangVien.TrinhDo.ThacSi || chucVu == NVHanhChinh.ChucVu.NhanVien)
            {
                phuCap = 500;
            }
            else if (trinhDo == GiangVien.TrinhDo.TienSi || chucVu == NVHanhChinh.ChucVu.NhanVien)
            {
                phuCap = 1000;
            }
            else if (chucVu == NVHanhChinh.ChucVu.TruongPhong)
            {
                 phuCap = 2000;
            }
        }
        public virtual void Luong(int _heSoLuong, int _phuCap,float _cong, int _heSo)
        {
            float luong = _heSoLuong * 730 + _phuCap + _cong * _heSo;
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("He So Luong: ");
            heSoLuong = float.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ho Ten: "+hoTen);
            Console.WriteLine("Phu Cap: " + phuCap);
            Console.WriteLine("He So Luong: " + heSoLuong);
            Console.WriteLine("Luong: " + luong);
        }
    }
}
