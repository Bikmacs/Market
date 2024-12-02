using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace market
{
    public partial class Form4 : Form
    {
        public string Name { get; set; }
        public string Quantity { get; set; }

        public string User {  get; set; }

        public Form4(string name, string quantity, string user)
        {
            InitializeComponent();
            Name = name;
            Quantity = quantity;
            User = user;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Text = Name;
            label4.Text = Quantity;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > Quantity.Length)
            {
                MessageBox.Show("Вы выбрали слишком много", "Error");
            }
            else
            {
                StreamWriter sw = File.AppendText("korzina.txt");
                sw.Write("\n" + Name + " ");
                sw.Write(textBox1.Text + " ");
                sw.Write(User + " ");
                sw.Close();
                DialogResult opachki = MessageBox.Show("Товар добавлен в каталог", "Accept", MessageBoxButtons.OK);
                if(opachki == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
