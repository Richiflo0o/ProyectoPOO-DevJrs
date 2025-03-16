namespace ProyectoPOO.Formularios
{
    partial class FrmListadoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoUsuario));
            this.bartListadoPerfil = new System.Windows.Forms.Panel();
            this.lblListadoPerfilUusuario = new System.Windows.Forms.Label();
            this.imgLogoListadoPerfil = new System.Windows.Forms.PictureBox();
            this.btnCerrarListadoPerfil = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblFiltrarSocio = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltroUsuario = new System.Windows.Forms.ToolStripTextBox();
            this.tsbFiltroSocio = new System.Windows.Forms.ToolStripButton();
            this.BtnAgregarSocio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificarSocio = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminarSocio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.DGVListadoUsuarios = new System.Windows.Forms.DataGridView();
            this.bartListadoPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoListadoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarListadoPerfil)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListadoUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // bartListadoPerfil
            // 
            this.bartListadoPerfil.BackColor = System.Drawing.Color.SeaGreen;
            this.bartListadoPerfil.Controls.Add(this.lblListadoPerfilUusuario);
            this.bartListadoPerfil.Controls.Add(this.imgLogoListadoPerfil);
            this.bartListadoPerfil.Controls.Add(this.btnCerrarListadoPerfil);
            this.bartListadoPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.bartListadoPerfil.Location = new System.Drawing.Point(0, 0);
            this.bartListadoPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bartListadoPerfil.Name = "bartListadoPerfil";
            this.bartListadoPerfil.Size = new System.Drawing.Size(715, 41);
            this.bartListadoPerfil.TabIndex = 8;
            // 
            // lblListadoPerfilUusuario
            // 
            this.lblListadoPerfilUusuario.AutoSize = true;
            this.lblListadoPerfilUusuario.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoPerfilUusuario.ForeColor = System.Drawing.Color.White;
            this.lblListadoPerfilUusuario.Location = new System.Drawing.Point(262, 3);
            this.lblListadoPerfilUusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListadoPerfilUusuario.Name = "lblListadoPerfilUusuario";
            this.lblListadoPerfilUusuario.Size = new System.Drawing.Size(308, 34);
            this.lblListadoPerfilUusuario.TabIndex = 2;
            this.lblListadoPerfilUusuario.Text = "LISTADO PERFIL DE USUARIO";
            // 
            // imgLogoListadoPerfil
            // 
            this.imgLogoListadoPerfil.BackColor = System.Drawing.Color.SeaGreen;
            this.imgLogoListadoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoListadoPerfil.Image")));
            this.imgLogoListadoPerfil.Location = new System.Drawing.Point(-18, -3);
            this.imgLogoListadoPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgLogoListadoPerfil.Name = "imgLogoListadoPerfil";
            this.imgLogoListadoPerfil.Size = new System.Drawing.Size(177, 42);
            this.imgLogoListadoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoListadoPerfil.TabIndex = 0;
            this.imgLogoListadoPerfil.TabStop = false;
            // 
            // btnCerrarListadoPerfil
            // 
            this.btnCerrarListadoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarListadoPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarListadoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarListadoPerfil.Image")));
            this.btnCerrarListadoPerfil.Location = new System.Drawing.Point(674, 6);
            this.btnCerrarListadoPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarListadoPerfil.Name = "btnCerrarListadoPerfil";
            this.btnCerrarListadoPerfil.Size = new System.Drawing.Size(22, 23);
            this.btnCerrarListadoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarListadoPerfil.TabIndex = 1;
            this.btnCerrarListadoPerfil.TabStop = false;
            this.btnCerrarListadoPerfil.Click += new System.EventHandler(this.btnCerrarListadoPerfil_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.lblFiltrarSocio,
            this.txtFiltroUsuario,
            this.tsbFiltroSocio,
            this.BtnAgregarSocio,
            this.toolStripSeparator3,
            this.btnModificarSocio,
            this.BtnEliminarSocio,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 41);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(715, 28);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // lblFiltrarSocio
            // 
            this.lblFiltrarSocio.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarSocio.Name = "lblFiltrarSocio";
            this.lblFiltrarSocio.Size = new System.Drawing.Size(58, 25);
            this.lblFiltrarSocio.Text = "Filtrar:";
            // 
            // txtFiltroUsuario
            // 
            this.txtFiltroUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltroUsuario.Name = "txtFiltroUsuario";
            this.txtFiltroUsuario.Size = new System.Drawing.Size(168, 28);
            // 
            // tsbFiltroSocio
            // 
            this.tsbFiltroSocio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFiltroSocio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbFiltroSocio.Image = ((System.Drawing.Image)(resources.GetObject("tsbFiltroSocio.Image")));
            this.tsbFiltroSocio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltroSocio.Name = "tsbFiltroSocio";
            this.tsbFiltroSocio.Size = new System.Drawing.Size(24, 25);
            this.tsbFiltroSocio.Text = "toolStripButton1";
            // 
            // BtnAgregarSocio
            // 
            this.BtnAgregarSocio.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarSocio.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarSocio.Image")));
            this.BtnAgregarSocio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAgregarSocio.Name = "BtnAgregarSocio";
            this.BtnAgregarSocio.Size = new System.Drawing.Size(93, 25);
            this.BtnAgregarSocio.Text = "Agregar";
            this.BtnAgregarSocio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // btnModificarSocio
            // 
            this.btnModificarSocio.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSocio.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarSocio.Image")));
            this.btnModificarSocio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificarSocio.Name = "btnModificarSocio";
            this.btnModificarSocio.Size = new System.Drawing.Size(107, 25);
            this.btnModificarSocio.Text = "Modificar";
            this.btnModificarSocio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // BtnEliminarSocio
            // 
            this.BtnEliminarSocio.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarSocio.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarSocio.Image")));
            this.BtnEliminarSocio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminarSocio.Name = "BtnEliminarSocio";
            this.BtnEliminarSocio.Size = new System.Drawing.Size(94, 25);
            this.BtnEliminarSocio.Text = "Eliminar";
            this.BtnEliminarSocio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // DGVListadoUsuarios
            // 
            this.DGVListadoUsuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGVListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListadoUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVListadoUsuarios.Location = new System.Drawing.Point(0, 69);
            this.DGVListadoUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVListadoUsuarios.Name = "DGVListadoUsuarios";
            this.DGVListadoUsuarios.RowHeadersWidth = 62;
            this.DGVListadoUsuarios.RowTemplate.Height = 28;
            this.DGVListadoUsuarios.Size = new System.Drawing.Size(715, 413);
            this.DGVListadoUsuarios.TabIndex = 36;
            this.DGVListadoUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListadoUsuarios_CellContentClick);
            // 
            // FrmListadoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 482);
            this.Controls.Add(this.DGVListadoUsuarios);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bartListadoPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmListadoUsuario";
            this.Text = "FrmListadoUsuario";
            this.bartListadoPerfil.ResumeLayout(false);
            this.bartListadoPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoListadoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarListadoPerfil)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListadoUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bartListadoPerfil;
        private System.Windows.Forms.Label lblListadoPerfilUusuario;
        private System.Windows.Forms.PictureBox imgLogoListadoPerfil;
        private System.Windows.Forms.PictureBox btnCerrarListadoPerfil;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblFiltrarSocio;
        private System.Windows.Forms.ToolStripTextBox txtFiltroUsuario;
        private System.Windows.Forms.ToolStripButton tsbFiltroSocio;
        public System.Windows.Forms.ToolStripButton BtnAgregarSocio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnModificarSocio;
        private System.Windows.Forms.ToolStripButton BtnEliminarSocio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridView DGVListadoUsuarios;
    }
}