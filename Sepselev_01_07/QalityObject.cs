using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepselev_01_07
{
    public class QalityObject
    {
        public string Type { get; set; }
        public int Kolvo { get; set; }
        public double Diametr { get; set; }
        public QalityObject(string type, int kolvo, double diametr)
        {
            Type = type;
            Kolvo = kolvo;
            Diametr = diametr;
        }
        public virtual double CalculateInfo()
        {
            return Diametr / Kolvo;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Тип = " + Type);
            Console.WriteLine("Количество жил = " + Kolvo);
            Console.WriteLine("Диаметр кабеля = " + Diametr);
            Console.WriteLine("Q = " + CalculateInfo());
        }
    }
}
