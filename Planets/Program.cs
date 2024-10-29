using Core.AppdbContext;
using Core.Helpers.Region;
using Core.Models;
using System.Net.Http.Headers;

namespace Planets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menyu1 = false; 
            bool menyu2 = false;
            bool menyu3 = false;
            bool menyu4 = false;    
            bool deyisen = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;   
                Console.WriteLine("-----------------------PLANETS AND COUNTRIES-------------------");
                Console.ForegroundColor= ConsoleColor.White;  
                Console.WriteLine("1.Sisteme giris\n0.CIXIS");
                int giris1;
                do
                {
                    deyisen = int.TryParse(Console.ReadLine(), out giris1);
                    if (deyisen == false)
                    {
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine("REQEM DAXIL EDIN !!!");
                        Console.ForegroundColor = ConsoleColor.White;   
                    }
                }while (!deyisen);
                switch (giris1)
                { 
                    case 0: menyu1 = true; break;
                      case 1:
                        Console.Beep();
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("1.PLANET\n2.COUNTRIES\n3.BACK");
                            int giris2;
                            deyisen = int.TryParse(Console.ReadLine(), out giris2);
                            if (deyisen == false)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("REQEM DAXIL EDIN !!!");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            switch (giris2) 
                            {
                                case 1:
                                    Console.Beep();
                                    Console.Clear();
                                    do
                                    {
                                        Console.WriteLine("----------Planet-------------");
                                        Console.WriteLine("1.Planet Yarat\n2.Planet Sil\n3.Planetleri goster\n4.BACK");
                                        int giris3;
                                        deyisen = int.TryParse(Console.ReadLine(), out giris3);
                                        if (deyisen == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("REQEM DAXIL EDIN !!!");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        switch (giris3)
                                        {
                                            case 4:
                                                Console.Beep();
                                                Console.Clear();
                                                menyu3 = true; break;
                                            case 1:
                                                Console.Beep();
                                                Console.Clear();
                                                Console.Write("Ad : ");
                                                string planetadi = Console.ReadLine();
                                                Console.Write("Erazi :");
                                                double planeterazisi;
                                                do
                                                {
                                                    deyisen = double.TryParse(Console.ReadLine(), out planeterazisi);
                                                    if (deyisen == false)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("REQEM DAXIL EDIN !!!");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                    }
                                                } while (!deyisen);
                                                Planet planet = new Planet(planetadi,planeterazisi);
                                                AppDbContext.CreatePlanet(planet);
                                                break;
                                                case 2:
                                                Console.Beep();
                                                AppDbContext.GetAllPlanets();
                                                Console.Write("Silmek istediyiniz planetin id : ");
                                                
                                                try
                                                {
                                                    int planetid;
                                                    do
                                                    {
                                                        deyisen = int.TryParse(Console.ReadLine(), out planetid);
                                                        if (deyisen == false)
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("REQEM DAXIL EDIN !!!");
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                        }
                                                    } while (!deyisen);
                                                    AppDbContext.RemovePlanet(planetid);
                                                }
                                                catch (System.NullReferenceException)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Movcud olke yoxdur!");
                                                    Console.ForegroundColor= ConsoleColor.White;
                                                }
                                                break;
                                                case 3:
                                                Console.Beep();
                                                AppDbContext.GetAllPlanets();
                                                break;
                                           


                                        }
                                        

                                    } while (!menyu3);

                                    break;

                                case 2:
                                    Console.Beep() ;
                                    Console.Clear();
                                    do
                                    {
                                        Console.WriteLine("------------Countries---------");
                                        Console.WriteLine("1.Olke Yarat\n2.Olkelere bax\n3.Olke sil\n4.Olke adi deyis\n5.Back");
                                        int giris4;
                                        deyisen = int.TryParse(Console.ReadLine(), out giris4);
                                        if (deyisen == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("REQEM DAXIL EDIN !!!");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        switch (giris4)
                                        {
                                            case 5:
                                                Console.Beep();
                                                Console.Clear();
                                                menyu4 = true; break;
                                            case 1:
                                                Console.Beep();
                                                Console.Clear();
                                                Console.Write("Olke adi : ");
                                                string olkeadi = Console.ReadLine();
                                                Console.Write("Olke erazisi : ");
                                                double olkerazisi;
                                                do
                                                {
                                                    deyisen = double.TryParse(Console.ReadLine(), out olkerazisi);
                                                    if (deyisen == false)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("REQEM DAXIL EDIN !!!");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                    }
                                                } while (!deyisen);
                                                Console.Write("Olke himni : ");
                                                string olkehimni= Console.ReadLine();   
                                                Country country = new Country(olkeadi,olkerazisi,olkehimni);
                                                Console.WriteLine("Region secin : 1.Avropa 2.Asiya 3.Amerika");
                                                Console.Write("Seciminiz : ");
                                                int olkeregion;
                                                deyisen = int.TryParse(Console.ReadLine(), out olkeregion);
                                                if (deyisen == false)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("REQEM DAXIL EDIN !!!");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                AppDbContext.CreateCountry(country);
                                                Region region = new Region();
                                                switch (olkeregion)
                                                {
                                                    case 1: region = Region.Avropa; break;
                                                    case 2: region = Region.Asiya; break;
                                                        case  3: region = Region.Amerika;break; 
                                                }
                                                country.Region = region.ToString();
                                                
                                                break;
                                            case 2:
                                                Console.Beep();

                                                AppDbContext.GetAllCountries();
                                                break;
                                                case 3:
                                                Console.Beep();
                                                AppDbContext.GetAllPlanets();
                                                Console.WriteLine("Silmek istediyiniz olkenin id : ");
                                                int olkeid;
                                                deyisen = int.TryParse(Console.ReadLine(), out olkeid);
                                                if (deyisen == false)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("REQEM DAXIL EDIN !!!");
                                                    Console.ForegroundColor = ConsoleColor.White;




                                                }
                                                AppDbContext.RemoveCountry(olkeid);

                                                break;
                                            case 4:
                                                Console.Beep();
                                                Console.Clear();
                                                AppDbContext.GetAllCountries();
                                                Console.Write("Adini deyismek istediyiniz olkenin id : ");
                                                int olkeid2;
                                                deyisen = int.TryParse(Console.ReadLine(), out olkeid2);
                                                if (deyisen == false)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("REQEM DAXIL EDIN !!!");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                Console.Write("Yeni ad : ");
                                                string yeniad = Console.ReadLine();
                                                AppDbContext.UpdateCountry(olkeid2, yeniad);
                                                break;







                                        }







                                    } while (!menyu4);
                                    break;

                                case 3:
                                    Console.Clear();
                                   menyu2 = true; break;   
                                
                                
                                
                            
                            
                            
                            }

                        } while (!menyu2);




                        break;

                }


            } while (!menyu1);
        }
    }
}
