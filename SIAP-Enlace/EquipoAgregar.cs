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
using SIAP_Enlace.Model.Producto;
using SIAP_Enlace.Model;
using SIAP_Enlace.Model.Auxiliares;
using System.Globalization;

namespace SIAP_Enlace
{
    public partial class EquipoAgregar : Form
    {        
        public EquipoAgregar()
        {
            InitializeComponent();
            siapgapEntities _context = new siapgapEntities();
            fillCombobox();
        }

        public void fillCombobox()
        {
            siapgapEntities _context = new siapgapEntities();

            var usuario = _context.t_usuario.ToList();
            comboBox1.DataSource = usuario;
            comboBox1.DisplayMember = "Usuario";
            comboBox1.ValueMember = "Id_Usuario";
            comboBox1.SelectedIndex = -1;


            var ubicacion = _context.t_ubicacion.ToList();
            comboBox2.DataSource = ubicacion;
            comboBox2.DisplayMember = "Ubicacion";
            comboBox2.ValueMember = "Id_Ubicacion";

            var tipo = _context.t_tipo.ToList();
            comboBox3.DataSource = tipo;
            comboBox3.DisplayMember = "Tipo";
            comboBox3.ValueMember = "Id_Tipo";

            var marca = _context.t_marca.ToList();
            comboBox4.DataSource = marca;
            comboBox4.DisplayMember = "Marca";
            comboBox4.ValueMember = "Id_Marca";

            var so = _context.t_so.ToList();
            comboBox5.DataSource = so;
            comboBox5.DisplayMember = "SO";
            comboBox5.ValueMember = "Id_SO";

            var proveedor = _context.t_proveedor.ToList();
            comboBox8.DataSource = proveedor;
            comboBox8.DisplayMember = "Proveedor";
            comboBox8.ValueMember = "Id_Proveedor";

            var area = _context.t_area.ToList();
            comboBox6.DataSource = area;
            comboBox6.DisplayMember = "Area";
            comboBox6.ValueMember = "Id_Area";

            List<EstadoModel> estados = new List<EstadoModel>();
            EstadoModel estadoA = new EstadoModel();
            estadoA.IdEstado = 1;
            estadoA.Estado = "Activo";
            estados.Add(estadoA);
            EstadoModel estadoI = new EstadoModel();
            estadoI.IdEstado = 0;
            estadoI.Estado = "Inactivo";
            estados.Add(estadoI);

            comboBox7.DataSource = estados;
            comboBox7.DisplayMember = "Estado";
            comboBox7.ValueMember = "IdEstado";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            siapgapEntities _context = new siapgapEntities();
            t_producto productoT = new t_producto();
            int ubicacionS;
            bool castUbicacion = Int32.TryParse(comboBox2.SelectedValue.ToString(), out ubicacionS);
            int tipoS;
            bool castTipo = Int32.TryParse(comboBox3.SelectedValue.ToString(), out tipoS);
            int marcaS;
            bool castMarca = Int32.TryParse(comboBox4.SelectedValue.ToString(), out marcaS);
            int soS;
            bool castSO = Int32.TryParse(comboBox5.SelectedValue.ToString(), out soS);
            int areaS;
            bool castArea = Int32.TryParse(comboBox6.SelectedValue.ToString(), out areaS);
            productoT.Usuario = 1;
            sbyte estadoS;
            bool castEstado = sbyte.TryParse(comboBox7.SelectedValue.ToString(), out estadoS);
            int proveedorS;
            bool castProveedor = Int32.TryParse(comboBox8.SelectedValue.ToString(), out proveedorS);
            productoT.Usuario = 1;
            productoT.Ubicacion = ubicacionS;
            productoT.Tipo = tipoS;
            productoT.Marca = marcaS;
            productoT.Sistema_Operativo = soS;
            productoT.Area = areaS;
            productoT.Estado = estadoS;
            productoT.Proveedor = proveedorS;
            productoT.Modelo = textBox1.Text;
            productoT.Serie = textBox2.Text;
            productoT.Factura = textBox3.Text;
            productoT.NActivo = textBox4.Text;
            productoT.NombreEquipo = textBox5.Text;
            productoT.Caracteristicas = textBox6.Text;
            productoT.Adquisicion = dateTimePicker1.Value;
            productoT.Garantia = dateTimePicker2.Value;
            try
            {
                _context.t_producto.Add(productoT);
                _context.SaveChanges();
                MessageBox.Show("Guardado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modelToTable(ProductoModel model)
        {
            t_producto productoTable = new t_producto();



        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            AuxUbicacion ubicacion = new AuxUbicacion();
            ubicacion.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AuxTipo tipo = new AuxTipo();
            tipo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AuxMarca marca = new AuxMarca();
            marca.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AuxArea area = new AuxArea();
            area.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AuxSO so = new AuxSO();
            so.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AuxProveedor proveedor = new AuxProveedor();
            proveedor.Show();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            fillCombobox();
        }
    }
}
