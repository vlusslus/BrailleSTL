namespace Braille3D
{
    partial class BrailleSchema
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
            this.groupBoxGlyphParams = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.glyphTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brailleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brailleDataSet = new Braille3D.BrailleDataSet();
            this.glyphTypesTableAdapter = new Braille3D.BrailleDataSetTableAdapters.GlyphTypesTableAdapter();
            this.glyphsParamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glyphsParamsTableAdapter = new Braille3D.BrailleDataSetTableAdapters.GlyphsParamsTableAdapter();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxGlyphParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glyphTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brailleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brailleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glyphsParamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGlyphParams
            // 
            this.groupBoxGlyphParams.Controls.Add(this.dataGridView1);
            this.groupBoxGlyphParams.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGlyphParams.Name = "groupBoxGlyphParams";
            this.groupBoxGlyphParams.Size = new System.Drawing.Size(445, 454);
            this.groupBoxGlyphParams.TabIndex = 0;
            this.groupBoxGlyphParams.TabStop = false;
            this.groupBoxGlyphParams.Text = "Параметры глифов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.glyphsParamsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(421, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // glyphTypesBindingSource
            // 
            this.glyphTypesBindingSource.DataMember = "GlyphTypes";
            this.glyphTypesBindingSource.DataSource = this.brailleDataSetBindingSource;
            // 
            // brailleDataSetBindingSource
            // 
            this.brailleDataSetBindingSource.DataSource = this.brailleDataSet;
            this.brailleDataSetBindingSource.Position = 0;
            // 
            // brailleDataSet
            // 
            this.brailleDataSet.DataSetName = "BrailleDataSet";
            this.brailleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // glyphTypesTableAdapter
            // 
            this.glyphTypesTableAdapter.ClearBeforeFill = true;
            // 
            // glyphsParamsBindingSource
            // 
            this.glyphsParamsBindingSource.DataMember = "GlyphsParams";
            this.glyphsParamsBindingSource.DataSource = this.brailleDataSetBindingSource;
            // 
            // glyphsParamsTableAdapter
            // 
            this.glyphsParamsTableAdapter.ClearBeforeFill = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // BrailleSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 478);
            this.Controls.Add(this.groupBoxGlyphParams);
            this.Name = "BrailleSchema";
            this.Text = "Схема Брайля";
            this.Load += new System.EventHandler(this.BrailleSchema_Load);
            this.groupBoxGlyphParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glyphTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brailleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brailleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glyphsParamsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGlyphParams;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource brailleDataSetBindingSource;
        private BrailleDataSet brailleDataSet;
        private System.Windows.Forms.BindingSource glyphTypesBindingSource;
        private BrailleDataSetTableAdapters.GlyphTypesTableAdapter glyphTypesTableAdapter;
        private System.Windows.Forms.BindingSource glyphsParamsBindingSource;
        private BrailleDataSetTableAdapters.GlyphsParamsTableAdapter glyphsParamsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}