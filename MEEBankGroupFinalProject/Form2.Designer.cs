namespace MEEBankGroupFinalProject
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
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(198, 135);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 28;
            label6.Text = "WELCOME";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = Color.White;
            label5.Location = new Point(336, 94);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 27;
            label5.Text = "Sign In";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(201, 382);
            button1.Name = "button1";
            button1.Size = new Size(68, 23);
            button1.TabIndex = 26;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Gill Sans MT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(201, 311);
            label4.Name = "label4";
            label4.Size = new Size(68, 18);
            label4.TabIndex = 25;
            label4.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(160, 285);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 23);
            textBox3.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Gill Sans MT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(197, 253);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 22;
            label2.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 23);
            textBox2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox1.Location = new Point(85, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 386);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(130, 23);
            label1.Name = "label1";
            label1.Size = new Size(217, 53);
            label1.TabIndex = 18;
            label1.Text = "MEEBank";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(457, 523);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button1;
        private Label label4;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}