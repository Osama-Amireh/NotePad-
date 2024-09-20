namespace Note_Pad
{
    partial class Repalce
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRepalceAll = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(199, 184);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(375, 52);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnRepalceAll
            // 
            this.btnRepalceAll.Location = new System.Drawing.Point(729, 260);
            this.btnRepalceAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRepalceAll.Name = "btnRepalceAll";
            this.btnRepalceAll.Size = new System.Drawing.Size(119, 44);
            this.btnRepalceAll.TabIndex = 1;
            this.btnRepalceAll.Text = "Replace All";
            this.btnRepalceAll.UseVisualStyleBackColor = true;
            this.btnRepalceAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(729, 184);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(119, 44);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(729, 338);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 44);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(199, 309);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(375, 52);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Repalce From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repalce to";
            // 
            // Repalce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnRepalceAll);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Repalce";
            this.Text = "Repalce";
            this.Load += new System.EventHandler(this.Repalce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRepalceAll;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.RichTextBox richTextBox2;
    }
}