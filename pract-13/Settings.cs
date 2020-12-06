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
using System.IO;

namespace pract_13
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void CanselSettings_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveSizeTable_Click(object sender, EventArgs e)
        {
            SizeTable.columnCount = (int)countColumnsTable.Value;
            SizeTable.rowCount = (int)countRowsTable.Value;
            StreamWriter write = new StreamWriter("config.ini");
            write.WriteLine(SizeTable.columnCount);
            write.WriteLine(SizeTable.rowCount);
            write.Close();
            Close();
        }
    }
}
