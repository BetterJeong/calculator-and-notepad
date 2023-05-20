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
    }
}
