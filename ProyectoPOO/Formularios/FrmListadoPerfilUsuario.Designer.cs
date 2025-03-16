namespace AplicacionGym
{
    partial class FrmListadoPerFilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoPerFilUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pAccionesListadoPerfilUsuario = new System.Windows.Forms.Panel();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.lblElegirFiltroPerfil = new System.Windows.Forms.Label();
            this.cmbFiltroPerfil = new System.Windows.Forms.ComboBox();
            this.txtFiltroPerfil = new System.Windows.Forms.TextBox();
            this.btnEliminarPerfil = new System.Windows.Forms.Button();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.btnAñadirPerfil = new System.Windows.Forms.Button();
            this.bartListadoPerfil = new System.Windows.Forms.Panel();
            this.lblListadoPerfilUusuario = new System.Windows.Forms.Label();
            this.imgLogoListadoPerfil = new System.Windows.Forms.PictureBox();
            this.btnCerrarListadoPerfil = new System.Windows.Forms.PictureBox();
            this.DGVListadoPerfilUsuario = new System.Windows.Forms.DataGridView();
            this.pAccionesListadoPerfilUsuario.SuspendLayout();
            this.bartListadoPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoListadoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarListadoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListadoPerfilUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pAccionesListadoPerfilUsuario
            // 
            this.pAccionesListadoPerfilUsuario.BackColor = System.Drawing.Color.White;
            this.pAccionesListadoPerfilUsuario.Controls.Add(this.lblBuscador);
            this.pAccionesListadoPerfilUsuario.Controls.Add(this.lblElegirFiltroPerfil);
            this.pAccionesListadoPerfilUsuario.Controls.Add(this.cmbFiltroPerfil);
            this.pAccionesListadoPerfilUsuario.Controls.Add(this.txtFiltroPerfil);
            this.pAccionesListadoPerfilUsuario.Controls.Add(this.btnEliminarPerfil);
            this.pAccionesListadoPerfilUsuario.Controls.Add(this.btnEditarPerfil);
            this.pAccionesListadoPerfilUsuario.Controls.Add(this.btnAñadirPerfil);
            this.pAccionesListadoPerfilUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAccionesListadoPerfilUsuario.Location = new System.Drawing.Point(0, 62);
            this.pAccionesListadoPerfilUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pAccionesListadoPerfilUsuario.Name = "pAccionesListadoPerfilUsuario";
            this.pAccionesListadoPerfilUsuario.Size = new System.Drawing.Size(1386, 92);
            this.pAccionesListadoPerfilUsuario.TabIndex = 8;
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.Location = new System.Drawing.Point(279, 14);
            this.lblBuscador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(119, 32);
            this.lblBuscador.TabIndex = 18;
            this.lblBuscador.Text = "Buscador";
            // 
            // lblElegirFiltroPerfil
            // 
            this.lblElegirFiltroPerfil.AutoSize = true;
            this.lblElegirFiltroPerfil.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirFiltroPerfil.Location = new System.Drawing.Point(48, 14);
            this.lblElegirFiltroPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElegirFiltroPerfil.Name = "lblElegirFiltroPerfil";
            this.lblElegirFiltroPerfil.Size = new System.Drawing.Size(149, 32);
            this.lblElegirFiltroPerfil.TabIndex = 17;
            this.lblElegirFiltroPerfil.Text = "Elegir filtro:";
            // 
            // cmbFiltroPerfil
            // 
            this.cmbFiltroPerfil.FormattingEnabled = true;
            this.cmbFiltroPerfil.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "ID de Usuario",
            "Correo"});
            this.cmbFiltroPerfil.Location = new System.Drawing.Point(44, 49);
            this.cmbFiltroPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltroPerfil.Name = "cmbFiltroPerfil";
            this.cmbFiltroPerfil.Size = new System.Drawing.Size(220, 28);
            this.cmbFiltroPerfil.TabIndex = 16;
            this.cmbFiltroPerfil.Text = "Nombre";
            // 
            // txtFiltroPerfil
            // 
            this.txtFiltroPerfil.Location = new System.Drawing.Point(274, 49);
            this.txtFiltroPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltroPerfil.Name = "txtFiltroPerfil";
            this.txtFiltroPerfil.Size = new System.Drawing.Size(392, 26);
            this.txtFiltroPerfil.TabIndex = 15;
            this.txtFiltroPerfil.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroPerfil_KeyUp);
            // 
            // btnEliminarPerfil
            // 
            this.btnEliminarPerfil.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPerfil.FlatAppearance.BorderSize = 0;
            this.btnEliminarPerfil.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarPerfil.Image")));
            this.btnEliminarPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPerfil.Location = new System.Drawing.Point(1026, 25);
            this.btnEliminarPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarPerfil.Name = "btnEliminarPerfil";
            this.btnEliminarPerfil.Size = new System.Drawing.Size(172, 54);
            this.btnEliminarPerfil.TabIndex = 14;
            this.btnEliminarPerfil.Text = "  Eliminar";
            this.btnEliminarPerfil.UseVisualStyleBackColor = false;
            this.btnEliminarPerfil.Click += new System.EventHandler(this.btnEliminarPerfil_Click);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.BackColor = System.Drawing.Color.Yellow;
            this.btnEditarPerfil.FlatAppearance.BorderSize = 0;
            this.btnEditarPerfil.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPerfil.Image")));
            this.btnEditarPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPerfil.Location = new System.Drawing.Point(886, 25);
            this.btnEditarPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(130, 54);
            this.btnEditarPerfil.TabIndex = 13;
            this.btnEditarPerfil.Text = "  Editar";
            this.btnEditarPerfil.UseVisualStyleBackColor = false;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnAñadirPerfil
            // 
            this.btnAñadirPerfil.BackColor = System.Drawing.Color.Orange;
            this.btnAñadirPerfil.FlatAppearance.BorderSize = 0;
            this.btnAñadirPerfil.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadirPerfil.Image")));
            this.btnAñadirPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirPerfil.Location = new System.Drawing.Point(728, 25);
            this.btnAñadirPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAñadirPerfil.Name = "btnAñadirPerfil";
            this.btnAñadirPerfil.Size = new System.Drawing.Size(150, 54);
            this.btnAñadirPerfil.TabIndex = 12;
            this.btnAñadirPerfil.Text = "  Añadir";
            this.btnAñadirPerfil.UseVisualStyleBackColor = false;
            this.btnAñadirPerfil.Click += new System.EventHandler(this.btnAñadirPerfil_Click);
            // 
            // bartListadoPerfil
            // 
            this.bartListadoPerfil.BackColor = System.Drawing.Color.SeaGreen;
            this.bartListadoPerfil.Controls.Add(this.lblListadoPerfilUusuario);
            this.bartListadoPerfil.Controls.Add(this.imgLogoListadoPerfil);
            this.bartListadoPerfil.Controls.Add(this.btnCerrarListadoPerfil);
            this.bartListadoPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.bartListadoPerfil.Location = new System.Drawing.Point(0, 0);
            this.bartListadoPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bartListadoPerfil.Name = "bartListadoPerfil";
            this.bartListadoPerfil.Size = new System.Drawing.Size(1386, 62);
            this.bartListadoPerfil.TabIndex = 7;
            // 
            // lblListadoPerfilUusuario
            // 
            this.lblListadoPerfilUusuario.AutoSize = true;
            this.lblListadoPerfilUusuario.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoPerfilUusuario.ForeColor = System.Drawing.Color.White;
            this.lblListadoPerfilUusuario.Location = new System.Drawing.Point(608, 9);
            this.lblListadoPerfilUusuario.Name = "lblListadoPerfilUusuario";
            this.lblListadoPerfilUusuario.Size = new System.Drawing.Size(451, 48);
            this.lblListadoPerfilUusuario.TabIndex = 2;
            this.lblListadoPerfilUusuario.Text = "LISTADO PERFIL DE USUARIO";
            // 
            // imgLogoListadoPerfil
            // 
            this.imgLogoListadoPerfil.BackColor = System.Drawing.Color.SeaGreen;
            this.imgLogoListadoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoListadoPerfil.Image")));
            this.imgLogoListadoPerfil.Location = new System.Drawing.Point(-27, -5);
            this.imgLogoListadoPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgLogoListadoPerfil.Name = "imgLogoListadoPerfil";
            this.imgLogoListadoPerfil.Size = new System.Drawing.Size(266, 65);
            this.imgLogoListadoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoListadoPerfil.TabIndex = 0;
            this.imgLogoListadoPerfil.TabStop = false;
            // 
            // btnCerrarListadoPerfil
            // 
            this.btnCerrarListadoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarListadoPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarListadoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarListadoPerfil.Image")));
            this.btnCerrarListadoPerfil.Location = new System.Drawing.Point(1340, 14);
            this.btnCerrarListadoPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarListadoPerfil.Name = "btnCerrarListadoPerfil";
            this.btnCerrarListadoPerfil.Size = new System.Drawing.Size(34, 35);
            this.btnCerrarListadoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarListadoPerfil.TabIndex = 1;
            this.btnCerrarListadoPerfil.TabStop = false;
            this.btnCerrarListadoPerfil.Click += new System.EventHandler(this.btnCerrarListadoPerfil_Click);
            // 
            // DGVListadoPerfilUsuario
            // 
            this.DGVListadoPerfilUsuario.AllowDrop = true;
            this.DGVListadoPerfilUsuario.AllowUserToAddRows = false;
            this.DGVListadoPerfilUsuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListadoPerfilUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVListadoPerfilUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVListadoPerfilUsuario.BackgroundColor = System.Drawing.Color.White;
            this.DGVListadoPerfilUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVListadoPerfilUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListadoPerfilUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVListadoPerfilUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListadoPerfilUsuario.Cursor = System.Windows.Forms.Cursors.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListadoPerfilUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVListadoPerfilUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVListadoPerfilUsuario.EnableHeadersVisualStyles = false;
            this.DGVListadoPerfilUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVListadoPerfilUsuario.Location = new System.Drawing.Point(0, 154);
            this.DGVListadoPerfilUsuario.Name = "DGVListadoPerfilUsuario";
            this.DGVListadoPerfilUsuario.ReadOnly = true;
            this.DGVListadoPerfilUsuario.RowHeadersWidth = 51;
            this.DGVListadoPerfilUsuario.RowTemplate.Height = 24;
            this.DGVListadoPerfilUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVListadoPerfilUsuario.Size = new System.Drawing.Size(1386, 534);
            this.DGVListadoPerfilUsuario.TabIndex = 34;
            this.DGVListadoPerfilUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListadoPerfilUsuario_CellClick);
            this.DGVListadoPerfilUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListadoPerfilUsuario_CellContentClick);
            // 
            // FrmListadoPerFilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 688);
            this.Controls.Add(this.DGVListadoPerfilUsuario);
            this.Controls.Add(this.pAccionesListadoPerfilUsuario);
            this.Controls.Add(this.bartListadoPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(28, 23);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmListadoPerFilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoPerfilUsuario";
            this.Load += new System.EventHandler(this.ListadoUsuario_Load);
            this.pAccionesListadoPerfilUsuario.ResumeLayout(false);
            this.pAccionesListadoPerfilUsuario.PerformLayout();
            this.bartListadoPerfil.ResumeLayout(false);
            this.bartListadoPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoListadoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarListadoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListadoPerfilUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pAccionesListadoPerfilUsuario;
        private System.Windows.Forms.Panel bartListadoPerfil;
        private System.Windows.Forms.Label lblListadoPerfilUusuario;
        private System.Windows.Forms.PictureBox imgLogoListadoPerfil;
        private System.Windows.Forms.PictureBox btnCerrarListadoPerfil;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.Label lblElegirFiltroPerfil;
        private System.Windows.Forms.ComboBox cmbFiltroPerfil;
        private System.Windows.Forms.TextBox txtFiltroPerfil;
        private System.Windows.Forms.Button btnEliminarPerfil;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.Button btnAñadirPerfil;
        public System.Windows.Forms.DataGridView DGVListadoPerfilUsuario;
    }
}