using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console002
{
    class Program
    {
        static void Main()
        {
            MultiBuilding dom_ = new MultiBuilding("Adress", 5, 3, 6, 2); //создание объекта производного класса с данными для конструктора, конструктор необязателен
            //MultiBuilding dom_ = new MultiBuilding(3);
            dom_.AB = "Adres Sity.Con.ZIP"; // обращение к полю класса
            dom_.Print();//вызов метода 
            Console.ReadKey();
        }

        class Building
        {
            public string AB { get; set; }
            public int LB { get; set; }
            public int WB { get; set; }
            public int HB { get; set; }

            public Building(string a, int l, int w, int h) //конструктор данных (базового класса), может не принимать значений, обьявлять нужные значения по умолчанию
            {
                AB = a;
                LB = l;
                WB = w;
                HB = h;
            }
            
            /*public Building() //конструктор данных (базового класса), не принимает значений, обьявляет нужные значения по умолчанию
            {
                AB = "Adres Sity.Con.ZIP";
                LB = 7;
                WB = 2;
                HB = 6;
            }
            */

            public void Print()
            {
                Console.Write("Адрес здания: {0}, Длинна: {1}, Ширина: {2}, Высота: {3}", AB, LB, WB, HB); 
            }

        }
        sealed /* sealed <- запрет наследования от этого класса*/class MultiBuilding : Building
        {
            public int FB { get; set; }
            public MultiBuilding(string a, int l, int w, int h, int f) : base(a, l, w, h) //конструктор производного класса :base (обращение к конструктору базового класса)
                {
                        FB = f;
                }
            
            /*
            public MultiBuilding(int f)  //конструктор производного класса с добавленным полем, значения остальных полей наследуется 
            {
                FB = f;
            }
            */
            new/*new <- убирает конфликт одноименных методов наследования*/ public void Print()
            {
                
                base.Print(); // обращение к методу базового класса внутри производного класса
                Console.Write(", Этажей: {0}",FB);
            }
        }
    }
}
