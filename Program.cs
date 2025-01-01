// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





Calisan calisan1 = new Calisan();
calisan1.Ad = "str";
calisan1.Soyad = "STR";
calisan1.No = 1232323;
calisan1.Departman = "s";
calisan1.CalisanBilgileri();

Calisan calisan2 = new Calisan();
calisan2.Ad = "str2";
calisan2.Soyad = "STR2";
calisan2.No = 9878787;
calisan2.Departman = "s2";
calisan2.CalisanBilgileri();


//Console.ReadLine();


class Calisan
{

    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adı:{0}", Ad);
        Console.WriteLine("Calisan Soyadı:{0}", Soyad);
        Console.WriteLine("Calisan Numarası:{0}", No);
        Console.WriteLine("Calisan Departmanı:{0}", Departman);

    }


}