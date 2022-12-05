using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args) 
        {
            Customer c1= new Customer(); //Default constructor metot

            Customer c4= new Customer(); //Default constructor metot çalışır , daha sonradan değer atamaları yapılabilir #2
            c4.Id= 3;
            c4.FirstName = "Batuhan";
            c4.LastName = "Alpan";
            c4.City = "İzmir";

            Customer c2= new Customer { Id = 1, FirstName = "Batuhan", LastName = "Alpan", City = "Ankara"}; //Parametreli constructor metot

            Customer c3 = new Customer (2,"Umut","Alpan","İstanbul"); //Parametreli constructor metot #2
        }

        class Customer
        {
            public Customer() 
            {
                Console.WriteLine("Default yapınca bu constructor metot tanımlaması çalışır.");
            }

            public Customer(int id, string firstName, string lastName, string city)
            {
                Id= id;
                FirstName= firstName;   
                LastName= lastName; 
                City= city;
                Console.WriteLine("Parametreli olarak çağırınca bu constructor metot tanımlaması çalışır.");
            }

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }

        }
    }
}