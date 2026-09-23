namespace Depi_Session09
{
    // Q5) Singleton pattern: only ONE instance of the class can exist.
    public class AppLogger
    {
        // Private static field that holds the single instance (starts as null)
        private static AppLogger? _instance = null;

        // Private constructor: nobody outside can write "new AppLogger()"
        private AppLogger()
        {
        }

        // The only way to get the logger.
        // Creates the instance on the first call only, then returns the same one every time.
        public static AppLogger GetLogger()
        {
            if (_instance is null)
            {
                _instance = new AppLogger();
            }

            return _instance;
        }

        // Note: this simple version is not thread-safe.
        // In real projects use a lock or Lazy<AppLogger> when several threads may call GetLogger().
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}
