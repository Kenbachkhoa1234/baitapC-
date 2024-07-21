using System;

namespace Bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mssv, hoten, xeploai;
            float  dtoan,dly,dhoa, dtb;
            Console.WriteLine("Nhap thong tin sinh vien: ");
            Console.Write("Nhap ma so sinh vien: ");
            mssv = Console.ReadLine();
            Console.Write("Nhap Ho va Ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            dtoan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            dly = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            dhoa = float.Parse(Console.ReadLine());
            dtb = ( dtoan + dly + dhoa)/3;
            if(dtb >= 8)
            xeploai = "Gioi";
            else if(dtb >= 6.5)
            xeploai = "Kha";
            else if(dtb >= 5)
            xeploai = "Trung Binh";
            else
            xeploai = "Kem";
            Console.WriteLine("Thong tin sinh vien la: Mssv:{0}, \n Hoten:{1}, \n toan:{2}, \n ly:{3}, \n hoa:{4}, \n Dtb:{5}, \n Xeploai:{6}",mssv , hoten, dtoan , dly ,dhoa , dtb , xeploai );
            Console.ReadLine();
        }
    }
}