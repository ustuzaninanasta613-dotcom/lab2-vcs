using System;
using System.IO;

namespace BackupSystem
{
    /// <summary>
    /// Хранение резервных копий на локальном диске.
    /// </summary>
    public class LocalBackup : IBackupDestination
    {
        private readonly string _folderPath;

        /// <summary>Позволяет искусственно сделать хранилище недоступным (для демонстрации в UI).</summary>
        public bool ForceUnavailable { get; set; } = false;

        public string Name => "Локальный диск";

        public LocalBackup(string folderPath = @"C:\Backups\Local")
        {
            _folderPath = folderPath;
        }

        public bool IsAvailable()
        {
            if (ForceUnavailable) return false;

            try
            {
                Directory.CreateDirectory(_folderPath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string Save(string data)
        {
            Directory.CreateDirectory(_folderPath);
            string id = Guid.NewGuid().ToString();
            string filePath = Path.Combine(_folderPath, id + ".bak");
            File.WriteAllText(filePath, data);
            return id;
        }

        public string Restore(string id)
        {
            string filePath = Path.Combine(_folderPath, id + ".bak");
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Бэкап с id={id} не найден в {_folderPath}");
            return File.ReadAllText(filePath);
        }
    }
}