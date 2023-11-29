namespace PetApp
{
    partial class frmMantoCliente
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.gpbeditarcliente = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbtelefono = new System.Windows.Forms.TextBox();
            this.txbnamecompleto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.gpbeditarcliente.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes";
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
            // gpbeditarcliente
            // 
            this.gpbeditarcliente.Controls.Add(this.btncancelar);
            this.gpbeditarcliente.Controls.Add(this.btneliminar);
            this.gpbeditarcliente.Controls.Add(this.btnactualizar);
            this.gpbeditarcliente.Controls.Add(this.txbemail);
            this.gpbeditarcliente.Controls.Add(this.txbtelefono);
            this.gpbeditarcliente.Controls.Add(this.txbnamecompleto);
            this.gpbeditarcliente.Controls.Add(this.label3);
            this.gpbeditarcliente.Controls.Add(this.label2);
            this.gpbeditarcliente.Controls.Add(this.label1);
            this.gpbeditarcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbeditarcliente.Location = new System.Drawing.Point(0, 189);
            this.gpbeditarcliente.Name = "gpbeditarcliente";
            this.gpbeditarcliente.Size = new System.Drawing.Size(800, 230);
            this.gpbeditarcliente.TabIndex = 5;
            this.gpbeditarcliente.TabStop = false;
            this.gpbeditarcliente.Text = "Edicion de Clientes";
            this.gpbeditarcliente.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(455, 90);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(195, 36);
            this.btncancelar.TabIndex = 26;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(551, 45);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 39);
            this.btneliminar.TabIndex = 25;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(451, 48);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(94, 36);
            this.btnactualizar.TabIndex = 24;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(37, 166);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(255, 20);
            this.txbemail.TabIndex = 23;
            // 
            // txbtelefono
            // 
            this.txbtelefono.Location = new System.Drawing.Point(37, 105);
            this.txbtelefono.Name = "txbtelefono";
            this.txbtelefono.Size = new System.Drawing.Size(255, 20);
            this.txbtelefono.TabIndex = 22;
            // 
            // txbnamecompleto
            // 
            this.txbnamecompleto.Location = new System.Drawing.Point(37, 48);
            this.txbnamecompleto.Name = "txbnamecompleto";
            this.txbnamecompleto.Size = new System.Drawing.Size(255, 20);
            this.txbnamecompleto.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre Completo";
            // 
            // frmMantoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbeditarcliente);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmMantoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantoCliente";
            this.Load += new System.EventHandler(this.frmMantoCliente_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.gpbeditarcliente.ResumeLayout(false);
            this.gpbeditarcliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.GroupBox gpbeditarcliente;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.TextBox txbtelefono;
        private System.Windows.Forms.TextBox txbnamecompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}