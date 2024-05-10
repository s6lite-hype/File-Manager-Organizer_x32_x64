#pragma warning disable

using System;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

class Program
{
     [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);


    static void Main()
    {
        StartIntroWarn();
        ProcessLogFile();
    }

    static void StartIntroWarn() {
        // Set the desired width and height for the console window
        int width = 110;
        int height = 30;

        // Ensure that the desired window size does not exceed the maximum allowed buffer size
        int maxAllowedWidth = Math.Min(Console.LargestWindowWidth, width);
        int maxAllowedHeight = Math.Min(Console.LargestWindowHeight, height);

        // Set the console window size
        Console.SetWindowSize(maxAllowedWidth, maxAllowedHeight);

        // Calculate the position for centering the console window
        int screenWidth = Console.LargestWindowWidth;
        int screenHeight = Console.LargestWindowHeight;

        int left = Math.Max(0, (screenWidth - width) / 2); // Ensure left position is not negative
        int top = Math.Max(0, (screenHeight - height) / 2); // Ensure top position is not negative

        // Call the native Windows function to get the console window handle
        IntPtr consoleWindowHandle = GetConsoleWindow();

        // Call the native Windows function to move the console window to the center
        MoveWindow(consoleWindowHandle, left * 8, top * 12, width * 8, height * 12, true);
        


        Console.Clear();
        Console.Title = "File Manager Organizer CLI (x32_x64) - Warning";
        Console.WriteLine("                        [https://github.com/s6lite-hype/File-Manager-Organizer_x32_x64]\n\n");
        Console.WriteLine(""+@"
                                                                            
                            ██╗    ██╗ █████╗ ██████╗ ███╗   ██╗██╗███╗   ██╗ ██████╗ 
                            ██║    ██║██╔══██╗██╔══██╗████╗  ██║██║████╗  ██║██╔════╝ 
                            ██║ █╗ ██║███████║██████╔╝██╔██╗ ██║██║██╔██╗ ██║██║  ███╗
                            ██║███╗██║██╔══██║██╔══██╗██║╚██╗██║██║██║╚██╗██║██║   ██║
                            ╚███╔███╔╝██║  ██║██║  ██║██║ ╚████║██║██║ ╚████║╚██████╔╝
                             ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝╚═╝  ╚═══╝ ╚═════╝ 
                                                                             
");
        Console.WriteLine("\n" + @"                Before you do anything else, make sure you backup everything on the folder you've set.
                    I'm not responsible for any data loss on your computer. to continue, type:" + @"
                                    'I'm responsible for any kind of data loss'" + "\n"); 
        Console.Write("                               > "); string inpu = Console.ReadLine();
        if (inpu == "I'm responsible for any kind of data loss"){
            Thread.Sleep(1000);
            Console.Clear();
            DisplayIntroduction();
        } else {
            Environment.Exit(0);
        }
    }

    static void DisplayIntroduction()
    {
        // Set the desired width and height for the console window
        int width = 170;
        int height = 35;

        // Ensure that the desired window size does not exceed the maximum allowed buffer size
        int maxAllowedWidth = Math.Min(Console.LargestWindowWidth, width);
        int maxAllowedHeight = Math.Min(Console.LargestWindowHeight, height);

        // Set the console window size
        Console.SetWindowSize(maxAllowedWidth, maxAllowedHeight);

        // Calculate the position for centering the console window
        int screenWidth = Console.LargestWindowWidth;
        int screenHeight = Console.LargestWindowHeight;

        int left = Math.Max(0, (screenWidth - width) / 2); // Ensure left position is not negative
        int top = Math.Max(0, (screenHeight - height) / 2); // Ensure top position is not negative

        // Call the native Windows function to get the console window handle
        IntPtr consoleWindowHandle = GetConsoleWindow();

        // Call the native Windows function to move the console window to the center
        MoveWindow(consoleWindowHandle, left * 8, top * 12, width * 8, height * 12, true);

        Console.Title = "File Manager Organizer CLI (x64_x32)";
        Console.WriteLine("                                             [https://github.com/MineTableCraft21/File-Manager-Organizer_x32_x64]\n\n");
        Console.WriteLine(@"                                    
                                    ███████╗██╗██╗     ███████╗    ███╗   ███╗ █████╗ ███╗   ██╗ █████╗  ██████╗ ███████╗██████╗ 
                                    ██╔════╝██║██║     ██╔════╝    ████╗ ████║██╔══██╗████╗  ██║██╔══██╗██╔════╝ ██╔════╝██╔══██╗
                                    █████╗  ██║██║     █████╗      ██╔████╔██║███████║██╔██╗ ██║███████║██║  ███╗█████╗  ██████╔╝
                                    ██╔══╝  ██║██║     ██╔══╝      ██║╚██╔╝██║██╔══██║██║╚██╗██║██╔══██║██║   ██║██╔══╝  ██╔══██╗
                                    ██║     ██║███████╗███████╗    ██║ ╚═╝ ██║██║  ██║██║ ╚████║██║  ██║╚██████╔╝███████╗██║  ██║
                                    ╚═╝     ╚═╝╚══════╝╚══════╝    ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝
                                                                                                                                 
                                             ██████╗ ██████╗  ██████╗  █████╗ ███╗   ██╗██╗███████╗███████╗██████╗               
                                            ██╔═══██╗██╔══██╗██╔════╝ ██╔══██╗████╗  ██║██║╚══███╔╝██╔════╝██╔══██╗              
                                            ██║   ██║██████╔╝██║  ███╗███████║██╔██╗ ██║██║  ███╔╝ █████╗  ██████╔╝              
                                            ██║   ██║██╔══██╗██║   ██║██╔══██║██║╚██╗██║██║ ███╔╝  ██╔══╝  ██╔══██╗              
                                            ╚██████╔╝██║  ██║╚██████╔╝██║  ██║██║ ╚████║██║███████╗███████╗██║  ██║              
                                             ╚═════╝ ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝╚══════╝╚═╝  ╚═╝              
                                                                                             
                             " + "\n\n");
    }

    static void ProcessLogFile()
    {
        string csLogFile = "CSavedPath.log";

        if (File.Exists(csLogFile))
        {
            try
            {
                using (StreamReader sr = new StreamReader(csLogFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        ProcessLogEntry(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR] " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("\n\n[FileNotFound] CSavedPath.log not found.");
            Console.WriteLine("[INFO] Create a text file in the same directory as the exe/cs file called : CSavedPath.log and add :\n");
            Console.WriteLine(@"SavedPathID {
    'MoveFromPath' : '(C:\Users\(username)\Desktop)' > 'DestinationPath' : '(C:\Users\(username)\Documents)';
}

OrganizedFile {
    'FileExtension' : "".exe, .cs. ps1, (any)"";
}");
        }
    }

    static void ProcessLogEntry(string line)
    {
        // Match and extract 'MoveFromPath' and 'DestinationPath' sections
        Match match = Regex.Match(line, @"'MoveFromPath' : '\(([^)]*)\)'\s*>\s*'DestinationPath' : '\(([^)]*)\)';");
        if (match.Success)
        {
            string moveFromPath = match.Groups[1].Value;
            string destinationPath = match.Groups[2].Value;
            Console.WriteLine("\n                 [INFO] " + moveFromPath + " > " + destinationPath);
        }

        // Match and extract 'FileExtension' section
        Match extensionMatch = Regex.Match(line, @"'FileExtension' : ""(.*)"";");
        if (extensionMatch.Success)
        {
            string fileExtensions = extensionMatch.Groups[1].Value;
            ExternalCommand();
        }
    }
    static void ExternalCommand() {

    }
}
