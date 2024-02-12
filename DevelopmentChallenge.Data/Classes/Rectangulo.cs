using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        public const string TranslationKey = nameof(Rectangulo);

        private readonly decimal _ladoMenor;

        private readonly decimal _ladoMayor;

        public Rectangulo(decimal ladoMayor, decimal ladoMenor) 
        {
            _ladoMayor = ladoMayor;
            _ladoMenor = ladoMenor;
        }

        public decimal LadoMayor
        {
            get { return _ladoMayor; }
        }

        public decimal LadoMenor
        {
            get { return _ladoMenor;  }
        }

        public override decimal CalcularArea() 
        {
            return _ladoMayor * _ladoMenor;

        }

        public override decimal CalcularPerimetro()
        {
            return (_ladoMayor * 2) +  (_ladoMenor * 2);
        }

    }
}