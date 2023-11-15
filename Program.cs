using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            double S, T;
            Avto c = new Avto();

            Console.Write("Введите марку автомобиля: ");
            c.Br = Console.ReadLine();

            Console.Write("Введите цвет автомобиля: ");
            c.Co = Console.ReadLine();
            
                    Console.Write("Введите мощность автомобиля: ");
            c.Pow = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояние, котрое необходимо проехать (км): ");
                        S = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите время, за которое необходимо проехать указанное расстояние (ч): ");
            T = Convert.ToDouble(Console.ReadLine());

            c.Go(T, S);
            c.AvtoS();
        }
    }
}
