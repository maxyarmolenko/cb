using System;

namespace AddressClassApp
{
    class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private int _house;
        private int _apartment;

        public void SetIndex(int value) 
        {
            _index = value;
        }

        public int GetIndex()           
        {
            return _index;
        }

          public void SetCountry(string value) 
        {
            _country = value;
        }

        public string GetCountry()          
        {
            return _country;
        }

        public void SetCity(string value)
        {
            _city = value;
        }

        public string GetCity()
        {
            return _city;
        }

        public void SetStreet(string value)
        {
            _street = value;
        }

        public string GetStreet()
        {
            return _street;
        }

        public void SetHouse(int value)
        {
            _house = value;
        }

        public int GetHouse()
        {
            return _house;
        }

        public void SetApartment(int value)
        {
            _apartment = value;
        }
        public int GetApartment()
        {
            return _apartment;
        }

        class Program
        {
            static void Main()
            {
                Address address = new Address();

                address.SetIndex(03190);
                int index = address.GetIndex();
                Console.WriteLine(index);

                address.SetCountry("Ukraine");
                string country = address.GetCountry();
                Console.WriteLine(country);

                address.SetCity("Kyiv");
                string city = address.GetCity();
                Console.WriteLine(city);

                address.SetStreet("Chernyahovskogo");
                string street = address.GetStreet();
                Console.WriteLine(street);

                address.SetHouse(24);
                int house = address.GetHouse();
                Console.WriteLine(house);

                address.SetApartment(158);
                int apartment = address.GetApartment();
                Console.WriteLine(apartment);

                Console.ReadKey();
            }
        }
    }
}
