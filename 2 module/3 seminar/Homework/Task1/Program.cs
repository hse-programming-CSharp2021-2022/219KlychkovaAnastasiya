using System;
using System.Text;
namespace Task1
{
    class VideoFile
    {
        string _name;
        int _duration;
        int _quality;

        public VideoFile(string name, int duration, int quality)
        {
            _name = name;
            _duration = duration;
            _quality = quality;
        }
        public int Size
        {
            get
            {
                return _duration * _quality;
            }
        }

        public override string ToString()
        {
            return $"Name: {_name}\nDuration: {_duration}\nQuality: {_quality}\nSize: {Size}";
        }
    }
    class Program
    {
        static string RandomName()
        {
            Random rnd = new Random();
            int n = rnd.Next(2, 10);
            StringBuilder name = new StringBuilder("");
            for(int i = 0; i < n; i++)
            {
                name.Append((char)rnd.Next(97, 123));
            }
            return name.ToString();
        }
        static void Main(string[] args)
        {
            do
            {
                Random rnd = new Random();
                VideoFile video = new VideoFile(RandomName(), rnd.Next(60, 361), rnd.Next(100, 1001));
                Console.WriteLine(video + "\n");
                int n = rnd.Next(5, 16);
                VideoFile[] videoSequence = new VideoFile[n];
                for (int i = 0; i < n; i++)
                {
                    videoSequence[i] = new VideoFile(RandomName(), rnd.Next(60, 361), rnd.Next(100, 1001));
                    Console.WriteLine(videoSequence[i]);
                }
                Console.WriteLine("\nВидеофайлы из массива, размер которых больше, чем размер отдельного видеофайла: ");
                for (int i = 0; i < n; i++)
                {
                    if (videoSequence[i].Size > video.Size)
                        Console.WriteLine(videoSequence[i]);
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
