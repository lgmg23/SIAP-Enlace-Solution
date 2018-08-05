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

namespace SIAP_Enlace
{
    public partial class Busqueda : Form
    {
        public Busqueda(List<BusquedaModel> busquedaMList)
        {
            InitializeComponent();
            loadDGV(busquedaMList);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadDGV(List<BusquedaModel> busquedaMList)
        {            
            dataGridView1.DataSource = busquedaMList;
            dataGridView1.AutoResizeColumns();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {

        }
    }
}