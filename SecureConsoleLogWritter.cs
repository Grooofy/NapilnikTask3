namespace NapilnikTask3
{
    class SecureConsoleLogWritter : ILogger
    {
        private ConsoleLogWritter _writer;

        public SecureConsoleLogWritter(ConsoleLogWritter writer)
        {
            _writer = writer;
        }

        public void WriteLog(string message)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
               _writer.WriteLog(message);
            }
        }
    }
}