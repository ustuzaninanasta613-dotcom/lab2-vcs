using System;
using System.Collections.Generic;

namespace BackupSystem
{
    /// <summary>
    /// Основной модуль системы. Зависит ТОЛЬКО от абстракции
    /// IBackupDestination (Dependency Inversion Principle). Список хранилищ
    /// передаётся через конструктор (Dependency Injection) — сам класс
    /// никогда не создаёт конкретные реализации через new().
    /// Это и делает возможным добавление NetworkFolderBackup без единой
    /// правки данного файла.
    /// </summary>
    public class BackupManager
    {
        private readonly List<IBackupDestination> _destinations;

        public BackupManager(List<IBackupDestination> destinations)
        {
            _destinations = destinations ?? throw new ArgumentNullException(nameof(destinations));
        }

        /// <summary>
        /// Сохраняет данные во все ДОСТУПНЫЕ хранилища.
        /// Возвращает результат по каждому хранилищу (id или причину отказа).
        /// </summary>
        public List<BackupResult> BackupToAll(string data)
        {
            var results = new List<BackupResult>();

            foreach (var destination in _destinations)
            {
                if (!destination.IsAvailable())
                {
                    results.Add(new BackupResult(destination.Name, null, false, "недоступно"));
                    continue;
                }

                try
                {
                    string id = destination.Save(data);
                    results.Add(new BackupResult(destination.Name, id, true, "OK"));
                }
                catch (Exception ex)
                {
                    results.Add(new BackupResult(destination.Name, null, false, "Ошибка: " + ex.Message));
                }
            }

            return results;
        }

        /// <summary>Восстановление данных из конкретного хранилища по id.</summary>
        public string RestoreFrom(IBackupDestination destination, string id)
        {
            return destination.Restore(id);
        }

        /// <summary>Список хранилищ, с которыми работает менеджер (нужен для UI).</summary>
        public IReadOnlyList<IBackupDestination> Destinations => _destinations;
    }

    /// <summary>Результат операции бэкапа для одного хранилища.</summary>
    public class BackupResult
    {
        public string DestinationName { get; }
        public string Id { get; }
        public bool Success { get; }
        public string Message { get; }

        public BackupResult(string destinationName, string id, bool success, string message)
        {
            DestinationName = destinationName;
            Id = id;
            Success = success;
            Message = message;
        }
    }
}