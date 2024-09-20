using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Pad
{
    public partial class Repalce : Form
    {
        Form1 frm1;
        RichTextBox MyRichTextBox;
        public Repalce(Form1 s)
        {
            InitializeComponent();
      this.frm1 = s; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.richTextBox1.Text = MyRichTextBox.Text.Replace(richTextBox1.Text, richTextBox2.Text);

        }

        private void Repalce_Load(object sender, EventArgs e)
        {
            MyRichTextBox = frm1.richTextBox1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
        int index= frm1.richTextBox1.Find(richTextBox1.Text);
            if (index == -1)
            {
                MessageBox.Show("not found", "Result",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else
            {
                StringBuilder sb = new StringBuilder(frm1.richTextBox1.Text);
                StringBuilder sb1 = new StringBuilder(richTextBox2.Text);
                int j = 0;
                for (int i = index; j < richTextBox2.TextLength;i++)
                {
                    sb[index] = sb1[j];
                    j++;
                }
                frm1.richTextBox1.Text= sb.ToString();
             


            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
