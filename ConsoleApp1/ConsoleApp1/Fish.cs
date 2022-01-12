using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Fish : Animal //Рыба
    {
        int swimmingspeed;

        public int Swimmingspeed  //Скорость плавания
        {
            get { return swimmingspeed; }
            set { if (value <= 0) throw new ArgumentException("Не верно задана скорость плавания!"); swimmingspeed = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " Скорость полета: " + swimmingspeed + ";";
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Fish p = (Fish)obj;
                return (Name == p.Name) && (Numbers == p.Numbers) && (Сolor == p.Сolor) && (Lifespan == p.Lifespan) && (Swimmingspeed == p.Swimmingspeed);
            }
        }
    }
}