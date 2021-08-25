using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            kurs kurs1 = new kurs();
            kurs1.kursadi = " C#";
            kurs1.egitmen = "kbö";
            kurs1.izlenmeorani = 79;


            kurs kurs2 = new kurs();
            kurs2.kursadi = "java";
            kurs2.egitmen = "kbö";
            kurs2.izlenmeorani = 70;


            kurs kurs3 = new kurs();
            kurs3.kursadi = " phyton";
            kurs3.egitmen = "kbö";
            kurs3.izlenmeorani = 50 ;

            //Console.WriteLine(kurs1.kursadi + " " + kurs1.izlenmeorani);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursadi+kurs.egitmen+kurs.izlenmeorani);

            }










       
        }




    }
    class kurs
    {
        public string kursadi { get; set; }
        public string egitmen { get; set; }

        public int izlenmeorani { get; set; }

    }

}
