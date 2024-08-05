using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {



        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити клас із ім'ям Address.
        // У тілі класу потрібно створити поля: index, country, city, street, house, apartment.
        // Для кожного поля створити властивість з двома методами доступу. Створити екземпляр класу Address.
        // У поля екземпляра записати інформацію про поштову адресу. Виведіть на екран значення полів, що описують адресу.



        class Address
        {
            private string index;
            private string country;
            private string city;
            private string street;
            private string house;
            private string apartment;

            public string Index
            {
                get { return index; }
                set { index = value; }
            }

            public string Country
            {
                get { return country; }
                set { country = value; }
            }

            public string City
            {
                get { return city; }
                set { city = value; }
            }

            public string Street
            {
                get { return street; }
                set { street = value; }
            }

            public string House
            {
                get { return house; }
                set { house = value; }
            }

            public string Apartment
            {
                get { return apartment; }
                set { apartment = value; }
            }

            public void Show()
            {
                if(Index != null)
                    Console.Write($"індекс: {Index}, ");
                if (Country != null)
                    Console.Write($"країна: {Country}, ");
                if (City != null)
                    Console.Write($"м.{City}, ");
                if (Street != null)
                    Console.Write($"вул.{Street}, ");
                if (House != null)
                    Console.Write($"д.{House} ");
                if (Apartment != null)
                    Console.Write($"кв.{Apartment}");

                Console.WriteLine();

            }

        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Address address1 = new Address();
            address1.Index = "123456";
            address1.Country = "Україна";
            address1.City = "Одеса";
            address1.Street = "Дерібасівська";
            address1.House = "1a";
            address1.Apartment = "12";
            address1.Show();
            Console.WriteLine(new string('-', 60));

            Address address2 = new Address();
            //address2.Index = "123456";
            //address2.Country = "Україна";
            address2.City = "Одеса";
            address2.Street = "Дерібасівська";
            address2.House = "1a";
            //address2.Apartment = "12";
            address2.Show();

            Console.WriteLine(new string('-', 60));

            Console.ReadKey();

        }
    }
}
