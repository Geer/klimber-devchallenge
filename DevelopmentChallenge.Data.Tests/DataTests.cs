using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var traductor = new Traductor();

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                traductor.Traducir(Idiomas.Castellano, "empty_list"));
                
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var traductor = new Traductor();

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                traductor.Traducir(Idiomas.Ingles, "empty_list"));
        }   

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            var traductor = new Traductor();

            Assert.AreEqual("<h1>Elenco Vuoto Di Forme!</h1>",
                traductor.Traducir(Idiomas.Italiano, "empty_list"));
        }

        [TestCase]
        public void TestResumenListaConUnCirculo()
        {
            var circulos = new List<FormaGeometrica> { new Circulo(5) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(circulos, Idiomas.Castellano);


            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Círculo | Area 19,63 | Perimetro 15,71 <br/>TOTAL:<br/>1 forma Perimetro 15,71 Area 19,63", resumen);

        }

        [TestCase]
        public void TestResumenListaConUnCirculoIngles()
        {
            var circulos = new List<FormaGeometrica> { new Circulo(5) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(circulos, Idiomas.Ingles);


            Assert.AreEqual("<h1>Shapes report</h1>1 Circle | Area 19,63 | Perimeter 15,71 <br/>TOTAL:<br/>1 shape Perimeter 15,71 Area 19,63", resumen);

        }

        [TestCase]
        public void TestResumenListaConUnCirculoItaliano()
        {
            var circulos = new List<FormaGeometrica> { new Circulo(5) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(circulos, Idiomas.Italiano);


            Assert.AreEqual("<h1>Rapporto sui Moduli</h1>1 Cerchio | Zona 19,63 | Perimetro 15,71 <br/>TOTALE:<br/>1 forma Perimetro 15,71 Zona 19,63", resumen);


        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(cuadrados, Idiomas.Castellano);


            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 25", resumen);

        }

        [TestCase]
        public void TestResumenListaConUnCuadradoIngles()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(cuadrados, Idiomas.Ingles);


            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shape Perimeter 20 Area 25", resumen);

        }

        [TestCase]
        public void TestResumenListaConUnCuadradoItaliano()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(cuadrados, Idiomas.Italiano);


            Assert.AreEqual("<h1>Rapporto sui Moduli</h1>1 Piazza | Zona 25 | Perimetro 20 <br/>TOTALE:<br/>1 forma Perimetro 20 Zona 25", resumen);

        }

        [TestCase]
        public void TestResumenListaConUnRectengulo()
        {
            var rectangulos = new List<FormaGeometrica> { new Rectangulo(5, 3) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(rectangulos, Idiomas.Castellano);


            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 15 | Perimetro 16 <br/>TOTAL:<br/>1 forma Perimetro 16 Area 15", resumen);

        }

        [TestCase]
        public void TestResumenListaConUnRectenguloIngles()
        {
            var rectangulos = new List<FormaGeometrica> { new Rectangulo(5, 3) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(rectangulos, Idiomas.Ingles);


            Assert.AreEqual("<h1>Shapes report</h1>1 Rectangle | Area 15 | Perimeter 16 <br/>TOTAL:<br/>1 shape Perimeter 16 Area 15", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectenguloItaliano()
        {
            var rectangulos = new List<FormaGeometrica> { new Rectangulo(5.5m, 3.9m) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(rectangulos, Idiomas.Italiano);


            Assert.AreEqual("<h1>Rapporto sui Moduli</h1>1 Rettangolo | Zona 21,45 | Perimetro 18,8 <br/>TOTALE:<br/>1 forma Perimetro 18,8 Zona 21,45", resumen);

        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecios = new List<FormaGeometrica> { new Trapecio(5, 3, 7, 4) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(trapecios, Idiomas.Castellano);


            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 16 | Perimetro 22 <br/>TOTAL:<br/>1 forma Perimetro 22 Area 16", resumen);

        }

        [TestCase]
        public void TestResumenListaConUnTrapecioIngles()
        {
            var trapecios = new List<FormaGeometrica> { new Trapecio(5, 3, 7, 4) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(trapecios, Idiomas.Ingles);


            Assert.AreEqual("<h1>Shapes report</h1>1 Trapeze | Area 16 | Perimeter 22 <br/>TOTAL:<br/>1 shape Perimeter 22 Area 16", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioItaliano()
        {
            var trapecios = new List<FormaGeometrica> { new Trapecio(5, 3, 7, 4) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(trapecios, Idiomas.Italiano);


            Assert.AreEqual("<h1>Rapporto sui Moduli</h1>1 Trapezio | Zona 16 | Perimetro 22 <br/>TOTALE:<br/>1 forma Perimetro 22 Zona 16", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTriangulo()
        {
            var triangulos = new List<FormaGeometrica> { new TrianguloEquilatero(5) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(triangulos, Idiomas.Castellano);


            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo | Area 10,83 | Perimetro 15 <br/>TOTAL:<br/>1 forma Perimetro 15 Area 10,83", resumen);

        }

        [TestCase]
        public void TestResumenListaConUnTrianguloIngles()
        {
            var triangulos = new List<FormaGeometrica> { new TrianguloEquilatero(5) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(triangulos, Idiomas.Ingles);


            Assert.AreEqual("<h1>Shapes report</h1>1 Triangle | Area 10,83 | Perimeter 15 <br/>TOTAL:<br/>1 shape Perimeter 15 Area 10,83", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrianguloItaliano()
        {
            var triangulos = new List<FormaGeometrica> { new TrianguloEquilatero(5) };

            var traductor = new Traductor();
            var resumen = FormaGeometrica.Imprimir(triangulos, Idiomas.Italiano);


            Assert.AreEqual("<h1>Rapporto sui Moduli</h1>1 Triangolo | Zona 10,83 | Perimetro 15 <br/>TOTALE:<br/>1 forma Perimetro 15 Zona 10,83", resumen);

        }

        [TestCase]
        public void TestResumenListaConMasCirculos()
        {
            var traductor = new Traductor();

            var circulos = new List<FormaGeometrica>()
            {
                new Circulo(8),
                new Circulo(19),
                new Circulo(5.24m)
            };


            var resumen = FormaGeometrica.Imprimir(circulos, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto sui Moduli</h1>3 Cerchi | Zona 355,36 | Perimetro 101,28 <br/>TOTALE:<br/>3 forme Perimetro 101,28 Zona 355,36", resumen);

        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var traductor = new Traductor();

            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
            
        }

        [TestCase]
        public void TestResumenListaConMasRectangulos()
        {
            var traductor = new Traductor();

            var rectangulos = new List<FormaGeometrica>
            {
                new Rectangulo(5, 2),
                new Rectangulo(10, 5),
                new Rectangulo(50, 30)
            };

            var resumen = FormaGeometrica.Imprimir(rectangulos, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Rectangles | Area 1560 | Perimeter 204 <br/>TOTAL:<br/>3 shapes Perimeter 204 Area 1560", resumen);

        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var traductor = new Traductor();

            var trapecios = new List<FormaGeometrica>
            {
                new Trapecio(5, 3, 7, 4),
                new Trapecio(10, 6, 14, 8),
                new Trapecio(15, 9, 21, 24)
            };

            var resumen = FormaGeometrica.Imprimir(trapecios, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto sui Moduli</h1>3 Trapezio | Zona 368 | Perimetro 132 <br/>TOTALE:<br/>3 forme Perimetro 132 Zona 368", resumen);

        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var traductor = new Traductor();

            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo((decimal)2.75),
                new TrianguloEquilatero((decimal)4.2),
                new Trapecio(10, 6, 14, 8),
                new Rectangulo(10, 5),
                new Trapecio(5.2m, 3.4m, 7.5m, 4.2m),
                new Rectangulo(5.5m, 3.9m)

            };

            var resumen = FormaGeometrica.Imprimir(formas, Idiomas.Ingles);

            
            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>2 Trapezoids | Area 82,06 | Perimeter 67,6 <br/>2 Rectangles | Area 71,45 | Perimeter 48,8 <br/>TOTAL:<br/>11 shapes Perimeter 214,06 Area 245,16",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var traductor = new Traductor();

            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(10, 6, 14, 8),
                new Rectangulo(10, 5),
                new Trapecio(5.2m, 3.4m, 7.5m, 4.2m),
                new Rectangulo(5.5m, 3.9m)
            
            };

            var resumen = FormaGeometrica.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>2 Trapecios | Area 82,06 | Perimetro 67,6 <br/>2 Rectángulos | Area 71,45 | Perimetro 48,8 <br/>TOTAL:<br/>11 formas Perimetro 214,06 Area 245,16",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var traductor = new Traductor();

            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(10, 6, 14, 8),
                new Rectangulo(10, 5),
                new Trapecio(5.2m, 3.4m, 7.5m, 4.2m),
                new Rectangulo(5.5m, 3.9m)
            
            };

            var resumen = FormaGeometrica.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto sui Moduli</h1>2 Piazze | Zona 29 | Perimetro 28 <br/>2 Cerchi | Zona 13,01 | Perimetro 18,06 <br/>3 triangoli | Zona 49,64 | Perimetro 51,6 <br/>2 Trapezio | Zona 82,06 | Perimetro 67,6 <br/>2 Rettangoli | Zona 71,45 | Perimetro 48,8 <br/>TOTALE:<br/>11 forme Perimetro 214,06 Zona 245,16",
                resumen);
        }
    }
}
