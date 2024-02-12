using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class Traductor 
    {
        private readonly List<Idioma> idiomas;

        public Traductor()
        {
            idiomas = new List<Idioma>();
            idiomas.Add(new IdiomaCastellano());
            idiomas.Add(new IdiomaIngles());
            idiomas.Add(new IdiomaItaliano());

            // Add any other language that needs to be supported.
        }

        public string Traducir(Idiomas idiomaKey, string key, int cantidad = 1)
        {
            var idioma = idiomas.Where(i => i.Maneja(idiomaKey)).FirstOrDefault();

            if (idioma == null)
            {
                return string.Empty;
            }

            return idioma.Traducir(key, cantidad);
        }

    }
}