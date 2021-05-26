using System;
using System.Collections.Generic;
using System.Threading;

namespace Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            users.Add(new User { Login = "tanya", Name = "Танюшка", IsPremium = false });

            Console.WriteLine("Введите свой логин");
            var login = Console.ReadLine();

            var curUser = users.Find((x) => x.Login == login);
            Console.WriteLine("Привет, " + curUser.Name);

            if (!curUser.IsPremium)
            {
                ShowAds();
            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
