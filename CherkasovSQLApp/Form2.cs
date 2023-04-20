using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CherkasovSQLApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);
        }

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        // Обработчик события MouseDown
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        // Обработчик события MouseMove
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int xDiff = Cursor.Position.X - lastCursor.X;
                int yDiff = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + xDiff, lastForm.Y + yDiff);
            }
        }

        // Обработчик события MouseUp
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 Autori = new Form1();
            Autori.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите выйти из приложенеия?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Введите логин";//подсказка
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Введите пароль";//подсказка
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Введите имя";//подсказка
            textBox3.ForeColor = Color.Gray;
            textBox4.Text = "Введите почту";//подсказка
            textBox4.ForeColor = Color.Gray;

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.ForeColor = Color.Black;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите логин";//подсказка
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Введите пароль";//подсказка
                textBox2.ForeColor = Color.Gray;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Введите имя";//подсказка
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Введите почту";//подсказка
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Gray;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Gray;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            buttonRegister.BackColor = Color.FromArgb(35, 66, 40);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            buttonRegister.BackColor = Color.FromArgb(34, 39, 50);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkGray;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.Gray || textBox2.ForeColor == Color.Gray || textBox3.ForeColor == Color.Gray || textBox4.ForeColor == Color.Gray)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                if (isUserExists())
                    return;
                DataBase DB = new DataBase();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `mail`) VALUES (@login, @password, @name, @mail)", DB.getConnection());

                command.Parameters.Add("@login",MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox3.Text;
                command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = textBox4.Text;

                DB.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы успешно зарегистрировались!");
                else
                    MessageBox.Show("Ошибка! Аккаунт не был создан.");
                DB.closeConnection();
            }
        }
        public Boolean isUserExists()
        {
            DataBase DB = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", DB.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox1.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже занят!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
