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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if(emailField.Text == "")
            {
                MessageBox.Show("Введите E-mail");
                return;
            }
            if (nameField.Text == "")
            {
                MessageBox.Show("Введите имья");
                return;
            }
            if (surnameField.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (!(passwordField.Text.Equals(recheckPassField.Text)))
            {
                MessageBox.Show("Неправильный проверочный пароль");
                return;
            }

            if (isUserExist())
            {
                return;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @pass, @name,@surname);", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = emailField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameField.Text;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан");
            }
            else
            {
                MessageBox.Show("Некоректные данные");
            }

            db.closeConnection();
        }

        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = emailField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("User is exist");
                return true;

            }
            else
            {
                MessageBox.Show("User is not exist");
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
