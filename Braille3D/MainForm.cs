using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braille3D
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonSelectInputFile_Click(object sender, EventArgs e)
        {
            openFileDialogInput.Filter = "Текстовый файл (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialogInput.InitialDirectory = @"C:\";
            openFileDialogInput.Title = "Выберите файл для печати";
            if (openFileDialogInput.ShowDialog() == DialogResult.OK)
            {
                string inputFile = openFileDialogInput.FileName;
                label2.Text = inputFile;
                string inputText = "";
                using (StreamReader sr = new StreamReader(inputFile, Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        inputText += line;
                        inputText += "\r\n";
                    }
                }
                richTextBoxInputText.Text = inputText;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brailleDataSet.GlyphTypes' table. You can move, or remove it, as needed.
            this.glyphTypesTableAdapter.Fill(this.brailleDataSet.GlyphTypes);

        }

        private void comboBoxGlyphType_SelectedValueChanged(object sender, EventArgs e)
        {
            //richTextBoxInputText.Text = comboBoxGlyphType.SelectedValue.ToString();
        }

        private void comboBoxGlyphType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //richTextBoxInputText.Text = comboBoxGlyphType.SelectedValue.ToString();

            //DataRowView row = (DataRowView)comboBoxGlyphType.SelectedItem;
            //richTextBoxInputText.Text = row.Row.ToString();

            //richTextBoxInputText.Text = comboBoxGlyphType.SelectedValue.ToString();
        }

        private void buttonBuildSvg_Click(object sender, EventArgs e)
        {
            string inputText = richTextBoxInputText.Text;
            Translator translator = new Translator(inputText, 1);
            translator.buildSvg();
            
        }

        private void buttonViewBrailleSchema_Click(object sender, EventArgs e)
        {
            BrailleSchema brailleSchema = new BrailleSchema();
            brailleSchema.Visible = true;
        }
    }
}
