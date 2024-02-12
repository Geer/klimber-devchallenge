using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class IdiomaIngles : Idioma
    {
        protected override void InitializeTraducciones()
        {
           // base.InitializeTraducciones();

            this.AgregarTraduccion(Circulo.TranslationKey, "Circle", "Circles");
            this.AgregarTraduccion(Cuadrado.TranslationKey, "Square", "Squares");
            this.AgregarTraduccion(TrianguloEquilatero.TranslationKey, "Triangle", "Triangles");
            this.AgregarTraduccion(Rectangulo.TranslationKey, "Rectangle", "Rectangles");
            this.AgregarTraduccion(Trapecio.TranslationKey, "Trapeze", "Trapezoids");

            this.AgregarTraduccion("empty_list", "<h1>Empty list of shapes!</h1>");
            this.AgregarTraduccion("shape_report", "<h1>Shapes report</h1>");
            this.AgregarTraduccion("total", "Total");
            this.AgregarTraduccion("area", "Area");
            this.AgregarTraduccion("perimeter", "Perimeter");
            this.AgregarTraduccion("shapes", "shape", "shapes");
        }

        public override bool Maneja(Idiomas idioma)
        {
            return Idiomas.Ingles == idioma;
        }
    }
}
