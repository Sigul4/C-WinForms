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

namespace BdProject
{
    public partial class authorizationForm : Form
    {
        public authorizationForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button ==MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void authorization_Click(object sender, EventArgs e)
        {
            String userName = login.Text;
            String userSurname = login.Text;
            String userPassword = password.Text;

            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee` WHERE `e_name` = @uN or `e_surname` = @uS AND `e_pass` = @uP", dataBase.getConnection());
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@uS", MySqlDbType.VarChar).Value = userSurname;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Fine, let`s work?"); 
                this.Hide();
                Form2 Form2 = new Form2();
                Form2.Show();
            }
            else
            {

                MessageBox.Show("Incorect data");
            }


        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main Main = new Main();
            Main.Show();
        }

        private void registration_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm registrationForm = new registrationForm();
            registrationForm.Show();
        }


    }
}
