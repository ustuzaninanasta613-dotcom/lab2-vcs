using System;
using System.Diagnostics;
using System.IO;

namespace BackupSystem
{    public static class Logger
    {
        private static readonly object _lock = new object();
        private static readonly string _logPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "backup.log");

        public static void Log(string message)
        {
            string line = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            Debug.WriteLine(line);

            try
            {
                lock (_lock)
                {
                    File.AppendAllText(_logPath, line + Environment.NewLine);
                }
            }
            catch
            {
                // Логирование не должно ломать работу программы.
            }
        }

        public static void Error(string message, Exception ex)
        {
            Log($"ОШИБКА: {message} ({ex.Message})");
        }
    }
}