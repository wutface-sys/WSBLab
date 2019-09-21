namespace ConsoleApp
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
            this.UNLabel = new System.Windows.Forms.Label();
            this.PWLaber = new System.Windows.Forms.Label();
            this.UNtext = new System.Windows.Forms.TextBox();
            this.PWtext = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UNLabel
            // 
            this.UNLabel.AutoSize = true;
            this.UNLabel.Location = new System.Drawing.Point(33, 63);
            this.UNLabel.Name = "UNLabel";
            this.UNLabel.Size = new System.Drawing.Size(57, 13);
            this.UNLabel.TabIndex = 0;
            this.UNLabel.Text = "UserName";
            this.UNLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PWLaber
            // 
            this.PWLaber.AutoSize = true;
            this.PWLaber.Location = new System.Drawing.Point(34, 96);
            this.PWLaber.Name = "PWLaber";
            this.PWLaber.Size = new System.Drawing.Size(53, 13);
            this.PWLaber.TabIndex = 1;
            this.PWLaber.Text = "Password";
            // 
            // UNtext
            // 
            this.UNtext.Location = new System.Drawing.Point(118, 59);
            this.UNtext.Name = "UNtext";
            this.UNtext.Size = new System.Drawing.Size(121, 20);
            this.UNtext.TabIndex = 2;
            this.UNtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PWtext
            // 
            this.PWtext.Location = new System.Drawing.Point(116, 97);
            this.PWtext.Name = "PWtext";
            this.PWtext.Size = new System.Drawing.Size(122, 20);
            this.PWtext.TabIndex = 3;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(82, 216);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(142, 39);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(42, 153);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 331);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PWtext);
            this.Controls.Add(this.UNtext);
            this.Controls.Add(this.PWLaber);
            this.Controls.Add(this.UNLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UNLabel;
        private System.Windows.Forms.Label PWLaber;
        private System.Windows.Forms.TextBox UNtext;
        private System.Windows.Forms.TextBox PWtext;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label errorLabel;
    }
}