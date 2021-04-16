using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EsercizioFigureGeometriche2
{
    public class Rettangolo : IForma
    {
        public int Altezza;
        public int Lato;

        public   double Perimetro(double Lato, double Altezza, double Raggio)
          {
            double perimetro = (Lato * 2)+(Altezza * 2);
            return perimetro;
          }
          public double Area(double Lato, double Altezza, double Raggio)
          {
            double area = Lato * Altezza;
            return area;
          }
    }
}