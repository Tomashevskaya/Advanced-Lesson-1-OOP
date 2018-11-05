using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            public class Shape {
            public float GetSquare();
            {
            return 0;
            }
;
        }
    public class Circle : Shape
    {
        private int _radious;
        public Circle(int radious)
        {
            this._radious = radious;
                }
        public override double GetSquare()
        {
            return Math.PI*_radious*_radious

                
        }

    }
    public class Rectangle : Shape
    {
        private int hight;
        private int weight;
        public Circle(int radious)
        {
            this._radious = radious;
        }
        public override double GetSquare()
        {
            return Math.PI * _radious * _radious
        }
    }
     
}
