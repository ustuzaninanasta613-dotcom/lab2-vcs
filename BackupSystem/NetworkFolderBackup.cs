using System;
using System.IO;

namespace BackupSystem
{
    /// <summary>
    /// ЧЕТВЁРТЫЙ узел сети — добавлен последним, для демонстрации расширяемости.
    /// Хранение резервных копий в сетевой папке (в реальности — UNC-путь
    /// вида \\SERVER\Share).
    ///
    /// ВАЖНО: этот класс только реализует уже существующий интерфейс
    /// IBackupDestination. Ни BackupManager.cs, ни LocalBackup.cs,
    /// ни S3Backup.cs, ни FtpBackup.cs НЕ БЫЛИ ИЗМЕНЕНЫ ни на одну строчку.
    /// Единственное, что потребовалось — передать новый экземпляр в список,
    /// который передаётся в конструктор BackupManager при сборке системы
    /// (см. MainForm.BuildBackupManager). Это и есть принцип Open/Closed:
    /// система открыта для расширения, но закрыта для изменения.
    /// </summary>
    public class NetworkFolderBackup : IBackupDestination
    {
        private readonly string _networkPath;

        public bool ForceUnavailable { get; set; } = false;

        public string Name => "Сетевая папка";

        public NetworkFolderBackup(string networkPath = @"C:\Backups\NetworkFolder_Simulated")
        {
            // В реальных условиях сюда передаётся, например, @"\\FILESERVER\backups"
            _networkPath = networkPath;
        }

        public bool IsAvailable()
        {
            if (ForceUnavailable) return false;

            try
            {
                Directory.CreateDirectory(_networkPath);
                return true;
            }
            catch
            {
                // Сервер выключен, нет доступа по сети и т.п.
                return false;
            }
        }

        public string Save(string data)
        {
            Directory.CreateDirectory(_networkPath);
            string id = "net-" + Guid.NewGuid();
            File.WriteAllText(Path.Combine(_networkPath, id + ".net"), data);
            return id;
        }

        public string Restore(string id)
        {
            string filePath = Path.Combine(_networkPath, id + ".net");
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Файл {id} не найден в сетевой папке");
            return File.ReadAllText(filePath);
        }
    }
}