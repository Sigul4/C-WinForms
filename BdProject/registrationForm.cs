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
    public partial class registrationForm : Form
    {

        public registrationForm()
        {
            InitializeComponent();


        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;


        private void registrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void registrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main Main = new Main();
            Main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorizationForm authorizationForm = new authorizationForm();
            authorizationForm.Show();
        }

        private void registration_Click(object sender, EventArgs e)

        {
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO employee (`e_name`,`e_surname`,`e_position`,`e_pass`) VALUES (@name, @surname,@position,@pass);", dataBase.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Name.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = Surname.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password.Text;
            command.Parameters.Add("@position", MySqlDbType.VarChar).Value = Seat.Text;

            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account was created");
                this.Hide();
                Form2 Form2 = new Form2();
                Form2.Show();
            }
            else
            {
                MessageBox.Show("Account wasn`t created");
            }
            dataBase.closeConnection();
        }

        private void Name_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Surname_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        
    }
}
