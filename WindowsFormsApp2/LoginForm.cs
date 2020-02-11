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

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
        static public String name;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passwordUser = passwordField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                name = loginUser;
                Console.WriteLine(name);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Не коректные данные");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
