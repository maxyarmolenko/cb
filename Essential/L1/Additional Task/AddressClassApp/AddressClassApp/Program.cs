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
                Address information = new Address();

                information.SetIndex(03190);
                information.SetCountry("Ukraine");
                information.SetCity("Kyiv");
                information.SetStreet("Chernyahovskogo");
                information.SetHouse(24);
                information.SetApartment(158);

                int index = information.GetIndex();
                Console.WriteLine(index);  

                string country = information.GetCountry();
                Console.WriteLine(country);

                string city = information.GetCity();
                Console.WriteLine(city);

                string street = information.GetStreet();
                Console.WriteLine(street);

                int house = information.GetHouse();
                Console.WriteLine(house);

                int apartment = information.GetApartment();
                Console.WriteLine(apartment);

                Console.ReadKey();
            }
        }
    }
}
