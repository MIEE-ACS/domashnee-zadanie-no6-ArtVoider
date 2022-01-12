using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        string name;
        int numbers;
        string color;
        int lifespan;

        public string Name //Имя
        {
            get { return name; }
            set { if (string.IsNullOrEmpty(value)) throw new ArgumentException("Не верно задано имя!"); name = value; }
        }

        public int Numbers  //Численность
        {
            get { return numbers; }
            set { if (value <= 0) throw new ArgumentException("Не верно задана скорость бега!"); numbers = value; }
        }
        public string Сolor //цвет
        {
            get { return color; }
            set { if (string.IsNullOrEmpty(value)) throw new ArgumentException("Не верно задан цвет!"); color = value; }
        }
        public int Lifespan//Срок жизни
        {
            get { return lifespan; }
            set { if (value <= 0) throw new ArgumentException("Не верно задан срок жизни!"); lifespan = value; }
        }

        public override string ToString()
        {
            return name+" - Численность: " + numbers + "; Цвет: " + Сolor + "; Срок жизни: " + Lifespan + ";";
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Animal p = (Animal)obj;
                return (name == p.name) && (numbers == p.numbers) && (color == p.color) && (lifespan == p.lifespan);
            }
        }


    }
}
