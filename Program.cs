using System;

namespace ConsoleApp2
{
    class Program
    {
        struct ipADDR
        {
            public int a, b, c, d; // A.B.C.D aka 192.168.0.1
            public void PrintIP()
            {
                Console.WriteLine("{0}.{1}.{2}.{3}", a, b, c, d);
            }
        }
        static void Main(string[] args)
        {
            ipADDR myIP;
            Console.WriteLine("Введите IP-адрес");
            myIP.a = int.Parse(Console.ReadLine());
            myIP.b = int.Parse(Console.ReadLine());
            myIP.c = int.Parse(Console.ReadLine());
            myIP.d = int.Parse(Console.ReadLine());
            myIP.PrintIP();
        }
    }
}
