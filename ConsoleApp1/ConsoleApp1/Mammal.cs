using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Mammal : Animal //млекопетающее
    {
        int runningspeed;

        public int Runningspeed  //Скорость бега
        {
            get { return runningspeed; }
            set { if (value <= 0) throw new ArgumentException("Не верно задана скорость бега!"); runningspeed = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " Скорость бега: " + runningspeed+ ";";
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Mammal p = (Mammal)obj;
                return (Name == p.Name) && (Numbers == p.Numbers) && (Сolor == p.Сolor) && (Lifespan == p.Lifespan) && (Runningspeed == p.Runningspeed);
            }
        }
    }
}
