namespace PROJE0101
{
    partial class Form4
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(68, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "İSİM SOYİSİM";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 49);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 58);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(480, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 34);
            textBox3.TabIndex = 2;
            textBox3.Text = "KART NUMARASI";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(480, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(273, 27);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox5.Location = new Point(68, 376);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 34);
            textBox5.TabIndex = 4;
            textBox5.Text = "SKT";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(68, 432);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(266, 27);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox7.Location = new Point(480, 9);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(213, 34);
            textBox7.TabIndex = 6;
            textBox7.Text = "ÖDENECEK TUTAR";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(480, 49);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(273, 58);
            textBox8.TabIndex = 7;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox9.Location = new Point(68, 208);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 34);
            textBox9.TabIndex = 8;
            textBox9.Text = "CVV";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(68, 261);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(266, 27);
            textBox10.TabIndex = 9;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(68, 141);
            label1.Name = "label1";
            label1.Size = new Size(344, 23);
            label1.TabIndex = 10;
            label1.Text = "İSİM SOYİSİM HATALI ! TEKRAR DENEYİNİZ";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(68, 310);
            label2.Name = "label2";
            label2.Size = new Size(270, 23);
            label2.TabIndex = 11;
            label2.Text = "CVV HATALI ! TEKRAR DENEYİNİZ";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(68, 482);
            label3.Name = "label3";
            label3.Size = new Size(265, 23);
            label3.TabIndex = 12;
            label3.Text = "SKT HATALI ! TEKRAR DENEYİNİZ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(480, 261);
            label4.Name = "label4";
            label4.Size = new Size(371, 23);
            label4.TabIndex = 13;
            label4.Text = "KART NUMARASI HATALI ! TEKRAR DENEYİNİZ";
            label4.Visible = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(932, 541);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form4";
            Text = "ÖDEME EKRANI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}