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
            this.components = new System.ComponentModel.Container();
            this.groupBoxGlyphs = new System.Windows.Forms.GroupBox();
            this.buttonDeselectAll = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.checkBoxSep = new System.Windows.Forms.CheckBox();
            this.checkBoxNum = new System.Windows.Forms.CheckBox();
            this.checkBoxRu = new System.Windows.Forms.CheckBox();
            this.checkBoxEng = new System.Windows.Forms.CheckBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelectInputFile = new System.Windows.Forms.Button();
            this.richTextBoxInputText = new System.Windows.Forms.RichTextBox();
            this.openFileDialogInput = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxGlyphType = new System.Windows.Forms.ComboBox();
            this.glyphTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brailleDataSet = new Braille3D.BrailleDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.glyphTypesTableAdapter = new Braille3D.BrailleDataSetTableAdapters.GlyphTypesTableAdapter();
            this.groupBoxGlyphs.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glyphTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brailleDataSet)).BeginInit();
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
            // buttonDeselectAll
            // 
            this.buttonDeselectAll.Location = new System.Drawing.Point(8, 198);
            this.buttonDeselectAll.Name = "buttonDeselectAll";
            this.buttonDeselectAll.Size = new System.Drawing.Size(187, 31);
            this.buttonDeselectAll.TabIndex = 5;
            this.buttonDeselectAll.Text = "Сбросить";
            this.buttonDeselectAll.UseVisualStyleBackColor = true;
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
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Controls.Add(this.buttonSelectInputFile);
            this.groupBoxInput.Controls.Add(this.richTextBoxInputText);
            this.groupBoxInput.Location = new System.Drawing.Point(237, 18);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(558, 239);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Текст для печати";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Не выбран.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Файл:";
            // 
            // buttonSelectInputFile
            // 
            this.buttonSelectInputFile.Location = new System.Drawing.Point(6, 25);
            this.buttonSelectInputFile.Name = "buttonSelectInputFile";
            this.buttonSelectInputFile.Size = new System.Drawing.Size(226, 35);
            this.buttonSelectInputFile.TabIndex = 1;
            this.buttonSelectInputFile.Text = "Выбрать файл для печати";
            this.buttonSelectInputFile.UseVisualStyleBackColor = true;
            this.buttonSelectInputFile.Click += new System.EventHandler(this.buttonSelectInputFile_Click);
            // 
            // richTextBoxInputText
            // 
            this.richTextBoxInputText.Location = new System.Drawing.Point(6, 66);
            this.richTextBoxInputText.Name = "richTextBoxInputText";
            this.richTextBoxInputText.Size = new System.Drawing.Size(546, 160);
            this.richTextBoxInputText.TabIndex = 0;
            this.richTextBoxInputText.Text = "";
            // 
            // openFileDialogInput
            // 
            this.openFileDialogInput.FileName = "openFileDialogInput";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxGlyphType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Транслятор";
            // 
            // comboBoxGlyphType
            // 
            this.comboBoxGlyphType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.glyphTypesBindingSource, "Id", true));
            this.comboBoxGlyphType.DataSource = this.glyphTypesBindingSource;
            this.comboBoxGlyphType.DisplayMember = "Type";
            this.comboBoxGlyphType.FormattingEnabled = true;
            this.comboBoxGlyphType.Location = new System.Drawing.Point(143, 26);
            this.comboBoxGlyphType.Name = "comboBoxGlyphType";
            this.comboBoxGlyphType.Size = new System.Drawing.Size(142, 28);
            this.comboBoxGlyphType.TabIndex = 1;
            this.comboBoxGlyphType.SelectedIndexChanged += new System.EventHandler(this.comboBoxGlyphType_SelectedIndexChanged);
            this.comboBoxGlyphType.SelectedValueChanged += new System.EventHandler(this.comboBoxGlyphType_SelectedValueChanged);
            // 
            // glyphTypesBindingSource
            // 
            this.glyphTypesBindingSource.DataMember = "GlyphTypes";
            this.glyphTypesBindingSource.DataSource = this.brailleDataSet;
            // 
            // brailleDataSet
            // 
            this.brailleDataSet.DataSetName = "BrailleDataSet";
            this.brailleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Система Брайля:";
            // 
            // glyphTypesTableAdapter
            // 
            this.glyphTypesTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxGlyphs);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Трансялтор шрифта Брайля";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxGlyphs.ResumeLayout(false);
            this.groupBoxGlyphs.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glyphTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brailleDataSet)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxInputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectInputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxGlyphType;
        private System.Windows.Forms.Label label3;
        private BrailleDataSet brailleDataSet;
        private System.Windows.Forms.BindingSource glyphTypesBindingSource;
        private BrailleDataSetTableAdapters.GlyphTypesTableAdapter glyphTypesTableAdapter;
    }
}

