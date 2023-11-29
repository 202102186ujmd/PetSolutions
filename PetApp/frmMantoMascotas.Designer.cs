namespace PetApp
{
    partial class frmMantoMascotas
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
            this.gpbedit = new System.Windows.Forms.GroupBox();
            this.btncancelarr = new System.Windows.Forms.Button();
            this.btneliminarr = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtespecie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.gpbedit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbedit
            // 
            this.gpbedit.Controls.Add(this.btncancelarr);
            this.gpbedit.Controls.Add(this.btneliminarr);
            this.gpbedit.Controls.Add(this.btnActualizar);
            this.gpbedit.Controls.Add(this.dtFechaNacimiento);
            this.gpbedit.Controls.Add(this.label5);
            this.gpbedit.Controls.Add(this.txtColor);
            this.gpbedit.Controls.Add(this.txtRaza);
            this.gpbedit.Controls.Add(this.label4);
            this.gpbedit.Controls.Add(this.label3);
            this.gpbedit.Controls.Add(this.txtespecie);
            this.gpbedit.Controls.Add(this.label2);
            this.gpbedit.Controls.Add(this.label1);
            this.gpbedit.Controls.Add(this.txtAlias);
            this.gpbedit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpbedit.Location = new System.Drawing.Point(0, 193);
            this.gpbedit.Name = "gpbedit";
            this.gpbedit.Size = new System.Drawing.Size(800, 288);
            this.gpbedit.TabIndex = 1;
            this.gpbedit.TabStop = false;
            this.gpbedit.Text = "Edicion de mascotas";
            this.gpbedit.Visible = false;
            // 
            // btncancelarr
            // 
            this.btncancelarr.Location = new System.Drawing.Point(481, 119);
            this.btncancelarr.Name = "btncancelarr";
            this.btncancelarr.Size = new System.Drawing.Size(250, 40);
            this.btncancelarr.TabIndex = 20;
            this.btncancelarr.Text = "Cancelar";
            this.btncancelarr.UseVisualStyleBackColor = true;
            this.btncancelarr.Click += new System.EventHandler(this.btncancelarr_Click);
            // 
            // btneliminarr
            // 
            this.btneliminarr.Location = new System.Drawing.Point(609, 50);
            this.btneliminarr.Name = "btneliminarr";
            this.btneliminarr.Size = new System.Drawing.Size(122, 37);
            this.btneliminarr.TabIndex = 19;
            this.btneliminarr.Text = "Eliminar";
            this.btneliminarr.UseVisualStyleBackColor = true;
            this.btneliminarr.Click += new System.EventHandler(this.btneliminarr_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(481, 50);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(122, 37);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.CustomFormat = "";
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(26, 220);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtFechaNacimiento.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(26, 170);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(370, 20);
            this.txtColor.TabIndex = 14;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(26, 130);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(370, 20);
            this.txtRaza.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Raza";
            // 
            // txtespecie
            // 
            this.txtespecie.Location = new System.Drawing.Point(26, 90);
            this.txtespecie.Name = "txtespecie";
            this.txtespecie.Size = new System.Drawing.Size(370, 20);
            this.txtespecie.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Especie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Alias (Nombre)";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(26, 50);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(370, 20);
            this.txtAlias.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btneditar);
            this.groupBox3.Controls.Add(this.dgvdata);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 189);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mascotas";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(151, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cancelar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(24, 160);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(109, 23);
            this.btneditar.TabIndex = 2;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvdata.Location = new System.Drawing.Point(3, 16);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(794, 138);
            this.dgvdata.TabIndex = 1;
            // 
            // frmMantoMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpbedit);
            this.Name = "frmMantoMascotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantoMascotas";
            this.Load += new System.EventHandler(this.frmMantoMascotas_Load);
            this.gpbedit.ResumeLayout(false);
            this.gpbedit.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbedit;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtespecie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAlias;
        private System.Windows.Forms.Button btneliminarr;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btncancelarr;
    }
}