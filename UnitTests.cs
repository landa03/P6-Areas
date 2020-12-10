using System;
using NUnit.Framework;

namespace P6_Areas
{
    [TestFixture]
    class UnitTests
    {
        [Test]
        [TestCase(TestName = "The area af the triangle should be calculated correctly")]
        public void TriangleAreaTest()
        {
            CalcularAreas triangulo = new CalcularAreas();
            triangulo.Triangulo(5, 3);
            // triangulo.area = 7.5M;
            Assert.That(triangulo.area, Is.EqualTo(7.5M));
            
            // todo: hacer un metodo para introducir los valores
        }
        [Test]
        [TestCase(TestName = "The area af the squere should be calculated correctly")]
        public void SquereAreaTest()
        {
            CalcularAreas cuadrado = new CalcularAreas();
            cuadrado.Cuadrado(5);
            Assert.That(cuadrado.area, Is.EqualTo(25));
            
        }

        [Test]
        [TestCase(TestName = "The area af the rectangle should be calculated correctly")]
        public void RectangleAreaTest()
        {
            CalcularAreas rectangulo = new CalcularAreas();
            rectangulo.Rectangulo(2, 4);
            Assert.That(rectangulo.area, Is.EqualTo(8));
            
        }

        [Test]
        [TestCase(TestName = "The area af the poligon should be calculated correctly")]
        public void PoligonAreaTest()
        {
            CalcularAreas pentagono = new CalcularAreas();
            pentagono.Pentagono(5, 6);
            Assert.That(pentagono.area, Is.EqualTo(75));
            
        }

        [Test]
        [TestCase(TestName = "The area af the ciecle should be calculated correctly")]
        public void CiecleAreaTest()
        {
            CalcularAreas circulo = new CalcularAreas();
            circulo.Circulo(5);
            Assert.That(circulo.area, Is.EqualTo(78.54));
            
        }
    }
}
