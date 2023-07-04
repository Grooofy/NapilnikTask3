namespace NapilnikTask3
{
    public class ConsoleLogWritter : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}