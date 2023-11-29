namespace PetApp
{
    partial class frmMantoWeight
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
            this.dgvdatapeso = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnewregistro = new System.Windows.Forms.ToolStripButton();
            this.btndeleteregistro = new System.Windows.Forms.ToolStripButton();
            this.btneditarregistro = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatapeso)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdatapeso
            // 
            this.dgvdatapeso.AllowUserToAddRows = false;
            this.dgvdatapeso.AllowUserToDeleteRows = false;
            this.dgvdatapeso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatapeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatapeso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdatapeso.Location = new System.Drawing.Point(0, 28);
            this.dgvdatapeso.Name = "dgvdatapeso";
            this.dgvdatapeso.ReadOnly = true;
            this.dgvdatapeso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatapeso.Size = new System.Drawing.Size(800, 422);
            this.dgvdatapeso.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnewregistro,
            this.btndeleteregistro,
            this.btneditarregistro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnnewregistro
            // 
            this.btnnewregistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnewregistro.Name = "btnnewregistro";
            this.btnnewregistro.Size = new System.Drawing.Size(89, 22);
            this.btnnewregistro.Text = "Nuevo registro";
            this.btnnewregistro.Click += new System.EventHandler(this.btnnewregistro_Click);
            // 
            // btndeleteregistro
            // 
            this.btndeleteregistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndeleteregistro.Name = "btndeleteregistro";
            this.btndeleteregistro.Size = new System.Drawing.Size(89, 22);
            this.btndeleteregistro.Text = "Borrar Registro";
            this.btndeleteregistro.Click += new System.EventHandler(this.btndeleteregistro_Click);
            // 
            // btneditarregistro
            // 
            this.btneditarregistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneditarregistro.Name = "btneditarregistro";
            this.btneditarregistro.Size = new System.Drawing.Size(87, 22);
            this.btneditarregistro.Text = "Editar Registro";
            this.btneditarregistro.Click += new System.EventHandler(this.btneditarregistro_Click);
            // 
            // frmMantoWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvdatapeso);
            this.Name = "frmMantoWeight";
            this.Text = "frmMantoWeight";
            this.Load += new System.EventHandler(this.frmMantoWeight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatapeso)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdatapeso;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnewregistro;
        private System.Windows.Forms.ToolStripButton btndeleteregistro;
        private System.Windows.Forms.ToolStripButton btneditarregistro;
    }
}