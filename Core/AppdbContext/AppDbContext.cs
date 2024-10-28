using Core.Helpers.Region;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.AppdbContext
{
    public static class AppDbContext
    {
        static List<Country> Countries = new List<Country>();
        static List<Planet> Planets = new List<Planet>();

        static public void CreateCountry(Country country)
        {
            Countries.Add(country);
        }
        static public void UpdateCountry(int id , string name )
        {
            for (int i = 0; i < Countries.Count; i++)
            {

                if (Countries[i].CountryID == id)
                {
                    Countries[i].CountryName = name;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Countries[i].CountryID + "-li olkenin adi deyisdirildi !");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }

        }
        static public void RemoveCountry(int id )
        {
            
            Country country = Countries.Find(x=> x.CountryID==id);
           
            Countries.Remove(country); 
            Console.ForegroundColor = ConsoleColor.Red;
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("muveffeqiyetle silindi");
            Console.ForegroundColor = ConsoleColor.White;    
            
        }
        static public void GetAllCountries()
        {
           for (int i = 0;i < Countries.Count;i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"-----------------*COUNTRY*[{Countries[i].CountryID}]-----------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{Countries[i].CountryID}.{Countries[i].CountryName}-{Countries[i].Area}km*km");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-----------------*ANTHEM*------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Countries[i].Anthem);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine($"-----------------*COUNTRY*[{country.CountryID}]-----------------------");
                //Console.ForegroundColor = ConsoleColor.White;
                //Console.WriteLine($"{country.CountryID}.{country.CountryName}-{country.Area}km*km");
                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("-----------------*ANTHEM*------------------------");
                //Console.ForegroundColor = ConsoleColor.White;
                //Console.WriteLine(country.Anthem);
                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("-------------------------------------------------");
                //Console.ForegroundColor = ConsoleColor.White;
            
        }
        static public void GetCountryByRegion(Region region)
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                if (region.ToString() == Countries[i].Region)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{Countries[i].CountryID}.{Countries[i].CountryName}-{Countries[i].Area}km*km");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        static  public void CreatePlanet(Planet planet)
        {
            Planets.Add(planet);
        }
        static  public void UpdatePlanet(int id, string name)
        {
            for    (int i = 0;i < Planets.Count;i++)
            {

                if (Planets[i].ID == id)
                {
                    Planets[i].Name = name; 
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Planets[i].ID+"-li Planetin adi deyisdirildi !");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }    
            }
           
        }
        static public  void RemovePlanet(int id)
        {
            Planet planet = Planets.Find(x => x.ID == id);
            string ad = planet.Name;
            Planets.Remove(planet);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ad);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("muveffeqiyetle silindi");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static public void GetAllPlanets()
        {
           for (int i = 0; i < Planets.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Planets[i].ID}.Planet:{Planets[i].Name} Erazi:{Planets[i].Area}km");
                Console.ForegroundColor = ConsoleColor.White;
            }     

        }

    }
}
