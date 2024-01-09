//UYGULAMA : BANKAMATİK

//Menu, bakiye, para yatırma, para çekme, çıkış
string secim="";
double bakiye=0;
double ekhesap=1000;
double ekhesaplimiti = 1000;

do
{
    

Console.Write("1-Bakiye Görüntüle\n2-Para Yatırma\n3-Para Çek\n4-Çıkış\nSeçiminiz: ");
secim = Console.ReadLine();
switch (secim)
{
    case "1":
    Console.WriteLine("Bakiyeniz {0} TL", bakiye);
    Console.WriteLine("Ek hesap bakiyeniz {0}", ekhesap);
        break;
    case "2":
    Console.Write("Yatırmak istediğiniz miktar: ");
    double yatirilan = double.Parse(Console.ReadLine());

    if(ekhesap<ekhesaplimiti)
    {
        double ekhesaptankullanilan = ekhesaplimiti - ekhesap;
        if(yatirilan>=ekhesaptankullanilan)
        {
            ekhesap=ekhesaplimiti;
            bakiye = yatirilan - ekhesaptankullanilan;
        }

        else
        {
            ekhesap+= yatirilan;
        }
        
    }

    else
    {

    bakiye+=yatirilan;
        
    }
        break;
    case "3":
    Console.Write("Çekmek istediğiniz miktar: ");
    double cekilecekmiktar = double.Parse(Console.ReadLine());
    if(cekilecekmiktar>bakiye)
    {
        double toplam = bakiye + ekhesap;
        if(toplam>=cekilecekmiktar)
        {
            Console.WriteLine("Ek hesap kullanılsın mı? (e/h)");
            string ekhesaptercihi = Console.ReadLine();

            if(ekhesaptercihi=="e")
            {
                Console.WriteLine("Paranızı alabilirsiniz.");
                ekhesap -=(cekilecekmiktar-bakiye);
                bakiye =0;
            }
            else
            {
                Console.WriteLine("Bakiyeniz yetersiz.");
            }
        }


    }
        else
        {
                Console.WriteLine("Paranızı alabilirsiniz.");
                 bakiye-=cekilecekmiktar;
        }
        break;
    case "4":
    Console.WriteLine("Çıkış");
        break;
    default:
    Console.WriteLine("Hatalı Seçim");
        break;
}

} while (secim!="4");

Console.WriteLine("Uygulamadan çıkıldı.");
