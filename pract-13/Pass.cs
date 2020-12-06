using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract_13
{
    public partial class Pass : Form
    {
        public Pass()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Close();// закрываем главную форму
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(passBox.Text == "123")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль. Повторите ввод.");
                passBox.Text = "";
                passBox.Focus();
            }
        }
    }
}
