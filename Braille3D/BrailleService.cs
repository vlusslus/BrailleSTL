using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille3D
{
    public static class BrailleService
    {

        public static int getGlyphId(string symbol)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Properties.Settings.Default.BrailleConnectionString;
                string queryString = "SELECT Id FROM Glyphs WHERE Title = ";
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                try
                {
                    string text = "";
                    while (reader.Read())
                    {
                        text += reader.GetString(1);
                    }
                }
                catch (SqlException)
                {

                }
                finally
                {
                    reader.Close();
                }
            }
        }

        public static string getGlyphParamsById(int id)
        {

        }



    }
}
