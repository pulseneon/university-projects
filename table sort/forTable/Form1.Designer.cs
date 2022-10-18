
namespace forTable
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
            this.dataGridShow = new System.Windows.Forms.DataGridView();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.demCheckBox = new System.Windows.Forms.CheckBox();
            this.fieldSortComboBox = new System.Windows.Forms.ComboBox();
            this.methodSortComboBox = new System.Windows.Forms.ComboBox();
            this.infoText = new System.Windows.Forms.Label();
            this.typeSortComboBox = new System.Windows.Forms.ComboBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.clearTableBtn = new System.Windows.Forms.Button();
            this.loadTableBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.comparLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itterLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.statsComparLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statsItterLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statsTimeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.ручнойВводТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShow)).BeginInit();
            this.menuGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridShow
            // 
            this.dataGridShow.AllowUserToAddRows = false;
            this.dataGridShow.AllowUserToDeleteRows = false;
            this.dataGridShow.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridShow.Location = new System.Drawing.Point(0, 19);
            this.dataGridShow.Name = "dataGridShow";
            this.dataGridShow.ReadOnly = true;
            this.dataGridShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridShow.Size = new System.Drawing.Size(919, 582);
            this.dataGridShow.TabIndex = 0;
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.demCheckBox);
            this.menuGroupBox.Controls.Add(this.fieldSortComboBox);
            this.menuGroupBox.Controls.Add(this.methodSortComboBox);
            this.menuGroupBox.Controls.Add(this.infoText);
            this.menuGroupBox.Controls.Add(this.typeSortComboBox);
            this.menuGroupBox.Controls.Add(this.sortButton);
            this.menuGroupBox.Controls.Add(this.clearTableBtn);
            this.menuGroupBox.Controls.Add(this.loadTableBtn);
            this.menuGroupBox.Location = new System.Drawing.Point(12, 27);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(221, 264);
            this.menuGroupBox.TabIndex = 2;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Настройки";
            // 
            // demCheckBox
            // 
            this.demCheckBox.AutoSize = true;
            this.demCheckBox.Location = new System.Drawing.Point(6, 192);
            this.demCheckBox.Name = "demCheckBox";
            this.demCheckBox.Size = new System.Drawing.Size(137, 17);
            this.demCheckBox.TabIndex = 8;
            this.demCheckBox.Text = "Режим демонстрации";
            this.demCheckBox.UseVisualStyleBackColor = true;
            this.demCheckBox.CheckedChanged += new System.EventHandler(this.demCheckBox_CheckedChanged);
            // 
            // fieldSortComboBox
            // 
            this.fieldSortComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Фамилия",
            "Имя",
            "Телефон",
            "Номер заказа",
            "Заказов всего"});
            this.fieldSortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldSortComboBox.FormattingEnabled = true;
            this.fieldSortComboBox.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Телефон",
            "Номер заказа",
            "Всего заказов"});
            this.fieldSortComboBox.Location = new System.Drawing.Point(6, 165);
            this.fieldSortComboBox.Name = "fieldSortComboBox";
            this.fieldSortComboBox.Size = new System.Drawing.Size(209, 21);
            this.fieldSortComboBox.TabIndex = 6;
            // 
            // methodSortComboBox
            // 
            this.methodSortComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Метод линейного выбора",
            "Метод линейного выбора с подсчетом"});
            this.methodSortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodSortComboBox.FormattingEnabled = true;
            this.methodSortComboBox.Items.AddRange(new object[] {
            "Метод линейного выбора",
            "Метод линейного выбора с подсчетом"});
            this.methodSortComboBox.Location = new System.Drawing.Point(6, 111);
            this.methodSortComboBox.Name = "methodSortComboBox";
            this.methodSortComboBox.Size = new System.Drawing.Size(209, 21);
            this.methodSortComboBox.TabIndex = 5;
            this.methodSortComboBox.SelectedIndexChanged += new System.EventHandler(this.methodSortComboBox_SelectedIndexChanged);
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Location = new System.Drawing.Point(6, 95);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(128, 13);
            this.infoText.TabIndex = 4;
            this.infoText.Text = "Параметры сортировки";
            // 
            // typeSortComboBox
            // 
            this.typeSortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSortComboBox.FormattingEnabled = true;
            this.typeSortComboBox.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.typeSortComboBox.Location = new System.Drawing.Point(6, 138);
            this.typeSortComboBox.Name = "typeSortComboBox";
            this.typeSortComboBox.Size = new System.Drawing.Size(209, 21);
            this.typeSortComboBox.TabIndex = 3;
            // 
            // sortButton
            // 
            this.sortButton.Enabled = false;
            this.sortButton.Location = new System.Drawing.Point(6, 230);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(209, 28);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Сортировать";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // clearTableBtn
            // 
            this.clearTableBtn.Enabled = false;
            this.clearTableBtn.Location = new System.Drawing.Point(6, 53);
            this.clearTableBtn.Name = "clearTableBtn";
            this.clearTableBtn.Size = new System.Drawing.Size(209, 28);
            this.clearTableBtn.TabIndex = 1;
            this.clearTableBtn.Text = "Очистить таблицу";
            this.clearTableBtn.UseVisualStyleBackColor = true;
            this.clearTableBtn.Click += new System.EventHandler(this.clearTableBtn_Click);
            // 
            // loadTableBtn
            // 
            this.loadTableBtn.Location = new System.Drawing.Point(6, 19);
            this.loadTableBtn.Name = "loadTableBtn";
            this.loadTableBtn.Size = new System.Drawing.Size(209, 28);
            this.loadTableBtn.TabIndex = 0;
            this.loadTableBtn.Text = "Загрузить таблицу";
            this.loadTableBtn.UseVisualStyleBackColor = true;
            this.loadTableBtn.Click += new System.EventHandler(this.loadTableBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logLabel);
            this.groupBox1.Controls.Add(this.dataGridShow);
            this.groupBox1.Location = new System.Drawing.Point(239, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 602);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(6, 604);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(0, 13);
            this.logLabel.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ручнойВводТаблицыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьЗаданиеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьЗаданиеToolStripMenuItem
            // 
            this.открытьЗаданиеToolStripMenuItem.Name = "открытьЗаданиеToolStripMenuItem";
            this.открытьЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьЗаданиеToolStripMenuItem.Text = "Открыть задание";
            this.открытьЗаданиеToolStripMenuItem.Click += new System.EventHandler(this.открытьЗаданиеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.comparLabel);
            this.resultGroupBox.Controls.Add(this.label5);
            this.resultGroupBox.Controls.Add(this.itterLabel);
            this.resultGroupBox.Controls.Add(this.label3);
            this.resultGroupBox.Controls.Add(this.timeLabel);
            this.resultGroupBox.Controls.Add(this.label1);
            this.resultGroupBox.Location = new System.Drawing.Point(12, 362);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(221, 130);
            this.resultGroupBox.TabIndex = 6;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Результат";
            this.resultGroupBox.Visible = false;
            // 
            // comparLabel
            // 
            this.comparLabel.AutoSize = true;
            this.comparLabel.Location = new System.Drawing.Point(6, 106);
            this.comparLabel.Name = "comparLabel";
            this.comparLabel.Size = new System.Drawing.Size(62, 13);
            this.comparLabel.TabIndex = 5;
            this.comparLabel.Text = "Сравнений";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество сравнений:";
            // 
            // itterLabel
            // 
            this.itterLabel.AutoSize = true;
            this.itterLabel.Location = new System.Drawing.Point(6, 67);
            this.itterLabel.Name = "itterLabel";
            this.itterLabel.Size = new System.Drawing.Size(61, 13);
            this.itterLabel.TabIndex = 3;
            this.itterLabel.Text = "Иттераций";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Иттераций сортировки:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(6, 29);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(40, 13);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Время";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время затраченное на сортировку: ";
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.statsComparLabel);
            this.statsGroupBox.Controls.Add(this.label4);
            this.statsGroupBox.Controls.Add(this.statsItterLabel);
            this.statsGroupBox.Controls.Add(this.label7);
            this.statsGroupBox.Controls.Add(this.statsTimeLabel);
            this.statsGroupBox.Controls.Add(this.label9);
            this.statsGroupBox.Location = new System.Drawing.Point(12, 498);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(221, 130);
            this.statsGroupBox.TabIndex = 7;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Статистика";
            this.statsGroupBox.Visible = false;
            // 
            // statsComparLabel
            // 
            this.statsComparLabel.AutoSize = true;
            this.statsComparLabel.Location = new System.Drawing.Point(6, 106);
            this.statsComparLabel.Name = "statsComparLabel";
            this.statsComparLabel.Size = new System.Drawing.Size(62, 13);
            this.statsComparLabel.TabIndex = 5;
            this.statsComparLabel.Text = "Сравнений";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Среднее кол-во сравнений:";
            // 
            // statsItterLabel
            // 
            this.statsItterLabel.AutoSize = true;
            this.statsItterLabel.Location = new System.Drawing.Point(6, 67);
            this.statsItterLabel.Name = "statsItterLabel";
            this.statsItterLabel.Size = new System.Drawing.Size(61, 13);
            this.statsItterLabel.TabIndex = 3;
            this.statsItterLabel.Text = "Иттераций";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Среднее кол-во иттераций:";
            // 
            // statsTimeLabel
            // 
            this.statsTimeLabel.AutoSize = true;
            this.statsTimeLabel.Location = new System.Drawing.Point(6, 29);
            this.statsTimeLabel.Name = "statsTimeLabel";
            this.statsTimeLabel.Size = new System.Drawing.Size(40, 13);
            this.statsTimeLabel.TabIndex = 1;
            this.statsTimeLabel.Text = "Время";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Среднее время на сортировку:";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(239, 636);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(46, 13);
            this.labelLog.TabIndex = 8;
            this.labelLog.Text = "log label";
            // 
            // ручнойВводТаблицыToolStripMenuItem
            // 
            this.ручнойВводТаблицыToolStripMenuItem.Name = "ручнойВводТаблицыToolStripMenuItem";
            this.ручнойВводТаблицыToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.ручнойВводТаблицыToolStripMenuItem.Text = "Ручной ввод таблицы";
            this.ручнойВводТаблицыToolStripMenuItem.Click += new System.EventHandler(this.ручнойВводТаблицыToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1170, 661);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.statsGroupBox);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка таблиц";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShow)).EndInit();
            this.menuGroupBox.ResumeLayout(false);
            this.menuGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridShow;
        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.Button loadTableBtn;
        private System.Windows.Forms.Button clearTableBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ComboBox typeSortComboBox;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.ComboBox methodSortComboBox;
        private System.Windows.Forms.ToolStripMenuItem открытьЗаданиеToolStripMenuItem;
        private System.Windows.Forms.ComboBox fieldSortComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label logLabel;
        protected System.Windows.Forms.Label comparLabel;
        protected System.Windows.Forms.Label itterLabel;
        protected System.Windows.Forms.Label timeLabel;
        protected System.Windows.Forms.Label statsComparLabel;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label statsItterLabel;
        protected internal System.Windows.Forms.Label statsTimeLabel;
        protected System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.GroupBox resultGroupBox;
        protected System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.CheckBox demCheckBox;
        private System.Windows.Forms.ToolStripMenuItem ручнойВводТаблицыToolStripMenuItem;
    }
}

