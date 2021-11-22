using System;

namespace TaskList
{
    // Сиквел.
    // Разработчики из HSE company просят доработать ваше приложение!
    // Дело в том, что разработчики тоже ошибаются, и приходится откатывать приложение к предыдущей версии.
    // К тому же, HSE company не хочет расходовать много памяти,
    // поэтому было принято решение хранить только определенное колличество последних версий приложений (MaxCount).
    // 
    // На вход программе подаются запросы следующего типа:
    // 1) add <application_name> <version> - добавить актуальную версию приложения.
    // 2) back <application_name> - откатить приложение до предыдущей версии. Если предыдущей нет, то удалить приложение.
    // 3) get <application_name> - получить актуальную версию приложения. Если приложения нет, то сообщить об этом.
    // 4) exit - завершить программу.

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RedisClient.Connect("redis-19876.c72.eu-west-1-2.ec2.cloud.redislabs.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            string query = "";
            string name;
            string newVersion;
            while (query != "exit")
            {
                Console.Write("input: ");
                query = Console.ReadLine();
                try
                {
                    string[] inputLines = query.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string command = inputLines[0];

                    switch (command)
                    {
                        case "add":
                            name = inputLines[1];
                            newVersion = inputLines[2];
                            RedisClient.Add(name, newVersion);
                            Console.WriteLine("New version set");
                            break;
                        case "back":
                            name = inputLines[1];
                            Console.WriteLine(RedisClient.Back(name));
                            break;
                        case "get":
                            name = inputLines[1];
                            if (RedisClient.Exist(name))
                            {
                                Console.WriteLine(RedisClient.Get(name));
                            }
                            else
                            {
                                Console.WriteLine("This application doesn't exist");
                            }
                            break;
                        case "exit":
                            break;
                        default:
                            Console.WriteLine("Unknown command");
                            break;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Incorrect input");
                }
            }
        }
    }
}