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
    public partial class Form3 : Form
    {
        public Form3()
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
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                this.Hide();
                Form1 MainForm = new Form1();
                MainForm.Show();
            }
            else
            {
                return;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Gray;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Gray;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {

            
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BorderStyle = BorderStyle.None;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BorderStyle = BorderStyle.None;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BorderStyle = BorderStyle.None;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BorderStyle = BorderStyle.None;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BorderStyle = BorderStyle.None;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
           label6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BorderStyle = BorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label7.Text = "Кружки";
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=cherkasovdata");
            connection.Open();
            string query = "SELECT * FROM circles";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);


 
            dataGridView1.Columns[0].HeaderText = "Код кружка";
            dataGridView1.Columns[1].HeaderText = "Название кружка";
            dataGridView1.Columns[2].HeaderText = "Описание кружка";
            dataGridView1.Columns[3].HeaderText = "Дата создания кружка";
            connection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label7.Text = "Руководители";
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=cherkasovdata");
            connection.Open();
            string query = "SELECT * FROM teachers";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;


            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);


            dataGridView1.Columns[0].HeaderText = "Код руководителя";
            dataGridView1.Columns[1].HeaderText = "ФИО руководителя";
            dataGridView1.Columns[2].HeaderText = "Адрес проживания";
            dataGridView1.Columns[3].HeaderText = "Контактный телефон";
            dataGridView1.Columns[4].HeaderText = "Электронная почта";
            connection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label7.Text = "Ученики";
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=cherkasovdata");
            connection.Open();
            string query = "SELECT * FROM students";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);


            dataGridView1.Columns[0].HeaderText = "Код ученика";
            dataGridView1.Columns[1].HeaderText = "ФИО ученика";
            dataGridView1.Columns[2].HeaderText = "Дата рождения";
            dataGridView1.Columns[3].HeaderText = "Адрес проживания";
            dataGridView1.Columns[4].HeaderText = "Контактный телефон";
            dataGridView1.Columns[5].HeaderText = "Электронная почта";
            connection.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label7.Text = "Посещаемость";
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=cherkasovdata");
            connection.Open();
            string query = "SELECT * FROM attendance_journal";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;


            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);



            dataGridView1.Columns[0].HeaderText = "Код записи";
            dataGridView1.Columns[1].HeaderText = "Дата записи";
            dataGridView1.Columns[2].HeaderText = "Код кружка";
            dataGridView1.Columns[3].HeaderText = "Код ученика";
            dataGridView1.Columns[4].HeaderText = "Код преподавателя";
            dataGridView1.Columns[5].HeaderText = "Оценка посещаемости";
            connection.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                this.Hide();
                Form1 MainForm = new Form1();
                MainForm.Show();
            }
            else
            {
                return;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
