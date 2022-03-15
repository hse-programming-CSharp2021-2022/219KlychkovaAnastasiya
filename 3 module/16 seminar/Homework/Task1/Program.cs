using System;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

/*
FileSystemWatcher и наблюдение за состоянием папки.
Отслеживать появление файлов во входной папке,
выполнять задание из них,
сохранять файл с результатом в выходной папке.
*/

class Task03_FileSystemWatcher
{
    static string initialDir = "Files";
    static string backupDir = "Backup";

    static void Main(string[] args)
    {
        SecureDirectories();
        StartWatcher();
        Console.WriteLine("Для окончания программы нажмите любую клавишу...");
        Console.ReadKey();
        Task.WaitAll();
    }

    private static void SecureDirectories()
    {
        initialDir = Environment.CurrentDirectory + Path.DirectorySeparatorChar + initialDir;
        backupDir = Environment.CurrentDirectory + Path.DirectorySeparatorChar + backupDir;

        CreateDirectory(initialDir);
        CreateDirectory(backupDir);
    }

    private static void CreateDirectory(string directory)
    {
        if (!Directory.Exists(directory))
            Directory.CreateDirectory(directory);
    }

    //
    // Далее все, что связано c FileSystemWatcher
    //

    private static void StartWatcher()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        FileSystemWatcher watcher = new FileSystemWatcher();
        watcher.Path = initialDir;
        Task[] tasks = {
            Task.Run(() => watcher.Changed += OnChanged),
            Task.Run(() => watcher.Created += OnCreated),
            Task.Run(() => watcher.Deleted += OnDeleted),
            Task.Run(() => watcher.Renamed += OnRenamed),
            Task.Run(() => watcher.Error += OnError) };
        watcher.EnableRaisingEvents = true;
    }

    private static void OnChanged(object sender, FileSystemEventArgs e)
    {
        if(e.ChangeType == WatcherChangeTypes.Changed)
        {
            Console.WriteLine($"Файл был изменен: {e.Name}");
            CopyFile(e.Name);
        }
    }

    // Перенос файла в папку считается за создание
    private static void OnCreated(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Новый файл был создан: {e.Name}");
        CopyFile(e.Name);
    }

    private static void OnDeleted(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Файл был удален: {e.Name}");
    }

    private static void OnRenamed(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Файл был переименован: {e.Name}");
        CopyFile(e.Name);
    }

    private static void OnError(object sender, ErrorEventArgs e)
    {
        Console.WriteLine("Произошла ошибка");
    }

    // Будет создавать копии всех текстовых файлов в папке Backup
    private static void CopyFile(string filename)
    {
        if (filename.EndsWith(".txt"))
        {
            File.Copy(Path.Combine(initialDir, filename), Path.Combine(backupDir, filename), true);
            Console.WriteLine($"Файл был скопирован: {filename}");
        }
    }
}