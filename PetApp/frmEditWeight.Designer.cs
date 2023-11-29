namespace PetApp
{
    partial class frmEditWeight
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
            this.gpbdatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cbxnamemascota = new System.Windows.Forms.ComboBox();
            this.gpbdatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbdatos
            // 
            this.gpbdatos.Controls.Add(this.cbxnamemascota);
            this.gpbdatos.Controls.Add(this.btncancelar);
            this.gpbdatos.Controls.Add(this.btnsave);
            this.gpbdatos.Controls.Add(this.dtFecha);
            this.gpbdatos.Controls.Add(this.label3);
            this.gpbdatos.Controls.Add(this.label2);
            this.gpbdatos.Controls.Add(this.label1);
            this.gpbdatos.Controls.Add(this.txtPeso);
            this.gpbdatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbdatos.Location = new System.Drawing.Point(0, 0);
            this.gpbdatos.Name = "gpbdatos";
            this.gpbdatos.Size = new System.Drawing.Size(432, 392);
            this.gpbdatos.TabIndex = 0;
            this.gpbdatos.TabStop = false;
            this.gpbdatos.Text = "Datos del registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(52, 155);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(269, 20);
            this.txtPeso.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mascota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha del registro";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(52, 230);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(130, 308);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(228, 308);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // cbxnamemascota
            // 
            this.cbxnamemascota.FormattingEnabled = true;
            this.cbxnamemascota.Location = new System.Drawing.Point(52, 84);
            this.cbxnamemascota.Name = "cbxnamemascota";
            this.cbxnamemascota.Size = new System.Drawing.Size(269, 21);
            this.cbxnamemascota.TabIndex = 8;
            // 
            // frmEditWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 394);
            this.Controls.Add(this.gpbdatos);
            this.Name = "frmEditWeight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditWeight";
            this.Load += new System.EventHandler(this.frmEditWeight_Load);
            this.gpbdatos.ResumeLayout(false);
            this.gpbdatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbdatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cbxnamemascota;
    }
}