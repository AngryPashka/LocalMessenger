using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalMessengerServer
{
    public partial class FormPassworAdministrator : Form
    {
        readonly WorkingWithDatabase work = new WorkingWithDatabase();
        int fail = 0;
        public FormPassworAdministrator()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (work.Administration(Convert.ToInt32(textBox1.Text)))
                {
                    DialogResult = DialogResult.Yes;
                    Close();
                }
                else
                {
                    textBox1.BackColor = Color.LightPink;
                    fail++;
                    textBox1.Clear();
                    if (fail > 2)
                        Close();
                }
            }
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                textBox1.BackColor = Color.White;
                return; 
            }
            if (e.KeyChar != 8) e.Handled = true;
        }
    }
}
