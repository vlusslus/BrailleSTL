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
                    while(reader.Read())
                    {
                        //Decimal dec =  reader.GetDecimal(0);
                        configs.Add("Circle_Radio", Convert.ToDouble(reader.GetDecimal(0)));
                        configs.Add("Circle_Ratio", Convert.ToDouble(reader.GetDecimal(1)));
                        configs.Add("Width", Convert.ToDouble(reader.GetDecimal(2)));
                        configs.Add("Heigth", Convert.ToDouble(reader.GetDecimal(3)));
                        configs.Add("Lines", reader.GetInt32(4));
                        configs.Add("Tokens", reader.GetInt32(5));
                    }
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
