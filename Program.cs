using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanBo
{
   public class Program
    {
        public void nhap()
        {
            GiangVien a = new GiangVien();
            Console.WriteLine("Ho Ten: ");
            a.hoTen = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập Giảng Viên(1) hoặc NV hành chính(2): ");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":

                    break;
            }
        }
    }
}
