using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorAndNotepad.panel
{
    public partial class calculator : UserControl
    {
        public event EventHandler OnPictureClick;

        public calculator()
        {
            InitializeComponent();
        }

        private void CalToNote_Click(object sender, EventArgs e)
        {
            OnPictureClick?.Invoke(this, EventArgs.Empty);
        }

        private void lblCalc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
