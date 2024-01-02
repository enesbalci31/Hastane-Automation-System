namespace HastaneOtomasyonu
{
    partial class HospitalScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalScreen));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(104, 250);
            button1.Name = "button1";
            button1.Size = new Size(242, 183);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(408, 250);
            button2.Name = "button2";
            button2.Size = new Size(238, 183);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(704, 250);
            button3.Name = "button3";
            button3.Size = new Size(238, 183);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(183, 445);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 1;
            label1.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(472, 445);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 1;
            label2.Text = "Doktor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCyan;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(753, 445);
            label3.Name = "label3";
            label3.Size = new Size(121, 34);
            label3.TabIndex = 1;
            label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(704, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ravie", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(125, 88);
            label4.Name = "label4";
            label4.Size = new Size(403, 40);
            label4.TabIndex = 3;
            label4.Text = "Sky Blue Hastanesi";
            // 
            // HospitalScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1051, 543);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "HospitalScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastane Yönetim  Sistemi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
