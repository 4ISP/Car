using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Avto
    {
        public string Br, 
            Co;
        public double Pow;
        private double Sp;

        public double Go(double vr, double rs)
        {
            return Sp = rs / vr;
        }





        public void AvtoS()
        {
                Console.WriteLine("\nХарактеристики:");

            Console.WriteLine("Скорость: " + Sp);

                    Console.WriteLine("Марка: " + Br);
            Console.WriteLine("Цвет: " + Co);
                                    Console.WriteLine("Мощность: " + Pow);
        




        }
    }
}
