using System.Reflection.Emit;

namespace DiceGameSimulator
{
    internal class Game
    {
        public void Start()
        {
            Label:
            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("╟ Введите 'старт', для начала игры ╢");
            Console.WriteLine("╚══════════════════════════════════╝");
            string starting = Console.ReadLine();
            while (starting != "старт")
            {
                Console.WriteLine("╔════════╗");
                Console.WriteLine("╟ Ошибка ╢");
                Console.WriteLine("╚════════╝");
                goto Label;
            }
            if (starting == "старт")
            {
                Random random = new Random();
                int firstValue = random.Next(6);
                int secondValue = random.Next(6);
                Console.WriteLine("╔═════════════════════╗");
                Console.WriteLine($"╟Ваше первое число: {firstValue} ╢");
                Console.WriteLine("╟═════════════════════╢");
                Console.WriteLine($"╟Ваше второе число: {secondValue} ╢");
                Console.WriteLine("╚═════════════════════╝");
            }
        }
    }
}