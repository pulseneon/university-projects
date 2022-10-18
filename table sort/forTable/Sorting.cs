using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forTable
{
    public partial class Sorting : Form1
    {
        public async Task sortByChoiceInt(DataGridView dataGridShow, int cell, bool dm)
        {
            int delay = 0;
            if (dm)
                delay = 700;

            Stopwatch stopwatch = new Stopwatch();
            int itter = 0;
            int compar = 0;

            stopwatch.Start();

            for (int i = 0; i < dataGridShow.Rows.Count - 1; ++i)
            {
                int min = i;
                for (int j = i + 1; j < dataGridShow.Rows.Count; ++j)
                {
                    if (dm)
                    {
                        for (int k = 0; k < dataGridShow.Rows.Count; k++)
                        {
                            dataGridShow.Rows[k].Cells[cell].Style.BackColor = Color.White;
                        }

                        dataGridShow.Rows[j].Cells[cell].Style.BackColor = Color.LightGoldenrodYellow;
                        dataGridShow.Rows[min].Cells[cell].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    await Task.Delay(delay);
                    if (Convert.ToInt64(dataGridShow.Rows[j].Cells[cell].Value).CompareTo(Convert.ToInt64(dataGridShow.Rows[min].Cells[cell].Value)) > 0)
                    {
                        if (dm) 
                        {
                            dataGridShow.Rows[j].Cells[cell].Style.BackColor = Color.Red;
                            dataGridShow.Rows[min].Cells[cell].Style.BackColor = Color.Red;
                        }
                        await Task.Delay(delay);
                        min = j;
                        compar++;
                    }

                    itter++;
                }

                for (int k = 0; k < dataGridShow.Columns.Count; k++)
                {
                    string temp = dataGridShow.Rows[i].Cells[k].Value.ToString();
                    dataGridShow.Rows[i].Cells[k].Value = dataGridShow.Rows[min].Cells[k].Value.ToString();
                    dataGridShow.Rows[min].Cells[k].Value = temp;
                }
                itter++;
            }

            stopwatch.Stop();
            long time = stopwatch.ElapsedMilliseconds;
            timeList.Add(time);
            itterList.Add(itter);
            comparList.Add(compar);

            for (int k = 0; k < dataGridShow.Rows.Count; k++)
            {
                dataGridShow.Rows[k].Cells[cell].Style.BackColor = Color.White;
            }
            return;
        }
        public async Task sortByChoiceIncreaceInt(DataGridView dataGridShow, int cell, bool dm)
        {
            int delay = 0;
            if (dm)
                delay = 700;

            Stopwatch stopwatch = new Stopwatch();
            int itter = 0;
            int compar = 0;

            stopwatch.Start();
            for (int i = 0; i < dataGridShow.Rows.Count - 1; ++i)
            {
                int min = i;
                for (int j = i + 1; j < dataGridShow.Rows.Count; ++j)
                {
                    if (dm)
                    {
                        for (int k = 0; k < dataGridShow.Rows.Count; k++)
                        {
                            dataGridShow.Rows[k].Cells[cell].Style.BackColor = Color.White;
                        }

                        dataGridShow.Rows[j].Cells[cell].Style.BackColor = Color.LightGoldenrodYellow;
                        dataGridShow.Rows[min].Cells[cell].Style.BackColor = Color.LightGoldenrodYellow;
                    }

                    await Task.Delay(delay);
                    if (Convert.ToInt64(dataGridShow.Rows[j].Cells[cell].Value).CompareTo(Convert.ToInt64(dataGridShow.Rows[min].Cells[cell].Value)) < 0)
                    {
                        if (dm)
                        {
                            dataGridShow.Rows[j].Cells[cell].Style.BackColor = Color.Red;
                            dataGridShow.Rows[min].Cells[cell].Style.BackColor = Color.Red;
                        }
                        await Task.Delay(delay);
                        min = j;
                        compar++;
                    }
                    itter++;
                }

                for (int k = 0; k < dataGridShow.Columns.Count; k++)
                {
                    string temp = dataGridShow.Rows[i].Cells[k].Value.ToString();
                    dataGridShow.Rows[i].Cells[k].Value = dataGridShow.Rows[min].Cells[k].Value.ToString();
                    dataGridShow.Rows[min].Cells[k].Value = temp;
                }
                itter++;
            }

            stopwatch.Stop();
            long time = stopwatch.ElapsedMilliseconds;
            timeList.Add(time);
            itterList.Add(itter);
            comparList.Add(compar);

            for (int k = 0; k < dataGridShow.Rows.Count; k++)
            {
                dataGridShow.Rows[k].Cells[cell].Style.BackColor = Color.White;
            }
            return;
        }

        public async Task sortByChoiceStr(DataGridView dataGridShow, int cell, bool dm)
        {
            int delay = 0;
            if (dm)
                delay = 700;

            Stopwatch stopwatch = new Stopwatch();
            int itter = 0;
            int compar = 0;

            stopwatch.Start();
            for (int i = 0; i < dataGridShow.Rows.Count - 1; ++i)
            {
                int min = i;
                for (int j = i + 1; j < dataGridShow.Rows.Count; ++j)
                {
                    if (dm)
                    {
                        for (int k = 0; k < dataGridShow.Rows.Count; k++)
                        {
                            dataGridShow.Rows[k].Cells[cell].Style.BackColor = Color.White;
                        }

                        dataGridShow.Rows[j].Cells[cell].Style.BackColor = Color.LightGoldenrodYellow;
                        dataGridShow.Rows[min].Cells[cell].Style.BackColor = Color.LightGoldenrodYellow;
                    }

                    await Task.Delay(delay);
                    if (dataGridShow.Rows[j].Cells[cell].Value.ToString().CompareTo(dataGridShow.Rows[min].Cells[cell].Value.ToString()) > 0)
                    {
                        if (dm)
                        {
                            dataGridShow.Rows[j].Cells[cell].Style.BackColor = Color.Red;
                            dataGridShow.Rows[min].Cells[cell].Style.BackColor = Color.Red;
                        }
                        await Task.Delay(delay);
                        min = j;
                        compar++;
                    }

                    itter++;
                }

                for (int k = 0; k < dataGridShow.Columns.Count; k++)
                {
                    string temp = dataGridShow.Rows[i].Cells[k].Value.ToString();
                    dataGridShow.Rows[i].Cells[k].Value = dataGridShow.Rows[min].Cells[k].Value.ToString();
                    dataGridShow.Rows[min].Cells[k].Value = temp;
                }
                itter++;
            }
            stopwatch.Stop();
            long time = stopwatch.ElapsedMilliseconds;
            timeList.Add(time);
            itterList.Add(itter);
            comparList.Add(compar);


            for (int k = 0; k < dataGridShow.Rows.Count; k++)
            {
                dataGridShow.Rows[k].Cells[cell].Style.BackColor = Color.White;
            }
            return;
        }

        public async Task sortByChoiceIncreaceStr(DataGridView dataGridShow, int cell, bool dm)
        {
            int delay = 0;
            if (dm)
                delay = 700;

            Stopwatch stopwatch = new Stopwatch();
            int itter = 0;
            int compar = 0;

            stopwatch.Start();
            for (int i = 0; i < dataGridShow.Rows.Count - 1; ++i)
            {
                int min = i;
                for (int j = i + 1; j < dataGridShow.Rows.Count; ++j)
                {
                    if (dm)
                    {
                        for (int k = 0; k < dataGridShow.Rows.Count; k++)
                        {
                            dataGridShow.Rows[k].Cells[cell].Style.BackColor = Color.White;
                        }

                        dataGridShow.Rows[j].Cells[cell].Style.BackColor = Color.LightGoldenrodYellow;
                        dataGridShow.Rows[min].Cells[cell].Style.BackColor = Color.LightGoldenrodYellow;
                    }

                    await Task.Delay(delay);
                    if (dataGridShow.Rows[j].Cells[cell].Value.ToString().CompareTo(dataGridShow.Rows[min].Cells[cell].Value.ToString()) < 0)
                    {
                        if (dm)
                        {
                            dataGridShow.Rows[j].Cells[cell].Style.BackColor = Color.Red;
                            dataGridShow.Rows[min].Cells[cell].Style.BackColor = Color.Red;
                        }
                        await Task.Delay(delay);
                        min = j;
                        compar++;
                    }
                    itter++;
                }


                for (int k = 0; k < dataGridShow.Columns.Count; k++)
                {
                    string temp = dataGridShow.Rows[i].Cells[k].Value.ToString();
                    dataGridShow.Rows[i].Cells[k].Value = dataGridShow.Rows[min].Cells[k].Value.ToString();
                    dataGridShow.Rows[min].Cells[k].Value = temp;
                }
                itter++;
            }

            stopwatch.Stop();
            long time = stopwatch.ElapsedMilliseconds;
            timeList.Add(time);
            itterList.Add(itter);
            comparList.Add(compar);
        }

        public void sortCounter(DataGridView dataGridShow, int cell)
        {
            Stopwatch stopwatch = new Stopwatch();
            int itter = 0;
            int compar = 0;

            stopwatch.Start();

            int length = dataGridShow.Rows.Count;
            int height = dataGridShow.Columns.Count;
            object[,] outputData = new object[length, height];
            int[] count = new int[100];

            for (int i = 0; i < 100; ++i)
            {
                count[i] = 0;
            }
            for (int i = 0; i < length; ++i)
            {
                ++count[Convert.ToInt32(dataGridShow.Rows[i].Cells[cell].Value)];
                itter++;
            }

            for (int i = 1; i <= 99; ++i)
            {
                count[i] += count[i - 1];
            }

            for (int i = length - 1; i >= 0; i--)
            {
                outputData[count[Convert.ToInt32(dataGridShow.Rows[i].Cells[cell].Value)] - 1, 0] = dataGridShow.Rows[i].Cells[0].Value.ToString();
                outputData[count[Convert.ToInt32(dataGridShow.Rows[i].Cells[cell].Value)] - 1, 1] = dataGridShow.Rows[i].Cells[1].Value.ToString();
                outputData[count[Convert.ToInt32(dataGridShow.Rows[i].Cells[cell].Value)] - 1, 2] = Convert.ToInt64(dataGridShow.Rows[i].Cells[2].Value);
                outputData[count[Convert.ToInt32(dataGridShow.Rows[i].Cells[cell].Value)] - 1, 3] = Convert.ToInt32(dataGridShow.Rows[i].Cells[3].Value);
                outputData[count[Convert.ToInt32(dataGridShow.Rows[i].Cells[cell].Value)] - 1, 4] = Convert.ToInt32(dataGridShow.Rows[i].Cells[4].Value);
                --count[Convert.ToInt32(dataGridShow.Rows[i].Cells[cell].Value)];
                itter++;
            }

            for (int i = 0; i < length; ++i)
            {
                for (int k = 0; k < dataGridShow.Columns.Count; k++)
                {
                    dataGridShow.Rows[i].Cells[k].Value = outputData[i, k];
                }
                itter++;
            }

            stopwatch.Stop();
            long time = stopwatch.ElapsedMilliseconds;
            timeList.Add(time);
            itterList.Add(itter);
            comparList.Add(compar);
        }
    }

}