using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIAP_Enlace.EF;
using SIAP_Enlace.Model;
//using SIAP_Enlace.EF;

namespace SIAP_Enlace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.ToString();           
            if(usuario.Length >= 4)
            {
                List<BusquedaModel> busquedaMList = new List<BusquedaModel>();
                siapgapEntities _context = new siapgapEntities();
                var dgview = new DataSet();
                var usuarios = _context.t_usuario.Where(x => x.Usuario.Contains(usuario)).ToList();
                if(usuarios.Count >= 1)
                {
                    foreach (var element in usuarios)
                    {
                        BusquedaModel busquedaM = new BusquedaModel();
                        busquedaM.IdUsuario = element.Id_Usuario;
                        busquedaM.Nombre = element.Usuario;
                        busquedaMList.Add(busquedaM);                        
                    }
                    var busquedaForm = new Busqueda(busquedaMList);
                    busquedaForm.Show();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros.", "Error", MessageBoxButtons.OK);
                }
            }            
            else
            {
                MessageBox.Show("Debe ingresar un usuario, o al menos 4 caracteres.", "Error", MessageBoxButtons.OK);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var equiposForm = new Equipos();
            equiposForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var usuarioDetalle = new UsuarioDetalle();
            //usuarioDetalle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var equipoAgregar = new EquipoAgregar();
            equipoAgregar.Show();
        }
    }
}
