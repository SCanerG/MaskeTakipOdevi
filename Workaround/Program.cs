//Degiskenler();

//Vatandaş vatandas1 = new Vatandaş();

using Businiess.Concrete;
using Entities.Concrete;

SelamVer("Caner");
SelamVer();

int sonuc =Topla();
int sonuc2 =Topla(1,5);

string ogrenci1 = "Sabri";
string ogrenci2 = "Caner";
string ogrenci3 = "Genco";

string[] ogrenciler = new string[3];
ogrenciler[0] = ogrenci1;
ogrenciler[1] = ogrenci2;
ogrenciler[2] = ogrenci3;
foreach (var ogrenci in ogrenciler)
{
    Console.WriteLine("Sırasıyla kayıtlı oğrenciler : " + ogrenci);

}

static void SelamVer(string name="isimsiz")
{
    Console.WriteLine("Selam Ver " + name);

}
static int Topla(int sayi1=3,int sayi2=10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam " + sonuc.ToString());
    return sonuc;
}
Person person1 = new Person();          //Person Manager için Person
person1.FirstName = "Sabri Caner";      //Person Manager için Person
person1.LastName = "Genco";             //Person Manager için Person
person1.DateOfBirthYear = 1999;         //Person Manager için Person
person1.NationalIdentity = 47803039790; //Person Manager için Person

Person person2 = new Person();          // Foreign Manager için Person 
person2.FirstName = "Sabri Caner";      // Foreign Manager için Person 
person2.LastName = "Genco";             // Foreign Manager için Person 
person2.DateOfBirthYear = 1999;         // Foreign Manager için Person 
person2.NationalIdentity = 47803039790; // Foreign Manager için Person 

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

PharmacyManager pharmacyManager= new PharmacyManager(new ForeignManager());
pharmacyManager.GiveMask(person2);

//static void Degiskenler()
//{
//    string mesaj = "Merhaba";
//    double tutar = 10000;
//    int sayi = 100;
//    bool girisYapmisMi = false;


//    string ad = "Sabri";
//    string soyAd = "Genco";
//    int dogumYili = 1999;
//    long tC = 12345678910;

//    Console.WriteLine(tutar * 1.18);

//    Console.ReadLine();
//}

//public class Vatandaş
//{
//    //public string ad = "Sabri";
//    //public string soyAd = "Genco";
//    //public int dogumYili = 1999;
//    //public long tC = 12345678910;

////pascal casing
//    public string Ad { get; set; }
//    public string SoyAd { get; set; }
//    public int DogumYili { get; set; }
//    public long TcNo { get; set; }

//}