using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        public const string TranslationKey = nameof(Circulo);

        private readonly decimal _diametro;

        public Circulo(decimal diametro) 
        {
            _diametro = diametro;
        }

        public decimal Diametro
        {
            get { return _diametro; }
        }

        public override decimal CalcularArea() 
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);

        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }

    }
}