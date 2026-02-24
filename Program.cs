using System;
using System.IO;
using System.Threading;

namespace GeminiFix
{
    class Program
    {
        readonly static string user_profile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        readonly static string dir_file_in = user_profile + "\\.gemini";
        readonly static string find_file_in = dir_file_in + "\\Gemini.md";

        const string fix_prompt = @"
**Correct (Expected behavior):**
`cmd /c <your_command>`
*Example:* `cmd /c echo Hello World`
*Example:* `cmd /c npm run build`
*Example:* `cmd /c dir`

**Incorrect (Forbidden):**
`<your_command>`
*Example:* `echo Hello World`
*Example:* `npm run build`

**You can join commands by & or &&**
*Examle:* `echo Hello && echo world`

**Before each command add**
*Example* `chcp 65001 && cls && commands_to_run`
*Example for hello world* `chcp 65001 && cls && echo Hello, World!`
";

        const string logo = @"
   _____ ______ __  __ _____ _   _ _____     ______ _______   __
  / ____|  ____|  \/  |_   _| \ | |_   _|   |  ____|_   _\ \ / /
 | |  __| |__  | \  / | | | |  \| | | |     | |__    | |  \ V / 
 | | |_ |  __| | |\/| | | | | . ` | | |     |  __|   | |   > <  
 | |__| | |____| |  | |_| |_| |\  |_| |_    | |     _| |_ / . \ 
  \_____|______|_|  |_|_____|_| \_|_____|   |_|    |_____/_/ \_\
                                                                 ";

        static void Main(string[] args)
        {
            if (!Console.IsOutputRedirected) Console.Clear();
            Print(logo, ConsoleColor.Cyan);
            Print("\n [!] Gemini Terminal Fix Tool for Windows v1.0", ConsoleColor.White);
            Print(" [i] This tool will patch your Gemini.md with mandatory Windows terminal rules.", ConsoleColor.Gray);
            Print(" [!] Please add +1 to issue: https://issuetracker.google.com/issues/487139128\n", ConsoleColor.White);

            Print(" > Press any key to start the scanner...", ConsoleColor.Yellow);
            if (args.Length == 0) Console.ReadKey(true);

            Typewriter("\n [*] Initializing scanner...", ConsoleColor.Cyan);
            Thread.Sleep(500);

            if (Directory.Exists(dir_file_in))
            {
                Print(" [OK] Gemini directory found: " + dir_file_in, ConsoleColor.Green);
                Thread.Sleep(300);

                if (File.Exists(find_file_in))
                {
                    Print(" [OK] Gemini.md detected!", ConsoleColor.Green);
                    Thread.Sleep(300);

                    Print("\n [?] Current content preview:", ConsoleColor.Yellow);
                    string content = File.ReadAllText(find_file_in);
                    Print(" --------------------------------------------------", ConsoleColor.Gray);
                    Print(string.IsNullOrWhiteSpace(content) ? " (File is empty)" : content, ConsoleColor.White);
                    Print(" --------------------------------------------------", ConsoleColor.Gray);

                    NextStep();
                }
                else
                {
                    Print(" [!] Gemini.md not found in the expected location.", ConsoleColor.Red);
                }
            }
            else
            {
                Print(" [!] .gemini root folder not found.", ConsoleColor.Red);
            }

            Print("\n [i] Execution finished. Closing...", ConsoleColor.Gray);
            Thread.Sleep(1000);
        }

        static void NextStep()
        {
            Print("\n [!] WARNING: Proceeding will overwrite Gemini.md content.", ConsoleColor.Red);
            Print(" 1. [ Apply Fix ]", ConsoleColor.Green);
            Print(" 2. [ Abort Mission ]", ConsoleColor.Red);
            Console.Write("\n > Select action: ");

            string choice = Console.ReadLine()!;

            if (choice.Trim() == "1")
            {
                FixFile();
            }
            else
            {
                Print(" [!] Operation aborted by user.", ConsoleColor.Yellow);
            }
        }

        static void FixFile()
        {
            Typewriter("\n [*] Injection in progress...", ConsoleColor.Cyan);

            try
            {
                File.WriteAllText(find_file_in, fix_prompt.Replace("\r\n", "\n"));
                Thread.Sleep(800);
                Print(" [SUCCESS] GEMINI.md has been patched successfully!", ConsoleColor.Green);
                Print(" [TIP] You can now use terminal tools without session errors.", ConsoleColor.Blue);
            }
            catch (Exception ex)
            {
                Print(" [ERROR] Failed to write to file: " + ex.Message, ConsoleColor.Red);
            }

            Print("\n > Press any key to exit...", ConsoleColor.Yellow);
            if (!Console.IsInputRedirected) Console.ReadKey(true);
        }

        // --- UI Helpers ---

        static void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Typewriter(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}