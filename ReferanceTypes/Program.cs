using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean gibi sayısal veri türleri değer tiptir
            int sayi1 = 10;
            int sayi2 = 20;

            sayi2 = sayi1;
            sayi1 = 100;
            Console.WriteLine("Sayi 2 : " + sayi2);

            //array, class, interface... reference types
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("sayilar1 in 1. elemanı : " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Sait";
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine("person2 nin firstname : " + person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";
            Employee employee = new Employee();

            //customer = employee;   //bunların ikisi de farklı veri türleri oldukları için birbiri yerine tanımlama veya eşitleme yapmam söz konusu olamaz
            //aynı int ve string veriler gibi
            Person person3 = customer; //customer ve employee classları person class'ından inherit ettikleri için aynı zamanda bir person olarak
                                       //tanımlamama herhangi bir sıkıntı çıkarmıyor
            Console.WriteLine("person3 ün firstname : " + person3.FirstName);
            Console.WriteLine("person3 e (customer) boxing uygulanırsa creditCardNumber a erişiriz: " + ((Customer)person3).CreditCardNumber); // BOXİNG uyguladık
            //boxing demek şablonunu Customer da belirlediğimiz bir hal almasını sağladı çünkü zaten person classı customer classının base classıdır.
            //boxing yaparken kabul edilebilir türlerde uygulanmalıdır.

        }
    }
    //Person base class'dır
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
}