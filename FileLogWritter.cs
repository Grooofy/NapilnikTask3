namespace NapilnikTask3
{
    class FileLogWritter : ILogger
    {
        public void WriteLog(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}