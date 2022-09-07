using MySql.Data.MySqlClient;
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

namespace BdProject
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();

            LoadData();


        }


        private void LoadData()
        {

            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM add_functionals", dataBase.getConnection());
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count-1][0] = reader[0].ToString();
                data[data.Count-1][1] = reader[1].ToString();
                data[data.Count-1][2] = reader[2].ToString();

            }
            reader.Close();

            dataBase.closeConnection();

            foreach (string[] s in data)
            {
                BdProject.Rows.Add(s);
            }

        }










        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TarifImg_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void TarifName_Click(object sender, EventArgs e)
        {
            TarifName.Text = "XX";
        }

        private void TarifPrice_Click(object sender, EventArgs e)
        {

        }

        
    }
}
