
namespace ProyectoPOO.Formularios
{
    partial class FrmAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistencia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTituloFormularioAgregarProducto = new System.Windows.Forms.Panel();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.tsAsistencia = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscmbFiltro = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscador = new System.Windows.Forms.ToolStripTextBox();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.BarraTituloFormularioAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.tsAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTituloFormularioAgregarProducto
            // 
            this.BarraTituloFormularioAgregarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.BarraTituloFormularioAgregarProducto.Controls.Add(this.lblAsistencia);
            this.BarraTituloFormularioAgregarProducto.Controls.Add(this.btnCerrar);
            this.BarraTituloFormularioAgregarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloFormularioAgregarProducto.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloFormularioAgregarProducto.Name = "BarraTituloFormularioAgregarProducto";
            this.BarraTituloFormularioAgregarProducto.Size = new System.Drawing.Size(1200, 63);
            this.BarraTituloFormularioAgregarProducto.TabIndex = 29;
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.ForeColor = System.Drawing.Color.White;
            this.lblAsistencia.Location = new System.Drawing.Point(69, -2);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(287, 60);
            this.lblAsistencia.TabIndex = 7;
            this.lblAsistencia.Text = "ASISTENCIA";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1155, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tsAsistencia
            // 
            this.tsAsistencia.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsAsistencia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tscmbFiltro,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.txtBuscador});
            this.tsAsistencia.Location = new System.Drawing.Point(0, 63);
            this.tsAsistencia.Name = "tsAsistencia";
            this.tsAsistencia.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsAsistencia.Size = new System.Drawing.Size(1200, 38);
            this.tsAsistencia.TabIndex = 30;
            this.tsAsistencia.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 33);
            this.toolStripLabel1.Text = "Elegir Filtro:";
            // 
            // tscmbFiltro
            // 
            this.tscmbFiltro.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Correo",
            "Telefono"});
            this.tscmbFiltro.Name = "tscmbFiltro";
            this.tscmbFiltro.Size = new System.Drawing.Size(180, 38);
            this.tscmbFiltro.Text = "Nombre";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(85, 33);
            this.toolStripLabel2.Text = "Buscador";
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(148, 38);
            this.txtBuscador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscador_KeyUp);
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.AllowUserToAddRows = false;
            this.dgvAsistencia.AllowUserToDeleteRows = false;
            this.dgvAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsistencia.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsistencia.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsistencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsistencia.EnableHeadersVisualStyles = false;
            this.dgvAsistencia.GridColor = System.Drawing.Color.Teal;
            this.dgvAsistencia.Location = new System.Drawing.Point(0, 101);
            this.dgvAsistencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.ReadOnly = true;
            this.dgvAsistencia.RowHeadersWidth = 62;
            this.dgvAsistencia.Size = new System.Drawing.Size(1200, 502);
            this.dgvAsistencia.TabIndex = 31;
            // 
            // FrmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 603);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.tsAsistencia);
            this.Controls.Add(this.BarraTituloFormularioAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAsistencia";
            this.Text = "FrmAsistencia";
            this.Load += new System.EventHandler(this.FrmAsistencia_Load);
            this.BarraTituloFormularioAgregarProducto.ResumeLayout(false);
            this.BarraTituloFormularioAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.tsAsistencia.ResumeLayout(false);
            this.tsAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTituloFormularioAgregarProducto;
        public System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ToolStrip tsAsistencia;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscmbFiltro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtBuscador;
        private System.Windows.Forms.DataGridView dgvAsistencia;
    }
}