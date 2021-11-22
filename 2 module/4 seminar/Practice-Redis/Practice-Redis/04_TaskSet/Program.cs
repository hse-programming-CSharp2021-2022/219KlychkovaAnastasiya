using System;
using System.Collections.Generic;
namespace TaskSet
{
    // Сиквел.
    // У Склад.LIFE большое количество различных складов с различными видами товаров.
    // Руководству важно знать, какие виды товаров находятся на различных складах. Помогите Склад.LIFE. 
    // P.S. В последнее время с заказами все плохо, поэтому на склад только завозят новые виды товаров.
    //
    // На вход программе поступают следующие запросы:
    // 1) add <storage_name> <product_name> - добавить вид товара на склад.
    // 2) get <storage_name> - получить список всех видов товаров на складе.
    // 3) exist <storage_name> <product_name> - узнать находится ли вид товара на складе.
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
            string storage;
            string product;
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
                            storage = inputLines[1];
                            product = inputLines[2];
                            RedisClient.Add(storage, product);
                            Console.WriteLine("New product set");
                            break;
                        case "get":
                            storage = inputLines[1];
                            if (RedisClient.Exist(storage))
                            {
                                List<string> products = RedisClient.GetProducts(storage);
                                foreach (string pr in products)
                                    Console.WriteLine(pr);
                            }
                            else
                            {
                                Console.WriteLine("This storage doesn't exist");
                            }
                            break;
                        case "exist":
                            storage = inputLines[1];
                            product = inputLines[2];
                            if (RedisClient.ExistProduct(storage, product))
                                Console.WriteLine($"Product {product} exists in stourage {storage}");
                            else
                                Console.WriteLine($"Product {product} doesn't exist in stourage {storage}");
                            break;
                        case "exit":
                            break;
                        default:
                            Console.WriteLine("Unknown command");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect input");
                }
            }
        }
    }
}