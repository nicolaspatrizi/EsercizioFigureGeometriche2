using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EsercizioFigureGeometriche2
{
    public class Quadrato : Rettangolo, IForma
    {
        

        public  double Perimetro(double Lato, double Altezza, double Raggio)
        {
            double perimetro = Lato * 4;
            return perimetro;
        }
        public double Area(double Lato, double Altezza, double Raggio)
        {
            double area = Lato * Lato;
            return area;
        }
    }
}