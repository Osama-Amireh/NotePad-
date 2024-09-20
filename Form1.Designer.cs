namespace Note_Pad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtFont = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateAndTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CenterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highlightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changePageColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtFont,
            this.colorToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pastToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.underLineToolStripMenuItem,
            this.highlightToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 172);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // txtFont
            // 
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(163, 24);
            this.txtFont.Text = "Font";
            this.txtFont.Click += new System.EventHandler(this.txtFont_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pastToolStripMenuItem
            // 
            this.pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            this.pastToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pastToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.pastToolStripMenuItem.Text = "Past";
            this.pastToolStripMenuItem.Click += new System.EventHandler(this.pastToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // underLineToolStripMenuItem
            // 
            this.underLineToolStripMenuItem.Name = "underLineToolStripMenuItem";
            this.underLineToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.underLineToolStripMenuItem.Text = "Under Line";
            this.underLineToolStripMenuItem.Click += new System.EventHandler(this.underLineToolStripMenuItem_Click);
            // 
            // highlightToolStripMenuItem
            // 
            this.highlightToolStripMenuItem.Name = "highlightToolStripMenuItem";
            this.highlightToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.highlightToolStripMenuItem.Text = "Highlight";
            this.highlightToolStripMenuItem.Click += new System.EventHandler(this.highlightToolStripMenuItem_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.alignmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wToolStripMenuItem,
            this.paperToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // wToolStripMenuItem
            // 
            this.wToolStripMenuItem.Name = "wToolStripMenuItem";
            this.wToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.wToolStripMenuItem.Text = "Window";
            this.wToolStripMenuItem.Click += new System.EventHandler(this.wToolStripMenuItem_Click);
            // 
            // paperToolStripMenuItem
            // 
            this.paperToolStripMenuItem.Name = "paperToolStripMenuItem";
            this.paperToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.paperToolStripMenuItem.Text = "Paper";
            this.paperToolStripMenuItem.Click += new System.EventHandler(this.paperToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redoToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.selectAToolStripMenuItem,
            this.dateAndTimeToolStripMenuItem,
            this.aToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click_1);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // selectAToolStripMenuItem
            // 
            this.selectAToolStripMenuItem.Name = "selectAToolStripMenuItem";
            this.selectAToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.selectAToolStripMenuItem.Text = "Select All";
            this.selectAToolStripMenuItem.Click += new System.EventHandler(this.selectAToolStripMenuItem_Click);
            // 
            // dateAndTimeToolStripMenuItem
            // 
            this.dateAndTimeToolStripMenuItem.Name = "dateAndTimeToolStripMenuItem";
            this.dateAndTimeToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.dateAndTimeToolStripMenuItem.Text = "Date and Time";
            this.dateAndTimeToolStripMenuItem.Click += new System.EventHandler(this.dateAndTimeToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem,
            this.cenerToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.aToolStripMenuItem.Text = "alignment ";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // cenerToolStripMenuItem
            // 
            this.cenerToolStripMenuItem.Name = "cenerToolStripMenuItem";
            this.cenerToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.cenerToolStripMenuItem.Text = "Cener";
            this.cenerToolStripMenuItem.Click += new System.EventHandler(this.cenerToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFontToolStripMenuItem,
            this.changeFontColorToolStripMenuItem,
            this.highlightToolStripMenuItem1,
            this.changePageColorToolStripMenuItem,
            this.boldToolStripMenuItem1,
            this.underlineToolStripMenuItem1});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // alignmentToolStripMenuItem
            // 
            this.alignmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem1,
            this.CenterToolStripMenuItem1,
            this.rightToolStripMenuItem2});
            this.alignmentToolStripMenuItem.Name = "alignmentToolStripMenuItem";
            this.alignmentToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.alignmentToolStripMenuItem.Text = "Alignment ";
            // 
            // leftToolStripMenuItem1
            // 
            this.leftToolStripMenuItem1.Name = "leftToolStripMenuItem1";
            this.leftToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.leftToolStripMenuItem1.Text = "Left";
            this.leftToolStripMenuItem1.Click += new System.EventHandler(this.leftToolStripMenuItem1_Click);
            // 
            // CenterToolStripMenuItem1
            // 
            this.CenterToolStripMenuItem1.Name = "CenterToolStripMenuItem1";
            this.CenterToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.CenterToolStripMenuItem1.Text = "Center";
            this.CenterToolStripMenuItem1.Click += new System.EventHandler(this.rightToolStripMenuItem1_Click);
            // 
            // rightToolStripMenuItem2
            // 
            this.rightToolStripMenuItem2.Name = "rightToolStripMenuItem2";
            this.rightToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.rightToolStripMenuItem2.Text = "Right";
            this.rightToolStripMenuItem2.Click += new System.EventHandler(this.rightToolStripMenuItem2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(0, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(822, 421);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.FontChanged += new System.EventHandler(this.richTextBox1_FontChanged);
            this.richTextBox1.ForeColorChanged += new System.EventHandler(this.richTextBox1_ForeColorChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "Arabic"});
            this.comboBox1.Location = new System.Drawing.Point(689, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changeFontToolStripMenuItem.Text = "Change Font";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // changeFontColorToolStripMenuItem
            // 
            this.changeFontColorToolStripMenuItem.Name = "changeFontColorToolStripMenuItem";
            this.changeFontColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changeFontColorToolStripMenuItem.Text = "Change Font Color";
            this.changeFontColorToolStripMenuItem.Click += new System.EventHandler(this.changeFontColorToolStripMenuItem_Click);
            // 
            // highlightToolStripMenuItem1
            // 
            this.highlightToolStripMenuItem1.Name = "highlightToolStripMenuItem1";
            this.highlightToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.highlightToolStripMenuItem1.Text = "Highlight";
            this.highlightToolStripMenuItem1.Click += new System.EventHandler(this.highlightToolStripMenuItem1_Click);
            // 
            // changePageColorToolStripMenuItem
            // 
            this.changePageColorToolStripMenuItem.Name = "changePageColorToolStripMenuItem";
            this.changePageColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changePageColorToolStripMenuItem.Text = "Change Page Color";
            this.changePageColorToolStripMenuItem.Click += new System.EventHandler(this.changePageColorToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem1
            // 
            this.boldToolStripMenuItem1.Name = "boldToolStripMenuItem1";
            this.boldToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.boldToolStripMenuItem1.Text = "Bold";
            this.boldToolStripMenuItem1.Click += new System.EventHandler(this.boldToolStripMenuItem1_Click);
            // 
            // underlineToolStripMenuItem1
            // 
            this.underlineToolStripMenuItem1.Name = "underlineToolStripMenuItem1";
            this.underlineToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.underlineToolStripMenuItem1.Text = "Underline";
            this.underlineToolStripMenuItem1.Click += new System.EventHandler(this.underlineToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_AutoSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.Form1_InputLanguageChanged);
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem txtFont;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateAndTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cenerToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underLineToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem highlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CenterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highlightToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePageColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem1;
    }
}

