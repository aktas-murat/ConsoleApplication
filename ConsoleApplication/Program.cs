// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string sayi = "999";

bool sonuc=int.TryParse(sayi, out int outSayi);
if (sonuc)
{
    Console.WriteLine("Başarılı");
    Console.WriteLine(outSayi);


}

else
{
    Console.WriteLine("Başarısız");
}


Metotlar instance=new Metotlar();
instance.Topla(4, 5, out int toplamSonuc);
Console.WriteLine(toplamSonuc);

class Metotlar
{
    public void Topla(int a,int b,out int toplam)
    {
        toplam = a + b;
    }

}