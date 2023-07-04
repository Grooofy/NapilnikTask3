namespace NapilnikTask3
{
    public class SecureConsoleLogWritter : ILogger
    {
        private ConsoleLogWritter _writter;

        public SecureConsoleLogWritter(ConsoleLogWritter writer)
        {
            _writter = writer;
        }

        public void WriteLog(string message)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
               _writter.WriteLog(message);
            }
        }
    }
}