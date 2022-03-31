using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskV2
{
    public class Shape
    {
        virtual public double GetArea() { return 0; }
    }
    public class Circle : Shape
    {

        private double radius;
        public Circle(double value)
        {
            radius = value;
        }
        public override double GetArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return Math.Round(area,1);
        }
    }
    public class Triangle : Shape
    {
        // Длины сторон треугольника
        private double A, B, C;                             
        // Полупериметр треугольника  
        public double P
        {
            get { return (A+B+C)/2; }
        }
        public Triangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && c + b > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                Console.WriteLine("Sum of two sides of a triangle is always greater than the third side. Triangle is not set");
                A = 0;
                B = 0;
                C = 0;
            }
        }
        // Вычисление площади треугольника по формуле Герона
        public override double GetArea()
        {
            double area = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            return area;  
        }
        // Проверка на прямоугольный треугольник, может быть многовато вычислений, но все равно лучше чем конструкция на if-ах
        public bool IsRightTriangle()
        {
            double area = GetArea();
            if (area == 0)
                return false;

            if (area == A * B / 2)
                return true;
            if (area == C * B / 2)
                return true;
            if (area == A * C / 2)
                return true;
            return false;
        }
    }
}

