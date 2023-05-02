using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Produkcja
{
    public class PrognozowanieParametru
    {

        public DateTime Prognozowanie(double[] x, DateTime[] y, double granica)
        {
            
            int dniDoSpadku = 0; 
            if (x.Length != y.Length || x.Length < 2)
            {
                //return dniDoSpadku=0;
            }

            double[] zmiany = new double[x.Length - 1];
            for (int i = 0; i < zmiany.Length; i++)
            {
                zmiany[i] = (x[i] - x[i + 1]) / x.Length;
            }

            double srednia = zmiany.Average();
            double spadekLiniowy = srednia * 10;


            double parametr = x[0];
            while (parametr > granica)
            {
                dniDoSpadku++;
                parametr -= spadekLiniowy;
            }
            DateTime dataprzekroczenia = y[y.Length - 1].AddDays(dniDoSpadku);
            return dataprzekroczenia;
        }

    }






}
