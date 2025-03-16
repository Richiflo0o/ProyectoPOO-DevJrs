using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOO.Formularios
{
    public partial class FrmAsistencia : Form
    {
        csConectaSQL sQL= new csConectaSQL();
        
        public FrmAsistencia()
        {
            InitializeComponent();
        }
        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
            AgregarCheckBoxColumn();
            dgvAsistencia.DataSource = sQL.retornaRegistros("select S.id_persona as ID, nombres as Nombre,Correo,Telefono,Estado from Socios as S inner JOIN Personas as P on S.id_persona = P.id_persona");
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AgregarCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn columnaCheckBox = new DataGridViewCheckBoxColumn();
            columnaCheckBox.HeaderText = "Asistencia"; 
            columnaCheckBox.Name = "Marca"; 
            dgvAsistencia.Columns.Add(columnaCheckBox);
        }

        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtBuscador.Text.Length>0)
            {
                switch (tscmbFiltro.Text)
                {
                    case "ID":
                        dgvAsistencia.DataSource = sQL.retornaRegistros("select S.id_persona as ID, nombres as Nombre,Correo,Telefono,Estado from Socios as S inner JOIN Personas as P on S.id_persona = P.id_persona where S.id_persona like '" + txtBuscador.Text + "%'");
                        break;
                    case "Nombre":
                        dgvAsistencia.DataSource = sQL.retornaRegistros("select S.id_persona as ID, nombres as Nombre,Correo,Telefono,Estado from Socios as S inner JOIN Personas as P on S.id_persona = P.id_persona where nombres like '" + txtBuscador.Text + "%'");
                        break;
                    case "Correo":
                        dgvAsistencia.DataSource = sQL.retornaRegistros("select S.id_persona as ID, nombres as Nombre,Correo,Telefono,Estado from Socios as S inner JOIN Personas as P on S.id_persona = P.id_persona where Correo like '" + txtBuscador.Text + "%'");
                        break;
                    case "Telefono":
                        dgvAsistencia.DataSource = sQL.retornaRegistros("select S.id_persona as ID, nombres as Nombre,Correo,Telefono,Estado from Socios as S inner JOIN Personas as P on S.id_persona = P.id_persona where Telefono like '" + txtBuscador.Text + "%'");
                        break;
                }
            }
            else
            {
                dgvAsistencia.DataSource = sQL.retornaRegistros("select S.id_persona as ID, nombres as Nombre,Correo,Telefono,Estado from Socios as S inner JOIN Personas as P on S.id_persona = P.id_persona");
            }
        }
    }
}
