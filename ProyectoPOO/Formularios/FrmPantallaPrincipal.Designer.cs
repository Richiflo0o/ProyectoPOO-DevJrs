namespace ProyectoPOO.Formularios
{
    partial class FrmPantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantallaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbMaximizar = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PtbCerrarFmrPrincipal = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiPerfilUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListaDeUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListadoDeUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMembresia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAggMembresia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInstructores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoInstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAgregarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPagosRealizados = new System.Windows.Forms.ToolStripMenuItem();
            this.pciContenedor = new System.Windows.Forms.Panel();
            this.verListadoDePerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInstructoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFmrPrincipal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.ptbMaximizar);
            this.panel1.Controls.Add(this.lblRolUsuario);
            this.panel1.Controls.Add(this.lblCerrarSesion);
            this.panel1.Controls.Add(this.ptbMinimizar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.PtbCerrarFmrPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 62);
            this.panel1.TabIndex = 3;
            // 
            // ptbMaximizar
            // 
            this.ptbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximizar.Image")));
            this.ptbMaximizar.Location = new System.Drawing.Point(1204, 11);
            this.ptbMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbMaximizar.Name = "ptbMaximizar";
            this.ptbMaximizar.Size = new System.Drawing.Size(34, 35);
            this.ptbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMaximizar.TabIndex = 4;
            this.ptbMaximizar.TabStop = false;
            this.ptbMaximizar.Click += new System.EventHandler(this.ptbMaximizar_Click);
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolUsuario.ForeColor = System.Drawing.Color.Gold;
            this.lblRolUsuario.Location = new System.Drawing.Point(782, 15);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(185, 30);
            this.lblRolUsuario.TabIndex = 6;
            this.lblRolUsuario.Text = "Perfil De Usuario";
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.lblCerrarSesion.Location = new System.Drawing.Point(999, 15);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(135, 30);
            this.lblCerrarSesion.TabIndex = 5;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(1162, 11);
            this.ptbMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(34, 35);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimizar.TabIndex = 2;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-27, -5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PtbCerrarFmrPrincipal
            // 
            this.PtbCerrarFmrPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PtbCerrarFmrPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbCerrarFmrPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrarFmrPrincipal.Image")));
            this.PtbCerrarFmrPrincipal.Location = new System.Drawing.Point(1246, 9);
            this.PtbCerrarFmrPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PtbCerrarFmrPrincipal.Name = "PtbCerrarFmrPrincipal";
            this.PtbCerrarFmrPrincipal.Size = new System.Drawing.Size(34, 35);
            this.PtbCerrarFmrPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbCerrarFmrPrincipal.TabIndex = 1;
            this.PtbCerrarFmrPrincipal.TabStop = false;
            this.PtbCerrarFmrPrincipal.Click += new System.EventHandler(this.PtbCerrarFormularioPrincipal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPerfilUsuarios,
            this.tsmiUsuarios,
            this.tsmiMembresia,
            this.tsmiInstructores,
            this.tsmiCaja,
            this.tsmiProductos,
            this.tsmiEstadisticas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 62);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1290, 48);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiPerfilUsuarios
            // 
            this.tsmiPerfilUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListaDeUsuarios,
            this.verListadoDePerfilesToolStripMenuItem});
            this.tsmiPerfilUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPerfilUsuarios.Image")));
            this.tsmiPerfilUsuarios.Name = "tsmiPerfilUsuarios";
            this.tsmiPerfilUsuarios.Size = new System.Drawing.Size(163, 44);
            this.tsmiPerfilUsuarios.Text = "Perfil Usuarios";
            // 
            // tsmiListaDeUsuarios
            // 
            this.tsmiListaDeUsuarios.Name = "tsmiListaDeUsuarios";
            this.tsmiListaDeUsuarios.Size = new System.Drawing.Size(286, 34);
            this.tsmiListaDeUsuarios.Text = "Agregar Perfil";
            // 
            // tsmiUsuarios
            // 
            this.tsmiUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.tsmiListadoDeUsuarios,
            this.tsmiAsistencia});
            this.tsmiUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUsuarios.Image")));
            this.tsmiUsuarios.Name = "tsmiUsuarios";
            this.tsmiUsuarios.Size = new System.Drawing.Size(120, 44);
            this.tsmiUsuarios.Text = "Usuarios";
            // 
            // tsmiListadoDeUsuarios
            // 
            this.tsmiListadoDeUsuarios.Name = "tsmiListadoDeUsuarios";
            this.tsmiListadoDeUsuarios.Size = new System.Drawing.Size(270, 34);
            this.tsmiListadoDeUsuarios.Text = "Listado de Usuarios";
            // 
            // tsmiAsistencia
            // 
            this.tsmiAsistencia.Name = "tsmiAsistencia";
            this.tsmiAsistencia.Size = new System.Drawing.Size(270, 34);
            this.tsmiAsistencia.Text = "Asistencia";
            // 
            // tsmiMembresia
            // 
            this.tsmiMembresia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAggMembresia});
            this.tsmiMembresia.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMembresia.Image")));
            this.tsmiMembresia.Name = "tsmiMembresia";
            this.tsmiMembresia.Size = new System.Drawing.Size(140, 44);
            this.tsmiMembresia.Text = "Membresia";
            // 
            // tsmiAggMembresia
            // 
            this.tsmiAggMembresia.Name = "tsmiAggMembresia";
            this.tsmiAggMembresia.Size = new System.Drawing.Size(275, 34);
            this.tsmiAggMembresia.Text = "Agregar Membresia";
            // 
            // tsmiInstructores
            // 
            this.tsmiInstructores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoInstructor,
            this.verInstructoresToolStripMenuItem});
            this.tsmiInstructores.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInstructores.Image")));
            this.tsmiInstructores.Name = "tsmiInstructores";
            this.tsmiInstructores.Size = new System.Drawing.Size(145, 44);
            this.tsmiInstructores.Text = "Instructores";
            // 
            // tsmiNuevoInstructor
            // 
            this.tsmiNuevoInstructor.Name = "tsmiNuevoInstructor";
            this.tsmiNuevoInstructor.Size = new System.Drawing.Size(247, 34);
            this.tsmiNuevoInstructor.Text = "Nuevo Instructor";
            // 
            // tsmiCaja
            // 
            this.tsmiCaja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVerCaja});
            this.tsmiCaja.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCaja.Image")));
            this.tsmiCaja.Name = "tsmiCaja";
            this.tsmiCaja.Size = new System.Drawing.Size(85, 44);
            this.tsmiCaja.Text = "Caja";
            // 
            // tsmiVerCaja
            // 
            this.tsmiVerCaja.Name = "tsmiVerCaja";
            this.tsmiVerCaja.Size = new System.Drawing.Size(174, 34);
            this.tsmiVerCaja.Text = "Ver caja";
            // 
            // tsmiProductos
            // 
            this.tsmiProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAgregarProducto,
            this.tsmiVerProductos,
            this.proveedoresToolStripMenuItem});
            this.tsmiProductos.Image = ((System.Drawing.Image)(resources.GetObject("tsmiProductos.Image")));
            this.tsmiProductos.Name = "tsmiProductos";
            this.tsmiProductos.Size = new System.Drawing.Size(133, 44);
            this.tsmiProductos.Text = "Productos";
            // 
            // tsmiAgregarProducto
            // 
            this.tsmiAgregarProducto.Name = "tsmiAgregarProducto";
            this.tsmiAgregarProducto.Size = new System.Drawing.Size(256, 34);
            this.tsmiAgregarProducto.Text = "Agregar Producto";
            // 
            // tsmiVerProductos
            // 
            this.tsmiVerProductos.Name = "tsmiVerProductos";
            this.tsmiVerProductos.Size = new System.Drawing.Size(256, 34);
            this.tsmiVerProductos.Text = "Ver Productos";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // tsmiEstadisticas
            // 
            this.tsmiEstadisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPagosRealizados});
            this.tsmiEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEstadisticas.Image")));
            this.tsmiEstadisticas.Name = "tsmiEstadisticas";
            this.tsmiEstadisticas.Size = new System.Drawing.Size(122, 44);
            this.tsmiEstadisticas.Text = "Reportes";
            // 
            // tsmiPagosRealizados
            // 
            this.tsmiPagosRealizados.Name = "tsmiPagosRealizados";
            this.tsmiPagosRealizados.Size = new System.Drawing.Size(250, 34);
            this.tsmiPagosRealizados.Text = "Pagos Realizados";
            // 
            // pciContenedor
            // 
            this.pciContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pciContenedor.Location = new System.Drawing.Point(0, 110);
            this.pciContenedor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pciContenedor.Name = "pciContenedor";
            this.pciContenedor.Size = new System.Drawing.Size(1290, 658);
            this.pciContenedor.TabIndex = 7;
            // 
            // verListadoDePerfilesToolStripMenuItem
            // 
            this.verListadoDePerfilesToolStripMenuItem.Name = "verListadoDePerfilesToolStripMenuItem";
            this.verListadoDePerfilesToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.verListadoDePerfilesToolStripMenuItem.Text = "Ver Listado de Perfiles";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            // 
            // verInstructoresToolStripMenuItem
            // 
            this.verInstructoresToolStripMenuItem.Name = "verInstructoresToolStripMenuItem";
            this.verInstructoresToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verInstructoresToolStripMenuItem.Text = "Ver Instructores";
            // 
            // FrmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 768);
            this.ControlBox = false;
            this.Controls.Add(this.pciContenedor);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPantallaPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPantallaPrincipal";
            this.Load += new System.EventHandler(this.FrmPantallaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFmrPrincipal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbMaximizar;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PtbCerrarFmrPrincipal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPerfilUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiListaDeUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiListadoDeUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiAsistencia;
        private System.Windows.Forms.ToolStripMenuItem tsmiMembresia;
        private System.Windows.Forms.ToolStripMenuItem tsmiAggMembresia;
        private System.Windows.Forms.ToolStripMenuItem tsmiInstructores;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoInstructor;
        private System.Windows.Forms.ToolStripMenuItem tsmiCaja;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerCaja;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem tsmiPagosRealizados;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerProductos;
        private System.Windows.Forms.Panel pciContenedor;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListadoDePerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInstructoresToolStripMenuItem;
    }
}