namespace PetApp
{
    partial class frmMantoVacunas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.Edicion = new System.Windows.Forms.GroupBox();
            this.cbxmascota = new System.Windows.Forms.ComboBox();
            this.dtpregsitro = new System.Windows.Forms.DateTimePicker();
            this.txbenfermedad = new System.Windows.Forms.TextBox();
            this.dtpnextregistro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Edicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Edicion);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(642, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vacunas";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(642, 450);
            this.dataGridView.TabIndex = 1;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(27, 30);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(108, 30);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 1;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(189, 30);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // Edicion
            // 
            this.Edicion.Controls.Add(this.button);
            this.Edicion.Controls.Add(this.btnactualizar);
            this.Edicion.Controls.Add(this.btncancel);
            this.Edicion.Controls.Add(this.btnsave);
            this.Edicion.Controls.Add(this.label4);
            this.Edicion.Controls.Add(this.label3);
            this.Edicion.Controls.Add(this.label2);
            this.Edicion.Controls.Add(this.label1);
            this.Edicion.Controls.Add(this.dtpnextregistro);
            this.Edicion.Controls.Add(this.txbenfermedad);
            this.Edicion.Controls.Add(this.dtpregsitro);
            this.Edicion.Controls.Add(this.cbxmascota);
            this.Edicion.Location = new System.Drawing.Point(0, 68);
            this.Edicion.Name = "Edicion";
            this.Edicion.Size = new System.Drawing.Size(337, 382);
            this.Edicion.TabIndex = 3;
            this.Edicion.TabStop = false;
            this.Edicion.Text = "Registro de vacunas";
            this.Edicion.Visible = false;
            // 
            // cbxmascota
            // 
            this.cbxmascota.FormattingEnabled = true;
            this.cbxmascota.Location = new System.Drawing.Point(27, 76);
            this.cbxmascota.Name = "cbxmascota";
            this.cbxmascota.Size = new System.Drawing.Size(246, 21);
            this.cbxmascota.TabIndex = 0;
            // 
            // dtpregsitro
            // 
            this.dtpregsitro.Location = new System.Drawing.Point(27, 143);
            this.dtpregsitro.Name = "dtpregsitro";
            this.dtpregsitro.Size = new System.Drawing.Size(246, 20);
            this.dtpregsitro.TabIndex = 1;
            // 
            // txbenfermedad
            // 
            this.txbenfermedad.Location = new System.Drawing.Point(30, 209);
            this.txbenfermedad.Name = "txbenfermedad";
            this.txbenfermedad.Size = new System.Drawing.Size(243, 20);
            this.txbenfermedad.TabIndex = 2;
            // 
            // dtpnextregistro
            // 
            this.dtpnextregistro.Location = new System.Drawing.Point(30, 279);
            this.dtpnextregistro.Name = "dtpnextregistro";
            this.dtpnextregistro.Size = new System.Drawing.Size(200, 20);
            this.dtpnextregistro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha del registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enfermedad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proxima Cita (Fecha)";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(139, 347);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(232, 347);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(139, 318);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 10;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Visible = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(232, 318);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 11;
            this.button.Text = "cancelar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Visible = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // frmMantoVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMantoVacunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantoVacunas";
            this.Load += new System.EventHandler(this.frmMantoVacunas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Edicion.ResumeLayout(false);
            this.Edicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Edicion;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpnextregistro;
        private System.Windows.Forms.TextBox txbenfermedad;
        private System.Windows.Forms.DateTimePicker dtpregsitro;
        private System.Windows.Forms.ComboBox cbxmascota;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button btnactualizar;
    }
}