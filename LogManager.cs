﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace dxpapp
{
    public static class LogManager
    {
        private static readonly string LogFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt");
        private static List<string> logs = new List<string>();

        // Event triggered when a new log is added
        public static event Action<string> LogAdded;

        public static void AddLog(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logEntry = $"[{timestamp}] {message}";
            logs.Add(logEntry);

            // Trigger the event
            LogAdded?.Invoke(logEntry);

            // Save to file
            File.AppendAllText(LogFilePath, logEntry + Environment.NewLine);
        }

        public static List<string> GetLogs()
        {
            if (File.Exists(LogFilePath))
            {
                logs = new List<string>(File.ReadAllLines(LogFilePath));
            }
            return logs;
        }
    }
}

