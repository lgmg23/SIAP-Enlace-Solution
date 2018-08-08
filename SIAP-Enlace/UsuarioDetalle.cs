using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIAP_Enlace.Model.Producto;
using SIAP_Enlace.EF;
using SIAP_Enlace.Model;

namespace SIAP_Enlace
{
    public partial class UsuarioDetalle : Form
    {
        public UsuarioDetalle(int idUsuario)
        {
            InitializeComponent();
            loadProfile(idUsuario);
        }
        private void UsuarioDetalle_Load(object sender, EventArgs e)
        {

        }
        public void loadProfile(int id)
        {
            siapgapEntities _context = new siapgapEntities();
            var perfil = _context.t_usuario.FirstOrDefault(x => x.Id_Usuario == id);
            label4.Text = perfil.Usuario;            
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(string file in files)
            {
                try
                {
                    string destinationDirectory = "C:\\Users\\luisg\\Desktop\\Datos\\";
                    File.Copy(file, destinationDirectory + "puto" + Path.GetExtension(file));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                MessageBox.Show("Archivo Copiado");
            }            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Directory.Exists("‪C:\\"))
            {
                MessageBox.Show("el folder existe");
            }
            else
            {
                MessageBox.Show("el folder no existe");

            }
        }


        ///Mapeo
        public static ProductoModel TableToModel(t_producto table)
        {
            ProductoModel producto = new ProductoModel();
            producto.Usuario.Nombre = table.t_usuario.Usuario;
            producto.Ubicacion.Ubicacion = table.t_ubicacion.Ubicacion;
            producto.Marca.Marca = table.t_marca.Marca;
            producto.Modelo = table.Modelo;
            producto.Serie = table.Serie;
            producto.SO.SO = table.t_so.SO;
            producto.Area.Area = table.t_area.Area;
            producto.Estado = table.Estado;
            producto.Adquisicion = table.Adquisicion;
            producto.Factura = table.Factura;
            producto.Proveedor.Proveedor = table.t_proveedor.Proveedor;
            producto.NActivo = table.NActivo;
            producto.Garantia = table.Garantia;
            producto.NombreEquipo = table.NombreEquipo;
            return producto;
        }
    }
}
