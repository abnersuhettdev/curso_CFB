namespace aula60
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
            btn_text = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btn_text
            // 
            btn_text.BackColor = Color.FromArgb(255, 255, 128);
            btn_text.ForeColor = Color.Crimson;
            btn_text.Location = new Point(220, 417);
            btn_text.Name = "btn_text";
            btn_text.Size = new Size(164, 68);
            btn_text.TabIndex = 0;
            btn_text.Text = "Texto";
            btn_text.UseVisualStyleBackColor = false;
            btn_text.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 43.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(117, 172);
            label1.Name = "label1";
            label1.Size = new Size(380, 87);
            label1.TabIndex = 1;
            label1.Text = "W3K CURSO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 312);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 597);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btn_text);
            ForeColor = SystemColors.ControlLight;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_text;
        private Label label1;
        private TextBox textBox1;
    }
}
