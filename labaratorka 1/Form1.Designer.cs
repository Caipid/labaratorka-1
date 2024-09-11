namespace labaratorka_1
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            shrina = new TextBox();
            dlina = new TextBox();
            gradus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(505, 333);
            button1.Name = "button1";
            button1.Size = new Size(309, 29);
            button1.TabIndex = 0;
            button1.Text = "Рассчитать площадь параллерограмма";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(505, 297);
            button2.Name = "button2";
            button2.Size = new Size(306, 31);
            button2.TabIndex = 1;
            button2.Text = "Рассчитать периметр параллерограмма";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // shrina
            // 
            shrina.Location = new Point(318, 32);
            shrina.Name = "shrina";
            shrina.Size = new Size(139, 27);
            shrina.TabIndex = 4;
            shrina.TextChanged += textBox3_TextChanged;
            shrina.Leave += shrina_Leave;
            // 
            // dlina
            // 
            dlina.Location = new Point(318, 65);
            dlina.Name = "dlina";
            dlina.Size = new Size(139, 27);
            dlina.TabIndex = 5;
            dlina.Leave += dlina_Leave;
            // 
            // gradus
            // 
            gradus.Location = new Point(318, 95);
            gradus.Name = "gradus";
            gradus.Size = new Size(139, 27);
            gradus.TabIndex = 9;
            gradus.Leave += gradus_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 363);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 383);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 32);
            label3.Name = "label3";
            label3.Size = new Size(259, 20);
            label3.TabIndex = 14;
            label3.Text = "Введите ширину параллелограмма:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 65);
            label4.Name = "label4";
            label4.Size = new Size(254, 20);
            label4.TabIndex = 15;
            label4.Text = "Введите длинну параллелограмма:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 98);
            label5.Name = "label5";
            label5.Size = new Size(296, 20);
            label5.TabIndex = 16;
            label5.Text = "Введите угол между любыми сторонами:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 39);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 17;
            label6.Text = "См";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(463, 72);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 18;
            label7.Text = "См";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(463, 102);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 19;
            label8.Text = "Градусы";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 363);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 20;
            label9.Text = "Периметр:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 383);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 21;
            label10.Text = "Площадь:";
            label10.Click += label10_Click;
            // 
            // button3
            // 
            button3.Location = new Point(505, 383);
            button3.Name = "button3";
            button3.Size = new Size(306, 29);
            button3.TabIndex = 22;
            button3.Text = "Завершение программы";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 450);
            Controls.Add(button3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gradus);
            Controls.Add(dlina);
            Controls.Add(shrina);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Расчет параллерограмма";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox shrina;
        private TextBox dlina;
        private TextBox gradus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button3;
    }
}