using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanBo
{
   public class NVHanhChinh :Nguoi
    {
        public string phongBan { get; set; }
        public float ngayCong { get; set; }
        public enum chucvu
        {
            TruongPhong, PhoPhong, NhanVien
        }
        public NVHanhChinh():base()
        {

        }
        public NVHanhChinh(string _hoTen, float _phuCap, float _heSoLuong, string _phongBan, float _soNgayCong, chucvu _chucVu) :base()
        {

        }
        public override void Luong(int _heSoLuong, int _phuCap, float _cong, int _heSo)
        {
            base.Luong(_heSoLuong, _phuCap, _cong = ngayCong, _heSo=30);
        }
        public override void Nhap()
        {
            NVHanhChinh nv = new NVHanhChinh();
            base.Nhap();
            Console.WriteLine("Phong Ban");
            nv.phongBan = Console.ReadLine();
            Console.WriteLine("So Ngay Cong");
            nv.ngayCong =float.Parse(Console.ReadLine());
            Console.WriteLine("Chuc Vu: (1)TruongPhong, (2)PhoPhong, (3)NhanVien");
            int a = int.Parse(Console.ReadLine());
            if (a==1)
            {
               chucvu.NhanVien;
            }
        }
    }
}
