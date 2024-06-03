namespace WinFormsApp6
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 32);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 0;
            label1.Text = "Войдите в профиль\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(612, 25);
            label2.TabIndex = 1;
            label2.Text = "Чтобы обращаться в поддержку и следить за ценами на нужные билеты ";
            // 
            // button1
            // 
            button1.Location = new Point(118, 147);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(29, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 233);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 45);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 92);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 141);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 2;
            label5.Text = "label5";
            // 
            // button2
            // 
            button2.Location = new Point(11, 742);
            button2.Name = "button2";
            button2.Size = new Size(60, 39);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(77, 742);
            button3.Name = "button3";
            button3.Size = new Size(60, 39);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(152, 742);
            button4.Name = "button4";
            button4.Size = new Size(60, 39);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(230, 742);
            button5.Name = "button5";
            button5.Size = new Size(60, 39);
            button5.TabIndex = 7;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(296, 742);
            button6.Name = "button6";
            button6.Size = new Size(60, 39);
            button6.TabIndex = 8;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 788);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "профиль";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}