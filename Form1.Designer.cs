namespace TemperatureConversionApp
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
            label3 = new Label();
            txt_Fahrenheit = new TextBox();
            txt_Celsius = new TextBox();
            txt_Kelvin = new TextBox();
            btn_Fahrenheit = new Button();
            btn_Celsius = new Button();
            btn_Kelvin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(95, 73);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 0;
            label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(134, 157);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 1;
            label2.Text = "Celsius";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(143, 241);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 2;
            label3.Text = "Kelvin";
            // 
            // txt_Fahrenheit
            // 
            txt_Fahrenheit.Font = new Font("Segoe UI", 14F);
            txt_Fahrenheit.Location = new Point(327, 76);
            txt_Fahrenheit.Name = "txt_Fahrenheit";
            txt_Fahrenheit.Size = new Size(185, 39);
            txt_Fahrenheit.TabIndex = 3;
            // 
            // txt_Celsius
            // 
            txt_Celsius.Font = new Font("Segoe UI", 14F);
            txt_Celsius.Location = new Point(327, 157);
            txt_Celsius.Name = "txt_Celsius";
            txt_Celsius.Size = new Size(185, 39);
            txt_Celsius.TabIndex = 4;
            // 
            // txt_Kelvin
            // 
            txt_Kelvin.Font = new Font("Segoe UI", 14F);
            txt_Kelvin.Location = new Point(327, 238);
            txt_Kelvin.Name = "txt_Kelvin";
            txt_Kelvin.Size = new Size(185, 39);
            txt_Kelvin.TabIndex = 5;
            // 
            // btn_Fahrenheit
            // 
            btn_Fahrenheit.BackColor = SystemColors.AppWorkspace;
            btn_Fahrenheit.Font = new Font("Segoe UI", 10F);
            btn_Fahrenheit.Location = new Point(624, 78);
            btn_Fahrenheit.Name = "btn_Fahrenheit";
            btn_Fahrenheit.Size = new Size(125, 35);
            btn_Fahrenheit.TabIndex = 6;
            btn_Fahrenheit.Text = "Convert";
            btn_Fahrenheit.UseVisualStyleBackColor = false;
            btn_Fahrenheit.Click += btn_Fahrenheit_Click;
            // 
            // btn_Celsius
            // 
            btn_Celsius.BackColor = SystemColors.AppWorkspace;
            btn_Celsius.Font = new Font("Segoe UI", 10F);
            btn_Celsius.Location = new Point(624, 161);
            btn_Celsius.Name = "btn_Celsius";
            btn_Celsius.Size = new Size(125, 35);
            btn_Celsius.TabIndex = 7;
            btn_Celsius.Text = "Convert";
            btn_Celsius.UseVisualStyleBackColor = false;
            btn_Celsius.Click += btn_Celsius_Click;
            // 
            // btn_Kelvin
            // 
            btn_Kelvin.BackColor = SystemColors.AppWorkspace;
            btn_Kelvin.Font = new Font("Segoe UI", 10F);
            btn_Kelvin.Location = new Point(624, 244);
            btn_Kelvin.Name = "btn_Kelvin";
            btn_Kelvin.Size = new Size(125, 35);
            btn_Kelvin.TabIndex = 8;
            btn_Kelvin.Text = "Convert";
            btn_Kelvin.UseVisualStyleBackColor = false;
            btn_Kelvin.Click += btn_Kelvin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Kelvin);
            Controls.Add(btn_Celsius);
            Controls.Add(btn_Fahrenheit);
            Controls.Add(txt_Kelvin);
            Controls.Add(txt_Celsius);
            Controls.Add(txt_Fahrenheit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Fahrenheit;
        private TextBox txt_Celsius;
        private TextBox txt_Kelvin;
        private Button btn_Fahrenheit;
        private Button btn_Celsius;
        private Button btn_Kelvin;
    }
}
