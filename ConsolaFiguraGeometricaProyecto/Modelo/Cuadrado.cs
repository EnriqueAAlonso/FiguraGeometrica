using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaFiguraGeometricaProyecto.Interface;

namespace ConsolaFiguraGeometricaProyecto.Modelo
{
    class Cuadrado: IFiguraGeometrica
    {
        private float lado;
        private string Nombre="Cuadrado";
        public Cuadrado(float l)
        {
            lado = l;
        }

        public float CalcularArea()
        {
            return lado * lado;

        }

        public float CalcularPerimetro()
        {
            return lado * 4;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }
    }
}
