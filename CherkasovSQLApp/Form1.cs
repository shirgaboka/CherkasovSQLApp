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

namespace CherkasovSQLApp
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
               Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
                pictureBox5.Image = CherkasovSQLApp.Properties.Resources.view;
            }
            else
            {
                textBox2.PasswordChar = '*';
                pictureBox5.Image = CherkasovSQLApp.Properties.Resources.hide;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Введите логин";//подсказка
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Введите пароль";//подсказка
            textBox2.ForeColor = Color.Gray;
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
            textBox2.PasswordChar = '*';
            pictureBox5.Image = CherkasovSQLApp.Properties.Resources.hide;
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
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 Registration = new Form2();
            Registration.Show();
            this.Hide();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Gray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            buttonLogin.BackColor = Color.FromArgb(35, 66, 40);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.FromArgb(34, 39, 50);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkGray;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = textBox1.Text;
            String passUser = textBox2.Text;

            Form3 MainForma = new Form3();
            

            DataBase DB = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (textBox1.ForeColor == Color.Gray || textBox2.ForeColor == Color.Gray)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", DB.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

               if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Авторизация прошла успешно!");
                    
                    MainForma.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует или данные неверны!");
                }
                   
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form4 AboutMe = new Form4();
            AboutMe.Show();
            this.Hide();
            
        }
    }
}
