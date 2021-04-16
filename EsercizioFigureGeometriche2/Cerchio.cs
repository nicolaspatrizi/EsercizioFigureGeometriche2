using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EsercizioFigureGeometriche2
{
    class Esempio
    {
       
    }

    public class Cerchio : IForma
    {
        public int Raggio;

       public double Perimetro(double Lato, double Altezza, double Raggio)
        {
            double perimetro = (2 * Raggio) * 3.14;
            return perimetro;
        }
       public double Area(double Lato, double Altezza, double Raggio)
        {
            double area = 3.14 * Math.Pow(Raggio,2);
            return area;
        }
        
    }
}