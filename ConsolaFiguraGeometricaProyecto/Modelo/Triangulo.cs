using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaFiguraGeometricaProyecto.Interface;
namespace ConsolaFiguraGeometricaProyecto.Modelo
{
    class Triangulo:IFiguraGeometrica
    {
        private float _base, _altura;
        private string name="Triangulo";

        public float CalcularArea()
        {
            return _base*_altura/2;
        }
        public float CalcularPerimetro()
        {
            return _base*3;
        }
        public string ObtenerNombre()
        {
            return name;
        }

        public Triangulo(float b, float a)
        {
            _base = b;
            _altura = a;
        }
    }
}
