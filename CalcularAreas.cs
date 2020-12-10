using System;

namespace P6_Areas
{
    public class CalcularAreas
    {
        // public decimal bases;
        // public decimal altura;
        public decimal area;
        public void Triangulo(decimal bases, decimal altura){
            //base por altura entre dos ((b*h)/2)
            this.area = (bases * altura) / 2;
        }
        public void Cuadrado(decimal bases){
            //base al cuadrado (b^2)
            this.area = bases * bases;
        }
        public void Rectangulo(decimal bases, decimal altura){
            // base por altura (b * a)
            this.area = bases * altura;
        }
        public void Pentagono(decimal bases, decimal altura){
            // base por radio menor por sinco, todo entre dos ((5 * b * a)/2)
            this.area = (5 * bases * altura) / 2;
        }
        public void Circulo(decimal radio){
            // pi por radio al cuadrado (π * r^2)
            this.area = 3.1416M * (radio * radio);
        }
    }
}
