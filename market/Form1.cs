using Microsoft.VisualBasic.Logging;
using System.Text.RegularExpressions;

namespace market
{
    public partial class Form1 : Form
    {
        string line;
        public int man = 0;

        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string email = textBox3.Text;

            try
            {
                using (StreamReader sr = new StreamReader("people.txt"))
                {
                    string line;
                    bool found = false;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(login) && line.Contains(password) && line.Contains(email))
                        {
                            found = true;
                            DialogResult dr = MessageBox.Show("�� ����� � ���.", "login", MessageBoxButtons.OK);
                            if (dr == DialogResult.OK)
                            {
                                if (checkBox1.Checked)
                                {
                                    Form2 form2 = new Form2(1);
                                    form2.HidePanel();
                                    form2.Show();
                                    man = 1;
                                }
                                else if (checkBox2.Checked)
                                {
                                    Form2 form2 = new Form2(2);
                                    form2.HidePanel();
                                    form2.Show();
                                    man = 2;
                                }
                                else
                                {
                                    MessageBox.Show("�� ���� CheckBox �� ������.");
                                }
                            }
                            break;
                        }
                    }

                    if (!found)
                    {
                        MessageBox.Show("����� ��� ������ �� �������.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ������ �����: " + ex.Message);
            }
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }

        private static bool IsValidPassword(string password)
        {
            for (int i = 0; i < password.Length - 1; i++)
            {
                char currentChar = password[i];
                char nextChar = password[i + 1];

                if ((currentChar + 1) == nextChar || (nextChar + 1) == currentChar)
                {
                    if (!((currentChar >= 'a' && currentChar <= 'z') || (currentChar >= 'A' && currentChar <= 'Z')) ||
                        !((nextChar >= 'a' && nextChar <= 'z') || (nextChar >= 'A' && nextChar <= 'Z')))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string email = textBox3.Text;

            if (login.Length < 3)
            {
                MessageBox.Show("����� ������ ��������� �� ����� 3 ��������.");
                return;
            }
            if (login.Contains(" "))
            {
                MessageBox.Show("����� �� ������ ��������� �������.");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("������ ������ ��������� �� ����� 8 ��������.");
                return;
            }
            if (password.Contains(" "))
            {
                MessageBox.Show("������ �� ������ ��������� �������.");
                return;
            }
            if (!Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"[a-z]") || !Regex.IsMatch(password, @"[0-9]"))
            {
                MessageBox.Show("������ ������ ��������� ����� � ����� ������� ��������.");
                return;
            }
            if (!Regex.IsMatch(password, @"[!\�;@%?]"))
            {
                MessageBox.Show("������ ������ ��������� ����������� (!\"�;@%:?).");
                return;
            }
            if (!IsValidPassword(password))
            {
                MessageBox.Show("������ �� ������ ��������� ������� �������.");
                return;
            }

            using (StreamWriter sw = File.AppendText("people.txt"))
            {
                sw.Write("\n" + textBox1.Text + " ");
                sw.Write(textBox2.Text + " ");
                sw.Write((checkBox1.Checked ? "1" : "0") + " ");
                sw.Write((checkBox2.Checked ? "1" : "0") + " ");
                sw.Write(textBox3.Text + " ");
            }
            MessageBox.Show("�� ����������������", "Accept");
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = null;
            textBox3.ForeColor = Color.Black;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
