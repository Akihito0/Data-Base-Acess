using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
//Author: Noah Gabriel R. Suan (BSCPE - 2)
//The concept of this forms will be used for later projects
namespace Data_Base_Acess
{
    public partial class Form1 : Form
    {
        OleDbConnection oleDbConnection;
        OleDbDataAdapter oleDbAdapter;
        OleDbCommand oleDbCommand = new OleDbCommand();
        DataSet? dataSet;
        bool Loaded = false;
        int indexRow;
        bool enable = false;
        string PhotoPath = "";
        string Data = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Noah Gabriel Suan\\source\\repos\\Data Base Acess\\Data Base Acess\\bin\\Debug\\net8.0-windows\\DataBase\\SUAN, NOAH GABRIEL - WEEK 7 LAB ACTIVITY.accdb\"";
        public Form1()
        {
            InitializeComponent();
            buttonenabler();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection($"{Data}");
            oleDbAdapter = new OleDbDataAdapter("SELECT *FROM [Grade Query]", oleDbConnection);
            dataSet = new DataSet();
            oleDbConnection.Open();
            oleDbAdapter.Fill(dataSet, "Grade Query");
            datagrid.DataSource = dataSet.Tables["Grade Query"];
            oleDbConnection.Close();
            Loaded = true;
            buttonenabler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection($"{Data}");
            oleDbConnection.Open();
            MessageBox.Show("Connected successfully!");
            oleDbConnection.Close();
        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string delete_query = "Delete From Student Where ID = @id";
                        oleDbConnection = new OleDbConnection($"{Data}");
                        oleDbCommand = new OleDbCommand(delete_query, oleDbConnection);
                        oleDbCommand.Parameters.AddWithValue("@id", datagrid.CurrentRow.Cells[0].Value);
                        oleDbConnection.Open();
                        oleDbCommand.ExecuteNonQuery();
                        oleDbConnection.Close();
                        refreshbtn_Click(sender, e);
                        MessageBox.Show("Record deleted successfully!");
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                    finally
                    {
                        if (oleDbConnection.State == ConnectionState.Open)
                        {
                            oleDbConnection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
            clearbtn_Click(sender, e);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (validate_answers()) //Validate the textboxes for empty strings
            {
                return;
            }
            string insert_to_query = "Insert into [Grade Query] (LastName, FirstName, Course, YearLevel, CourseNum1, FG1) values (@LName, @FName, @Course, @Year, @Subject, @Grade)";
            oleDbCommand = new OleDbCommand(insert_to_query, oleDbConnection);
            oleDbCommand.Parameters.AddWithValue("@LName", lastNametxtb.Text);
            oleDbCommand.Parameters.AddWithValue("@FName", firstNametxtb.Text);
            oleDbCommand.Parameters.AddWithValue("@Course", coursebx.Text);
            oleDbCommand.Parameters.AddWithValue("@Year", yeartxtb.Text);
            oleDbCommand.Parameters.AddWithValue("@Subject", subjecttxtb.Text);
            oleDbCommand.Parameters.AddWithValue("@Grade", gradetxtb.Text);
            oleDbConnection.Open();
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();
            clearbtn_Click(sender, e);
            refreshbtn_Click(sender, e);
        }
        private void refreshbtn_Click(object sender, EventArgs e) //A refresh button, this is just the loadbtn_Click function but with a different name
        {
            loadbtn_Click(sender, e);
        }
        //Display the data from the access database to the textboxes and picture box
        private void datagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = datagrid.Rows[indexRow];
            idlbl.Text = "Student ID: " + row.Cells[0].Value.ToString();
            lastNametxtb.Text = row.Cells[1].Value.ToString();
            firstNametxtb.Text = row.Cells[2].Value.ToString();
            coursebx.Text = row.Cells[3].Value.ToString();
            yeartxtb.Text = row.Cells[4].Value.ToString();
            subjecttxtb.Text = row.Cells[5].Value.ToString();
            gradetxtb.Text = row.Cells[6].Value.ToString();
            //Add photo to picture box
            string studentId = row.Cells[0].Value.ToString();
            string query = "SELECT PhotoPath FROM Student WHERE ID = @id";
            oleDbCommand = new OleDbCommand(query, oleDbConnection);
            oleDbCommand.Parameters.AddWithValue("@id", studentId);
            oleDbConnection.Open();
            object result = oleDbCommand.ExecuteScalar();
            oleDbConnection.Close();

            if (result != null && !string.IsNullOrEmpty(result.ToString()))
            {
                studentPictureBox.ImageLocation = result.ToString();
            }
            else
            {
                studentPictureBox.Image = null;
            }
        }
        //this will show a tooltip when the mouse hovers over the button
        private void loadbtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(loadbtn, "This button is for connecting to the database");
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button2, "This button is for testing the connection to the database");
        }
        private void refreshbtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(refreshbtn, "This button is for refreshing the table from the database");
        }

        private void clearbtn_Click(object sender, EventArgs e) //This function will clear the textboxes and the picture box of the forms
        {
            idlbl.Text = "Student ID: ";
            lastNametxtb.Text = "";
            firstNametxtb.Text = "";
            coursebx.SelectedItem = null;
            yeartxtb.Text = "";
            subjecttxtb.Text = "";
            gradetxtb.Text = "";
            studentPictureBox.Image = null;
        }

        private void updatebtn_Click(object sender, EventArgs e) //This function will update the database with the new values from the textboxes
        {
            if (validate_answers())
            {
                return;
            }
            string query = "Update [Grade Query] Set LastName = @Lname, FirstName = @Fname, Course = @Course, YearLevel = @Year, CourseNum1 = @Subject, FG1 = @Grade Where ID = @id";
            oleDbCommand = new OleDbCommand(query, oleDbConnection);
            oleDbCommand.Parameters.AddWithValue("@Lname", lastNametxtb.Text);
            oleDbCommand.Parameters.AddWithValue("@Fname", firstNametxtb.Text);
            oleDbCommand.Parameters.AddWithValue("@Course", coursebx.Text);
            oleDbCommand.Parameters.AddWithValue("@Year", yeartxtb.Text);
            oleDbCommand.Parameters.AddWithValue("@Subject", subjecttxtb.Text);
            oleDbCommand.Parameters.AddWithValue("@Grade", gradetxtb.Text);
            oleDbCommand.Parameters.AddWithValue("@id", Convert.ToInt32(idlbl.Text.Replace("Student ID: ", "")));
            oleDbConnection.Open();
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();
            refreshbtn_Click(sender, e);
            clearbtn_Click(sender, e);
            MessageBox.Show("Record updated successfully!");
        }

        private void filebtn_Click(object sender, EventArgs e) //This is the function that will allow the user to select a photo from their computer and update the database with the path of the photo(Multiple Sources Used)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
                openFileDialog.Title = "Select a Photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PhotoPath = openFileDialog.FileName;
                    string studentId = idlbl.Text.Replace("Student ID: ", "");

                    if (!string.IsNullOrEmpty(studentId))
                    {
                        try
                        {
                            string query = "Update Student Set PhotoPath = @PhotoPath Where ID = @id";
                            oleDbCommand = new OleDbCommand(query, oleDbConnection);
                            oleDbCommand.Parameters.AddWithValue("@PhotoPath", PhotoPath);
                            oleDbCommand.Parameters.AddWithValue("@id", Convert.ToInt32(studentId));
                            oleDbConnection.Open();
                            oleDbCommand.ExecuteNonQuery();
                            oleDbConnection.Close();
                            MessageBox.Show("Photo updated successfully!");
                        }
                        catch (OleDbException ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                        finally
                        {
                            if (oleDbConnection.State == ConnectionState.Open)
                            {
                                oleDbConnection.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a student record first.");
                    }
                }
            }
        }
        private void buttonenabler() //A function used to enable and disable buttons depending on the state of the program this will help in reducing the repitition of code
        {
            if (Loaded == false)
            {
                loadbtn.Enabled = true;
                addbtn.Enabled = false;
                updatebtn.Enabled = false;
                deletebtn.Enabled = false;
                refreshbtn.Enabled = false;
                clearbtn.Enabled = false;
                filebtn.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                loadbtn.Enabled = false;
                addbtn.Enabled = true;
                updatebtn.Enabled = true;
                deletebtn.Enabled = true;
                refreshbtn.Enabled = true;
                clearbtn.Enabled = true;
                filebtn.Enabled = true;
                button2.Enabled = true;
            }
        }
        private bool validate_answers() //Simple way to validate the textboxes for empty strings
        {
            if (lastNametxtb.Text == string.Empty || firstNametxtb.Text == string.Empty || coursebx.Text == string.Empty || yeartxtb.Text == string.Empty || subjecttxtb.Text == string.Empty || gradetxtb.Text == string.Empty)
            {
                MessageBox.Show("Please fill out all the fields.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
