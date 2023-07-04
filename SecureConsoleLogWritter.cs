namespace NapilnikTask3
{
    class SecureConsoleLogWritter : ILogger
    {
        private FileLogWritter _writer;

        public SecureConsoleLogWritter(FileLogWritter writer)
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