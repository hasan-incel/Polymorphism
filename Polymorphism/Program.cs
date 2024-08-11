
using Polymorphism;

// Kare nesnesi oluşturuluyor
GeometrikSekil kare = new Kare(5);
Console.WriteLine($"Kare'nin Alanı: {kare.AlanHesapla()}");

// Dikdörtgen nesnesi oluşturuluyor
GeometrikSekil dikdortgen = new Dikdortgen(5, 10);
Console.WriteLine($"Dikdörtgen'in Alanı: {dikdortgen.AlanHesapla()}");

// Dik Üçgen nesnesi oluşturuluyor
GeometrikSekil dikUcgen = new DikUcgen(5, 10);
Console.WriteLine($"Dik Üçgen'in Alanı: {dikUcgen.AlanHesapla()}");