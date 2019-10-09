using System;
namespace AddressClassApp
{
    class Adress
    {
        public int index;
        public string country;
        public string city;
        public string street;
        public int house;
        public int apartment;
        public void SetIndex(int value) 
        {
            index = value;
        }

        public int GetIndex(int v)         
        {
            return index;
        }

        public void SetCountry(string value)
        {
            country = value;
        }

        public string GetCountry()
        {
            return country;
        }
        public void SetCity(string value)
        {
            city = value;
        }

        public string GetCity()
        {
            return city;
        }
        public void SetStreet(string value)
        {
            street = value;
        }

        public string GetStreet()
        {
            return street;
        }
        public void SetHouse(int value) 
        {
            house = value;
        }

        public int GetHouse()           
        {
            return house;
        }

        public void SetApartment(int value) 
        {
            index = value;
        }

        public int GetApartment()           
        {
            return apartment;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Adress addr = new Adress();

            addr.index = 03190;
            Console.WriteLine(addr.index);

            addr.country = "Ukraine";
            Console.WriteLine(addr.country);

            addr.city = "Kyiv";
            Console.WriteLine(addr.city);

            addr.street = "Chernyahovskogo";
            Console.WriteLine(addr.street);

            addr.house = 14;
            Console.WriteLine(addr.house);

            addr.apartment = 54;
            Console.WriteLine(addr.apartment);

            Console.ReadKey();
        }
    }
}
