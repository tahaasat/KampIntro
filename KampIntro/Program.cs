
string kategoriEtiketi = "Kategori";
Console.WriteLine(kategoriEtiketi);
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.45;
double dolarBugün = 7.45;

if (dolarDun>dolarBugün)
{
    Console.WriteLine("AZALIŞ OKU");
}
else if (dolarDun < dolarBugün)
{
    Console.WriteLine("ARTIŞ OKU");
}
else
{
    Console.WriteLine("DEĞİŞMEDİ OKU");
}


if (sistemeGirisYapmisMi == false)
{
    Console.WriteLine("Kullanıcı ayarı butonu");
}
else
{
    Console.WriteLine("Giriş Yap Butonu");
}
Console.WriteLine(kategoriEtiketi);



