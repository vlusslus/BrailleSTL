namespace Braille3D
{
    partial class MainForm
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
            this.groupBoxGlyphs = new System.Windows.Forms.GroupBox();
            this.checkBoxEng = new System.Windows.Forms.CheckBox();
            this.checkBoxRu = new System.Windows.Forms.CheckBox();
            this.checkBoxNum = new System.Windows.Forms.CheckBox();
            this.checkBoxSep = new System.Windows.Forms.CheckBox();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonDeselectAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBoxGlyphs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGlyphs
            // 
            this.groupBoxGlyphs.Controls.Add(this.buttonDeselectAll);
            this.groupBoxGlyphs.Controls.Add(this.buttonSelectAll);
            this.groupBoxGlyphs.Controls.Add(this.checkBoxSep);
            this.groupBoxGlyphs.Controls.Add(this.checkBoxNum);
            this.groupBoxGlyphs.Controls.Add(this.checkBoxRu);
            this.groupBoxGlyphs.Controls.Add(this.checkBoxEng);
            this.groupBoxGlyphs.Location = new System.Drawing.Point(18, 18);
            this.groupBoxGlyphs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGlyphs.Name = "groupBoxGlyphs";
            this.groupBoxGlyphs.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGlyphs.Size = new System.Drawing.Size(202, 239);
            this.groupBoxGlyphs.TabIndex = 0;
            this.groupBoxGlyphs.TabStop = false;
            this.groupBoxGlyphs.Text = "Глифы";
            // 
            // checkBoxEng
            // 
            this.checkBoxEng.AutoSize = true;
            this.checkBoxEng.Location = new System.Drawing.Point(8, 39);
            this.checkBoxEng.Name = "checkBoxEng";
            this.checkBoxEng.Size = new System.Drawing.Size(189, 24);
            this.checkBoxEng.TabIndex = 0;
            this.checkBoxEng.Text = "Англиский алфавит";
            this.checkBoxEng.UseVisualStyleBackColor = true;
            // 
            // checkBoxRu
            // 
            this.checkBoxRu.AutoSize = true;
            this.checkBoxRu.Location = new System.Drawing.Point(8, 70);
            this.checkBoxRu.Name = "checkBoxRu";
            this.checkBoxRu.Size = new System.Drawing.Size(168, 24);
            this.checkBoxRu.TabIndex = 1;
            this.checkBoxRu.Text = "Русский алфавит";
            this.checkBoxRu.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum
            // 
            this.checkBoxNum.AutoSize = true;
            this.checkBoxNum.Location = new System.Drawing.Point(8, 101);
            this.checkBoxNum.Name = "checkBoxNum";
            this.checkBoxNum.Size = new System.Drawing.Size(91, 24);
            this.checkBoxNum.TabIndex = 2;
            this.checkBoxNum.Text = "Цифры";
            this.checkBoxNum.UseVisualStyleBackColor = true;
            // 
            // checkBoxSep
            // 
            this.checkBoxSep.AutoSize = true;
            this.checkBoxSep.Location = new System.Drawing.Point(8, 132);
            this.checkBoxSep.Name = "checkBoxSep";
            this.checkBoxSep.Size = new System.Drawing.Size(138, 24);
            this.checkBoxSep.TabIndex = 3;
            this.checkBoxSep.Text = "Разделители";
            this.checkBoxSep.UseVisualStyleBackColor = true;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(7, 162);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(188, 30);
            this.buttonSelectAll.TabIndex = 4;
            this.buttonSelectAll.Text = "Выбрать все";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonDeselectAll
            // 
            this.buttonDeselectAll.Location = new System.Drawing.Point(8, 198);
            this.buttonDeselectAll.Name = "buttonDeselectAll";
            this.buttonDeselectAll.Size = new System.Drawing.Size(187, 31);
            this.buttonDeselectAll.TabIndex = 5;
            this.buttonDeselectAll.Text = "Сбросить";
            this.buttonDeselectAll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(363, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(345, 179);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxGlyphs);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Трансялтор шрифта Брайля";
            this.groupBoxGlyphs.ResumeLayout(false);
            this.groupBoxGlyphs.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGlyphs;
        private System.Windows.Forms.Button buttonDeselectAll;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.CheckBox checkBoxSep;
        private System.Windows.Forms.CheckBox checkBoxNum;
        private System.Windows.Forms.CheckBox checkBoxRu;
        private System.Windows.Forms.CheckBox checkBoxEng;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

