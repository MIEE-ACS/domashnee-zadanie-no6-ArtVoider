using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Bird : Animal //Птицы
    {
        int аirspeed;

        public int Airspeed  //Скорость полета
        {
            get { return аirspeed; }
            set { if (value <= 0) throw new ArgumentException("Не верно задана скорость полета!"); аirspeed = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " Скорость полета: " + аirspeed + ";";
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Bird p = (Bird)obj;
                return (Name == p.Name) && (Numbers == p.Numbers) && (Сolor == p.Сolor) && (Lifespan == p.Lifespan) && (Airspeed == p.Airspeed);
            }
        }
    }
}