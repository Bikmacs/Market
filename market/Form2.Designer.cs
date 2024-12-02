namespace market
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            tabPage6 = new TabPage();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            dataGridView3 = new DataGridView();
            tabPage2 = new TabPage();
            button10 = new Button();
            button9 = new Button();
            dataGridView4 = new DataGridView();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(925, 573);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(917, 540);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Каталог";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 416);
            dataGridView1.TabIndex = 5;
            // 
            // button5
            // 
            button5.Location = new Point(739, 56);
            button5.Name = "button5";
            button5.Size = new Size(87, 44);
            button5.TabIndex = 3;
            button5.Text = "Обновить";
            button5.Click += button5_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(7, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(654, 413);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(739, 106);
            button4.Name = "button4";
            button4.Size = new Size(87, 44);
            button4.TabIndex = 1;
            button4.Text = "Создать";
            button4.Click += Button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(739, 6);
            button3.Name = "button3";
            button3.Size = new Size(87, 44);
            button3.TabIndex = 0;
            button3.Text = "назад";
            button3.Click += button3_Click;
            // 
            // tabPage6
            // 
            tabPage6.BackgroundImage = (Image)resources.GetObject("tabPage6.BackgroundImage");
            tabPage6.Controls.Add(button8);
            tabPage6.Controls.Add(button7);
            tabPage6.Controls.Add(button6);
            tabPage6.Controls.Add(dataGridView3);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(917, 540);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Корзина";
            tabPage6.UseVisualStyleBackColor = true;
            tabPage6.Click += tabPage6_Click;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Location = new Point(-4, 194);
            button8.Name = "button8";
            button8.Size = new Size(921, 350);
            button8.TabIndex = 5;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(515, 67);
            button7.Name = "button7";
            button7.Size = new Size(87, 44);
            button7.TabIndex = 4;
            button7.Text = "Обновить";
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(515, 17);
            button6.Name = "button6";
            button6.Size = new Size(87, 44);
            button6.TabIndex = 1;
            button6.Text = "назад";
            button6.Click += button6_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(7, 6);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(475, 182);
            dataGridView3.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(dataGridView4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(917, 540);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Заказы";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // button10
            // 
            button10.Location = new Point(568, 56);
            button10.Name = "button10";
            button10.Size = new Size(87, 44);
            button10.TabIndex = 5;
            button10.Text = "Обновить";
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(568, 6);
            button9.Name = "button9";
            button9.Size = new Size(87, 44);
            button9.TabIndex = 2;
            button9.Text = "назад";
            button9.Click += button9_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(7, 6);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(532, 275);
            dataGridView4.TabIndex = 0;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(917, 540);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Склад";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(917, 540);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Финансы";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImage = (Image)resources.GetObject("tabPage5.BackgroundImage");
            tabPage5.Controls.Add(button2);
            tabPage5.Controls.Add(textBox3);
            tabPage5.Controls.Add(textBox2);
            tabPage5.Controls.Add(textBox1);
            tabPage5.Controls.Add(label3);
            tabPage5.Controls.Add(label2);
            tabPage5.Controls.Add(label1);
            tabPage5.Controls.Add(button1);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(917, 540);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "профиль";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Olive;
            button2.Location = new Point(76, 447);
            button2.Name = "button2";
            button2.Size = new Size(277, 73);
            button2.TabIndex = 7;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(21, 116);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "место";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Тип ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // button1
            // 
            button1.Location = new Point(452, 16);
            button1.Name = "button1";
            button1.Size = new Size(564, 504);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(926, 575);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private TabPage tabPage2;
        public TabControl tabControl1;
        private Button button3;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button4;
        private DataGridView dataGridView2;
        private Button button5;
        private DataGridView dataGridView1;
        private TabPage tabPage6;
        private DataGridView dataGridView3;
        private Button button7;
        private Button button6;
        private Button button8;
        private DataGridView dataGridView4;
        private Button button10;
        private Button button9;
    }
}