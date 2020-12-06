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

namespace pract_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sizeTable.Text = "Размер таблицы -" + tableNumbers.RowCount + "x" + tableNumbers.ColumnCount;
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
            LibMass.SizeTable(tableNumbers, (int)countColumns.Value, (int)countRows.Value);
            LibMass.FillTable(tableNumbers, (int)minNumber.Value, (int)maxNumber.Value);
            sizeTable.Text = "Размер таблицы -" + tableNumbers.RowCount + "x" + tableNumbers.ColumnCount;
        }

        private void ChangeSizeByRows(object sender, EventArgs e)
        {
            LibMass.SizeTable(tableNumbers, (int)countColumns.Value, (int)countRows.Value);
            sizeTable.Text = "Размер таблицы -" + tableNumbers.RowCount + "x" + tableNumbers.ColumnCount;
        }

        private void ChangeSiseByColumns(object sender, EventArgs e)
        {
            LibMass.SizeTable(tableNumbers, (int)countColumns.Value, (int)countRows.Value);
            sizeTable.Text = "Размер таблицы -" + tableNumbers.RowCount + "x" + tableNumbers.ColumnCount;
        }

        private void FillTable_Click(object sender, EventArgs e)
        {
            LibMass.SizeTable(tableNumbers, (int)countColumns.Value, (int)countRows.Value);
            LibMass.FillTable(tableNumbers, (int)minNumber.Value, (int)maxNumber.Value);
            sizeTable.Text = "Размер таблицы -" + tableNumbers.RowCount + "x" + tableNumbers.ColumnCount;
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
    }
}
