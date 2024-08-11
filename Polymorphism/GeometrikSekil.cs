using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Base sınıf
    public abstract class GeometrikSekil
    {
        // Propertyler
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        // Abstract methot
        public abstract double AlanHesapla();
    }
    
    //Kare sınıfı
    public class Kare : GeometrikSekil
    {
        public Kare(double kenar)
        {
            Genislik = kenar;
            Yukseklik = kenar;
        }

        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    // Dikdörtgen sınıfı
    public class Dikdortgen : GeometrikSekil
    {
        public Dikdortgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    // Diküçgen sınıfı
    public class DikUcgen : GeometrikSekil
    {
        public DikUcgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;
        }
    }
}
