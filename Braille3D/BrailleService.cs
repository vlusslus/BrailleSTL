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
                string queryString = "SELECT Id FROM Glyphs WHERE Title = " + symbol;
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                try
                {
                    return reader.GetInt32(1);
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return -1;
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        public static string getGlyphParamsById(int id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Properties.Settings.Default.BrailleConnectionString;
                string queryString = "Select Value From GlyphParams Where Id = " +
                                     "(Select Id_glyph_param From Glyphs Where Id = " + id + ")";
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                try
                {
                    return reader.GetString(1);
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return " ";
                }
                finally
                {
                    reader.Close();
                }
            }

        }

        public static Dictionary<string, double> getConfigsById(int glyphTypeId)
        {
            Dictionary<string, double> configs = new Dictionary<string, double>();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Properties.Settings.Default.BrailleConnectionString;
                string queryString = "SELECT Circle_Radio, Circle_Ratio, Width, Heigth, Lines, Tokens FROM GlyphTypes WHERE Id = " + glyphTypeId;
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                try
                {
                    configs.Add("Circle_Radio", reader.GetDouble(0));
                    configs.Add("Circle_Ratio", reader.GetDouble(1));
                    configs.Add("Width", reader.GetDouble(2));
                    configs.Add("Heigth", reader.GetDouble(3));
                    configs.Add("Lines", reader.GetDouble(4));
                    configs.Add("Tokens", reader.GetDouble(5));
                    return configs;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return configs;
                }
                finally
                {
                    reader.Close();
                }
            }

        }



    }
}
