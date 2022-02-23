
namespace _20220210_Quiz
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
            this.width_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.left_textbox = new System.Windows.Forms.TextBox();
            this.top_textbox = new System.Windows.Forms.TextBox();
            this.height_textbox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // width_textbox
            // 
            resources.ApplyResources(this.width_textbox, "width_textbox");
            this.width_textbox.Name = "width_textbox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // left_textbox
            // 
            resources.ApplyResources(this.left_textbox, "left_textbox");
            this.left_textbox.Name = "left_textbox";
            // 
            // top_textbox
            // 
            resources.ApplyResources(this.top_textbox, "top_textbox");
            this.top_textbox.Name = "top_textbox";
            // 
            // height_textbox
            // 
            resources.ApplyResources(this.height_textbox, "height_textbox");
            this.height_textbox.Name = "height_textbox";
            // 
            // save_button
            // 
            resources.ApplyResources(this.save_button, "save_button");
            this.save_button.Name = "save_button";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.height_textbox);
            this.Controls.Add(this.top_textbox);
            this.Controls.Add(this.left_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.width_textbox);
            this.Name = "Form2";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox width_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox left_textbox;
        private System.Windows.Forms.TextBox top_textbox;
        private System.Windows.Forms.TextBox height_textbox;
        private System.Windows.Forms.Button save_button;
    }
}