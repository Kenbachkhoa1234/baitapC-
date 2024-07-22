using System;

namespace TinhTong
{
    class Tong2SoNguyen
    {
        static void Main(string[] args)
        {
            int num1 , num2, sum;
            Console.Write("Nhap so a: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("Tong cua 2 so nguyen la: \n so thu nhat:{0}\n so thu hai:{1} \n sum:{2}",num1 , num2, sum);
            Console.ReadLine();

        }
    }
}