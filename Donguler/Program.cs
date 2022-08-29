// See https://aka.ms/new-console-template for more information


string[] kurslar = new string[] {"YAZILIM GELİŞTİRİCİ YETİŞTİRME KURSU", "REACT","error trainig",
 "PROGRAMLAMAYA BAŞLANGIÇ İÇİN TEMEL KURS",
"JAVA", "python" };


for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}


foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("SAYFA SONU - FOOTER");