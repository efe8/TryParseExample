using System;
using System.Xml.Schema;

namespace TryParse_örnekleri
{
    internal class Program
    {
        static void Main()
        {
            SayiAl("Sayı giriniz: ");

        }
        static int SayiAl(string mesaj)
        {
            int sayi;

            while (true)
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out sayi))
                {
                    return sayi;
                }

                Console.WriteLine("Hatalı giriş yapıldı.");

            }
        }

    }
}




    

