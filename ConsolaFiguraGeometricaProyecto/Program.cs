using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaFiguraGeometricaProyecto.Interface;

namespace ConsolaFiguraGeometricaProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void mostrarInformacion(IFiguraGeometrica figura)
        {
            Console.WriteLine($"Nombre :{figura.ObtenerNombre()}");
            Console.WriteLine($"Area :{figura.CalcularArea()}");
            Console.WriteLine($"Perimetro :{figura.CalcularPerimetro()}");
        }
    }
}
