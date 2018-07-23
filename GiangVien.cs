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
        public GiangVien()
        {

        }
        public GiangVien(string _hoTen, float _phuCap, float _heSoLuong, string _khoa, TrinhDo _tringDo, float _soTiet):base()
        {
            khoa = _khoa;
            trinhDo = _tringDo;
            soTiet = _soTiet;
        }
        public override void Luong(float _heSoLuong, float _phuCap, float _cong, float _heSo)
        {
            base.Luong(_heSoLuong, _phuCap, _cong = soTiet, _heSo = 45);
        }
        public void KTTringDo()
        {
            Console.WriteLine("Tring Do: Cu Nhan(1), Thac Si(2), Tien Si(3)");
            int cke = int.Parse(Console.ReadLine());
            if (cke == 1)
            {
                trinhDo = TrinhDo.CuNhan;
            }
            else if (cke == 2)
            {
                trinhDo = TrinhDo.ThacSi;
            }
            else if (cke == 3)
            {
                trinhDo = TrinhDo.TienSi;
            }
            else
            {
                Console.WriteLine("khong ton tai !!!");
            }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Khoa: ");
            khoa = Console.ReadLine();
            KTTringDo();
            Console.WriteLine("So Tiet Day Trong Thang: ");
            soTiet = int.Parse(Console.ReadLine());      
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Khoa: "+khoa);
            Console.WriteLine("Tring Do: "+trinhDo);
            Console.WriteLine("So Tiet: "+soTiet);
        }
    }
}
