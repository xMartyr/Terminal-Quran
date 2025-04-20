using Terminal_Quran.sys;
using static System.Console;
using static System.ConsoleColor;

namespace Terminal_Quran
{
    public class termoquran
    {
        private static void Main(string[] args)
        {
            Clear();
            CursorVisible = false;
            ForegroundColor = Red;
            Write("\n\t   Developed by");
            ForegroundColor = Yellow;
            WriteLine($"{StringLibrary.asciiTitles[1]}");
            ForegroundColor = DarkGray;
            WriteLine("\t   v.1.0.0.0");

            Thread.Sleep(3000);
            UserInterface.StartProgram();
        }
    }
}