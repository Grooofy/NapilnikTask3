namespace NapilnikTask3
{
    class SecureFileLogWritter : ILogger
    {
        private FileLogWritter _writter;

        public SecureFileLogWritter(FileLogWritter writter)
        {
            _writter = writter;
        }

        public void WriteLog(string message)
        {
            throw new NotImplementedException();
        }
    }
}