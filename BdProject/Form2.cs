using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;

namespace BdProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;

            MySqlConnection myConnection = new MySqlConnection("server=localhost; port=3307; username=root; password=root; database=mobile_operator");

            myConnection.Open();
            string query = "SELECT count(cl_id) FROM deals join tarif USING(tarif_id) ";

            MySqlCommand command = new MySqlCommand(query, myConnection);
            
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString()+" Грн";
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            myConnection.Close();

            dataGridView3.Rows.Clear();

            foreach (string[] s in data)
                dataGridView3.Rows.Add(s);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.Visible = true;
            dataGridView4.Visible = false;
            MySqlConnection myConnection = new MySqlConnection("server=localhost; port=3307; username=root; password=root; database=mobile_operator");

            myConnection.Open();


            string query = "SELECT add_name, add_price FROM add_functionals";

            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString()+" Грн";
            }

            reader.Close();

            myConnection.Close();

            dataGridView1.Rows.Clear();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

            }
        

        private void Name_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        Point lastPoint;
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button ==MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            MySqlConnection myConnection = new MySqlConnection("server=localhost; port=3307; username=root; password=root; database=mobile_operator");

            myConnection.Open();
                   

            string query = "SELECT tarif_id, tarif_name, tarif_price, tarif_description, tarif_network_experience FROM tarif WHERE tarif_price >= '" + From.Value + "' and tarif_price <= '" + ToSmt.Value +"'; ";

            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString()+" Грн";
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            myConnection.Close();

            dataGridView3.Rows.Clear();

            foreach (string[] s in data)
                dataGridView3.Rows.Add(s);

            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            MySqlConnection myConnection = new MySqlConnection("server=localhost; port=3307; username=root; password=root; database=mobile_operator");

            myConnection.Open();

            string tarifName = textBox1.Text;
            string query = "SELECT cl_name, cl_surname, cl_balance  from deals join tarif using (tarif_id) join clients using (cl_id) where tarif_name = '" + tarifName +"';";
            


            MySqlCommand command = new MySqlCommand(query, myConnection);

            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString()+" Грн";
            }

            reader.Close();

            myConnection.Close();

            dataGridView2.Rows.Clear();

            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            dataGridView4.Visible = false;
            MySqlConnection myConnection = new MySqlConnection("server=localhost; port=3307; username=root; password=root; database=mobile_operator");

            myConnection.Open();


            string query = "SELECT tarif_id, tarif_name, tarif_price, tarif_description, tarif_network_experience, count(cl_id) FROM deals join tarif USING(tarif_id) GROUP BY 1 ORDER BY `count(cl_id)` DESC;";

            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString()+" Грн";
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            myConnection.Close();

            dataGridView3.Rows.Clear();

            foreach (string[] s in data)
                dataGridView3.Rows.Add(s);


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            MySqlConnection myConnection = new MySqlConnection("server=localhost; port=3307; username=root; password=root; database=mobile_operator");

            myConnection.Open();

            string tarifName = textBox1.Text;
            string query = "SELECT cl_name, cl_surname, cl_balance from clients;";



            MySqlCommand command = new MySqlCommand(query, myConnection);

            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString()+" Грн";
            }

            reader.Close();

            myConnection.Close();

            dataGridView2.Rows.Clear();

            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            MySqlConnection myConnection = new MySqlConnection("server=localhost; port=3307; username=root; password=root; database=mobile_operator");

            myConnection.Open();

            string tarifName = textBox1.Text;
            string query = "SELECT cl_name, cl_surname, cl_balance, d_status  from deals join tarif using (tarif_id) join clients using (cl_id) where d_status = 'Заблоковано';";



            MySqlCommand command = new MySqlCommand(query, myConnection);

            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString()+" Грн";
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            myConnection.Close();

            dataGridView4.Rows.Clear();

            foreach (string[] s in data)
                dataGridView4.Rows.Add(s);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            MySqlConnection myConnection = new MySqlConnection("server=localhost; port=3307; username=root; password=root; database=mobile_operator");

            myConnection.Open();


            string query = "SELECT tarif_id, tarif_name, tarif_price, tarif_description, tarif_network_experience FROM tarif; ";

            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString()+" Грн";
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            myConnection.Close();

            dataGridView3.Rows.Clear();

            foreach (string[] s in data)
                dataGridView3.Rows.Add(s);


        }

       
    }
}
