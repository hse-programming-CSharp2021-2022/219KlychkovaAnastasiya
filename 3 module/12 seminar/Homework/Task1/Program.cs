using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task1
{
    [Serializable]
    class Human
    { 
        public string Name { get; init; }
        public Human(string name)
        {
            Name = name;
        }
    }
    [Serializable]
    class Professor:Human 
    { 
        public Professor(string name) : base(name) { }
    }
    [Serializable]
    class Department 
    {
        public string Name { get; init; }
        public List<Human> Staff { get; set; }
        public  Department(string name, params Human[] people)
        {
            Name = name;
            foreach(Human human in people)
            {
                Staff.Add(human);
            }
        }
    }
    [Serializable]
    class University
    {
        public string Name { get; init; }
        public List<Department> Departments { get; set; }
        public University(string name, List<Department> departments)
        {
            Name = name;
            Departments = departments;
        }
    }    
    class Program
    {
        static string RandomName(int length)
        {
            Random rnd = new();
            StringBuilder name = new();
            for(int i=0;i<length; i++)
            {
                name.Append((char)rnd.Next('A', 'Z' + 1));
            }
            return name.ToString();
        }
        static void Main(string[] args)
        {
            University[]universities = new University[3];
            for(int i = 0; i < 3; i++)
            {
                Random rnd = new();
                List<Department> departments = new();
                for(int j = 0; j < 4; i++)
                {
                    departments[i] = new(RandomName(4), new Human(RandomName(5)), new Human(RandomName(6)));
                }
                universities[i] = new University(RandomName(3), departments);
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream("f1.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, universities);
            }
            using (FileStream file = new FileStream("f1.txt", FileMode.OpenOrCreate))
            {
                University[] un = (University[])formatter.Deserialize(file);
                foreach(var u in un)
                    Console.WriteLine(u.Name);
                
            }
            Console.WriteLine("***");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(University[]));
            using (FileStream file = new FileStream("f2.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, universities);
            }
            using (FileStream file = new FileStream("f2.txt", FileMode.OpenOrCreate))
            {
                University[] un = (University[])xmlSerializer.Deserialize(file);
                foreach (var u in un)
                    Console.WriteLine(u.Name);
            }
            Console.WriteLine();
            Console.WriteLine("***");
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize<University[]>(universities, options);
            Console.WriteLine(json);
            University[] uni = JsonSerializer.Deserialize<University[]>(json, options);
            foreach (var u in uni)
                Console.WriteLine(u.Name);
        }
    }
}
