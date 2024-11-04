using System.Diagnostics;
namespace VoidWatchDog
{
    internal class ExceptionHandler
    {

        public static void LogError(Exception ex)
        {
            try
            {
                // Specify the path to your log file
                string logFilePath = Application.StartupPath + @"\log_file.txt";

                // Create or append to the log file
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    // Log the unhandled exception details to the file
                    writer.WriteLine($"[{DateTime.Now}] - Unhandled Exception Type: {ex.GetType().FullName}");
                    writer.WriteLine($"Message: {ex.Message}");
                    writer.WriteLine($"StackTrace: {ex.StackTrace}");
                    writer.WriteLine(); // Add an empty line for better readability
                }
                LogMessage($"Unhandled Exception Type: {ex.GetType().FullName}\nMessage: {ex.Message}\nStackTrace: {ex.StackTrace}");
                Debug.WriteLine($"[Error Log] Error details logged to: {logFilePath}");
            }
            catch (Exception logEx)
            {
                // If logging itself fails, you may want to handle that as well
                Debug.WriteLine("[Error Log] Error logging failed: " + logEx.Message);
            }
        }
        public static void LogMessage(string message)
        {
            string logFilePath = Application.StartupPath + @"\log_file.txt";
            const int maxRetries = 5;         // Maximum number of retry attempts
            const int delayBetweenRetries = 500; // Delay between retries in milliseconds
            int retries = 0;

            while (retries < maxRetries)
            {
                try
                {
                    // Attempt to write to the log file
                    using (var writer = new StreamWriter(logFilePath, true))
                    {
                        writer.WriteLine($"[{DateTime.Now}] - {message}");
                        writer.WriteLine();
                    }

                    // Log success message to Debug console
                    Debug.WriteLine($"[Log] Message logged: {message}");

                    // If writing is successful, break out of the retry loop
                    break;
                }
                catch (IOException)
                {
                    // If file is in use, increase the retry count and delay
                    retries++;
                    Debug.WriteLine($"[Log] Log file is in use. Retrying... Attempt {retries}/{maxRetries}");
                    Thread.Sleep(delayBetweenRetries); // Pause before retrying
                }
                catch (Exception ex)
                {
                    // Log any unexpected error and break out of the loop
                    Debug.WriteLine($"[Log] Unexpected error logging message: {ex.Message}");
                    break;
                }
            }

            // If all retry attempts fail, log a final failure message
            if (retries == maxRetries)
            {
                Debug.WriteLine("[Log] Max retries reached. Failed to write to the log file.");
            }
        }


        public static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = e.ExceptionObject as Exception;

            if (exception != null)
            {
                // Log the type, message, and stack trace of the unhandled exception
                Debug.WriteLine($"Unhandled Exception Type: {exception.GetType().FullName}");
                Debug.WriteLine($"Message: {exception.Message}");
                Debug.WriteLine($"StackTrace: {exception.StackTrace}");
                // Log the exception using your custom logging logic
                LogError(exception);
            }

            // Optionally, you can perform additional cleanup or actions before the application exits
            // Environment.Exit(1); // Terminate the application with a non-zero exit code
        }

    }
}
