namespace Practice1
{
    partial class Form1
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
            this.bnt_clear = new System.Windows.Forms.Button();
            this.bnt_close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bnt_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_times = new System.Windows.Forms.Button();
            this.btn_divided = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bnt_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnt_clear
            // 
            this.bnt_clear.Location = new System.Drawing.Point(12, 227);
            this.bnt_clear.Name = "bnt_clear";
            this.bnt_clear.Size = new System.Drawing.Size(75, 22);
            this.bnt_clear.TabIndex = 0;
            this.bnt_clear.Text = "Nova Conta";
            this.bnt_clear.UseVisualStyleBackColor = true;
            this.bnt_clear.Click += new System.EventHandler(this.bnt_clear_Click);
            // 
            // bnt_close
            // 
            this.bnt_close.Location = new System.Drawing.Point(197, 226);
            this.bnt_close.Name = "bnt_close";
            this.bnt_close.Size = new System.Drawing.Size(75, 23);
            this.bnt_close.TabIndex = 1;
            this.bnt_close.Text = "Fechar";
            this.bnt_close.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // bnt_plus
            // 
            this.bnt_plus.Location = new System.Drawing.Point(172, 73);
            this.bnt_plus.Name = "bnt_plus";
            this.bnt_plus.Size = new System.Drawing.Size(21, 23);
            this.bnt_plus.TabIndex = 3;
            this.bnt_plus.Text = "+";
            this.bnt_plus.UseVisualStyleBackColor = true;
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(197, 73);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(21, 23);
            this.btn_minus.TabIndex = 4;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            // 
            // btn_times
            // 
            this.btn_times.Location = new System.Drawing.Point(224, 73);
            this.btn_times.Name = "btn_times";
            this.btn_times.Size = new System.Drawing.Size(21, 23);
            this.btn_times.TabIndex = 5;
            this.btn_times.Text = "x";
            this.btn_times.UseVisualStyleBackColor = true;
            // 
            // btn_divided
            // 
            this.btn_divided.Location = new System.Drawing.Point(251, 73);
            this.btn_divided.Name = "btn_divided";
            this.btn_divided.Size = new System.Drawing.Size(21, 23);
            this.btn_divided.TabIndex = 6;
            this.btn_divided.Text = "/";
            this.btn_divided.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero";
            this.label1.Click += new System.EventHandler(this.Numero_Click);
            // 
            // bnt_result
            // 
            this.bnt_result.Location = new System.Drawing.Point(172, 102);
            this.bnt_result.Name = "bnt_result";
            this.bnt_result.Size = new System.Drawing.Size(73, 23);
            this.bnt_result.TabIndex = 8;
            this.bnt_result.Text = "=";
            this.bnt_result.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bnt_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_divided);
            this.Controls.Add(this.btn_times);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.bnt_plus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bnt_close);
            this.Controls.Add(this.bnt_clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_clear;
        private System.Windows.Forms.Button bnt_close;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bnt_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_times;
        private System.Windows.Forms.Button btn_divided;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_result;
    }
}

