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

        // 값1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // 값2
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // + 연산
        private void button1_Click(object sender, EventArgs e)
        {
            resultText.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
        }

        // - 연산
        private void button2_Click(object sender, EventArgs e)
        {
            resultText.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text));
        }

        // * 연산
        private void button3_Click(object sender, EventArgs e)
        {
            resultText.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));
        }

        // / 연산
        private void button4_Click(object sender, EventArgs e)
        {
            resultText.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
        }

        // 결과 텍스트 박스
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblCalc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
