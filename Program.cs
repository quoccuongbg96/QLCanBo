using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanBo
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Giang Vien(1) hoac NV Hanh Chinh(2): ");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    GiangVien[] n = new GiangVien[10];
                    for (int i = 0; i < 2; i++)
                    {
                        n[i] = new GiangVien();
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Giang Vien thu: "+(i+1));
                        n[i].Nhap();                      
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        n[i] = new GiangVien();
                        n[i].Xuat();
                    }
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}
