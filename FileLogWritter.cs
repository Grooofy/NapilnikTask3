namespace NapilnikTask3
{
    class FileLogWritter
    {
        public virtual void WriteError(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}