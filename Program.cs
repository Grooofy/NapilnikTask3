namespace NapilnikTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogWritter _consoleLogWritter = new ConsoleLogWritter();
            SecureConsoleLogWritter _secureConsoleWritter = new SecureConsoleLogWritter(_consoleLogWritter);
            FileLogWritter _fileLogWritter = new FileLogWritter();
            SecureFileLogWritter _secureFileLogWritter = new SecureFileLogWritter(_fileLogWritter);
            SuperSecureLogWritter _superSecureLogWritter = new SuperSecureLogWritter(_consoleLogWritter, _secureFileLogWritter);

            Pathfinder pathfinder0 = new Pathfinder(_consoleLogWritter);
            Pathfinder pathfinder1 = new Pathfinder(_secureConsoleWritter);
            Pathfinder pathfinder2 = new Pathfinder(_fileLogWritter);
            Pathfinder pathfinder3 = new Pathfinder(_secureFileLogWritter);
            Pathfinder pathfinder4 = new Pathfinder(_superSecureLogWritter);


            pathfinder0.Find("1");
            pathfinder1.Find("2");
            pathfinder2.Find("3");
            pathfinder3.Find("4");
            pathfinder4.Find("5");
            
        }
    }
}