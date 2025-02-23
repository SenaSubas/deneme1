// clas kullanımı bu yazıya sonradan bak
Kurs kurs1 = new Kurs(); // clasa bir değişken olusturmak için 2
kurs1.KursAdi = "C#"; /// degiskenlere özellik değeri karsılığı atamak için bu
kurs1.egitmen = "Engin Demiroğ";
kurs1.izlemeOrani = 68;
//artık kurs1 in var ve tipi Kurs
Kurs kurs2=new Kurs();
kurs2.KursAdi = "Javascript";
kurs2.egitmen = "Sena Subaş";
kurs2.izlemeOrani = 100;
Kurs kurs3 = new Kurs();
kurs3.KursAdi = "css";
kurs3.egitmen = "Kerem Bilginer";
kurs3.izlemeOrani = 70;
// ekrana yazdirmasi böyle STATİK OLRAK
//Console.WriteLine(kurs2.KursAdi + " : " + kurs2.egitmen);
//Console.WriteLine(kurs3.KursAdi + ":" + kurs3.egitmen);

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
         //tam alttaki veri tipi kurs 
foreach (Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + ":" + kurs.egitmen + ":" + kurs.izlemeOrani);
}

public class Kurs  // bir clas olusturmak için bu 1
{
    public string KursAdi { get; set; }
    public string egitmen { get; set; }
    public int izlemeOrani { get; set; }
   
}
// kurs bir değişken TÜRÜDÜR string bir değişken türüyse kurs da bir değişken türüdür. kendi veri tipini oluşturuyoomuş gibi düşün
// propa intelliesence yapınca  public int MyProperty { get; set; } bunu gosteriyor property ozellik demek biz bir clas oluşturduk ismi kurs.
// bu classın özelliklerini propla oluşturuyoruz

