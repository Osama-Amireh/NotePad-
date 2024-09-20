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
    public partial class Search : Form
    {
        public int lastIndex=0 ;
        private RichTextBox MyRichTextBox;
        public Search( RichTextBox s )
        {
            InitializeComponent();
            MyRichTextBox = s;
            richTextBox1.Font = new Font("Arial", 20, FontStyle.Regular); // Set font size to 12
           // lastIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          //Form1 form1   =new Form1(); 
          if(lastIndex!=-1&& MyRichTextBox.TextLength > lastIndex)
            lastIndex = MyRichTextBox.Find(richTextBox1.Text, lastIndex,RichTextBoxFinds.MatchCase);
             if (lastIndex <= -1|| MyRichTextBox.TextLength <= lastIndex)
            {

                MessageBox.Show("not found", "Result",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MyRichTextBox.SelectionStart = lastIndex;
                MyRichTextBox.SelectionLength = richTextBox1.TextLength;
                MyRichTextBox.Focus();

                MessageBox.Show("found", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  lastIndex += 1;

            }



        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
      {
            lastIndex = 0;
        }

        private void Search_Load(object sender, EventArgs e)
        {
        }

        private void Srearch_Click(object sender, EventArgs e)
        {
            lastIndex = MyRichTextBox.Find(richTextBox1.Text, lastIndex, RichTextBoxFinds.MatchCase);
            if (lastIndex <= -1 || MyRichTextBox.TextLength <= lastIndex)
            {

                MessageBox.Show("not found", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MyRichTextBox.SelectionStart = lastIndex;
                MyRichTextBox.SelectionLength = richTextBox1.TextLength;
                MyRichTextBox.Focus();
                MessageBox.Show("found", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
              ;

            }

        }
    }
}
