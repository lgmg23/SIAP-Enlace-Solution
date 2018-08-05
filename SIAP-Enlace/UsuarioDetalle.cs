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
using SIAP_Enlace.EF;

namespace SIAP_Enlace
{
    public partial class UsuarioDetalle : Form
    {
        public UsuarioDetalle()
        {
            InitializeComponent();
            loadProfile();
        }

        public void loadProfile()
        {
            siapgapEntities _context = new siapgapEntities();
            var perfil = _context.t_usuario.FirstOrDefault(x => x.Id_Usuario == 1);
            label4.Text = perfil.Nombre;            
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
    }
}
