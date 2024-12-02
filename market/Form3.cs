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
    public partial class Form3 : Form
    {
        private string imagePath2;
        public Form3()
        {
            InitializeComponent();
            string imagePath2;
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath2 = openFileDialog.FileName;
                    button1.BackgroundImage = Image.FromFile(imagePath2);
                    button1.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText("sale.txt"))
            {
                sw.WriteLine($"{textBox1.Text} {textBox2.Text} {textBox3.Text} {textBox4.Text} {imagePath2}");
            }
            MessageBox.Show("Магазин сохранен", "Accept");
        }

        
    }
}
