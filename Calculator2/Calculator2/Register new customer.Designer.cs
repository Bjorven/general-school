﻿namespace Calculator2
{
    partial class RegisterNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterNewCustomer));
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.sureNameLabel = new System.Windows.Forms.Label();
            this.MailAdressLabel = new System.Windows.Forms.Label();
            this.PhoneNrLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            resources.ApplyResources(this.FirstNameLabel, "FirstNameLabel");
            this.FirstNameLabel.Name = "FirstNameLabel";
            // 
            // sureNameLabel
            // 
            resources.ApplyResources(this.sureNameLabel, "sureNameLabel");
            this.sureNameLabel.Name = "sureNameLabel";
            // 
            // MailAdressLabel
            // 
            resources.ApplyResources(this.MailAdressLabel, "MailAdressLabel");
            this.MailAdressLabel.Name = "MailAdressLabel";
            // 
            // PhoneNrLabel
            // 
            resources.ApplyResources(this.PhoneNrLabel, "PhoneNrLabel");
            this.PhoneNrLabel.Name = "PhoneNrLabel";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // RegisterButton
            // 
            resources.ApplyResources(this.RegisterButton, "RegisterButton");
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // RegisterNewCustomer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PhoneNrLabel);
            this.Controls.Add(this.MailAdressLabel);
            this.Controls.Add(this.sureNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterNewCustomer";
            this.Load += new System.EventHandler(this.New_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label sureNameLabel;
        private System.Windows.Forms.Label MailAdressLabel;
        private System.Windows.Forms.Label PhoneNrLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button RegisterButton;
    }
}