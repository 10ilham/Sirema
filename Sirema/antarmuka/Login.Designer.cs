namespace Sirema
{
    partial class Login
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
            this.Password = new System.Windows.Forms.TextBox();
            this.User_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(323, 217);
            this.Password.Name = "Password";
            this.Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Password.Size = new System.Drawing.Size(251, 22);
            this.Password.TabIndex = 10;
            this.Password.UseSystemPasswordChar = true;
            // 
            // User_id
            // 
            this.User_id.Location = new System.Drawing.Point(323, 174);
            this.User_id.Name = "User_id";
            this.User_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.User_id.Size = new System.Drawing.Size(251, 22);
            this.User_id.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 85);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "-- LOGIN --";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 218);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "PASSWORD";
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(168, 279);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Login_btn.Size = new System.Drawing.Size(195, 38);
            this.Login_btn.TabIndex = 12;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 173);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "USER ID";
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(379, 279);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Exit_btn.Size = new System.Drawing.Size(195, 38);
            this.Exit_btn.TabIndex = 13;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Login_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.User_id);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Location = new System.Drawing.Point(-10, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 463);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox User_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Panel panel1;
    }
}