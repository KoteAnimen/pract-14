using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libmass;
using findcolumns;
using System.IO;

namespace pract_13
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                StreamReader read = new StreamReader("config.ini");
                SizeTable.columnCount = Convert.ToInt32(read.ReadLine());
                SizeTable.rowCount = Convert.ToInt32(read.ReadLine());
                LibMass.SizeTable(tableNumbers, SizeTable.columnCount, SizeTable.rowCount);
                LibMass.FillTable(tableNumbers, (int)minNumber.Value, (int)maxNumber.Value);
                read.Close();
                sizeTable.Text = "Размер таблицы -" + SizeTable.rowCount + "x" + SizeTable.columnCount;
            }
            catch
            {
                sizeTable.Text = "Размер таблицы -" + SizeTable.rowCount + "x" + SizeTable.columnCount;
            }
            
        }

        private void OpenTable_Click(object sender, EventArgs e)
        {
            LibMass.OpenDialogToOpen(tableNumbers, openFileDialog1);
        }

        private void SaveTable_Click(object sender, EventArgs e)
        {
            LibMass.OpenDialogToSave(tableNumbers, saveFileDialog1);
        }

        private void ClearTable_Click(object sender, EventArgs e)
        {
            LibMass.ClearTable(tableNumbers);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateRandomTable_Click(object sender, EventArgs e)
        {
            LibMass.InstantRandomTable(tableNumbers);
            sizeTable.Text = "Размер таблицы -" + tableNumbers.RowCount + "x" + tableNumbers.ColumnCount;
        }

        private void CreateRandomTableContext_Click(object sender, EventArgs e)
        {
            LibMass.InstantRandomTable(tableNumbers);
            sizeTable.Text = "Размер таблицы -" + tableNumbers.RowCount + "x" + tableNumbers.ColumnCount;
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {            
            answer.Text = FindColumns.CountColumns(tableNumbers).ToString();
        }

        private void FillMainTable_Click(object sender, EventArgs e)
        {
            SizeTable.columnCount = (int)countColumns.Value;
            SizeTable.rowCount = (int)countRows.Value;
            LibMass.SizeTable(tableNumbers, SizeTable.columnCount, SizeTable.rowCount);
            LibMass.FillTable(tableNumbers, (int)minNumber.Value, (int)maxNumber.Value);
            sizeTable.Text = "Размер таблицы -" + SizeTable.rowCount + "x" + SizeTable.columnCount;
        }

        private void ChangeSizeByRows(object sender, EventArgs e)
        {
            SizeTable.columnCount = (int)countColumns.Value;
            SizeTable.rowCount = (int)countRows.Value;
            LibMass.SizeTable(tableNumbers, SizeTable.columnCount, SizeTable.rowCount);
            LibMass.FillTable(tableNumbers, (int)minNumber.Value, (int)maxNumber.Value);
            sizeTable.Text = "Размер таблицы -" + SizeTable.rowCount + "x" + SizeTable.columnCount;
        }

        private void ChangeSiseByColumns(object sender, EventArgs e)
        {
            SizeTable.columnCount = (int)countColumns.Value;
            SizeTable.rowCount = (int)countRows.Value;
            LibMass.SizeTable(tableNumbers, SizeTable.columnCount, SizeTable.rowCount);
            LibMass.FillTable(tableNumbers, (int)minNumber.Value, (int)maxNumber.Value);
            sizeTable.Text = "Размер таблицы -" + SizeTable.rowCount + "x" + SizeTable.columnCount;
        }

        private void FillTable_Click(object sender, EventArgs e)
        {
            SizeTable.columnCount = (int)countColumns.Value;
            SizeTable.rowCount = (int)countRows.Value;
            LibMass.SizeTable(tableNumbers, SizeTable.columnCount, SizeTable.rowCount);
            LibMass.FillTable(tableNumbers, (int)minNumber.Value, (int)maxNumber.Value);
            sizeTable.Text = "Размер таблицы -" + SizeTable.rowCount + "x" + SizeTable.columnCount;
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филяк, ИСП-31, вариант 1. Дана матрица размера M * N. Найти количество ее столбцов, элементы которых упорядочены по убыванию. ", "О программе");
        }

        private void ChangeNumberBox(object sender, DataGridViewCellEventArgs e)
        {
            int row = tableNumbers.CurrentRow.Index + 1;
            int column = tableNumbers.CurrentCell.ColumnIndex + 1;
            numerBox.Text = "Номер строки - " + row.ToString() + " Номер столбца - " + column.ToString();

        }

        private void Pass(object sender, EventArgs e)
        {
            Pass pass = new Pass();
            pass.ShowDialog(this);// открываем форму авторизации в модальном режиме и передаем ссылку на родительскую форму
        }

        private void TableSettings_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings();            
            setting.ShowDialog(this);
            tableNumbers.RowCount = SizeTable.rowCount;
            tableNumbers.ColumnCount = SizeTable.columnCount;
            sizeTable.Text = "Размер таблицы -" + SizeTable.rowCount + "x" + SizeTable.columnCount;
        }

        private void GetAnswerContext_Click(object sender, EventArgs e)
        {            
            answer.Text = FindColumns.CountColumns(tableNumbers).ToString();
        }
    }
    public class SizeTable
    {
        public static int columnCount;
        public static int rowCount;

    }
}
