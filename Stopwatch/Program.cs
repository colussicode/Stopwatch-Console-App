using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma opção de contagem: ");
            Console.WriteLine("S - Segundos");
            Console.WriteLine("M - Minutos");
            Console.WriteLine("Quanto tempo deseja cronometrar?");
            Console.WriteLine("0 - Sair");

            string data = Console.ReadLine().ToLower();
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime <= time) {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime ++;
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado...Retornando para o menu!");
            Thread.Sleep(2000);
        }
    }
}
