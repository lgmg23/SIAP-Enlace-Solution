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
    public partial class AuxSO : Form
    {
        public AuxSO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            siapgapEntities _context = new siapgapEntities();
            string soM = textBox1.Text.ToString();
            t_so soT = new t_so();
            soT.SO = soM;
            if (soM.Length >= 2)
            {
                try
                {
                    _context.t_so.Add(soT);
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
