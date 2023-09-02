namespace YEMEK_SİPARİŞ_HESABİ_PROJESİ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double adet;
            double toplam = 0;
            double hesap = 0;
            double alinanpara, paraustu;

            Console.WriteLine("*****************************YEMEK SİPARİŞ MENÜSÜ************************************");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("**                                  **                                             **");
            Console.WriteLine("**      YİYECEKLER     * FİYATLAR   **         YİYECEKLER       *  FİYATLAR        **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("**                     *            **                          *                  **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("**      1-ET DÖNER     *  85TL      **         9-SU            *    5TL            **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("**      2-TAVUK DÖNER  *  75TL      **         10-TENEKE KOLA   *    20TL          **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("**      3-ÇORBALAR     *  15TL      **         11-AYRAN         *    10TL          **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("**      4-SALATALAR    *  18TL      **         12-ŞALGAM SUYU   *    15TL          **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("**      5-PİLAV        *  45TL      **         13-TENEKE FANTA  *    20TL          **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("**      6-KURU FASULYE *  60TL      **         14-SODA          *    10TL          **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("**      7-GÜVEÇ        *  80TL      **         15-ÇAY           *     5TL          **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("**      8-PİDE         *  75TL      **         16-MEYVE SUYU    *     18TL         **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("*************************************************************************************");

            for (int i = 0; i < 100; i++)
            {

                Console.WriteLine("Sipariş vermek için sipariş numarasını girin lütfen");
                double secim = Convert.ToDouble(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("kaç porsiyon Et Döner istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 85;
                        hesap = hesap + toplam;
                        break;
                    case 2:
                        Console.WriteLine("kaç porsiyon Tavuk Döner istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 75;
                        hesap = hesap + toplam;
                        break;
                    case 3:
                        Console.WriteLine("kaç Tabak çorba istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 15;
                        hesap = hesap + toplam;
                        break;
                    case 4:
                        Console.WriteLine("kaç Tabak salata Döner istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 18;
                        hesap = hesap + toplam;
                        break;
                    case 5:
                        Console.WriteLine("kaç porsiyon pilav istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 45;
                        hesap = hesap + toplam;
                        break;
                    case 6:
                        Console.WriteLine("kaç Tabak kuru fasulye istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 60;
                        hesap = hesap + toplam;
                        break;
                    case 7:
                        Console.WriteLine("kaç porsiyon güveç istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 80;
                        hesap = hesap + toplam;
                        break;
                    case 8:
                        Console.WriteLine("kaç porsiyon pide istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 75;
                        hesap = hesap + toplam;
                        break;
                    case 9:
                        Console.WriteLine("kaç tane su istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 5;
                        hesap = hesap + toplam;
                        break;
                    case 10:
                        Console.WriteLine("kaç teneke kola istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 20;
                        hesap = hesap + toplam;
                        break;
                    case 11:
                        Console.WriteLine("kaç ayran istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 10;
                        hesap = hesap + toplam;
                        break;
                    case 12:
                        Console.WriteLine("kaç şalgam suyu istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 15;
                        hesap = hesap + toplam;
                        break;
                    case 13:
                        Console.WriteLine("kaç teneke fanta istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 20;
                        hesap = hesap + toplam;
                        break;
                    case 14:
                        Console.WriteLine("kaç tane soda istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 10;
                        hesap = hesap + toplam;
                        break;
                    case 15:
                        Console.WriteLine("kaç bardak çay istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 5;
                        hesap = hesap + toplam;
                        break;
                    case 16:
                        Console.WriteLine("kaç adet meyve suyu istersiniz:");
                        adet = Convert.ToInt32(Console.ReadLine());
                        toplam = adet * 18;
                        hesap = hesap + toplam;
                        break;
                    default:
                        Console.WriteLine("Menüde böyle bir ürün seçimi yoktur \n lütfen menüde yer alan ürünlerini seçiniz.");
                        break;
                       

                }
                
                Console.WriteLine("Başka bir isteğiniz var mı?");
                string cevap = Console.ReadLine();
                if (cevap == "h" || cevap == "H" || cevap == "Hayır" || cevap == "hayır" || cevap == "HAYIR")
                    break;

            }
            Console.WriteLine("Siparişinizin  toplam tutarı:" + hesap);
            Console.WriteLine("Alınan para:");
            alinanpara = Convert.ToDouble(Console.ReadLine());
            if(alinanpara>hesap)
            {
                paraustu = alinanpara - hesap;
                Console.WriteLine("müşteriye verilen para üstü:" + paraustu +"tl dir");
            }
            else if(hesap>alinanpara)
            {
                Console.WriteLine("verdiğiniz para sipariş edilen hesap tutarından azdır lütfen hesap tutarı kadar ödeme yapınız.");
            }
          

           
            Console.ReadKey();


        }
    }
}