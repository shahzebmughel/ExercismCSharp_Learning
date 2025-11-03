
// Console.WriteLine(LogLine.Message("[ERROR]: Invalid operation"));
// Console.WriteLine(LogLine.Message("[WARNING]: Disk almost full\r\n"));
// Console.WriteLine(LogLine.Message("[INFO]: You completed a task!"));
// Console.WriteLine();
// Console.WriteLine(LogLine.LogLevel("[ERROR]: Invalid operation"));
// Console.WriteLine(LogLine.LogLevel("[WARNING]: Disk almost full\r\n"));
// Console.WriteLine(LogLine.LogLevel("[INFO]: You completed a task!"));
// Console.WriteLine();
// Console.WriteLine(LogLine.Reformat("[ERROR]: Invalid operation"));
// Console.WriteLine(LogLine.Reformat("[WARNING]: Disk almost full\r\n"));
// Console.WriteLine(LogLine.Reformat("[INFO]: You completed a task!"));

static class LogLine
{
    public static string Message(string logLine)
    {
      
       return logLine.Substring(logLine.IndexOf(": ", StringComparison.Ordinal) + 2).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf('[') + 1;
        int end = logLine.IndexOf(']');

        return logLine.Substring(start, end - start).Trim().ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{LogLine.Message(logLine)} ({LogLine.LogLevel(logLine)})";
    }
}
