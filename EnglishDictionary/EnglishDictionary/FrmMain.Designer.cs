
namespace EnglishDictionary
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LbDictionaryData = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMeaning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtWord = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteAll = new System.Windows.Forms.Button();
            this.BtnListAll = new System.Windows.Forms.Button();
            this.BtnDeleteSelected = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbDictionaryData
            // 
            this.LbDictionaryData.FormattingEnabled = true;
            this.LbDictionaryData.ItemHeight = 15;
            this.LbDictionaryData.Location = new System.Drawing.Point(16, 19);
            this.LbDictionaryData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbDictionaryData.Name = "LbDictionaryData";
            this.LbDictionaryData.Size = new System.Drawing.Size(304, 304);
            this.LbDictionaryData.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtMeaning);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtWord);
            this.groupBox1.Location = new System.Drawing.Point(337, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(353, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(102, 98);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(137, 22);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add to Dictionary";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Definition";
            // 
            // TxtMeaning
            // 
            this.TxtMeaning.Location = new System.Drawing.Point(113, 57);
            this.TxtMeaning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMeaning.Name = "TxtMeaning";
            this.TxtMeaning.Size = new System.Drawing.Size(223, 23);
            this.TxtMeaning.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word";
            // 
            // TxtWord
            // 
            this.TxtWord.Location = new System.Drawing.Point(114, 20);
            this.TxtWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtWord.Name = "TxtWord";
            this.TxtWord.Size = new System.Drawing.Size(223, 23);
            this.TxtWord.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDeleteAll);
            this.groupBox2.Controls.Add(this.BtnListAll);
            this.groupBox2.Controls.Add(this.BtnDeleteSelected);
            this.groupBox2.Controls.Add(this.BtnFind);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(337, 163);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(353, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find and Delete";
            // 
            // BtnDeleteAll
            // 
            this.BtnDeleteAll.Location = new System.Drawing.Point(6, 129);
            this.BtnDeleteAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteAll.Name = "BtnDeleteAll";
            this.BtnDeleteAll.Size = new System.Drawing.Size(124, 22);
            this.BtnDeleteAll.TabIndex = 4;
            this.BtnDeleteAll.Text = "Delete All";
            this.BtnDeleteAll.UseVisualStyleBackColor = true;
            this.BtnDeleteAll.Click += new System.EventHandler(this.BtnDeleteAll_Click);
            // 
            // BtnListAll
            // 
            this.BtnListAll.Location = new System.Drawing.Point(6, 94);
            this.BtnListAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnListAll.Name = "BtnListAll";
            this.BtnListAll.Size = new System.Drawing.Size(124, 22);
            this.BtnListAll.TabIndex = 3;
            this.BtnListAll.Text = "List All";
            this.BtnListAll.UseVisualStyleBackColor = true;
            this.BtnListAll.Click += new System.EventHandler(this.BtnListAll_Click);
            // 
            // BtnDeleteSelected
            // 
            this.BtnDeleteSelected.Location = new System.Drawing.Point(6, 57);
            this.BtnDeleteSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteSelected.Name = "BtnDeleteSelected";
            this.BtnDeleteSelected.Size = new System.Drawing.Size(124, 22);
            this.BtnDeleteSelected.TabIndex = 2;
            this.BtnDeleteSelected.Text = "Delete Selected";
            this.BtnDeleteSelected.UseVisualStyleBackColor = true;
            this.BtnDeleteSelected.Click += new System.EventHandler(this.BtnDeleteSelected_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(184, 19);
            this.BtnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(124, 22);
            this.BtnFind.TabIndex = 1;
            this.BtnFind.Text = "Find Meaning";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 23);
            this.textBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbDictionaryData);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "English-English Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LbDictionaryData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMeaning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtWord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDeleteAll;
        private System.Windows.Forms.Button BtnListAll;
        private System.Windows.Forms.Button BtnDeleteSelected;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

