using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagerCSharpXamppMySQL
{
	public partial class FormUI : Form
	{
		public FormUI()
		{
			InitializeComponent();
		}

		private void FormUI_Load(object sender, EventArgs e)
		{

		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			if (txtFName.Text == "" || txtLName.Text == "" || txtDOB.Text == "" || txtGender.Text == "" || txtRace.Text == "")
			{
				MessageBox.Show("Please fill in all blanks");
			}
			else
			{
				InsertStudentInfo();
			}
		}

		private void btnViewRecords_Click(object sender, EventArgs e)
		{
			// view students data in a different window
			ViewStudentInfoListView();

			// View students data in console lines
			// ViewStudentInfo();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void InsertStudentInfo()
		{
			string MySQLConnectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=dbstudentmanager";
			string queryInsert = "INSERT INTO studentinfo(sid,firstname,lastname,ssn,dob,gender,race,photo,submission) " +
								 "VALUES (NULL, '" + txtFName.Text + "', '" + txtLName.Text + "', '" + txtSSN.Text + "', '" + txtDOB.Text + "', '" + txtGender.Text + "', '" + txtRace.Text + "', '" + txtAvatar.Text + "', '" + txtSubmissions.Text + "' )";

			MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
			MySqlCommand commandDatabase = new MySqlCommand(queryInsert, databaseConnection);
			commandDatabase.CommandTimeout = 60;

			try
			{
				databaseConnection.Open();
				MySqlDataReader myReader = commandDatabase.ExecuteReader();

				MessageBox.Show("Student 's record successfully registered.", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);

				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				// Show any error message
				MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ViewStudentInfo()
		{
			string MySQLConnectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=dbstudentmanager";
			string queryView = "SELECT * FROM studentinfo";

			MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
			MySqlCommand commandDatabase = new MySqlCommand(queryView, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			MySqlDataReader myReader;

			try
			{
				databaseConnection.Open();
				myReader = commandDatabase.ExecuteReader();
				// Success, now show the data

				// if there are rows that avail.
				if (myReader.HasRows)
				{
					while (myReader.Read())
					{
						Console.WriteLine(myReader.GetString(0) + " - " +
										  myReader.GetString(1) + " - " +
										  myReader.GetString(2) + " - " +
										  myReader.GetString(3) + " - " +
										  myReader.GetString(4) + " - " +
										  myReader.GetString(5) + " - " +
										  myReader.GetString(6) + " - " +
										  myReader.GetString(7) + " - " +
										  myReader.GetString(8) + " - " 
										 );

					}
				}
				else
				{
					Console.WriteLine("No rows found.");
				}
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ViewStudentInfoListView()
		{

		}
	}
}
