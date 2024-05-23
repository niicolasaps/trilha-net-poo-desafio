using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando o Nokia:");
            Smartphone nokia = new Nokia("123456789", "Nokia 3310", "111111111111111", 16);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            Console.WriteLine("Testando o iPhone:");
            Smartphone iphone = new Iphone("987654321", "iPhone 12", "222222222222222", 64);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
