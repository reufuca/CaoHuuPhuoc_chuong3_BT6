using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_baitap6
{
    class DsSinhVien
    {
        private int n;
        private sinhVien[] DS;

        public void Nhap()
        {
            Console.WriteLine("Hay nhap so sinh vien trong danh sach");
            n = Convert.ToInt32(Console.ReadLine());

            DS = new sinhVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hay nhap thong tin cho sinh vien thu {0} ",i + 1);
                DS[i] = new sinhVien();
                DS[i].Nhap();
            }
        }

        public void Xuat()
        {
            if (DS != null && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    DS[i].Xuat();
                }
            }
        }

        public void SapXep()
        {
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(DS[i].Masv, DS[j].Masv) > 0)
                    {
                        sinhVien tg = new sinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;
                    }
                }
        }
        public void XuatSVtren8()
        {
            Console.WriteLine("\nnhung sinh vien tren 8.0:");
            for (int i = 0; i < n; i++)
            {
                if (DS[i].DiemTB >= 8)
                {
                    Console.WriteLine("\nsinh vien {0} co diem trung binh tren 8", i + 1);

                }

            }
        }
    }
}
