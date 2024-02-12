using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public const string TranslationKey = nameof(TrianguloEquilatero);

        private readonly decimal _cateto;

        

        public TrianguloEquilatero(decimal cateto) 
        {
            _cateto = cateto;
        
        }

        public decimal Cateto
        {
            get { return _cateto; }
        }


        public override decimal CalcularArea() 
        {
            return ((decimal)Math.Sqrt(3) / 4) * _cateto * _cateto;

        }

        public override decimal CalcularPerimetro()
        {
            return _cateto * 3; 
        }

    }
}