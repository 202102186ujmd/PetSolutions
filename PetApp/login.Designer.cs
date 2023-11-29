namespace PetApp
{
    partial class login
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
            this.btningresarLogin = new System.Windows.Forms.Button();
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancelarlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btningresarLogin
            // 
            this.btningresarLogin.Location = new System.Drawing.Point(44, 199);
            this.btningresarLogin.Name = "btningresarLogin";
            this.btningresarLogin.Size = new System.Drawing.Size(75, 23);
            this.btningresarLogin.TabIndex = 0;
            this.btningresarLogin.Text = "Ingresar";
            this.btningresarLogin.UseVisualStyleBackColor = true;
            this.btningresarLogin.Click += new System.EventHandler(this.btningresarLogin_Click);
            // 
            // txbusuario
            // 
            this.txbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbusuario.Location = new System.Drawing.Point(24, 61);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(234, 24);
            this.txbusuario.TabIndex = 1;
            // 
            // txbpassword
            // 
            this.txbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbpassword.Location = new System.Drawing.Point(24, 150);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.Size = new System.Drawing.Size(234, 24);
            this.txbpassword.TabIndex = 2;
            this.txbpassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btncancelarlogin
            // 
            this.btncancelarlogin.Location = new System.Drawing.Point(157, 198);
            this.btncancelarlogin.Name = "btncancelarlogin";
            this.btncancelarlogin.Size = new System.Drawing.Size(75, 23);
            this.btncancelarlogin.TabIndex = 5;
            this.btncancelarlogin.Text = "Cancelar";
            this.btncancelarlogin.UseVisualStyleBackColor = true;
            this.btncancelarlogin.Click += new System.EventHandler(this.btncancelarlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "--Login--";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 306);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncancelarlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbpassword);
            this.Controls.Add(this.txbusuario);
            this.Controls.Add(this.btningresarLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Integral de Mascotas. Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btningresarLogin;
        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancelarlogin;
        private System.Windows.Forms.Label label3;
    }
}