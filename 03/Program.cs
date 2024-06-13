using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal partial class Program
    {



        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити клас Book. Створити класи Title, Author та Content,
        // кожен з яких повинен містити одне рядкове поле та метод void Show().
        // Реалізуйте можливість додавання до книги назви книги, імені автора та змісту.
        // Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.



        // Інкапсуляція варіацій, що приховує частини об'єктно орієнтованої системи.
        class Book
        {
            private Title title;
            private Author author;
            private Content content;

            public string Title
            {
                set
                {
                    this.title.Value = value;
                }
            }

            public string Author
            {
                set
                {
                    this.author.Value = value;
                }
            }

            public string Content
            {
                set
                {
                    this.content.Value = value;
                }
            }

            private void InitializeBook()
            {
                this.title = new Title();
                this.author = new Author();
                this.content = new Content();
            }

            public Book(string title)
            {
                InitializeBook();

                this.title.Value = title;
            }

            public void Show()
            {
                title.Show();
                author.Show();
                content.Show();
            }
        }



        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;


            Book book1 = new Book("Колобок");
            book1.Show();

            Console.WriteLine(new string('-', 30));

            Book book2 = new Book("Гобіт, або Туди і звідти");
            book2.Author = "Дж.Р.Р.Толкін";
            book2.Content = "Глава 1. Незваные гости\r\nВ норе под землей жил хоббит. Не в сырой и затхлой с дождевыми червями, не в голой песчаной, где не на что сесть и нечем подкрепиться; нора была хоббичья, а это означает уют.\r\n\r\nУ нее была круглая, как иллюминатор, дверь, выкрашенная в зеленый цвет, с блестящей медной ручкой точно посередине. Она открывалась в круглый туннель вроде железнодорожного, но, разумеется, без дыма, очень удобный, с деревянными стенами, плиткой и ковром на по...";
            book2.Show();

            Console.WriteLine(new string('-', 30));

            Console.ReadKey();

        }
    }
}
