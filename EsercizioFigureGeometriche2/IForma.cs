using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioFigureGeometriche2
{
    interface IForma
    {
        double Area(double Lato, double Altezza, double Raggio);
        double Perimetro(double Lato, double Altezza, double Raggio);
    }
}
