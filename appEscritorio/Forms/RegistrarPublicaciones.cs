using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEscritorio.Forms
{
    public partial class RegistrarPublicaciones : Form
    {
        public RegistrarPublicaciones()
        {
            InitializeComponent();
        }

        private void RegistrarPublicaciones_Load(object sender, EventArgs e)
        {
            mtdCargarPublicaciones();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        Miservicio.ServicioRegistrarPublicacionesSoapClient miservicio = new Miservicio.ServicioRegistrarPublicacionesSoapClient();
        private void mtdCargarPublicaciones()
        {
            DataSet dsDatos = new DataSet();
            dsDatos = miservicio.mtdListarProductos();
            dgvPublicaciones.DataSource = dsDatos.Tables["tblDatos"];
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Miservicio.Publicaciones objpub = new Miservicio.Publicaciones();
            objpub.Nombre = txtNombrePublicacion.Text;
            objpub.Precio = int.Parse(txtPrecio.Text);
            objpub.Descripcion = txtDescripcion.Text;
            objpub.Telefono = txtTelefono.Text;
            objpub.Estrato = txtNombrePublicacion.Text;
            objpub.Direccion = txtDescripcion.Text;
            objpub.NumeroHabitaciones = int.Parse(txtNombrePublicacion.Text);
            objpub.IdUsuario = int.Parse(cmbUsuario.Text);
            objpub.IdTipo = int.Parse(cmbTipo.Text);
            objpub.IdEstado = int.Parse(cmbEstado.Text);
            objpub.IdCiudad = int.Parse(cmbCiudad.Text);
            objpub.IdCategoria = int.Parse(cmbCategoria.Text);

            int res = miservicio.mtdRegistrarPublicaciones(objpub);
            if (res > 0)
            {
                MessageBox.Show("Publicacion Registrada");
                mtdCargarPublicaciones();
            }
        }
    }
}
