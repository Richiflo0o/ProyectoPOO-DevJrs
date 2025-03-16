using AplicacionGym;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO.clases
{
    class gProductos
    {
        csConectaSQL oCON;
        string CodigoProducto;
        string NOmbreProducto;
        string Categoria;
        string Descripcion;
        string Precio;
        string Cantidad;


        public string CODIGO
        {
            get { return CodigoProducto; }
            set { CodigoProducto = value; }
        }
        public string NOMBRE
        {
            get { return NOmbreProducto; }
            set { NOmbreProducto = value; }
        }
        public string CATEGORIA
        {
            get { return Categoria; }
            set { Categoria = value; }
        }
        public string DESCRIPCION
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public string PRECIO
        {
            get { return Precio; }
            set { Precio = value; }
        }
        public string CANTIDAD
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
        public gProductos()
        {
            oCON = new csConectaSQL();
        }
        public void IngresarUsuario(string tabla, string campos, string datos)
        {
            oCON.insertarDatos(tabla, campos, datos);
        }
        public void EliminarUsuario(string tabla, string condicion)
        {
            oCON.eliminarDatos(tabla, condicion);
        }
        public void ModificarUsuario(string cadena)
        {
            oCON.ModificarDatos(cadena);
        }
    }
}
