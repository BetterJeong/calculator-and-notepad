using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorAndNotepad.panel
{
    public partial class notepad : UserControl
    {
        public event EventHandler OnPictureClick;

        public notepad()
        {
            InitializeComponent();
        }
        private void NoteToCal_Click(object sender, EventArgs e)
        {
            OnPictureClick?.Invoke(this, EventArgs.Empty);
        }

        private void lblCalc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            String filePath = "C:\\memo.txt";
            sw = File.CreateText(filePath);
            sw.Write(Convert.ToString(textBox1.Text));
            sw.Close();
        }
    }
}
