using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        public const string TranslationKey = nameof(Trapecio);

        private readonly decimal _base;
        
        private readonly decimal _ladoSuperior;

        private readonly decimal _altura;

        private readonly decimal _ladoInclinado;


        public Trapecio(decimal ladoBase, decimal ladoSuperior, decimal ladoInclinado, decimal altura) 
        {
            _ladoSuperior = ladoSuperior;
            _altura = altura;
            _ladoInclinado = ladoInclinado;
            _base = ladoBase;
        }

        public decimal LadoSuperior
        {
            get { return _ladoSuperior; }
        }

        public decimal LadoInclinado
        {
            get { return _ladoInclinado; }
        }

        public decimal Altura
        {
            get { return _altura; }
        }

        public decimal Base
        {
            get { return _base; }
        }

        public override decimal CalcularArea() 
        {
            return ((_ladoSuperior + _base) * _altura)/2;

        }

        public override decimal CalcularPerimetro()
        {
            return (_ladoInclinado * 2) + _base + _ladoSuperior;
        }

    }
}