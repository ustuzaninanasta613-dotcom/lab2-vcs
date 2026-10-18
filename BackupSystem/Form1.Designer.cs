/*namespace BackupSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}*/

namespace BackupSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        // --- Компоненты ---
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.Label lblDestinations;
        private System.Windows.Forms.CheckedListBox clbDestinations;
        private System.Windows.Forms.Button btnBackup;

        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;

        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.Label lblDestSelect;
        private System.Windows.Forms.ComboBox cmbDestinations;
        private System.Windows.Forms.Label lblIdSelect;
        private System.Windows.Forms.TextBox txtRestoreId;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblRestoredData;
        private System.Windows.Forms.TextBox txtRestoredData;

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblDestinations = new System.Windows.Forms.Label();
            this.clbDestinations = new System.Windows.Forms.CheckedListBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.lblDestSelect = new System.Windows.Forms.Label();
            this.cmbDestinations = new System.Windows.Forms.ComboBox();
            this.lblIdSelect = new System.Windows.Forms.Label();
            this.txtRestoreId = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblRestoredData = new System.Windows.Forms.Label();
            this.txtRestoredData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.grpRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblData.Location = new System.Drawing.Point(14, 10);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(356, 15);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Данные для резервного копирования (или загрузите файл):";
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtData.Location = new System.Drawing.Point(14, 32);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(995, 126);
            this.txtData.TabIndex = 1;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadFile.Location = new System.Drawing.Point(14, 166);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(202, 30);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "Загрузить файл";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Выберите файл для резервного копирования";
            // 
            // lblDestinations
            // 
            this.lblDestinations.AutoSize = true;
            this.lblDestinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDestinations.Location = new System.Drawing.Point(14, 216);
            this.lblDestinations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinations.Name = "lblDestinations";
            this.lblDestinations.Size = new System.Drawing.Size(357, 15);
            this.lblDestinations.TabIndex = 3;
            this.lblDestinations.Text = "Хранилища (снимите галочку, чтобы сделать недоступным):";
            // 
            // clbDestinations
            // 
            this.clbDestinations.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clbDestinations.CheckOnClick = true;
            this.clbDestinations.FormattingEnabled = true;
            this.clbDestinations.Location = new System.Drawing.Point(14, 238);
            this.clbDestinations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clbDestinations.Name = "clbDestinations";
            this.clbDestinations.Size = new System.Drawing.Size(349, 100);
            this.clbDestinations.TabIndex = 4;
            this.clbDestinations.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbDestinations_ItemCheck);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackup.Location = new System.Drawing.Point(385, 238);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(295, 47);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "Выполнить резервное копирование";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResults.Location = new System.Drawing.Point(14, 358);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(229, 15);
            this.lblResults.TabIndex = 6;
            this.lblResults.Text = "Результаты резервного копирования:";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDestination,
            this.colId,
            this.colMessage});
            this.dgvResults.Location = new System.Drawing.Point(14, 380);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.Size = new System.Drawing.Size(995, 127);
            this.dgvResults.TabIndex = 7;
            // 
            // colDestination
            // 
            this.colDestination.HeaderText = "Хранилище";
            this.colDestination.Name = "colDestination";
            this.colDestination.ReadOnly = true;
            this.colDestination.Width = 200;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id / статус";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 300;
            // 
            // colMessage
            // 
            this.colMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMessage.HeaderText = "Сообщение";
            this.colMessage.Name = "colMessage";
            this.colMessage.ReadOnly = true;
            // 
            // grpRestore
            // 
            this.grpRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRestore.Controls.Add(this.lblDestSelect);
            this.grpRestore.Controls.Add(this.cmbDestinations);
            this.grpRestore.Controls.Add(this.lblIdSelect);
            this.grpRestore.Controls.Add(this.txtRestoreId);
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.lblRestoredData);
            this.grpRestore.Controls.Add(this.txtRestoredData);
            this.grpRestore.Location = new System.Drawing.Point(14, 526);
            this.grpRestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpRestore.Size = new System.Drawing.Size(995, 219);
            this.grpRestore.TabIndex = 8;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "Восстановление";
            // 
            // lblDestSelect
            // 
            this.lblDestSelect.AutoSize = true;
            this.lblDestSelect.Location = new System.Drawing.Point(18, 35);
            this.lblDestSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestSelect.Name = "lblDestSelect";
            this.lblDestSelect.Size = new System.Drawing.Size(76, 15);
            this.lblDestSelect.TabIndex = 0;
            this.lblDestSelect.Text = "Хранилище:";
            // 
            // cmbDestinations
            // 
            this.cmbDestinations.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbDestinations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinations.FormattingEnabled = true;
            this.cmbDestinations.Location = new System.Drawing.Point(117, 31);
            this.cmbDestinations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDestinations.Name = "cmbDestinations";
            this.cmbDestinations.Size = new System.Drawing.Size(256, 23);
            this.cmbDestinations.TabIndex = 1;
            // 
            // lblIdSelect
            // 
            this.lblIdSelect.AutoSize = true;
            this.lblIdSelect.Location = new System.Drawing.Point(397, 35);
            this.lblIdSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdSelect.Name = "lblIdSelect";
            this.lblIdSelect.Size = new System.Drawing.Size(63, 15);
            this.lblIdSelect.TabIndex = 2;
            this.lblIdSelect.Text = "Id бэкапа:";
            // 
            // txtRestoreId
            // 
            this.txtRestoreId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRestoreId.Location = new System.Drawing.Point(467, 31);
            this.txtRestoreId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRestoreId.Name = "txtRestoreId";
            this.txtRestoreId.Size = new System.Drawing.Size(303, 21);
            this.txtRestoreId.TabIndex = 3;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestore.Location = new System.Drawing.Point(793, 29);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(179, 26);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Восстановить";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblRestoredData
            // 
            this.lblRestoredData.AutoSize = true;
            this.lblRestoredData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRestoredData.Location = new System.Drawing.Point(18, 75);
            this.lblRestoredData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestoredData.Name = "lblRestoredData";
            this.lblRestoredData.Size = new System.Drawing.Size(163, 15);
            this.lblRestoredData.TabIndex = 5;
            this.lblRestoredData.Text = "Восстановленные данные:";
            // 
            // txtRestoredData
            // 
            this.txtRestoredData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRestoredData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRestoredData.Location = new System.Drawing.Point(18, 97);
            this.txtRestoredData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRestoredData.Multiline = true;
            this.txtRestoredData.Name = "txtRestoredData";
            this.txtRestoredData.ReadOnly = true;
            this.txtRestoredData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRestoredData.Size = new System.Drawing.Size(954, 100);
            this.txtRestoredData.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1023, 759);
            this.Controls.Add(this.grpRestore);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.clbDestinations);
            this.Controls.Add(this.lblDestinations);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(814, 571);
            this.Name = "Form1";
            this.Text = "Система резервного копирования";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

