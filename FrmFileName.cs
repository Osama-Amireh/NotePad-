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
    public partial class File_Name : Form
    {
        Form1 frm1;
        public File_Name(Form1 s)
        {
            InitializeComponent();
            frm1 = s;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            frm1.fileName = textBox1.Text;
            frm1.check = true;
            this.Close();

        }

        private void File_Name_Load(object sender, EventArgs e)
        {
            textBox1.Text = frm1.fileName;
        }
    }
}
