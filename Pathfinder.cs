namespace NapilnikTask3
{
    public class Pathfinder
    {
        private ILogger _logger;

        public Pathfinder(ILogger logger)
        {
            _logger = logger;
        }

        public void ShowMessage(string message)
        {
            _logger.WriteLog(message);
        }
    }
}