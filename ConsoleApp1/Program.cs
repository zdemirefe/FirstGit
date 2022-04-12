using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Efe Baba";
            kurs1.TamamlamaYuzdesi = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Fevi Baba";
            kurs2.TamamlamaYuzdesi = 35;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Anil Baba";
            kurs3.TamamlamaYuzdesi = 4;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (Kurs item in kurslar) 
            {
                Console.WriteLine(item.KursAdi + " " + item.Egitmen + " " + item.TamamlamaYuzdesi);
            }

        }

    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int TamamlamaYuzdesi { get; set; }

    }


}    

