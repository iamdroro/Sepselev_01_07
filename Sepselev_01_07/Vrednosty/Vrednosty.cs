using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sepselev_01_07.Vrednosty;

namespace Sepselev_01_07.Vrednosty
{
    public class Vrednosty:QalityObject
    {
        public string TF { get; set; }
        public Vrednosty(string atype,int akolvo, double adiametr, string tF):base(atype,akolvo,adiametr)
        {
            TF = tF;
        }

        public override double CalculateInfo()
        {
            double OBJ = base.CalculateInfo();
            if (TF == "true")
            {
              return  OBJ = 2.1 * OBJ;
            }
            else if (TF == "false")
            {
               return  OBJ = 0.7 * OBJ;
            }
            else
            {
                Console.WriteLine("Допущена ошибка ввода, можно только true или false");
            }
            return CalculateInfo();
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Наличие оплетки = " + TF);
            Console.WriteLine("Qp = " + CalculateInfo());
        }
    }
}
