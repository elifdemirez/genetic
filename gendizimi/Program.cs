using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gendizimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac1 = 0;
            int sayac2 = 0;
           
            Random rnd = new Random();
            Random rnd2= new Random();

            int[] anne = new int[10];
            int[] baba= new int[10];
            int[] capraz= new int[10];
            int[] yapilan=new int[10];
            int[] mutasyon=new int[10];
            Console.WriteLine("Bir gen dizimi oluşturunuz: ");
            for(int i=0;i<yapilan.Length;i++) 
            {
                Console.Write((i+1)+". gen için 0 veya 1 sayısını giriniz: ");
                yapilan[i]=Convert.ToInt32(Console.ReadLine());
                while (yapilan[i] < 0 || yapilan[i]>1)
                {
                    Console.WriteLine((i+1)+". gen için 0 veya 1 sayısından birini giriniz.");
                    yapilan[i]=Convert.ToInt32((Console.ReadLine()));
                }
            }
            while(sayac1!=10)
            {
                for (int i = 0; i < mutasyon.Length; i++)
                {
                    anne[i] = rnd.Next(0, 2);
                    baba[i] = rnd.Next(0, 2);
                }
                Console.WriteLine();
                Console.WriteLine("Oluşturduğunuz gen dizimi:");
                foreach(int i in yapilan) 
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                Console.WriteLine("Annenin gen dizimi: ");
                foreach(int i in anne)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                Console.WriteLine("Babanın gen dizimi: ");
                foreach(int i in baba) 
                {
                    Console.Write(i);
                }

                for (int i = 0; i < 5; i++)
                {
                    capraz[i] = anne[i];
                }
                for (int i = 5; i < 10; i++)
                {
                    capraz[i] = baba[i];
                }
                Console.WriteLine();
                Console.Write("Çaprazlama sonucu oluşan gen dizimi:");
                foreach (int i in capraz)
                {
                    Console.Write(i);
                }
                int rastgele = rnd2.Next(0, 10);
                for (int i = 0; i < mutasyon.Length; i++)
                {
                    mutasyon[i] = capraz[i];

                    if (mutasyon[rastgele] == 0)
                    {
                        mutasyon[rastgele] = 1;
                    }
                    else
                    {
                        mutasyon[rastgele] = 0;
                    }
                }
                Console.WriteLine();
                Console.Write("Mutasyon sonucu oluşan gen dizimi:");
                foreach (int i in mutasyon)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                Console.Write("Yeni birey:");
                foreach (int i in mutasyon)
                {
                    Console.Write(i);
                }

                for (int i = 0; i < 10; i++)
                {
                    if (yapilan[i] == mutasyon[i])
                    {
                        sayac1++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Benzerlik oranı=%" + sayac1 * 10);
                sayac2++;
                if (sayac1 != 10)
                {
                    sayac1 = 0;
                }
                else if (sayac1 == 10)
                {
                    Console.WriteLine("İstenilen bireye {0}. denemede ulaştınız.", sayac2);
                    break;
                }
            }

            Console.ReadLine();

        

        }
    }
}
