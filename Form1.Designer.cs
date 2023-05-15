namespace Курсовая
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            button6 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(43, 92);
            button1.Name = "button1";
            button1.Size = new Size(238, 52);
            button1.TabIndex = 1;
            button1.Text = "Привести к стандартному виду";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(43, 291);
            button2.Name = "button2";
            button2.Size = new Size(126, 52);
            button2.TabIndex = 2;
            button2.Text = "Сложить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(43, 227);
            button3.Name = "button3";
            button3.Size = new Size(126, 52);
            button3.TabIndex = 3;
            button3.Text = "Вычесть";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(43, 358);
            button4.Name = "button4";
            button4.Size = new Size(126, 52);
            button4.TabIndex = 4;
            button4.Text = "Умножить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(323, 32);
            label1.TabIndex = 6;
            label1.Text = "Операции над полиномами";
            // 
            // button5
            // 
            button5.Location = new Point(43, 159);
            button5.Name = "button5";
            button5.Size = new Size(238, 52);
            button5.TabIndex = 7;
            button5.Text = "Вычислить значение многочлена";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(43, 425);
            button6.Name = "button6";
            button6.Size = new Size(126, 52);
            button6.TabIndex = 8;
            button6.Text = "Разделить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(328, 92);
            label3.Name = "label3";
            label3.Size = new Size(697, 299);
            label3.TabIndex = 10;
            label3.Text = resources.GetString("label3.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 522);
            Controls.Add(label3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Операции с полиномами";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button6;
        private Label label3;
    }
}