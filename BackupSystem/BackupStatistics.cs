using System.Collections.Generic;
using System.Linq;

namespace BackupSystem
{
    public static class BackupStatistics
    {
        public static int SuccessCount(IEnumerable<BackupResult> results)
        {
            return results.Count(r => r.Success);
        }

        public static int FailureCount(IEnumerable<BackupResult> results)
        {
            return results.Count(r => !r.Success);
        }

        public static string Summary(IEnumerable<BackupResult> results)
        {
            List<BackupResult> list = results.ToList();
            return $"Успешно: {SuccessCount(list)} из {list.Count}, ошибок: {FailureCount(list)}";
        }
    }
}