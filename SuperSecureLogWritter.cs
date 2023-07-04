namespace NapilnikTask3
{
    public class SuperSecureLogWritter : ILogger
    {
        private ConsoleLogWritter _consoleWriter;
        private SecureFileLogWritter _fileWritter;

        public SuperSecureLogWritter(ConsoleLogWritter consoleWriter, SecureFileLogWritter fileWritter)
        {
            _consoleWriter = consoleWriter;
            _fileWritter = fileWritter;
        }

        public void WriteLog(string message)
        {
            _consoleWriter.WriteLog(message);
            _fileWritter.WriteLog(message);
        }
    }
}