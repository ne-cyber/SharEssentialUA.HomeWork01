using System;

namespace _03
{
    internal partial class Program
    {
        class Content
        {
            private string content;

            public string Value
            {
                private get
                {
                    if (this.content != null)
                        return this.content;
                    else
                        return "Вміст книги відсутній.";
                }
                set
                {
                    this.content = value;
                }
            }

            public void Show()
            {
                ConsoleColor cfc = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(this.Value);

                Console.ForegroundColor = cfc;
            }


        }
    }
}
