namespace NapilnikTask3
{
    public class SecureFileLogWritter : ILogger
    {
        private FileLogWritter _writter;

        public SecureFileLogWritter(FileLogWritter writter)
        {
            _writter = writter;
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