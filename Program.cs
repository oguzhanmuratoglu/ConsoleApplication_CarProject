namespace CarProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            carApplication();
            Console.ReadLine();
        }

        static void carApplication()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car
            {
                Marka = "Mercedes - Benz",
                Model = "C180",
                ModelYili = 2016,
                Miktar = 3,
                Tip = "Sedan",
                KiralamaFiyatı = 1500,
                UygunlukDurumu = "2 Araç Kiralanmış, 1 Araç Garajda Mevcuttur."
            });
            cars.Add(new Car
            {
                Marka = "Fiat",
                Model = "Egea",
                ModelYili = 2014,
                Miktar = 6,
                Tip = "Sedan",
                KiralamaFiyatı = 800,
                UygunlukDurumu = "Bütün Araçlar Kiralanmıştır."
            });
            cars.Add(new Car
            {
                Marka = "Renault",
                Model = "Clio",
                ModelYili = 2020,
                Miktar = 4,
                Tip = "Hatchback",
                KiralamaFiyatı = 700,
                UygunlukDurumu = "2 Araç Kiralanmış, 2 Araç Garajda Mevcuttur."
            });
        tekrar:;
            Console.WriteLine("MURATOGLU CARS'A HOŞGELDİNİZ\nLütfen Size Hitap Edebilmem İçin Adınızı ve Soyadınızı Yazınız");
            string kullaniciAdi = Console.ReadLine();
            int deger =0;
            if (int.TryParse(kullaniciAdi, out deger))
            {
                Console.WriteLine("Lütfen sayısal değer kullanmayınız ve sadece adınızı ve soyadınızı yazınız!");
                Console.ReadLine();
                goto tekrar;
            }
            Console.WriteLine($"Sayın {kullaniciAdi} MURATOGLU CARS'A TEKRARDAN HOŞŞGELDİNİZ \n {kullaniciAdi} Sana Yardımcı Olabilmem İçin Lütfen Aşağıdaki Konu Başlıklarından Birini Seç");
            while (true)
            {
                Console.WriteLine("---------------MURATOGLU CARS---------------\nAraçları Görüntülemek İçin 1'e Basınız\nAraç Eklemek İçin 2'e Basınız\nAraç Kiralamak İçin 3'e Basınız\nÇıkış için 0'a Basınız");
                string degerString = Console.ReadLine();
                int degerInt = 0;
                if (int.TryParse(degerString, out degerInt) && degerInt==1)
                {
                
                    Console.WriteLine("---------------Araç Listesi---------------");
                    foreach (var item in cars)
                    {
                        Console.WriteLine($"Araç : {item.Marka} {item.Model}, Üretim Yılı : {item.ModelYili}, Miktar : {item.Miktar} Adet, Tip : {item.Tip},\n Günlük Kira Bedeli : {item.KiralamaFiyatı}TL  Uygunluk Durumu : {item.UygunlukDurumu}\n");
                    }
                tekrar2:;
                    Console.WriteLine("Üst Menüye Dönmek İçin 1'i, Çıkış Yapmak İçin 2'yi Tuşlayınız.");
                    string atamaString =Console.ReadLine();
                    int atamaInt = 0;
                    if (int.TryParse(atamaString, out atamaInt) && atamaInt ==1)
                    {
                        continue;
                    }
                    else if (int.TryParse(atamaString, out atamaInt) && atamaInt == 2)
                    {
                        Console.WriteLine("İşlem Sonlandırıldı. Kendinize İyi Bakın");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Beklenmedik Bir Hata Oluştu Lütfen Yazımı Kontrol Edip Tekrar Deneyiniz.");
                        goto tekrar2;
                    }
                }

                else if (int.TryParse(degerString, out degerInt) && degerInt == 2)
                {
                    Console.WriteLine("---------------Araç Ekleme---------------");
                    Console.WriteLine("Araç Ekleme Alanına Hoşgeldiniz\nLütfen Eklemek İstediğiniz Aracın Markasını Giriniz.");
                    string marka = Console.ReadLine();
                    Console.WriteLine("Lütfen Eklemek İstediğiniz Aracın Modelini Giriniz.");
                    string model = Console.ReadLine();
                    Console.WriteLine("Lütfen Eklemek İstediğiniz Aracın Üretim Yılını Giriniz.");
                    int modelYili = int.Parse(Console.ReadLine());
                    Console.WriteLine("Lütfen Eklemek İstediğiniz Aracın Miktarını Giriniz.");
                    int miktar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Lütfen Eklemek İstediğiniz Aracın Tipini Giriniz.(Sedan,PickUp,Hatchback)");
                    string tip = Console.ReadLine();
                    Console.WriteLine("Lütfen Eklemek İstediğiniz Aracın Günlük Kiralama Ücretini Giriniz");
                    int kiralamaFiyatı = int.Parse(Console.ReadLine());

                    cars.Add(new Car
                    {
                        Marka = marka,
                        Model = model,
                        ModelYili = modelYili,
                        Miktar = miktar,
                        Tip = tip,
                        KiralamaFiyatı = kiralamaFiyatı
                    });
                tekrar4:;
                    Console.WriteLine("Aracınız Başarıyla Eklenmiştir\nAraç Listesini Görüntülemek İçin 1'i \nÜst Menü İçin 2'yi\n Çıkış Yapmak İçin 0'ı Tuşlayınız");
                    string atamaString2 = Console.ReadLine();
                    int atamaInt2 = 0;

                    if (int.TryParse(atamaString2, out atamaInt2) && atamaInt2 == 1)
                    {
                        Console.WriteLine("---------------Araç Listesi---------------");
                        foreach (var item in cars)
                        {
                            Console.WriteLine($"Araç : {item.Marka} {item.Model}, Üretim Yılı : {item.ModelYili}, Miktar : {item.Miktar} Adet, Tip : {item.Tip},\n Günlük Kira Bedeli : {item.KiralamaFiyatı}TL  Uygunluk Durumu : {item.UygunlukDurumu}\n");
                        }
                    tekrar2:;
                        Console.WriteLine("Üst Menüye Dönmek İçin 1'i, Çıkış Yapmak İçin 2'yi Tuşlayınız.");
                        string atamaString = Console.ReadLine();
                        int atamaInt = 0;
                        if (int.TryParse(atamaString, out atamaInt) && atamaInt == 1)
                        {
                            continue;
                        }
                        else if (int.TryParse(atamaString, out atamaInt) && atamaInt == 2)
                        {
                            Console.WriteLine("İşlem Sonlandırıldı. Kendinize İyi Bakın");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Beklenmedik Bir Hata Oluştu Lütfen Yazımı Kontrol Edip Tekrar Deneyiniz.");
                            goto tekrar2;
                        }
                    }
                    else if (int.TryParse(atamaString2, out atamaInt2) && atamaInt2 == 2)
                    {
                        continue;
                    }
                    else if (int.TryParse(atamaString2, out atamaInt2) && atamaInt2 == 0)
                    {
                        Console.WriteLine("İşlem Sonlandırıldı. Kendinize İyi Bakın");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Beklenmedik Bir Hata Oluştu Lütfen YAzımı Kontrol Edip Tekrar Deneyiniz.");
                        goto tekrar4;
                    }
                }

                else if (int.TryParse(degerString, out degerInt) && degerInt == 3)
                {
                    Console.WriteLine("---------------Araç Kiralama---------------");
                    for (int i = 0; i < cars.Count; i++)
                    {
                        Console.WriteLine($"{i+1} - {cars[i].Marka} {cars[i].Model} - Günlük Kiralama Fiyatı : {cars[i].KiralamaFiyatı}");
                    }
                    Console.WriteLine("Araç Kiralama Alanına Hoş Gelidniz \nLütfen Yukarıdaki Araçlardan Hangisini Kiralamak İstiyorsanız Yanındaki Numarayı Tuşlayınız.");
                    int markaModel = int.Parse(Console.ReadLine());
                    string markaModelString = $"{cars[markaModel - 1].Marka} {cars[markaModel - 1].Model}";
                    Console.WriteLine("Kiralama Tarihini Girin : ÖRNEK(22/08/2023)");
                    string kiralamaTarihi = Console.ReadLine();
                    Console.WriteLine("Kiralama Saatini Girin : ÖRNEK(14.00)");
                    string kiralamaSaai = Console.ReadLine();
                    Console.WriteLine("Teslim Tarihini Girin : ÖRNEK(25/08/2023)");
                    string teslimTarihi = Console.ReadLine();
                    Console.WriteLine("Teslim Saatini Girin : ÖRNEK(14.00)");
                    string teslimSaai = Console.ReadLine();

                    int gün = kiraMasrafiHesaplama(kiralamaTarihi, teslimTarihi);
                    int kiraBedeli = cars[markaModel - 1].KiralamaFiyatı * gün;

                    Console.WriteLine("---------------Kiralama Bilgileri---------------");
                    Console.WriteLine($"Sayın {kullaniciAdi}, {markaModelString} aracı {kiralamaTarihi} tarihi {kiralamaSaai} satti ile {teslimTarihi} tarihi {teslimSaai} saati \narasında adınıza kiralanmak için işlem başlatılacaktır\nİşlem Tutarı : {kiraBedeli}TL'dir. \nİşlemi Onaylamak İçin 1'i Çıkış Yapmak İçin 0'ı Tuşlayınız.");
                    int son = int.Parse(Console.ReadLine());

                    if (son == 1)
                    {
                        Console.WriteLine("İşlem Başarıyla Onaylanmıştır. \nAraca İyi Bakın Sakın Kaza Falan Yapmayın Uslu Uslu Gidip Gelin Lütfen");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("İşlem Sonlandırıldı. Kendinize İyi Bakın");
                        break;
                    }

                }

                else if (int.TryParse(degerString, out degerInt) && degerInt == 0)
                {
                    Console.WriteLine("İşlem Sonlandırıldı. Kendinize İyi Bakın");
                    break;
                }
                else
                {
                    Console.WriteLine("Beklenmedik Bir Hata Oluştu Lütfen YAzımı Kontrol Edip Tekrar Deneyiniz.");
                    continue;
                }
                

            }

            static int kiraMasrafiHesaplama(string deger1, string deger2)
            {
                List<char> chr1 = new List<char>(deger1);
                List<char> chr2 = new List<char>(deger2);

                int value1 = Convert.ToInt32(chr2[1]);
                int value2 = Convert.ToInt32(chr1[1]);

                int result = value1 - value2;
                return result;
            }
        }
    }
}