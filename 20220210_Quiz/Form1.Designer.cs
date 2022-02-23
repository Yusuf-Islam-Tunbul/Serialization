namespace _20220210_Quiz
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
            this.user_name_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.user_name_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.log_in_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_name_textbox
            // 
            this.user_name_textbox.Location = new System.Drawing.Point(70, 12);
            this.user_name_textbox.Name = "user_name_textbox";
            this.user_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.user_name_textbox.TabIndex = 0;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(70, 38);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(100, 20);
            this.password_textbox.TabIndex = 1;
            // 
            // user_name_label
            // 
            this.user_name_label.AutoSize = true;
            this.user_name_label.Location = new System.Drawing.Point(2, 15);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(64, 13);
            this.user_name_label.TabIndex = 2;
            this.user_name_label.Text = "Kullanıcı Adı";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(2, 41);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(28, 13);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Şifre";
            // 
            // log_in_button
            // 
            this.log_in_button.Location = new System.Drawing.Point(5, 64);
            this.log_in_button.Name = "log_in_button";
            this.log_in_button.Size = new System.Drawing.Size(165, 23);
            this.log_in_button.TabIndex = 4;
            this.log_in_button.Text = "GİRİŞ YAP";
            this.log_in_button.UseVisualStyleBackColor = true;
            this.log_in_button.Click += new System.EventHandler(this.log_in_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 94);
            this.Controls.Add(this.log_in_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.user_name_label);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.user_name_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_name_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button log_in_button;
    }
}

