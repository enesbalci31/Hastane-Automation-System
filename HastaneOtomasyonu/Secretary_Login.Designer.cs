namespace HastaneOtomasyonu
{
    partial class Secretary_Login
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
            button1 = new Button();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(222, 285);
            button1.Name = "button1";
            button1.Size = new Size(164, 43);
            button1.TabIndex = 11;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(222, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 34);
            textBox1.TabIndex = 10;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            maskedTextBox1.Location = new Point(222, 172);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(164, 34);
            maskedTextBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(152, 231);
            label3.Name = "label3";
            label3.Size = new Size(64, 31);
            label3.TabIndex = 5;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(68, 175);
            label2.Name = "label2";
            label2.Size = new Size(148, 31);
            label2.TabIndex = 6;
            label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 67);
            label1.Name = "label1";
            label1.Size = new Size(472, 67);
            label1.TabIndex = 7;
            label1.Text = "Sekreter Giriş Paneli";
            // 
            // Secretary_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(553, 386);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Secretary_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sekreter Giriş  Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}