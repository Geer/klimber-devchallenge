using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class IdiomaItaliano : Idioma
    {
        protected override void InitializeTraducciones()
        {

            this.AgregarTraduccion(Circulo.TranslationKey, "Cerchio", "Cerchi");
            this.AgregarTraduccion(Cuadrado.TranslationKey, "Piazza", "Piazze");
            this.AgregarTraduccion(TrianguloEquilatero.TranslationKey, "Triangolo", "triangoli");
            this.AgregarTraduccion(Rectangulo.TranslationKey, "Rettangolo", "Rettangoli");
            this.AgregarTraduccion(Trapecio.TranslationKey, "Trapezio", "Trapezio");

            this.AgregarTraduccion("empty_list", "<h1>Elenco Vuoto Di Forme!</h1>");
            this.AgregarTraduccion("shape_report", "<h1>Rapporto sui Moduli</h1>");
            this.AgregarTraduccion("total", "Totale");
            this.AgregarTraduccion("area", "Zona");
            this.AgregarTraduccion("perimeter", "Perimetro");
            this.AgregarTraduccion("shapes", "forma", "forme");
        }

        public override bool Maneja(Idiomas idioma)
        {
            return Idiomas.Italiano == idioma;
        }
    }
}
