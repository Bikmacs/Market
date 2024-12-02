using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class Form2 : Form
    {
        private string imagePath;
        private int man;

        public Form2(int man)
        {

            InitializeComponent();
            this.man = man;
            this.Load += Form2_Load;
            InitializeDataGridView();
            ConfigureVisibility();


            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
        private void InitializeDataGridView()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Название" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Количество" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Цена" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Manufacturer", HeaderText = "Изготовитель" });

                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn()
                {
                    Name = "Action",
                    HeaderText = "Покупка",
                    Text = "КУПИТЬ",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(buttonColumn);
            }

            if (dataGridView2.Columns.Count == 0)
            {
                dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Название" });
                dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Количество" });
                dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Цена" });
                dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Manufacturer", HeaderText = "Изготовитель" });
                dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "ImagePath", HeaderText = "Путь к изображению" });
            }

            if (dataGridView3.Columns.Count == 0)
            {
                dataGridView3.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Название" });
                dataGridView3.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Количество" });
            }

            if (dataGridView4.Columns.Count == 0)
            {
                dataGridView4.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Название" });
                dataGridView4.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Количество" });
                //dataGridView4.Columns.Add(new DataGridViewTextBoxColumn { Name = "Oplachen", HeaderText = "Статус" });
                dataGridView4.Columns.Add(new DataGridViewTextBoxColumn { Name = "User", HeaderText = "Пользователь" });
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Action"].Index && e.RowIndex >= 0)
            {
                string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                string quantity = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value?.ToString();

                if (name != null && quantity != null)
                {
                    string user = GetUserFilePath("people.txt");
                    OpenForm4(name, quantity, user);
                }
            }
        }

        private void OpenForm4(string name, string quantity, string user)
        {
            Form4 form4 = new Form4(name, quantity, user);
            form4.Show();
        }

        public void HidePanel()
        {
            button3.Visible = true;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            LoadProductsForDataGridView1("sale.txt");
            LoadProductsForDataGridView2("market.txt");
            LoadZakazyFromFile("korzina.txt");
            LoadKorzinaFromFile("korzina.txt");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void ConfigureVisibility()
        {
            if (man == 1)
            {
                dataGridView2.Visible = false;
                button4.Visible = false;
            }
            else
            {
                dataGridView1.Visible = false;
                button4.Visible = true;
            }
            button3.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    button1.BackgroundImage = Image.FromFile(imagePath);
                    button1.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText("market.txt", string.Empty);

            using (StreamWriter sw = new StreamWriter("market.txt", true))
            {
                sw.Write("\n" + textBox1.Text + " ");
                sw.Write(textBox2.Text + " ");
                sw.Write(textBox3.Text + " ");
                sw.Write(imagePath);
            }

            MessageBox.Show("Магазин сохранен", "Accept");
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click_1(object sender, EventArgs e)
        {

        }

        private void LoadProductsFromFile(string filePath)
        {
            if (man == 1)
            {
                dataGridView1.Rows.Clear();
                dataGridView3.Rows.Clear();
            }
            else
            {
                dataGridView2.Rows.Clear();
            }

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 5)
                    {
                        if (man == 1)
                        {
                            dataGridView1.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4]);
                        }
                        else
                        {
                            dataGridView2.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4]);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не найден.", "Ошибка");
            }
        }

        private void LoadProductsForDataGridView1(string filePath)
        {
            dataGridView1.Rows.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 5)
                    {
                        dataGridView1.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не найден.", "Ошибка");
            }
        }

        private void LoadProductsForDataGridView2(string filePath)
        {
            dataGridView2.Rows.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 5)
                    {
                        dataGridView2.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не найден.", "Ошибка");
            }
        }
        private void LoadZakazyFromFile(string filePath)
        {
            dataGridView4.Rows.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 3)
                    {
                        dataGridView4.Rows.Add(parts[0], parts[1], parts[2]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не найден.", "Ошибка");
            }
        }


        private void LoadKorzinaFromFile(string filePath)
        {
            dataGridView3.Rows.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2)
                    {
                        dataGridView3.Rows.Add(parts[0], parts[1]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не найден.", "Ошибка");
            }
        }

        private string GetUserFilePath(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 1)
                    {
                        return parts[0];
                    }
                }
            }
            return string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            LoadProductsFromFile("sale.txt");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadKorzinaFromFile("korzina.txt");

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadZakazyFromFile("korzina.txt");
        }
    }
}
