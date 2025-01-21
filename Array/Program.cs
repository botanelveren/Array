using System;

namespace DiziIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10]; // 10 elemanlı bir tam sayı dizisi oluşturduk

            // For döngüsü ile diziyi doldurma
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Foreach döngüsü ile diziyi ekrana yazdırma
            Console.WriteLine("Girilen sayılar:");
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            // Yeni bir dizi oluşturup eski dizinin elemanlarını kopyala
            int[] yeniDizi = new int[sayilar.Length + 1];
            Array.Copy(sayilar, yeniDizi, sayilar.Length);

            // Yeni eleman ekleme
            Console.Write("Eklenecek sayıyı giriniz: ");
            int yeniSayi = Convert.ToInt32(Console.ReadLine());
            yeniDizi[yeniDizi.Length - 1] = yeniSayi;

            sayilar = yeniDizi; // eski diziyi yeni dizi ile değiştir

            // Diziyi sıralama (Büyükten küçüğe)
            Array.Sort(sayilar);
            Array.Reverse(sayilar);

            // Sırlanmış diziyi ekrana yazdırma
            Console.WriteLine("Sıralama (Büyükten Küçüğe):");
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}