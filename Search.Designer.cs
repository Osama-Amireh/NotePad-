namespace Note_Pad
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchNext = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Srearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(85, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter what do you want to search for it";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearchNext
            // 
            this.btnSearchNext.Location = new System.Drawing.Point(476, 144);
            this.btnSearchNext.Name = "btnSearchNext";
            this.btnSearchNext.Size = new System.Drawing.Size(118, 49);
            this.btnSearchNext.TabIndex = 3;
            this.btnSearchNext.Text = "Search Next";
            this.btnSearchNext.UseVisualStyleBackColor = true;
            this.btnSearchNext.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(387, 60);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Srearch
            // 
            this.Srearch.Location = new System.Drawing.Point(476, 60);
            this.Srearch.Name = "Srearch";
            this.Srearch.Size = new System.Drawing.Size(118, 49);
            this.Srearch.TabIndex = 2;
            this.Srearch.Text = "Search";
            this.Srearch.UseVisualStyleBackColor = true;
            this.Srearch.Click += new System.EventHandler(this.Srearch_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 242);
            this.Controls.Add(this.Srearch);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSearchNext);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchNext;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Srearch;
    }
}