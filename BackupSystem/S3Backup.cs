using System;
using System.IO;

namespace BackupSystem
{
    /// <summary>
    /// Хранение резервных копий в облаке (Amazon S3).
    ///
    /// Чтобы лабораторную можно было проверить без реального AWS-аккаунта
    /// и интернета, класс ЭМУЛИРУЕТ бакет S3 обычной папкой на диске.
    /// Вся логика (интерфейс, идентификаторы, обработка ошибок) построена
    /// так же, как в реальном сценарии — при необходимости тело методов
    /// Save/Restore можно заменить на вызовы AWSSDK.S3
    /// (PutObjectRequest / GetObjectRequest), не трогая остальную систему.
    /// </summary>
    public class S3Backup : IBackupDestination
    {
        private readonly string _bucketFolder; // эмуляция "бакета"

        public bool ForceUnavailable { get; set; } = false;

        public string Name => "Облако (S3)";

        public S3Backup(string bucketFolder = @"C:\Backups\S3_Simulated")
        {
            _bucketFolder = bucketFolder;
        }

        public bool IsAvailable()
        {
            if (ForceUnavailable) return false;

            // Реальная реализация: проверка соединения, например
            // await _s3Client.ListBucketsAsync();
            return true;
        }

        public string Save(string data)
        {
            Directory.CreateDirectory(_bucketFolder);
            string id = "s3-" + Guid.NewGuid();

            // Реальная реализация:
            // await _s3Client.PutObjectAsync(new PutObjectRequest {
            //     BucketName = _bucketName, Key = id, ContentBody = data });
            File.WriteAllText(Path.Combine(_bucketFolder, id + ".s3"), data);
            return id;
        }

        public string Restore(string id)
        {
            string filePath = Path.Combine(_bucketFolder, id + ".s3");
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Объект {id} не найден в S3");

            // Реальная реализация:
            // var response = await _s3Client.GetObjectAsync(_bucketName, id);
            return File.ReadAllText(filePath);
        }
    }
}