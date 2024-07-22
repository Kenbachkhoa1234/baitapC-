using System;
namespace Bt3
{
    class Bt3
    {
        static void Main(string[] args)
        {
            float c;
            Console.Write("Nhap so c: ");
            c = float.Parse( Console.ReadLine());
            if(c % 2 == 0)
            Console.WriteLine("{c} So Chan!");
            else
            Console.WriteLine("{c}So Le!");
        }
    }
}