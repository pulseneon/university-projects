using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace forTable
{
    enum DefaultRows
    {
        Family,
        Name,
        Phone,
        Order,
        Booking
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            typeSortComboBox.SelectedIndex = 0;
            methodSortComboBox.SelectedIndex = 0;
            fieldSortComboBox.SelectedIndex = 0;
            labelLog.Text = "";
            dataGridShow.EnableHeadersVisualStyles = false;
        }

        DataTable dt = new DataTable();
        bool debugMode = false;


        protected List<long> timeList = new List<long>();
        protected List<int> itterList = new List<int>();
        protected List<int> comparList = new List<int>();

        private void loadTableBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Table files| *.csv; *.txt;";
            if (ofd.ShowDialog() == DialogResult.OK)
                fillDataGrid(ofd.FileName);
        }

        private void fillDataGrid(string filePath)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    string firstLine = lines[0];
                    string[] headersLabel = firstLine.Split(',');
                    foreach (string headerWord in headersLabel)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }

                    for (int i = 1; i < lines.Length; i++)
                    {
                        DataRow dr = dt.NewRow();
                        int colomnIndex = 0;
                        string[] dataWords = lines[i].Split(',');
                        foreach (string headerWord in headersLabel)
                        {
                            dr[headerWord] = dataWords[colomnIndex++];
                        }

                        dt.Rows.Add(dr);
                    }
                }
                else
                {
                    MessageBox.Show("Возникла ошибка:\n\nПустая таблица");
                }

                if (dt.Rows.Count > 0)
                {
                    dataGridShow.DataSource = dt;
                    sortButton.Enabled = true;
                }
                disibleSort();
                clearHead();
                clearTableBtn.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла ошибка:\n\n" + e.ToString());
            }
        }

        private void disibleSort()
        {
            foreach (DataGridViewColumn column in dataGridShow.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void clearHead()
        {
            for (int i = 0; i < dataGridShow.Columns.Count; i++)
            {
                dataGridShow.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
            }
        }

        private void setLog()
        {
            labelLog.Text = "";
        }

        private void setLog(string log)
        {
            labelLog.Text = log;
        }

        private void clearTableBtn_Click(object sender, EventArgs e)
        {
            clearTable();   
        }

        private void clearTable()
        {
            ((DataTable)dataGridShow.DataSource).Clear();
            dt.Columns.Clear();
            dt.Rows.Clear();
            dataGridShow.Columns.Clear();
            sortButton.Enabled = false;
            clearTableBtn.Enabled = false;

            timeList.Clear();
            itterList.Clear();
            comparList.Clear();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            try
            {
                Sorting sort = new Sorting();
                clearHead();
                bool isIncrease;
                int sortField;
                if (typeSortComboBox.Text == "По возрастанию")
                    isIncrease = true;
                else
                    isIncrease = false;

                if (debugMode)
                {
                    sortButton.Enabled = false;
                    demCheckBox.Enabled = false;
                }

                switch (fieldSortComboBox.Text)
                {
                    case "Фамилия":
                        sortField = (int)DefaultRows.Family;
                        break;
                    case "Имя":
                        sortField = (int)DefaultRows.Name;
                        break;
                    case "Телефон":
                        sortField = (int)DefaultRows.Phone;
                        break;
                    case "Номер заказа":
                        sortField = (int)DefaultRows.Order;
                        break;
                    case "Всего заказов":
                        sortField = (int)DefaultRows.Booking;
                        break;
                    default:
                        sortField = 0;
                        break;
                }
                switch (methodSortComboBox.Text)
                {
                    case "Метод линейного выбора":
                        if (sortField == 0)
                        {
                            if (isIncrease)
                                Task.Run(async () => { await sort.sortByChoiceIncreaceStr(dataGridShow, 0, debugMode); }).Wait();
                            else
                                Task.Run(async () => { await sort.sortByChoiceStr(dataGridShow, 0, debugMode); }).Wait();
                            dataGridShow.Columns[0].HeaderCell.Style.BackColor = Color.LightCyan;
                            setLog("Отсортровано по фамилии (по возрастанию: " + isIncrease.ToString() + ")");
                        }
                        if (sortField == 1)
                        {
                            if (isIncrease)
                                Task.Run(async () => { await sort.sortByChoiceIncreaceStr(dataGridShow, 1, debugMode); }).Wait();
                            
                            else
                                Task.Run(async () => { await sort.sortByChoiceStr(dataGridShow, 1, debugMode); }).Wait();
                            dataGridShow.Columns[1].HeaderCell.Style.BackColor = Color.LightCyan;
                            setLog("Отсортровано по имени (по возрастанию: " + isIncrease.ToString() + ")");
                        }
                        if (sortField == 2)
                        {
                            if (isIncrease)
                                Task.Run(async () => { await sort.sortByChoiceIncreaceInt(dataGridShow, 2, debugMode); }).Wait();
                            else
                            {
                                Task.Run(async () => { await sort.sortByChoiceInt(dataGridShow, 2, debugMode); }).Wait();
                            }
                            dataGridShow.Columns[2].HeaderCell.Style.BackColor = Color.LightCyan;
                        }
                        if (sortField == 3)
                        {
                            if (isIncrease)
                                Task.Run(async () => { await sort.sortByChoiceIncreaceInt(dataGridShow, 3, debugMode); }).Wait();
                            else
                                Task.Run(async () => { await sort.sortByChoiceInt(dataGridShow, 3, debugMode); }).Wait();
                            dataGridShow.Columns[3].HeaderCell.Style.BackColor = Color.LightCyan;
                            setLog("Отсортровано по номеру заказа (по возрастанию: " + isIncrease.ToString() + ")");
                        }
                        if (sortField == 4)
                        {
                            if (isIncrease)
                                Task.Run(async () => { await sort.sortByChoiceIncreaceInt(dataGridShow, 4, debugMode); }).Wait();
                            else
                                Task.Run(async () => { await sort.sortByChoiceInt(dataGridShow, 4, debugMode); }).Wait();
                            dataGridShow.Columns[4].HeaderCell.Style.BackColor = Color.LightCyan;
                            setLog("Отсортровано по всего заказам (по возрастанию: " + isIncrease.ToString() + ")");
                        }
                        break;
                    case "Метод линейного выбора с подсчетом":
                        if (sortField == 3)
                        {
                            sort.sortCounter(dataGridShow, 3);
                            dataGridShow.Columns[3].HeaderCell.Style.BackColor = Color.LightCyan;
                            setLog("Отсортровано по номеру заказа по возрастанию");
                        }
                        if (sortField == 4)
                        {
                            sort.sortCounter(dataGridShow, 4);
                            dataGridShow.Columns[4].HeaderCell.Style.BackColor = Color.LightCyan;
                            setLog("Отсортровано по всего заказов по возрастанию");
                        }
                        break;
                }
                timeList.Add(sort.timeList[0]);
                itterList.Add(sort.itterList[0]);
                comparList.Add(sort.comparList[0]);

                updateStats();
                updateResult();

                if (debugMode)
                {
                    sortButton.Enabled = true;
                    demCheckBox.Enabled = true;
                }
            }
            catch(Exception exception)
            {
            }
        }
        protected void updateResult()
        {
            if (!resultGroupBox.Visible)
            {
                resultGroupBox.Visible = true;
            }

            timeLabel.Text = timeList.Last().ToString() + " милисекунд";
            itterLabel.Text = itterList.Last().ToString() + " иттераций";
            comparLabel.Text = comparList.Last().ToString() + " сравнений";
        }

        public void updateStats()
        {
            if (!statsGroupBox.Visible)
                statsGroupBox.Visible = true;

            double middleTime = 0;
            double middleItter = 0;
            double middleCompar = 0;

            for (int i = 0; i < timeList.Count; i++)
            {
                middleTime += timeList[i];
                middleItter += itterList[i];
                middleCompar += comparList[i];
            }

            statsTimeLabel.Text = Math.Round(middleTime / timeList.Count, 2) + " милисекунд";
            statsItterLabel.Text = Math.Round(middleItter / itterList.Count, 2) + " иттераций";
            statsComparLabel.Text = Math.Round(middleCompar / comparList.Count, 2) + " сравнений";
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpText = "ИНСТРУКЦИЯ\n\n1. Запустите программу\n2. Выберите таблицу\n3. Выберите настройки сортировки\n4. Сортируйте";
            MessageBox.Show(helpText);
        }

        private void открытьЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpText = "Метод линейного выбора и метод линейного выбора с подсчетом.";
            MessageBox.Show(helpText);
        }

        private void methodSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (methodSortComboBox.SelectedIndex == 0)
            {
                typeSortComboBox.Enabled = true;
                fieldSortComboBox.Items.Clear();
                fieldSortComboBox.Items.Add("Фамилия");
                fieldSortComboBox.Items.Add("Имя");
                fieldSortComboBox.Items.Add("Телефон");
                fieldSortComboBox.Items.Add("Номер заказа");
                fieldSortComboBox.Items.Add("Всего заказов");
                fieldSortComboBox.SelectedIndex = 0;
            }
            if (methodSortComboBox.SelectedIndex == 1)
            {
                typeSortComboBox.Enabled = false;
                fieldSortComboBox.Items.Clear();
                fieldSortComboBox.Items.Add("Номер заказа");
                fieldSortComboBox.Items.Add("Всего заказов");
                fieldSortComboBox.SelectedIndex = 0;
            }
        }
        private void demCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (demCheckBox.Checked)
            {
                debugMode = true;
                setLog("режим демонтрации включен");
                methodSortComboBox.Enabled = false;
                methodSortComboBox.SelectedIndex = 0;
            }
            else
            {
                debugMode = false;
                setLog("режим демонтрации выключен");
                methodSortComboBox.Enabled = true;
            }
        }

        private void ручнойВводТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridShow.Rows.Count != 0)
                    clearTable();
                setLog("Включен ручной ввод");
                dt.Columns.Add("Фамилия", typeof(string));
                dt.Columns.Add("Имя", typeof(string));
                dt.Columns.Add("Телефон", typeof(long));
                dt.Columns.Add("Номер заказа", typeof(int));
                dt.Columns.Add("Заказов всего", typeof(int));
                
                String userRows = Microsoft.VisualBasic.Interaction.InputBox("Укажите количество строк в таблице: ", "Заполнение таблицы", "", 700, 300);

                for (int i = 0; i < Convert.ToInt32(userRows); i++)
                {
                    DataRow dr = dt.NewRow();
                    String tabFam = Microsoft.VisualBasic.Interaction.InputBox(i + ". Фамилия: ", "Заполнение таблицы", "", 700, 300);
                    String tabName = Microsoft.VisualBasic.Interaction.InputBox(i + ". Имя: ", "Заполнение таблицы", "", 700, 300);
                    String tabPhone = Microsoft.VisualBasic.Interaction.InputBox(i + ". Телефон: ", "Заполнение таблицы", "", 700, 300);
                    String tabId = Microsoft.VisualBasic.Interaction.InputBox(i + ". Номер заказа: ", "Заполнение таблицы", "", 700, 300);
                    String tabBook = Microsoft.VisualBasic.Interaction.InputBox(i + ". Всего заказов: ", "Заполнение таблицы", "", 700, 300);

                    dr[0] = tabFam;
                    dr[1] = tabName;
                    dr[2] = Convert.ToInt64(tabPhone);
                    dr[3] = Convert.ToInt32(tabId);
                    dr[4] = Convert.ToInt32(tabBook);

                    dt.Rows.Add(dr);
                }

                dataGridShow.DataSource = dt;
                sortButton.Enabled = true;
                clearTableBtn.Enabled = true;
                clearHead();
                disibleSort();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
