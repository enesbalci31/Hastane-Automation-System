namespace HastaneOtomasyonu
{
    partial class Doctor_Detail
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            richTextBox1 = new RichTextBox();
            groupBox4 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Detay";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(181, 137);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 31);
            label4.TabIndex = 11;
            label4.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(181, 72);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 31);
            label3.TabIndex = 8;
            label3.Text = "00000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(25, 72);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 9;
            label2.Text = "TC kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(55, 137);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 31);
            label1.TabIndex = 10;
            label1.Text = "Ad Soyad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(411, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(753, 643);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Listesi";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(12, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(393, 308);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Detay";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(8, 38);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 10;
            label5.Text = "Şikayet:";
            label5.Click += label5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(747, 617);
            dataGridView1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(8, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(333, 226);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(20, 553);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(385, 125);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hızlı Erişim";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.Font = new Font("Segoe Print", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(6, 26);
            button1.Name = "button1";
            button1.Size = new Size(182, 41);
            button1.TabIndex = 0;
            button1.Text = "Bilgileri Düzenle";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LemonChiffon;
            button2.Font = new Font("Segoe Print", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(207, 26);
            button2.Name = "button2";
            button2.Size = new Size(172, 41);
            button2.TabIndex = 0;
            button2.Text = "Duyurular";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.Font = new Font("Segoe Print", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.Location = new Point(98, 73);
            button3.Name = "button3";
            button3.Size = new Size(179, 46);
            button3.TabIndex = 0;
            button3.Text = "Çıkış Yap";
            button3.UseVisualStyleBackColor = false;
            // 
            // Doctor_Detail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1169, 699);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Doctor_Detail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Detay Ekranı";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private RichTextBox richTextBox1;
        private Label label5;
        private GroupBox groupBox4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}