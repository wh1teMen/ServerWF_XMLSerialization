namespace ServerWF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_ip = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_port = new System.Windows.Forms.MaskedTextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.label_con = new System.Windows.Forms.Label();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_ip
            // 
            this.comboBox_ip.Font = new System.Drawing.Font("Arial Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_ip.FormattingEnabled = true;
            this.comboBox_ip.Location = new System.Drawing.Point(21, 14);
            this.comboBox_ip.Name = "comboBox_ip";
            this.comboBox_ip.Size = new System.Drawing.Size(196, 38);
            this.comboBox_ip.TabIndex = 0;
            // 
            // maskedTextBox_port
            // 
            this.maskedTextBox_port.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_port.Location = new System.Drawing.Point(223, 15);
            this.maskedTextBox_port.Mask = "0000";
            this.maskedTextBox_port.Name = "maskedTextBox_port";
            this.maskedTextBox_port.Size = new System.Drawing.Size(63, 37);
            this.maskedTextBox_port.TabIndex = 1;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(292, 14);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(88, 38);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label_con
            // 
            this.label_con.AutoSize = true;
            this.label_con.Font = new System.Drawing.Font("Arial Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_con.Location = new System.Drawing.Point(20, 303);
            this.label_con.Name = "label_con";
            this.label_con.Size = new System.Drawing.Size(194, 30);
            this.label_con.TabIndex = 3;
            this.label_con.Text = "Соединение.....";
            // 
            // textBox_msg
            // 
            this.textBox_msg.Location = new System.Drawing.Point(21, 58);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.Size = new System.Drawing.Size(359, 242);
            this.textBox_msg.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 351);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.label_con);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.maskedTextBox_port);
            this.Controls.Add(this.comboBox_ip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ip;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_con;
        private System.Windows.Forms.TextBox textBox_msg;
    }
}

