namespace NapilnikTask3
{
    class ConsoleLogWritter
    {
        public virtual void WriteError(string message)
        {
            Console.WriteLine(message);
        }
    }
}