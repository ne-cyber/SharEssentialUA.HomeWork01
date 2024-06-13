using System;

namespace _03
{
    internal partial class Program
    {
        class Author
        {
            private string content;

            public string Value
            {
                private get
                {
                    if (this.content != null)
                        return this.content;
                    else
                        return "Автор книги не задан.";
                }
                set
                {
                    this.content = value;
                }
            }

            public void Show()
            {
                ConsoleColor cfc = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(this.Value);

                Console.ForegroundColor = cfc;
            }
        }
    }
}
