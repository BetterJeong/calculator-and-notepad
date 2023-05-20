using calculatorAndNotepad.panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorAndNotepad
{
    public partial class Form1 : Form
    {
        private calculator pCalculator;
        private notepad pNotepad;

        public Form1()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            pCalculator = new calculator();
            pCalculator.Dock = DockStyle.Fill;
            pCalculator.OnPictureClick += CalToNote_ButtonClick;
            pMain.Controls.Add(pCalculator);
            pCalculator.BringToFront(); 
        }

        private void CalToNote_ButtonClick(object sender, EventArgs e)
        {
            pMain.Controls.Remove(pCalculator);
            pNotepad = new notepad();
            pNotepad.OnPictureClick += NoteToCal_ButtonClick;
            pNotepad.Dock = DockStyle.Fill;
            pMain.Controls.Add(pNotepad);
            pCalculator.BringToFront();
        }

        private void NoteToCal_ButtonClick(object sender, EventArgs e)
        {
            pMain.Controls.Remove(pNotepad);
            pCalculator = new calculator();
            pCalculator.OnPictureClick += CalToNote_ButtonClick;
            pCalculator.Dock = DockStyle.Fill;
            pMain.Controls.Add(pCalculator);
            pNotepad.BringToFront();
        }
    }
}
