using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class IdiomaCastellano : Idioma
    {
        protected override void InitializeTraducciones()
        {
            this.AgregarTraduccion(Circulo.TranslationKey, "Círculo", "Círculos");
            this.AgregarTraduccion(Cuadrado.TranslationKey, "Cuadrado", "Cuadrados");
            this.AgregarTraduccion(TrianguloEquilatero.TranslationKey, "Triángulo", "Triángulos");
            this.AgregarTraduccion(Rectangulo.TranslationKey, "Rectángulo", "Rectángulos");
            this.AgregarTraduccion(Trapecio.TranslationKey, "Trapecio", "Trapecios");

            this.AgregarTraduccion("empty_list", "<h1>Lista vacía de formas!</h1>");
            this.AgregarTraduccion("shape_report", "<h1>Reporte de Formas</h1>");
            this.AgregarTraduccion("total", "Total");
            this.AgregarTraduccion("area", "Area");
            this.AgregarTraduccion("perimeter", "Perimetro");
            this.AgregarTraduccion("shapes", "forma", "formas");

        }

        public override bool Maneja(Idiomas idioma)
        {
            return Idiomas.Castellano == idioma;
        }
    }
}
