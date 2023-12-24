using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.DragomeretskiyED.Sprint7.Project.V15.Lib;
namespace Tyuiu.DragomeretskiyED.Sprint7.Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_DED.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        static string[,] arrayValues;
        string openFilePath;
        static int rows, colums;
        private int index;

        private void FormMain_Load(object sender, EventArgs e)
        {
            

            for (int i = 0; i < 0; i++)
            {
                dataGridViewOut_DED.Columns[i].Width = 60;
                if (i >= 3)
                {
                    dataGridViewOut_DED.Columns[i].Width = 105;
                }
            }
        }

        private void buttonSaveFile_DED_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogExcel_DED.FileName = "FileTask7.csv";
                saveFileDialogExcel_DED.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogExcel_DED.ShowDialog();

                string path = saveFileDialogExcel_DED.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewOut_DED.RowCount;
                int columns = dataGridViewOut_DED.ColumnCount;

                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewOut_DED.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewOut_DED.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.Default);
                    str = "";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChange_DED_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridViewOut_DED.Rows[index];
            newdata.Cells[0].Value = textBoxAddNamee_DED.Text;
            newdata.Cells[1].Value = textBoxAddAddress_DED.Text;
            newdata.Cells[2].Value = textBoxAddPhone_DED.Text;
            newdata.Cells[3].Value = textBoxAddStatus_DED.Text;
            newdata.Cells[4].Value = textBoxAddOklad_DED.Text;
            newdata.Cells[5].Value = textBoxAddSrok_DED.Text;

        }
    
        private void buttonAdd_DED_Click(object sender, EventArgs e)
        {
            addRow(textBoxAddNamee_DED.Text, textBoxAddAddress_DED.Text, textBoxAddPhone_DED.Text, textBoxAddStatus_DED.Text, textBoxAddOklad_DED.Text, textBoxAddSrok_DED.Text);
        }

        private void addRow(string textBoxAddNamee_DED, string textBoxAddAddress_DED, string textBoxAddPhone_DED, string textBoxAddStatus_DED, string textBoxAddOklad_DED, string textBoxAddSrok_DED)
        {
            String[] row = { textBoxAddNamee_DED, textBoxAddAddress_DED, textBoxAddPhone_DED, textBoxAddStatus_DED, textBoxAddOklad_DED, textBoxAddSrok_DED };
            dataGridViewOut_DED.Rows.Add(row);
        }

        private void buttonDelete_DED_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridViewOut_DED.SelectedRows)
            {
                dataGridViewOut_DED.Rows.Remove(row);
            }
        }

        private void dataGridViewOut_DED_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridViewOut_DED.Rows[index];
            textBoxAddNamee_DED.Text = row.Cells[0].Value.ToString();
            textBoxAddAddress_DED.Text = row.Cells[1].Value.ToString();
            textBoxAddPhone_DED.Text = row.Cells[2].Value.ToString();
            textBoxAddStatus_DED.Text = row.Cells[3].Value.ToString();
            textBoxAddOklad_DED.Text = row.Cells[4].Value.ToString();
            textBoxAddSrok_DED.Text = row.Cells[5].Value.ToString();
        }

        private void buttonHelp_DED_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSort_DED_Click(object sender, EventArgs e)
        {
            string columnName = textBoxSort_DED.Text;
            dataGridViewOut_DED.Sort(dataGridViewOut_DED.Columns[columnName], ListSortDirection.Ascending);
        }

        private void buttonOpenFile_DED_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_DED.ShowDialog();
                openFilePath = openFileDialog_DED.FileName;
                arrayValues = ds.LoadFromFileData(openFilePath);
                dataGridViewOut_DED.Rows.Clear();

                rows = arrayValues.GetUpperBound(0) + 1;
                colums = arrayValues.Length / rows;

                dataGridViewOut_DED.ColumnCount = colums;
                dataGridViewOut_DED.RowCount = rows;


                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < colums; c++)
                    {
                        dataGridViewOut_DED.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
                dataGridViewOut_DED.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                buttonSaveFile_DED.Enabled = true;
                buttonChange_DED.Enabled = true;
                buttonDelete_DED.Enabled = true;
                buttonAdd_DED.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



    }
}
