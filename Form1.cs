using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
namespace Note_Pad
{
    public partial class Form1 : Form
    {

        public RichTextBox MyRichTextBox { get; private set; }
        public int index = 0;
        public string fileName = Guid.NewGuid().ToString();
        public bool check = false;
        bool CheckLastChange=false;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Font = new Font("Arial", 20, FontStyle.Regular); // Set font size to 12
            richTextBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
            MyRichTextBox = richTextBox1;
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            //comboBox1.Location = new System.Drawing.Point(0, 0);
            //comboBox1.Width = this.ClientSize.Width - 20;
        }



        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = fontDialog1.Color;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "English";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void ChangetxtFont()
        {
            fontDialog1.ShowApply = true;
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.Font = richTextBox1.SelectionFont ?? richTextBox1.Font;
            fontDialog1.Color = richTextBox1.SelectionColor;

            if (richTextBox1.SelectionLength > 0)
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                    richTextBox1.SelectionColor = fontDialog1.Color;

                }
            }
            else
            {
                richTextBox1.SelectionStart = richTextBox1.Text.Length; // Select the end of the text
                richTextBox1.SelectionLength = 0;

                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                    richTextBox1.SelectionColor = fontDialog1.Color;

                }
            }
        }
        private void txtFont_Click(object sender, EventArgs e)
        {
            ChangetxtFont();


        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void wToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }

        private void selectAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {



            richTextBox1.Undo();




        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            undoToolStripMenuItem.Enabled = true;

        }

        private void redoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Redo();


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                undoToolStripMenuItem.Enabled = true;

            }
            else
            {

                undoToolStripMenuItem.Enabled = false;

            }
            if (richTextBox1.CanRedo)
            {
                redoToolStripMenuItem.Enabled = true;
            }
            else
            {
                redoToolStripMenuItem.Enabled = false;

            }
            CheckLastChange=false;
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void paperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveChanges())
            {
                Save();
                fileName = Guid.NewGuid().ToString();
            }
            richTextBox1.Clear();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Search(richTextBox1);
            form.ShowDialog();
        }
        private void ChangeFontColor()
        {
            colorDialog1.ShowHelp = true;
            colorDialog1.Color = richTextBox1.SelectionColor;

            if (richTextBox1.SelectionLength > 0)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;

                }
            }
            else
            {
                richTextBox1.SelectionStart = richTextBox1.Text.Length; // Select the end of the text
                richTextBox1.SelectionLength = 0;

                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;

                }
            }

        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFontColor();
        }

        private void dateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            richTextBox1.Text += date;
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repalce form1 = new Repalce(this);
            form1.ShowDialog();
            // richTextBox1.Text = form1.MyRichTextBox.Text;
        }

        private void SaveAs()
        {
            saveFileDialog1.Filter = "Rich text format (*.rtf)|*.rtf|all files (*.*)|*.*|Text File(*.txt)|*.txt";
            saveFileDialog1.DefaultExt = "rtf";
                saveFileDialog1.FileName = fileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog1.FileName) == ".txt")
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);

                else
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                MessageBox.Show(saveFileDialog1.FileName);

            }
            CheckLastChange = true;

        }

        private bool SaveChanges()
        {
            if (DialogResult.OK == MessageBox.Show("Do you want save change", "Message", MessageBoxButtons.OKCancel))
                return true;
            else return false;
        }
        private void Save()
        {
            if(check==false)
            {
             Form form1=new File_Name(this);
                form1.ShowDialog();
            }

            string path = @"C:\Users\User\Documents\" + fileName +".rtf";
            if(check!=false) 
            if (fileName.IndexOf("C:") != -1 && fileName.IndexOf(".rtf") == -1)
            {
                richTextBox1.SaveFile(fileName, RichTextBoxStreamType.PlainText);
            }
            else
            {

                richTextBox1.SaveFile(path);
            }
            CheckLastChange=true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Save();

            
            this.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void openFile()
        {
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "Rich text format (*.rtf)|*.rtf| all files(*.*) | *.*| Text File (*.txt)| *.txt";
            openFileDialog1.DefaultExt = "rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".rtf")
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                else
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);

                fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);

                MessageBox.Show(fileName);
                CheckLastChange = true;
                check = true;
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();

        }

        private void Form1_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Agliment_To_Left()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agliment_To_Left();
        }
        private void Agliment_To_Right()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;


        }
        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agliment_To_Right();
        }
        private void Agliment_To_Center()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;


        }
        private void cenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agliment_To_Center();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Arabic")
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

            }
            else if (comboBox1.SelectedItem.ToString() == "English")
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

            }
        }
        private void Bold()
        {

            if (richTextBox1.SelectionLength > 0)
            {
                // Get the current font
                Font currentFont = richTextBox1.SelectionFont;

                // Toggle the bold style
                FontStyle newFontStyle;
                if (currentFont.Bold)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Bold;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Bold;
                }

                // Apply the new font
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
            else
            {
                richTextBox1.SelectionStart = richTextBox1.Text.Length; // Select the end of the text
                richTextBox1.SelectionLength = 0;

                Font currentFont = richTextBox1.SelectionFont;

                // Toggle the bold style
                FontStyle newFontStyle;
                if (currentFont.Bold)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Bold;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Bold;
                }

                // Apply the new font
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);

            }
        }
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bold();
        }
        private void underLine()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                // Get the current font
                Font currentFont = richTextBox1.SelectionFont;

                // Toggle the underline style
                FontStyle newFontStyle;
                if (currentFont.Underline)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Underline;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Underline;
                }

                // Apply the new font
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
            else
            {
                richTextBox1.SelectionStart = richTextBox1.Text.Length; // Select the end of the text
                richTextBox1.SelectionLength = 0;
                Font currentFont = richTextBox1.SelectionFont;

                // Toggle the underline style
                FontStyle newFontStyle;
                if (currentFont.Underline)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Underline;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Underline;
                }

                // Apply the new font
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);

            }

        }
        private void underLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            underLine();

        }

        private void print()
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                // Set the printer settings
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                // Print the document
                printDocument1.Print();
            }

        }
        private void printDocument(PrintPageEventArgs e)
        {
            string content = richTextBox1.Text;
            Font printFont = richTextBox1.Font;

            e.Graphics.DrawString(content, printFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print();


        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            printDocument(e);
        }
        private void highlight()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;
            }
        }
        private void highlightToolStripMenuItem_Click(object sender, EventArgs e)
        {

            highlight();



        }

        private void Form1_Leave(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(CheckLastChange==false&&richTextBox1.TextLength>0)
            if(SaveChanges())
            {
                Save();
            }
            
          
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            CheckLastChange=false;

        }

        private void richTextBox1_ForeColorChanged(object sender, EventArgs e)
        {
            CheckLastChange=false;
        }

        private void leftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agliment_To_Left();
        }

        private void rightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agliment_To_Center();
        }

        private void rightToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Agliment_To_Right();
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangetxtFont();
        }

        private void changeFontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFontColor();

        }

        private void highlightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            highlight();
        }

        private void changePaperColor()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }


        }
        private void changePageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePaperColor();

        }

        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bold();
        }

        private void underlineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            underLine();
        }
    }
}
