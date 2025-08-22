using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== FotZIP ===");
            Console.WriteLine("1. Extract ZIP");
            Console.WriteLine("2. Create ZIP");
            Console.WriteLine("3. Exit");
            Console.Write("Your choice: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ExtractZip();
                    break;
                case "2":
                    CreateZip();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    Pause();
                    break;
            }
        }
    }

    static void ExtractZip()
    {
        Console.Write("Enter ZIP file path: ");
        string? zipPath = Console.ReadLine();
        Console.Write("Enter extraction folder: ");
        string? extractPath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(zipPath) || string.IsNullOrWhiteSpace(extractPath))
        {
            Console.WriteLine("Invalid input!");
            Pause();
            return;
        }

        try
        {
            Console.WriteLine("Extracting, please wait...");
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            Console.WriteLine("Files successfully extracted!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Pause();
    }

    static void CreateZip()
    {
        Console.Write("Enter folder path to ZIP: ");
        string? folderPath = Console.ReadLine();
        Console.Write("Enter output ZIP file path: ");
        string? zipPath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(folderPath) || string.IsNullOrWhiteSpace(zipPath))
        {
            Console.WriteLine("Invalid input!");
            Pause();
            return;
        }

        try
        {
            Console.WriteLine("Creating ZIP, please wait...");
            ZipFile.CreateFromDirectory(folderPath, zipPath);
            Console.WriteLine("ZIP file successfully created!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
