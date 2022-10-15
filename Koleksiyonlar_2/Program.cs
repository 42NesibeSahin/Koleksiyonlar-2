using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();

            for (int i = 1; i <=20; i++)
            {
                Console.Write(i + ". sayiyi giriniz: ");
                bool num = int.TryParse(Console.ReadLine(), out int sayi);
                if (num)
                    liste.Add(sayi);
                else
                {
                    Console.WriteLine("Hatalı sayi girişi tekrar giriniz...");
                    i--;

                }
            }

            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);

            int toplamIlkUc = 0;
            int toplamSonUc = 0;

            for (int i = 0; i < 3; i++)
                toplamIlkUc += (int)liste[i];

            for (int i = 17; i <20; i++)
                toplamSonUc += (int)liste[i];

            Console.WriteLine("İlk üç: "+ toplamIlkUc+ " ortalaması: "+ toplamIlkUc/3);
            Console.WriteLine("Son üç: " + toplamSonUc+ " ortalaması: "+ toplamSonUc/3);
            Console.WriteLine("Ortalama toplamı :" + (toplamIlkUc + toplamSonUc) / 6);
            Console.ReadLine();
        }
    }
}
