// See https://aka.ms/new-console-template for more information

string adi = "Engin";
int yas = 21;

kurs kurs1 = new kurs();
kurs1.KursAdi = "C#";
kurs1.Eğitmen = "MUHAMMET TAHA ŞAT";
kurs1.IzlenmeOrani = 68;

kurs kurs2 = new kurs();
kurs2.KursAdi = "Java";
kurs2.Eğitmen = "Kerem varış";
kurs2.IzlenmeOrani = 64;


kurs kurs3 = new kurs();
kurs3.KursAdi = "python";
kurs3.Eğitmen = "Berkay";
kurs3.IzlenmeOrani = 80;

//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);

kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi  + " : " +  kurs.Eğitmen);
}


class kurs
{
    public string KursAdi { get; set; }
    public string Eğitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}
