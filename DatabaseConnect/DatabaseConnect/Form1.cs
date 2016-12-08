using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DatabaseConnect
{
    public partial class Form1 : Form
    {
        // Database Connections
        static OleDbConnection connection = new OleDbConnection();
        private static string connectionString = connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cskre\Documents\Visual Studio 2015\Projects\DatabaseConnect\DatabaseConnect\bin\Debug\TestDB.accdb; Persist Security Info=False;";
        OleDbDataReader reader = null;
        //

        // Instance Variables
        Project currentProject = new Project();
        //List<Project> projectList = new List<Project>();
        //

        // SQL Strings

        private string commandStringProjectNames = "SELECT ProjectName from Projects";
        //

        public Form1()
        {
            InitializeComponent();

            loadProjects();

        }

        // sets the path to the exe - currently not needed
        //string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

        #region Tests
        private void testConnectionToDatabase()
        {
            try
            {
                connection.Open();
                labelCheckConnection.Text = "Database Connected!";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex);
            }
        }
        #endregion
        
        private void loadProjectData()
        {
            string commandStringProjectData = "SELECT * from Projects WHERE ProjectName = '"+currentProject.ProjectName+"'";
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand(commandStringProjectData, connection);
                reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    currentProject.ProjectNotes= (reader[5].ToString());
                    currentProject.ProjectID = reader[1].ToString();
                    currentProject.ProjectName = reader[2].ToString();
                    ///currentProject.ProjectStart = Convert.ToDateTime(reader[3]);
                    //currentProject.ProjectDue = Convert.ToDateTime(reader[4]);
                }
                //listBoxProject.Items.Add(currentProject.ProjectID);

                connection.Close();

                richTextBoxProjectNotes.Text = currentProject.ProjectNotes;
                //listBoxProject.Text = currentProject.ProjectDue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex);
            }
        }

        /// loadProjects Method
        /// *Ran once at the begining of the application to gather all available projects
        /// *Preloads info from database to reduce calls to and from database
        /// loadProjects Method
        private void loadProjects()
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand(commandStringProjectNames, connection);
                reader = command.ExecuteReader();

                comboBoxProjectSelector.Items.Clear();
                while( reader.Read() )
                {
                    comboBoxProjectSelector.Items.Add(reader[0].ToString());
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex);
            }
        }

        private void comboBoxProjectSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProject.ProjectName = comboBoxProjectSelector.SelectedItem.ToString();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadProjectData();
        }
    }
}
