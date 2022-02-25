using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task1
{
    [Serializable]
    public class Student
    {
        public string Surname { get; set; }
        public int CourseNumber { get; set; }
        public Student(string surname,int course)
        {
            Surname = surname;
            CourseNumber = course;
        }
        public Student()
        {
            Surname = "Pupkin";
            CourseNumber = 1;
        }
    }
    [Serializable]
    public class Group
    {
        public string GroupName { get; set; }
        public List<Student> students;
        public Group(string name,params Student[] students)
        {
            GroupName = name;
            this.students = new(students);
        }
        public Group()
        {
            GroupName = "SomeGroup";
            students = new();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Klychkova", 1);
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream("f1.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, student1);
            }
            using (FileStream file = new FileStream("f1.txt", FileMode.OpenOrCreate))
            {
                Student s = (Student)formatter.Deserialize(file);
                Console.WriteLine(s.Surname);
                Console.WriteLine(s.CourseNumber);
            }
            Console.WriteLine();
            Group group1 = new("BPI219", student1, new Student("Petrov", 1),new Student("Ivanov", 1));
            using (FileStream file = new FileStream("f2.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, group1);
            }
            using (FileStream file = new FileStream("f2.txt", FileMode.OpenOrCreate))
            {
                Group g = (Group)formatter.Deserialize(file);
                Console.WriteLine(g.GroupName);
                g.students.ForEach(x => Console.WriteLine(x.Surname + " " + x.CourseNumber));
            }
            Console.WriteLine("***");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            using (FileStream file = new FileStream("f3.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, student1);
            }
            using (FileStream file = new FileStream("f3.txt", FileMode.OpenOrCreate))
            {
                Student s = (Student)xmlSerializer.Deserialize(file);
                Console.WriteLine(s.Surname);
                Console.WriteLine(s.CourseNumber);
            }
            Console.WriteLine();
            XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(Group));
            using (FileStream file = new FileStream("f4.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer2.Serialize(file, group1);
            }
            using (FileStream file = new FileStream("f4.txt", FileMode.OpenOrCreate))
            {
                Group g = (Group)xmlSerializer2.Deserialize(file);
                Console.WriteLine(g.GroupName);
                g.students.ForEach(x => Console.WriteLine(x.Surname + " " + x.CourseNumber));
            }
            Console.WriteLine("***");

            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize<Student>(student1, options);
            Console.WriteLine(json);
            Student student2 = JsonSerializer.Deserialize<Student>(json, options);
            Console.WriteLine(student2.Surname+" "+student2.CourseNumber);
            string json2 = JsonSerializer.Serialize<Group>(group1, options);
            Console.WriteLine(json2);
            Group group2 = JsonSerializer.Deserialize<Group>(json2, options);
            Console.WriteLine(group2.GroupName);
        }
    }
}
