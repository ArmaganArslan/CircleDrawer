using System;

namespace CircleDrawer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Dairenin yarıçapını girin: ");
            int radius;
            if (!int.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("Geçerli bir yarıçap girin.");
                return;
            }

            CircleDrawer.Draw(radius);

            Console.WriteLine("Devam etmek için herhangi bir tuşa basın...");
            Console.ReadKey();
        }
    }

    public static class CircleDrawer
    {
        public static void Draw(int radius)
        {
            int diameter = radius * 2;
            for (int y = 0; y <= diameter; y++)
            {
                for (int x = 0; x <= diameter; x++)
                {
                    double distance = Math.Sqrt(Math.Pow(x - radius, 2) + Math.Pow(y - radius, 2));
                    if (Math.Abs(distance - radius) < 0.5)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
