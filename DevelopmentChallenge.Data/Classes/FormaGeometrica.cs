/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        private readonly decimal _lado;

        public int Tipo { get; set; }

        public abstract decimal CalcularPerimetro();

        public abstract decimal CalcularArea();

        public static string Imprimir(List<FormaGeometrica> formas, Idiomas idioma)
        {
            var traductor = new Traductor();
            var sb = new StringBuilder();
            var idiomaKey = (Idiomas)idioma;

            if (!formas.Any())
            {
                sb.Append(traductor.Traducir(idiomaKey, "empty_list"));
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER

                sb.Append(traductor.Traducir(idiomaKey, "shape_report"));

                var formasPorTipo = formas.GroupBy(f => f.GetType());
                var numeroTotalDeFormas = formasPorTipo.Select(fpt => fpt.Count()).Sum();
                var perimetroTotal = formasPorTipo.Select(fpt => fpt.Sum(f => f.CalcularPerimetro())).Sum();
                var areaTotal = formasPorTipo.Select(fpt => fpt.Sum(f => f.CalcularArea())).Sum();

                foreach (var group in formasPorTipo)
                {
                    var type = group.Key;
                    var numeroFormas = group.Count();
                    var areaFormas = group.Sum(g => g.CalcularArea());
                    var perimetroFormas = group.Sum(g => g.CalcularPerimetro());

                    sb.Append(ObtenerLinea(traductor, numeroFormas, areaFormas, perimetroFormas, type.Name, idiomaKey));

                }

                // FOOTER
                sb.Append(traductor.Traducir(idiomaKey, "total").ToUpper() + ":<br/>");
                sb.Append(numeroTotalDeFormas + " " + traductor.Traducir(idiomaKey, "shapes", numeroTotalDeFormas) + " ");


                sb.Append(traductor.Traducir(idiomaKey, "perimeter") + " " + (perimetroTotal).ToString("#.##") + " ");


                sb.Append(traductor.Traducir(idiomaKey, "area") + " " + (areaTotal).ToString("#.##"));

            }

            return sb.ToString().Replace(".", ",");
        }

        private static string ObtenerLinea(Traductor traductor, int cantidad, decimal area, decimal perimetro, string forma, Idiomas idiomaKey)
        {

            return cantidad > 0 
                ? $"{cantidad} {traductor.Traducir(idiomaKey, forma, cantidad)} | {traductor.Traducir(idiomaKey, "area")} {area:#.##} | " +
                    $"{traductor.Traducir(idiomaKey, "perimeter")} {perimetro:#.##} <br/>" 
                : string.Empty;
        
        }
    }
}
