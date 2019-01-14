using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace QuestionPaperGenerator
{
    /// <summary>
    /// This class simply gets a connection from the database to access it,
    /// </summary>
    class MyDatabaseConnector
    {

        /// <summary>
        ///     This method creates a object for MySqlConnection to access the database.
        /// </summary>
        /// <returns>
        ///     It returns the objects of MySqlConnection.
        /// </returns>
        public static MySqlConnection GetDatabaseConnection()
            {
                String connectionString = "datasource=127.0.0.1;username=nikhil;password=nikhil1234;database=qpgenerator;SslMode=none";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                try
                {
                    databaseConnection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return databaseConnection;
            }
        }
    }
