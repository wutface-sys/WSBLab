namespace ConsoleApp
{
    partial class Library
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.bookLbl = new System.Windows.Forms.Label();
            this.bookText = new System.Windows.Forms.TextBox();
            this.chkBtn = new System.Windows.Forms.Button();
            this.chkLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(56, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(309, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Witaj w naszej bibliotece";
            // 
            // bookLbl
            // 
            this.bookLbl.AutoSize = true;
            this.bookLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bookLbl.Location = new System.Drawing.Point(75, 101);
            this.bookLbl.Name = "bookLbl";
            this.bookLbl.Size = new System.Drawing.Size(150, 20);
            this.bookLbl.TabIndex = 1;
            this.bookLbl.Text = "Podaj nazwe ksiazki";
            // 
            // bookText
            // 
            this.bookText.Location = new System.Drawing.Point(242, 94);
            this.bookText.Name = "bookText";
            this.bookText.Size = new System.Drawing.Size(166, 20);
            this.bookText.TabIndex = 2;
            // 
            // chkBtn
            // 
            this.chkBtn.Location = new System.Drawing.Point(434, 93);
            this.chkBtn.Name = "chkBtn";
            this.chkBtn.Size = new System.Drawing.Size(138, 20);
            this.chkBtn.TabIndex = 3;
            this.chkBtn.Text = "Sprawdz liste";
            this.chkBtn.UseVisualStyleBackColor = true;
            this.chkBtn.Click += new System.EventHandler(this.chkBtn_Click);
            // 
            // chkLbl
            // 
            this.chkLbl.AutoSize = true;
            this.chkLbl.Location = new System.Drawing.Point(593, 96);
            this.chkLbl.Name = "chkLbl";
            this.chkLbl.Size = new System.Drawing.Size(0, 13);
            this.chkLbl.TabIndex = 4;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkLbl);
            this.Controls.Add(this.chkBtn);
            this.Controls.Add(this.bookText);
            this.Controls.Add(this.bookLbl);
            this.Controls.Add(this.titleLabel);
            this.Name = "Library";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label bookLbl;
        private System.Windows.Forms.TextBox bookText;
        private System.Windows.Forms.Button chkBtn;
        private System.Windows.Forms.Label chkLbl;
    }
}