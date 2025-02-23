//dongulerin tekrari
// donguleri c# birbirine benzeyen işlermleri tekrar etmek için kullanırız
// birer birier arttırmak için i++ ikişker arttırmak için i=i+2


// dizi array örneği yapalım
// mesela bir kurstaki başlıklı elemanlar yazılırken onları sıralamak için tek bir string değil birden fazla stringi bir arada tutmak için
// degiskenin türünün string olmasını istiyorsan string değil string[] yani string ve array olması lazım array=[]
// tek bir veri tutulacaksa string=sfefas birden fazlaysa string[]
string[] kurslar = new string[] {"java","pyhton","c","angular","html","css" };


for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("sayfa sonuna ulastiniz");






string[] cookies = new string[] {"white chocholate","mnm","dark chocholate","milk chocholate","not sugar" };
for (int i = 0; i < 4; i++)
{
    Console.WriteLine(cookies[i]);
}

string[] dizi = new string[] {"aski memnu","k,raz mevsimi","poyraz karayel" };
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(dizi[i]);
}


// foreach dizi temelli yapıları tek tek dönmeye yarar. dizilere uygulanır
//alttaki kurslar = kursları dolaş. kurslardan kastım yukarıdaki olusturduğum ve elemanları olan kurslar
// ininci eleman yazmaya gerek yok herbirkus takma eleman
foreach (string herbirkurs in kurslar)
{
    Console.WriteLine(herbirkurs); 
}

foreach (var kurabiye in cookies)
{
    Console.WriteLine(kurabiye);
}

foreach (var kurss in kurslar)
{
    Console.WriteLine(kurss);
}




string[] Mobilya = new string[] {"baza","baza başlığı","komodin","makyaj masası","gardırop","oturma pufu" };
foreach (string esyaismi in Mobilya)
{
    Console.WriteLine(esyaismi);
}
Console.WriteLine("ürünlerimiz listede gördündüğü kadardır.");