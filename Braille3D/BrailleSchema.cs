using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braille3D
{
    public partial class BrailleSchema : Form
    {
        public BrailleSchema()
        {
            InitializeComponent();
        }

        private void BrailleSchema_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brailleDataSet.GlyphsParams' table. You can move, or remove it, as needed.
            this.glyphsParamsTableAdapter.Fill(this.brailleDataSet.GlyphsParams);
            // TODO: This line of code loads data into the 'brailleDataSet.GlyphTypes' table. You can move, or remove it, as needed.
            this.glyphTypesTableAdapter.Fill(this.brailleDataSet.GlyphTypes);

        }
    }
}
