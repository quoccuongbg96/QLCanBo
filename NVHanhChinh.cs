using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanBo
{
    class NVHanhChinh :Nguoi
    {
        public string phongBan { get; set; }
        public float ngayCong { get; set; }
        public ChucVu chucvu { get; set; }
        public enum ChucVu
        {
            TruongPhong, PhoPhong, NhanVien
        }
        public NVHanhChinh(string _hoTen, float _phuCap, float _heSoLuong, string _phongBan, float _soNgayCong, ChucVu _chucVu) :base()
        {

        }
        public NVHanhChinh()
        {

        }

        public override void Luong(float _heSoLuong, float _phuCap, float _cong, float _heSo)
        {
            base.Luong(_heSoLuong, _phuCap, _cong = ngayCong, _heSo = 30);
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Phong Ban: ");
            phongBan = Console.ReadLine();
            KTTringDo();
            Console.WriteLine("So Ngay Cong Trong Thang: ");
            ngayCong = int.Parse(Console.ReadLine());
        }
        public void KTTringDo()
        {
            Console.WriteLine("Tring Do: NhanVien(1), PhoPhong(2), TruongPhong(3)");
            int cke = int.Parse(Console.ReadLine());
            if (cke == 1)
            {
                chucvu = ChucVu.NhanVien;
            }
            else if (cke == 2)
            {
                chucvu = ChucVu.PhoPhong;
            }
            else if (cke == 3)
            {
                chucvu = ChucVu.TruongPhong;
            }
            else
            {
                Console.WriteLine("khong ton tai !!!");
            }
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Phong Ban: " + phongBan);
            Console.WriteLine("Chuc Vu: "+chucvu);
            Console.WriteLine("Ngay Cong: "+ngayCong);
        }
    }
}
