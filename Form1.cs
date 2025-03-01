using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Noah Gabriel Suan\\source\\repos\\Data Base Acess\\Data Base Acess\\bin\\Debug\\net8.0-windows\\DataBase\\SUAN, NOAH GABRIEL - WEEK 7 LAB ACTIVITY.accdb\"");
            oleDbAdapter = new OleDbDataAdapter("SELECT *FROM Student Query", oleDbConnection);
            dataSet = new DataSet();
            oleDbConnection.Open();
            oleDbAdapter.Fill(dataSet, "Student");
            datagrid.DataSource = dataSet.Tables["Student"];
            oleDbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            MessageBox.Show("Connected successfully!");
        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {

        }


    }
}
