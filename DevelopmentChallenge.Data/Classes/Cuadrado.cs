using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public const string TranslationKey = nameof(Cuadrado);

        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public decimal Lado
        {
            get { return _lado; }
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;

        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

    }
}