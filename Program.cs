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
                    Console.WriteLine("So can bo can nhap: ");
                    int soGV = int.Parse(Console.ReadLine());
                    GiangVien[] n = new GiangVien[soGV];
                    for (int i = 0; i < soGV; i++)
                    {
                        n[i] = new GiangVien();
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Giang Vien thu: "+(i+1));
                        n[i].Nhap();                      
                    }
                    for (int i = 0; i < soGV; i++)
                    {
                        Console.WriteLine("----------Thong---Tin-------------");
                        Console.WriteLine("------------Can---bo------------");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Giang Vien Thu: "+(1+i));
                        n[i].Xuat();
                    }
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("So can bo can nhap: ");
                    int soNV = int.Parse(Console.ReadLine());
                    NVHanhChinh[] m = new NVHanhChinh[soNV];
                    for (int i = 0; i < soNV; i++)
                    {
                        m[i] = new NVHanhChinh();
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("NV Hanh Chinh thu: " + (1+i));
                        m[i].Nhap();
                    }
                    for (int i = 0; i < soNV; i++)
                    {
                        Console.WriteLine("----------Thong---Tin-------------");
                        Console.WriteLine("------------Can---bo------------");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("NV Hanh Chinh Thu: " + (i+1));
                        m[i].Xuat();
                    }
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}
