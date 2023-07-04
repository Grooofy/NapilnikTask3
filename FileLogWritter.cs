namespace NapilnikTask3
{
    public class FileLogWritter : ILogger
    {
        public void WriteLog(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}