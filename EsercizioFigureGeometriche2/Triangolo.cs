using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EsercizioFigureGeometriche2
{
    public class Triangolo : IForma
    {
        public int Lato;
        public int Altezza;


        public double Perimetro(double Lato, double Altezza, double Raggio)
         {
            double perimetro = Lato * 3;
            return perimetro;
         }
         public double Area(double Lato, double Altezza, double Raggio)
         {
            double area = (Lato * Altezza)/2;
            return area;
         }

    }
}