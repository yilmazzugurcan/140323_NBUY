using System;
using System.Globalization;

namespace _140323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ad ve Unvan Yazdırma
            /*gel:
                Kisi kisi = new Kisi();
                kisi.BilgiAl();
                kisi.BilgileriYazdir();
                goto gel;*/
            #endregion

            #region Kisi ve Cinsiyet Yazdırma
            /* gel:
                 Kisi kisi = new Kisi();
                 kisi.BilgiAl();
                 kisi.BilgileriYazdir();
                 goto gel;*/

            #endregion

            #region Kisi ve Cinsiyet Yazdırma 2
            /*  cins kisi = new cins("osman", "erkek");
                kisi.yaz();*/
            #endregion

            #region Kisi ve Cinsiyet Yazdırma Ugur Hoca
            /*kisi kisi1 = new kisi();
            kisi1.ad = "uğur";
            kisi1.soyad = "dam";
            kisi1.Cinsiyet = "erkek";

            kisi kisi2 = new kisi();
            kisi2.soyad = "yuh";
            kisi2.ad = "osman";
            kisi2.Cinsiyet = "erkek";

            kisi kisi3 = new kisi();
            kisi3.ad = "leyla";
            kisi3.soyad = "kasabacı";
            kisi3.Cinsiyet = "kadın";

            Console.WriteLine(kisi1.Cinsiyet + " " + kisi1.ad + " " + kisi1.soyad);
            Console.WriteLine(kisi2.Cinsiyet + " " + kisi2.ad + " " + kisi2.soyad);
            Console.WriteLine(kisi3.Cinsiyet + " " + kisi3.ad + " " + kisi3.soyad); */
            #endregion

            #region Elektronik Alet Tanımlama Get - Set içerisinde yazdırma
            /*  urun urun1 = new urun();
                urun1.elektronik = "kahve makinesi";
                urun urun2 = new urun();
                urun2.elektronik = "koltuk takımı";

                Console.WriteLine(urun1.elektronik);
                Console.WriteLine(urun2.elektronik);*/
            #endregion

            #region Encapsulation ile dikdörtgen alanı çözme. Boy veya en 0 girilirse hata verir.
            /* dortgen d = new dortgen();
             Console.WriteLine("Boy gir");
             d.Boy = int.Parse(Console.ReadLine());
             Console.WriteLine("En gir");
             d.En = int.Parse(Console.ReadLine());

             Console.WriteLine("Alan:" + "" + d.alan()); */
            #endregion

        }

        #region Ad ve Unvan Yazdırma. Unvan prof değil ise null değer alma.
        /* class Kisi
         {
             public string Ad { get; set; }
             public string Unvan { get; set; }

             public void UnvanBelirle(string ad, string unvan)
             {
                 if (unvan.ToLower() == "prof")
                 {
                     Ad = ad;
                     Unvan = unvan;
                 }
                 else
                 {
                     Ad = ad;
                     Unvan = null;
                 }
             }
             public void BilgiAl()
             {
                 Console.Write("Lütfen adınızı girin: ");
                 string ad = Console.ReadLine();
                 Console.Write("Lütfen unvanınızı girin: ");
                 string unvan = Console.ReadLine();
                 UnvanBelirle(ad, unvan);
             }
             public void BilgileriYazdir()
             {
                 if (Ad != null && Unvan != null)
                 {
                     Console.WriteLine("Ad: {0}, Unvan: {1}", Ad, Unvan);
                 }
                 else
                 {
                     Console.WriteLine("Bilgiler geçersiz veya eksik.");
                 }
             } */
        #endregion

        #region Kisi ve Cinsiyet Yazdırma
        /* class Kisi
         {
             public string Ad { get; set; }
             public string Cinsiyet { get; set; }

             public void UnvanBelirle(string ad, string cinsiyet)
             {
                 if (cinsiyet.ToLower() == "erkek")
                 {
                     Ad = ad;
                     Cinsiyet = cinsiyet;
                 }
                 else
                 {
                     Ad = ad;
                     Cinsiyet = null;
                 }
             }
             public void BilgiAl()
             {
                 Console.Write("Lütfen adınızı girin: ");
                 string ad = Console.ReadLine();
                 Console.Write("Lütfen cinsiyet girin: ");
                 string cinsiyet = Console.ReadLine();
                 UnvanBelirle(ad, cinsiyet);
             }
             public void BilgileriYazdir()
             {
                 if (Ad != null && Cinsiyet != null)
                 {
                     Console.WriteLine("Ad: {0}, Cinsiyet: {1}", Ad, Cinsiyet);
                 }
                 else
                 {
                     Console.WriteLine("Bilgiler geçersiz veya eksik.");
                 }
             } */
        #endregion

        #region kisi ve cinsiyet2
        /* class cins
         {
             private string name;
             private string gender;

             public cins(string name, string gender)
             {
                 this.name = name;
                 this.gender = gender;
             }

             public string Name
             {
                 get { return name; }
                 set { name = value; }
             }

             public string Gender
             {
                 get { return gender; }
                 set { gender = value; }
             }

             public void yaz()
             {
                 Console.WriteLine("Name: " + name);
                 Console.WriteLine("Gender: " + gender);
             } */
        #endregion

        #region Kisi ve Cinsiyet Ugur Hoca get-set metotlu
        /*  class kisi
          {
              public string ad { get; set; }
              public string soyad { get; set; }


              private string cins;

              public string Cinsiyet
              {

                  get
                  {
                      if (cins == "ERKEK")
                      {
                          return "Beyfendi " + cins;
                      }
                      else
                      {
                          return "Hanımefendi " + cins;
                      }
                  }
                  set
                  {
                      cins = value.ToUpper();
                  }
              }



          }*/


        #endregion

        #region Elektronik Alet Tanımlama Get - Set İçerisine Yazdırma
        /*   public class urun
           {
               private string elek;
               public string elektronik
               {
                   get
                   {
                       if (elek == "kahve makinesi")
                       {
                           return "Elektronik Urun " + elek;
                       }
                       else
                       {
                           return "Elektronik Urun Degil " + elek;
                       }
                   }
                   set
                   {
                       elek = value;
                   }
               }
           }*/

        #endregion

        #region Encapsulation ile dikdörtgen alanı çözme. Boy veya en 0 girilirse hata verir.
        /* class dortgen
         {
             private int boy;

             public int Boy
             {
                 get
                 {
                     return boy;
                 }
                 set
                 {
                     if (value <= 0)
                     {
                         Console.WriteLine("Hatalı Giriş Yapıldı.Boy 0 veya 0'dan küçük olamaz.");

                     }
                     else
                     {
                         boy = value;
                     }
                 }
             }
             private int en;


             public int En
             {
                 get
                 {
                     return en;
                 }
                 set
                 {
                     if (value <= 0)
                     {
                         Console.WriteLine("Hatalı Giriş Yapıldı.En 0 veya 0'dan küçük olamaz");

                     }
                     else
                     {
                         en = value;
                     }

                 }
             }

             public int alan()
             {
                 int sonuc = 0;
                 sonuc = en * boy;
                 return sonuc;
             }

         } */
        #endregion

    }
}




