using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            Shape[,] matrix = new Shape[2, 10];
            for (int i = 0; i < 10; i++)
            {
                matrix[0, i] = new Circle(i);
                matrix[1, i] = new Rectangle(i, i);
                matrix[2, i] = new Triangle(i, i);

            }
            for (int i = 0; i < matrix.Rank; i++)
            {
                for (int j = 0; j < 10; i++)
                {
                    Console.Write($"{matrix[i, j].GetSquare(),7}");
                }
                Console.ReadLine();
            }
        }


             public class Shape
             {
                public virtual double GetSquare()
                {
                    return 0;
                }
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
                return Math.Round(Math.PI * _radious * _radious, 1);

            }

        }

        public class Rectangle : Shape
            {
             private int hight;
             private int weight;

                public Rectangle(int _hight, int _weight)
                {
                this.hight = _hight;
                this.weight = _weight;
                }

                public override double GetSquare()
                {
                    return Math.PI * hight * weight;
                }
        }

        public class Triangle : Shape
        {
            private int height;
            private int basis;

            public Triangle(int _height, int _basis)
            {
                this.height = _height;
                this.basis = _basis;
            }

            public override double GetSquare()
            {
                
                return (height * basis)/2;
            }
        }





        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
           

        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {

        }
    }
}
