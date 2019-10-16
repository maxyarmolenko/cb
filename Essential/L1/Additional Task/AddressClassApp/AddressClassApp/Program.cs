using System;

namespace AddressClassApp
{
    class Address
    {
        public int Index { set; get; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Street { get; set; }

        public int House { set; get; }

        public int Apartment { set; get; }

        class Program
        {
            static void Main()
            {
                Address information = new Address();
                {
                   information.Index = 03190;
                   information.City = "Kyiv";
                   information.Country = "Ukraine";
                   information.Street = "Chernyahovskogo";
                   information.House = 58;
                   information.Apartment = 72;
                }
                Console.WriteLine("Index: {0}", information.Index);
                Console.WriteLine("City: {0}", information.City);
                Console.WriteLine("Country: {0}", information.Country);
                Console.WriteLine("Street: {0}", information.Street);
                Console.WriteLine("House: {0}",information.House);
                Console.WriteLine("Apartment: {0}",information.Apartment);
                Console.ReadKey();
            }
        }
    }
}
