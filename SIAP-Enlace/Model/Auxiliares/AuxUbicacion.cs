using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIAP_Enlace.Model;
using SIAP_Enlace.EF;

namespace SIAP_Enlace.Model.Auxiliares
{
    public partial class AuxUbicacion : Form
    {
        public AuxUbicacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            siapgapEntities _context = new siapgapEntities();
            string ubicacionM = textBox1.Text.ToString();
            t_ubicacion ubicacionT = new t_ubicacion();
            ubicacionT.Ubicacion = ubicacionM;
            if (ubicacionM.Length >= 2)
            {
                try
                {
                    _context.t_ubicacion.Add(ubicacionT);
                    _context.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar contacte al administrador.", "Error", MessageBoxButtons.OK);
                    throw ex;
                }
            }
        }
    }
}
