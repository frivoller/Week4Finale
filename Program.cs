using System;

// base class
abstract class BaseMakine
{
    public string UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string IsletimSistemi { get; set; }

    public BaseMakine(string seriNumarasi, string ad, string aciklama, string isletimSistemi)
    {
        UretimTarihi = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        SeriNumarasi = seriNumarasi;
        Ad = ad;
        Aciklama = aciklama;
        IsletimSistemi = isletimSistemi;
    }

    // polymorphism
    public virtual void BilgileriYazdir()
    {
        Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
        Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
        Console.WriteLine($"Ad: {Ad}");
        Console.WriteLine($"Açıklama: {Aciklama}");
        Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
    }

    // abstract method
    public abstract void UrunAdiGetir();
}

// derived class
class Telefon : BaseMakine
{
    public bool TrLisansliMi { get; set; }

    public Telefon(string seriNumarasi, string ad, string aciklama, string isletimSistemi, bool trLisansliMi)
        : base(seriNumarasi, ad, aciklama, isletimSistemi)
    {
        TrLisansliMi = trLisansliMi;
    }

    // polymorphism
    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"TR Lisanslı: {TrLisansliMi}");
    }

    // abstraction
    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
    }
}

// derived class
class Bilgisayar : BaseMakine
{
    private int usbGirisSayisi;
    public bool BluetoothVarMi { get; set; }

    // encapsulation
    public int UsbGirisSayisi
    {
        get { return usbGirisSayisi; }
        set
        {
            if (value == 2 || value == 4)
                usbGirisSayisi = value;
            else
            {
                Console.WriteLine("USB Giriş Sayısı 2 veya 4 olmalıdır, -1 atanıyor.");
                usbGirisSayisi = -1;
            }
        }
    }

    public Bilgisayar(string seriNumarasi, string ad, string aciklama, string isletimSistemi, int usbGirisSayisi, bool bluetoothVarMi)
        : base(seriNumarasi, ad, aciklama, isletimSistemi)
    {
        UsbGirisSayisi = usbGirisSayisi;
        BluetoothVarMi = bluetoothVarMi;
    }

    // polymorphism
    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
        Console.WriteLine($"Bluetooth Var Mı: {BluetoothVarMi}");
    }

    // abstraction
    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
    }
}

// main program
class Program
{
    static void Main(string[] args)
    {
        bool devamMi = true;
        while (devamMi)
        {
            Console.WriteLine("Telefon üretmek için 1, bilgisayar üretmek için 2'ye basınız.");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                // telefon uretimi
                Console.Write("Seri Numarası: ");
                string seriNumarasi = Console.ReadLine();
                Console.Write("Ad: ");
                string ad = Console.ReadLine();
                Console.Write("Açıklama: ");
                string aciklama = Console.ReadLine();
                Console.Write("İşletim Sistemi: ");
                string isletimSistemi = Console.ReadLine();
                Console.Write("TR Lisanslı mı (true/false): ");
                bool trLisansliMi = Convert.ToBoolean(Console.ReadLine());

                Telefon telefon = new Telefon(seriNumarasi, ad, aciklama, isletimSistemi, trLisansliMi);
                telefon.BilgileriYazdir();
                telefon.UrunAdiGetir();
            }
            else if (secim == 2)
            {
                // bilgisayar uretimi
                Console.Write("Seri Numarası: ");
                string seriNumarasi = Console.ReadLine();
                Console.Write("Ad: ");
                string ad = Console.ReadLine();
                Console.Write("Açıklama: ");
                string aciklama = Console.ReadLine();
                Console.Write("İşletim Sistemi: ");
                string isletimSistemi = Console.ReadLine();
                Console.Write("USB Giriş Sayısı (2/4): ");
                int usbGirisSayisi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bluetooth Var mı (true/false): ");
                bool bluetoothVarMi = Convert.ToBoolean(Console.ReadLine());

                Bilgisayar bilgisayar = new Bilgisayar(seriNumarasi, ad, aciklama, isletimSistemi, usbGirisSayisi, bluetoothVarMi);
                bilgisayar.BilgileriYazdir();
                bilgisayar.UrunAdiGetir();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
            }

            Console.WriteLine("Başka bir ürün üretmek istiyor musunuz? (evet/hayir)");
            string cevap = Console.ReadLine().ToLower();
            if (cevap != "evet")
            {
                devamMi = false;
                Console.WriteLine("İyi günler!");
            }
        }
    }
}
