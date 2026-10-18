using System;
using System.IO;

namespace BackupSystem
{
    /// <summary>
    /// Хранение резервных копий на FTP-сервере.
    ///
    /// Как и S3Backup, для автономной проверки лабораторной работы класс
    /// эмулирует FTP-каталог обычной локальной папкой. Реальная реализация
    /// Save/Restore использовала бы System.Net.FtpWebRequest (или
    /// сторонний клиент, например FluentFTP) для загрузки/скачивания
    /// файла по адресу вида ftp://host/path/id.
    /// </summary>
    public class FtpBackup : IBackupDestination
    {
        private readonly string _ftpFolder; // эмуляция FTP-каталога

        public bool ForceUnavailable { get; set; } = false;

        public string Name => "FTP-сервер";

        public FtpBackup(string ftpFolder = @"C:\Backups\Ftp_Simulated")
        {
            _ftpFolder = ftpFolder;
        }

        public bool IsAvailable()
        {
            if (ForceUnavailable) return false;

            // Реальная реализация: попытка подключения к FTP, например
            // WebRequestMethods.Ftp.ListDirectory
            return true;
        }

        public string Save(string data)
        {
            Directory.CreateDirectory(_ftpFolder);
            string id = "ftp-" + Guid.NewGuid();

            // Реальная реализация: FtpWebRequest с методом STOR
            File.WriteAllText(Path.Combine(_ftpFolder, id + ".ftp"), data);
            return id;
        }

        public string Restore(string id)
        {
            string filePath = Path.Combine(_ftpFolder, id + ".ftp");
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Файл {id} не найден на FTP");

            // Реальная реализация: FtpWebRequest с методом RETR
            return File.ReadAllText(filePath);
        }
    }
}