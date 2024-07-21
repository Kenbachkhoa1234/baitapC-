using System;

namespace bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mssv,hoten,xl;
            float dtb, toan , van , anh ;
            Console.WriteLine("Nhap Thong tin sinh vien: ");
            Console.Write("Nhap ma so sinh vien: ");
            mssv = Console.ReadLine();
            Console.Write("Nhap ho va ten: ");
            hoten= Console.ReadLine();
            Console.Write("Nhap diem Toan: ");
            toan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Van: ");
            van = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Anh: ");
            anh = float.Parse(Console.ReadLine());
            dtb = (toan+ van + anh )/3;
            if(dtb >= 8)
            xl = "Gioi";
            else if(dtb >=6.5)
            xl = "Kha";
            else if(dtb >= 5)
            xl = "Trung Binh";
            else
            xl = "kem";
            Console.WriteLine("Thong tin sinh vien: \nMSSV: {0} \nHo Ten: {1} \nDiem toan: {2} \nDiem van : {3} \nDiem anh: {4} \nDiem trung binh: {5} \nXep Loai: {6}", mssv, hoten, toan, van , anh , dtb, xl );
            Console.ReadLine();
            
        }
    }
}