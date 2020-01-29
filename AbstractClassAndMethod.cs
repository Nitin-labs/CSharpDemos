// Program for the abstract class and abstract method
using System;
namespace CSharp
{
    abstract class Figure
    {
        public int height, width;
        public float radius;
        public const float pi = 3.14F;
        public abstract void getArea();
    }
    class Rectangle : Figure
    {
        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public override void getArea()
        {
            Console.WriteLine("Rectangle Area: " + (height * width));
        }
    }
    class Circle : Figure
    {
        public Circle(float radius)
        {
            this.radius = radius;
        }
        public override void getArea()
        {
            Console.WriteLine("Circle Area: " + (pi * radius * radius));
        }
    }
    class AbstractClassAndMethod
    {
        public void testAbstractClassAndMethod()
        {
            Console.WriteLine("Abstract Class and Method:");
            Circle cir = new Circle(25.23F);
            cir.getArea();
            Rectangle rect = new Rectangle(25, 32);
            rect.getArea();
        }
    }
}