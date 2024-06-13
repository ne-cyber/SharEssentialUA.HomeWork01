using System;

namespace _03
{
    internal partial class Program
    {
        class Title
        {
            string content;

            public string Value
            {
                private get
                {
                    if (this.content != null)
                        return this.content;
                    else
                        return "Заголовок книги відсутній.";
                }
                set
                {
                    this.content = value;
                }
            }

            public void Show()
            {
                ConsoleColor cfc = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(this.Value);

                Console.ForegroundColor = cfc;

            }
        }
    }
}
