namespace _04
{
    internal partial class Program
    {



        //Клас Point повинен містити два цілих поля і одне рядкове поле.
        //Створити три властивості одним методом доступу get.
        //Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів.



        class Point
        {
            private int x;
            private int y;
            private string name;

            

            public int X
            {
                get
                {
                    return this.x;
                }
            }

            public int Y
            {
                get
                {
                    return this.y;
                }                
            }

            public string Name 
            { 
                get
                {
                    return this.name;
                }
            }


            public Point(int x, int y, string name = "точка")
            {
                this.x = x;
                this.y = y;
                this.name = name;
            }
        }
    }
}
