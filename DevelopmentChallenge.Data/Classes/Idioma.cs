using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class Idioma
    {
        private readonly Dictionary<string, List<string>> traducciones;

        protected Idioma()
        {
            this.traducciones = new Dictionary<string, List<string>>();

            this.InitializeTraducciones();
        }

        protected abstract void InitializeTraducciones();

        protected void AgregarTraduccion(string key, string traduccionSingular, string traduccionPlural = null)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentOutOfRangeException(nameof(key));
            }

            if (traduccionSingular == null)
            {
                throw new ArgumentNullException(nameof(traduccionSingular));
            }

            var traduccion = new List<string>();
            traduccion.Add(traduccionSingular);

            if (traduccionPlural != null)
            {
                traduccion.Add(traduccionPlural);
            }

            this.traducciones[key] = traduccion;
        }

        public abstract bool Maneja(Idiomas idioma);

        public virtual string Traducir(string key, int cantidad = 1)
        {
            if (!this.traducciones.ContainsKey(key))
            {
                return string.Empty;
            }

            List<string> traduccion = this.traducciones[key];

            return traduccion.Count == 1
                ? traduccion[0]
                : cantidad == 1 ? traduccion[0] : traduccion[1];
        }
    }
}
