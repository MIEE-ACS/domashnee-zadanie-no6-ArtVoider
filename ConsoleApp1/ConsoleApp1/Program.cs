using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            List<Animal> g = new List<Animal>();
            g.Add(new Iganna("Игуанна", 123, "Зеленый", 3, 3));
            g.Add(new Dog("Собака", 412, "Черный", 11, 12));
            g.Add(new Crow("Ворон", 232, "Черный", 240, 19));
            g.Add(new Shark("Акула", 99, "Белый", 55, 13));
            while (true)
            {
                try
                {
                    Console.WriteLine("1 - Добавить");
                    Console.WriteLine("2 - Удалить");
                    Console.WriteLine("3 - Вывести весь список");
                    Console.WriteLine("4 - Годы жизни болльше 5 лет");
                    Console.Write("Ваш выбор: ");
                    n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            {
                                Console.WriteLine("Добавление нового животного");
                                Console.WriteLine("1 - Птица");
                                Console.WriteLine("2 - Присыкающееся");
                                Console.WriteLine("3 - Млекопетающее");
                                Console.WriteLine("4 - Рыба");
                                Console.Write("Ваш выбор: ");
                                n = int.Parse(Console.ReadLine());
                                if (n >= 1 && n <= 4)
                                {
                                    Console.Write("Название: ");
                                    string t = Console.ReadLine();
                                    Console.Write("Численность: ");
                                    int u = int.Parse(Console.ReadLine());
                                    Console.Write("Цвет: ");
                                    string c = Console.ReadLine();
                                    Console.Write("Срок жизни: ");
                                    int v = int.Parse(Console.ReadLine());
                                    switch (n)
                                    {
                                        case 1:
                                            {
                                                Console.Write("Скорость полета: ");
                                                g.Add(new Crow(t, u, c, v, int.Parse(Console.ReadLine())));
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.Write("Рамер пасти: ");
                                                g.Add(new Iganna(t, u, c, v, int.Parse(Console.ReadLine())));
                                                break;
                                            }

                                        case 3:
                                            {
                                                Console.Write("Скорость бега: ");
                                                g.Add(new Dog(t, u, c, v, int.Parse(Console.ReadLine())));
                                                break;
                                            }
                                        case 4:
                                            {
                                                Console.Write("Скорость плавания: ");
                                                g.Add(new Shark(t, u, c, v, int.Parse(Console.ReadLine())));
                                                break;
                                            }
                                    }

                                }
                                break;
                            }
                            break;
                        case 2: { Console.Write("Введите номер: "); 
                                g.RemoveAt(int.Parse(Console.ReadLine())); 
                                break; }
                        case 3: { g = g.OrderBy(x => x.Numbers).ToList();
                                for (int i = 0; i < g.Count; i++) 
                                    Console.WriteLine(g[i].ToString());
                                break; }
                        case 4:
                            {
                                g = g.OrderBy(x => x.Lifespan).ToList();
                                for (int i = g.Count - 1; i > 0; i--)
                                Console.WriteLine(g[i].ToString());

                                break; }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
                Console.Clear();
            }

        }
    }

    class Dog : Mammal
    {
        public Dog(string Name, int Numbers, string Сolor, int Lifespan, int Runningspeed)
        {

            this.Name = Name;
            this.Numbers = Numbers;
            this.Сolor = Сolor;
            this.Lifespan = Lifespan;
            this.Runningspeed = Runningspeed;
        }
    }

    class Iganna : Reptile
    {
        public Iganna(string Name, int Numbers, string Сolor, int Lifespan, int Mouthsize)
        {
            this.Name = Name;
            this.Numbers = Numbers;
            this.Сolor = Сolor;
            this.Lifespan = Lifespan;
            this.Mouthsize = Mouthsize;
        }
    }

    class Crow : Bird
    {
        public Crow(string Name, int Numbers, string Сolor, int Lifespan, int Airspeed)
        {
            this.Name = Name;
            this.Numbers = Numbers;
            this.Сolor = Сolor;
            this.Lifespan = Lifespan;
            this.Airspeed = Airspeed;
        }
    }

    class Shark : Fish
    {
        public Shark(string Name, int Numbers, string Сolor, int Lifespan, int Swimmingspeed)
        {
            this.Name = Name;
            this.Numbers = Numbers;
            this.Сolor = Сolor;
            this.Lifespan = Lifespan;
            this.Swimmingspeed = Swimmingspeed;
        }
    }

}

