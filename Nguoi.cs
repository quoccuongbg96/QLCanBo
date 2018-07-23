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
        public static string TachChuoi(string chuoi)
        {
            string ten;
            string[] arrTen = chuoi.Split(' ');
            if (arrTen.Length >= 2)
            {
                ten = arrTen[arrTen.Length - 1];
                return ten;
            }
            return "khong co gia tri";
        }
        public Nguoi(string _hoTen, float _phuCap, float _heSoLuong)
        {
            hoTen = _hoTen;
            phuCap = _phuCap;
            heSoLuong = _heSoLuong;
        }
        public void PhuCap()
        {
            var trinhDo = new GiangVien.TrinhDo();
            var chucVu = new NVHanhChinh.ChucVu();
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
        public virtual void Luong(float _heSoLuong, float _phuCap,float _cong, float _heSo)
        {
            heSoLuong = _heSoLuong;
            phuCap = _phuCap;
            luong = _heSoLuong * 730 + _phuCap + _cong * _heSo;
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
