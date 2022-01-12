using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Reptile : Animal //Пресмыкающееся
    {
        int mouthsize; //Размер пасти

        public int Mouthsize
        {
            get { return mouthsize; }
            set { if (value <= 0) throw new ArgumentException("Не верно задан размер пасти!"); mouthsize = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " Размер пасти: " + mouthsize + ";";
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Reptile p = (Reptile)obj;
                return (Name == p.Name) && (Numbers == p.Numbers) && (Сolor == p.Сolor) && (Lifespan == p.Lifespan) && (Mouthsize == p.Mouthsize);
            }
        }
    }
}
