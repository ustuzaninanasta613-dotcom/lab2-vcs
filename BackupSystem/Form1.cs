using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BackupSystem
{    public partial class Form1 : Form
    {
        // Основной модуль системы, хранит ссылки только на интерфейс IBackupDestination
        private BackupManager _backupManager;

        // Список хранилищ нужен, чтобы связать пункты ComboBox/CheckedListBox с конкретными объектами при восстановлении и переключении доступности.
        private List<IBackupDestination> _destinations;

        public Form1()
        {
            InitializeComponent();

            BuildBackupManager();
            SetupResultsGrid();
            FillDestinationsList();
        }

        private void BuildBackupManager()
        {
            _destinations = new List<IBackupDestination>
            {
                new LocalBackup(),
                new S3Backup(),
                new FtpBackup(),
                new NetworkFolderBackup() //  добавлен без изменения BackupManager
            };

            _backupManager = new BackupManager(_destinations);
        }

        private void SetupResultsGrid()
        {
            dgvResults.Rows.Clear();
        }

        private void FillDestinationsList()
        {
            clbDestinations.Items.Clear();
            foreach (var dest in _destinations)
                clbDestinations.Items.Add(dest.Name, true);

            cmbDestinations.Items.Clear();
            foreach (var dest in _destinations)
                cmbDestinations.Items.Add(dest.Name);
            if (cmbDestinations.Items.Count > 0)
                cmbDestinations.SelectedIndex = 0;
        }


        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtData.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtData.Text))
            {
                MessageBox.Show("Введите данные или загрузите файл для резервного копирования.",
                    "Нет данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Основной модуль работает через интерфейс IBackupDestination ему неважно, сколько и каких именно хранилищ ему передали.
            List<BackupResult> results = _backupManager.BackupToAll(txtData.Text);

            dgvResults.Rows.Clear();
            foreach (var result in results)
            {
                dgvResults.Rows.Add(
                    result.DestinationName,
                    result.Success ? result.Id : "-",
                    result.Message);
            }
            Logger.Log($"Резервное копирование выполнено, результатов: {results.Count}");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (cmbDestinations.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите хранилище для восстановления.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRestoreId.Text))
            {
                MessageBox.Show("Введите идентификатор бэкапа (id), полученный при сохранении.");
                return;
            }

            IBackupDestination selected = _destinations[cmbDestinations.SelectedIndex];

            try
            {
                string restored = _backupManager.RestoreFrom(selected, txtRestoreId.Text.Trim());
                txtRestoredData.Text = restored;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось восстановить данные: " + ex.Message,
                    "Ошибка восстановления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clbDestinations_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Событие срабатывает ДО того, как состояние реально изменится,
            // поэтому e.NewValue, а не текущее состояние айтема.
            bool willBeAvailable = e.NewValue == CheckState.Checked;
            IBackupDestination dest = _destinations[e.Index];

            switch (dest)
            {
                case LocalBackup l: l.ForceUnavailable = !willBeAvailable; break;
                case S3Backup s: s.ForceUnavailable = !willBeAvailable; break;
                case FtpBackup f: f.ForceUnavailable = !willBeAvailable; break;
                case NetworkFolderBackup n: n.ForceUnavailable = !willBeAvailable; break;
            }
        }
    }
}