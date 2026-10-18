using System;

namespace BackupSystem
{
    /// <summary>
    /// Абстракция точки хранения резервных копий (центр "звёздной" сети).
    /// Все конкретные хранилища (Local, S3, FTP, сетевая папка и т.д.)
    /// реализуют этот интерфейс. Основной модуль (BackupManager) работает
    /// ТОЛЬКО с этой абстракцией и ничего не знает о конкретных классах
    /// (Dependency Inversion Principle).
    /// </summary>
    public interface IBackupDestination
    {
        /// <summary>Отображаемое имя хранилища (для UI и логов).</summary>
        string Name { get; }

        /// <summary>
        /// Проверка доступности хранилища на текущий момент
        /// (диск подключен, есть сеть, сервис отвечает и т.п.).
        /// </summary>
        bool IsAvailable();

        /// <summary>
        /// Сохранить данные бэкапа. Возвращает уникальный идентификатор,
        /// по которому позже можно будет восстановить данные.
        /// </summary>
        string Save(string data);

        /// <summary>
        /// Восстановить данные бэкапа по идентификатору, полученному от Save().
        /// </summary>
        string Restore(string id);
    }
}