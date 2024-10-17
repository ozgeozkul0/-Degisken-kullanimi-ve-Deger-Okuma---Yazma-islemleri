// See https://aka.ms/new-console-template for more information


//iki sayinin farkini bulan c# kodu 
Console.WriteLine("1. sayiyi giriniz:");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. sayiyi giriniz:");
int sayi2 = Convert.ToInt32(Console.ReadLine());
int sonuc = sayi1 - sayi2;
Console.WriteLine("sonuc:" + sonuc);


// 5 sayisinin karesini bulan c# kadu
int sayi = 5;
int kare = sayi * sayi;
Console.WriteLine("5 sayisinin karesini:" + kare);

// 10 sayisinin 3'e bolumundan kalanı bulan c# kodu
int sayi3 = 10;
int kalan = 10 % 3;
Console.WriteLine("10'un 3'e bolumunden kalan:" + kalan);

//Klavyeden girilen 4 sayinin taplamini ve carpimini bulan c# kodu 
Console.WriteLine("1. sayiyi giriniz:");
int sayi_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. sayiyi giriniz:");
int sayi_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. sayiyi giriniz:");
int sayi_3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("4. sayiyi giriniz:");
int sayi_4 = Convert.ToInt32(Console.ReadLine());
int toplam = sayi_1 + sayi_2 + sayi_3 + sayi_4;
int carpim = sayi_1 * sayi_2 * sayi_3 * sayi_4;
Console.WriteLine("sayilarin toplami: " + toplam);
Console.WriteLine("sayilarin carpimi:" + carpim);

Console.WriteLine("1. sayiyi gir:");
int sayi_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. sayiyi gir:");
int sayi_b = Convert.ToInt32(Console.ReadLine());
if (sayi_b != 0)
{
    int bolum = sayi_a / sayi_b;
    Console.WriteLine("bolumu: " + bolum);
}
else
{
    Console.WriteLine("bir sayi sifira bolunemez");
}

//Klavyeden kenarları girilen dikdörtgenler prizmasının hacmini hesaplayan   c# kodu
Console.WriteLine("dikdortgenin uzunlugunu giriniz:");
int uzunluk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("dikdortgenin tüksekligini giriniz:");
int h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("dikdortgenin genisligini giriniz:");
int genislik = Convert.ToInt32(Console.ReadLine());
int hacim = uzunluk * h * genislik;
Console.WriteLine("dikdortgenin hacmi: " + hacim);