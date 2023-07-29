using System;

namespace Patikadev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            Questions questions = new Questions();
            questions.QuestionFour();
        }
    }

    class Questions
    {
        public void QuestionOne()
        {
            Console.WriteLine("Kaç adet sayı olacak: ");
            int count = Convert.ToInt32(Console.ReadLine());
            List<int> sayilar = new List<int>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}. sayıyı girin: ", i + 1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);
            }

            Console.WriteLine("Çift olanlar;");
            foreach(int sayi in sayilar){
                if (sayi%2==0){
                    Console.WriteLine(sayi.ToString());
                }
            }
        }

        public void QuestionTwo()
        {
            Console.WriteLine("Kaç adet sayı olacak: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kontrol sayısını girin: ");
            int m = Convert.ToInt32(Console.ReadLine());

            List<int> sayilar = new List<int>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}. sayıyı girin: ", i + 1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);
            }

            foreach(int sayi in sayilar){
                if (sayi%m == 0)
                {
                    Console.WriteLine(sayi.ToString());
                }
            }
        }

        public void QuestionThree()
        {
            Console.WriteLine("Kaç adet kelime olacak: ");
            int count = Convert.ToInt32(Console.ReadLine());
            List<string> kelimeler = new List<string>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}. kelime girin: ", i + 1);
                string kelime = Console.ReadLine();
                kelimeler.Add(kelime);
            }

            kelimeler.Reverse();
            foreach(string kelime in kelimeler){
                Console.WriteLine(kelime);
            }
        }

        public void QuestionFour()
        {
            Console.WriteLine("Cümleniz: ");
            string cumle = Console.ReadLine().Trim();
            int harfSayisi = 0;
            int kelimeSayisi = 1;
            for (int i = 0; i < cumle.Length; i++)
            {
                char karakter = cumle[i];
                if (karakter == ' ')
                {
                    kelimeSayisi++;
                }else{
                    harfSayisi++;
                }
            }

            Console.WriteLine("Bu cümlede {0} adet harf ve {1} adet kelime bulunmakta",harfSayisi, kelimeSayisi);
        }
    }
}