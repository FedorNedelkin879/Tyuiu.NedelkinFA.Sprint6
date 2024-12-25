using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NedelkinFA.Sprint6.Task7.V30.Lib;
namespace Tyuiu.NedelkinFA.Sprint6.Task7.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string openFilePath = "";
        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            {
                openFileDialogTask.ShowDialog();
                this.openFilePath = openFileDialogTask.FileName;
                if (openFilePath == "")
                {
                    MessageBox.Show("Файл не был выбран", "Ошибка");
                }
                else
                {
                    MessageBox.Show($"Файл {openFilePath} открыт успешно", "Открытие");


                    int[,] matrix = ds.ReadCsvToIntArray(openFilePath);
                    inputGrid.ColumnCount = matrix.GetLength(1);
                    inputGrid.RowCount = matrix.GetLength(0);
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            inputGrid.Rows[i].Cells[j].Value = matrix[i, j];
                        }
                    }


                    groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialogTask.FileName;
                    buttonRun.Enabled = true;
                }
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[inputGrid.RowCount, inputGrid.ColumnCount];
            for (int i = 0; i < inputGrid.RowCount; i++)
            {
                for (int j = 0; j < inputGrid.ColumnCount; j++)
                {
                    matrix[i, j] = Convert.ToInt32(inputGrid.Rows[i].Cells[j].Value);
                }
            }

            try
            {
                int[,] matrix_res = ds.GetMatrix(openFilePath);
                resultBox.ColumnCount = matrix_res.GetLength(1);
                resultBox.RowCount = matrix_res.GetLength(0);
                for (int i = 0; i < matrix_res.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix_res.GetLength(1); j++)
                    {
                        resultBox.Rows[i].Cells[j].Value = matrix_res[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так.\nМожет вы ошиблись?", "Ошибка");
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}