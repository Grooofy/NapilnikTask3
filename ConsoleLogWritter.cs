namespace NapilnikTask3
{
    class ConsoleLogWritter : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}