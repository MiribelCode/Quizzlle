using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quizzlle
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //start
        }

        private void Connect()
        {
            string connectionString = "SERVER=localhost:3306;DATABASE=quizzlle;UID=quizzlleProjekt;PASSWORD=123456;";

            SqlConnection connection = new SqlConnection(connectionString);
        }

        
        public List<Frage> GetFragenZumThema(int themaID)
        {
            string query = "SELECT frage FROM fragen WHERE ThemaID=" + themaID + ";";

            //Create a list to store the result
            List< string >[] fragen = new List< string >[];

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    fragen.Add(dataReader["frage"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list
                return fragen;
            }
            else
            {
                return fragen;
            }
        }
    }
}
