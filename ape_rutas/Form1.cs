using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ape_rutas
{
    public partial class Form1 : Form
    {
        Ruta ruta = new Ruta();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtMinutosDesdeBaseAnterior.Text == "")
                MessageBox.Show("Hay campos vacíos");
            else
                ruta.agregar(new Base(txtNombre.Text, Convert.ToInt16(txtMinutosDesdeBaseAnterior.Text)));

            limpiarTXT();
        }

        private void btnAgregarEnInicio_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtMinutosDesdeBaseAnterior.Text == "")
                MessageBox.Show("Hay campos vacíos");
            else
                ruta.agregarEnInicio(new Base(txtNombre.Text, Convert.ToInt16(txtMinutosDesdeBaseAnterior.Text)));

            limpiarTXT();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
                MessageBox.Show("Favor de escribir el nombre de la base a buscar.");
            else
                if (ruta.buscar(txtNombre.Text) == null)
                MessageBox.Show("La base no existe.");
            else
                txtReporte.Text = ruta.buscar(txtNombre.Text).ToString();

            limpiarTXT();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
                MessageBox.Show("Favor de escribir el nombre de la base a eliminar.");
            else
            {
                if (ruta.eliminar(txtNombre.Text))
                {
                    MessageBox.Show("Base eliminada.");
                    txtReporte.Text = ruta.mostrar();
                }
                else
                    MessageBox.Show("La base no existe.");
            }

            limpiarTXT();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            if (ruta.eliminarPrimero() == false)
                MessageBox.Show("No hay bases para eliminar.");
            else
            {
                MessageBox.Show("Base eliminada.");
                txtReporte.Text = ruta.mostrar();
            }
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            if (ruta.eliminarUltimo() == false)
                MessageBox.Show("No hay bases para eliminar.");
            else
            {
                MessageBox.Show("Base eliminada.");
                txtReporte.Text = ruta.mostrar();
            }
        }

        private void btnInsertarDespuesDe_Click(object sender, EventArgs e)
        {
            if (txtInsertarDespuesDe.Text == "" || txtBaseAInsertar.Text == "" || txtMinAInsertar.Text == "")
                MessageBox.Show("Hay campos vacíos");
            else
            {
                if (ruta.insertarDespuesDe(txtInsertarDespuesDe.Text, new Base(txtBaseAInsertar.Text, Convert.ToInt16(txtMinAInsertar.Text))) == false)
                    MessageBox.Show("Base no encontrada.");
                else
                    MessageBox.Show("Base insertada.");
            }

            txtInsertarDespuesDe.Text = "";
            txtBaseAInsertar.Text = "";
            txtMinAInsertar.Text = "";
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            if (txtNombreRecorrido.Text == "")
                MessageBox.Show("Inserta el nombre de la base por la que empezará el recorrido.");
            else
                txtReporte.Text = ruta.recorrido(txtNombreRecorrido.Text, dtpHoraInicio.Value, dtpHoraFin.Value);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = ruta.mostrar();
        }

        public void limpiarTXT()
        {
            txtNombre.Text = "";
            txtMinutosDesdeBaseAnterior.Text = "";
        }
    }
}
