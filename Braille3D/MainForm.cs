using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Braille3D.Properties.Settings.Default.BrailleConnectionString;
                string queryString = "SELECT * FROM Glyphs";
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                try
                {
                    string text = "";
                    while(reader.Read())
                    {
                        text += reader.GetString(1);
                    }
                    richTextBox1.Text = text;
                }
                catch (SqlException)
                {
                    
                }
                finally
                {
                    reader.Close();
                }
                //connection.Open();

                Console.WriteLine("State: {0}", connection.State);
                Console.WriteLine("ConnectionString: {0}",
                    connection.ConnectionString);
            }
            //richTextBox1.Text = Braille3D.Properties.Settings.Default.BrailleConnectionString;
        }
    }
}
