namespace U3_Practica_6
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
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(384, 26);
            label1.TabIndex = 0;
            label1.Text = "Verificar si un número es par o impar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 89);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 1;
            label2.Text = "Inserte un número";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Thistle;
            listBox1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(218, 89);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 277);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(47, 205);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Verifica";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(36, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 28);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(407, 396);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Par o impar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
    }
}