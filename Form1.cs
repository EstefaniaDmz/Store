using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Final_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(254, 231, 181);
            menuStrip1.BackColor = Color.FromArgb(255, 226, 163);
            x.ContadorDelIndex();
        }
        Cventas x = new Cventas();
        internal static int buscarQue = 0;
        private void añadirVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.AgregarVenta();
        }

        private void todasLasVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Ventas.txt"))
            {
                x.MostrarDatos(lsvVentas);
            }
            else
            {
                MessageBox.Show("No existen datos para mostrar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void modificarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Ventas.txt"))
            {
                x.ContadorDelIndex();
                x.ModificarDatos();
                x.MostrarDatos(lsvVentas);
            }
            else
            {
                MessageBox.Show("No existen datos para modificar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void borrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Ventas.txt"))
            {
                x.ContadorDelIndex();
                x.EliminarDatos();
                x.MostrarDatos(lsvVentas);
            }
            else
            {
                MessageBox.Show("No existen datos para modificar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Ventas.txt"))
            {
                buscarQue = 1;
                x.Buscar(lsvVentas);
            }
            else
            {
                MessageBox.Show("No existen datos para mostrar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Ventas.txt"))
            {
                buscarQue = 2;
                x.Buscar(lsvVentas);
            }
            else
            {
                MessageBox.Show("No existen datos para mostrar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void porFormaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Ventas.txt"))
            {
                buscarQue = 3;
                x.Buscar(lsvVentas);
            }
            else
            {
                MessageBox.Show("No existen datos para mostrar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void laVentaMásAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Ventas.txt"))
            {
                x.MostrarDatos(lsvVentas);
                x.MostraVentaAlta(lsvVentas);
            }
            else
            {
                MessageBox.Show("No existen datos para mostrar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void laVentaMásBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Ventas.txt"))
            {
                x.MostrarDatos(lsvVentas);
                x.MostraVentaBaja(lsvVentas);
            }
            else
            {
                MessageBox.Show("No existen datos para mostrar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de salir?" , "Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogBoxManual manual = new DialogBoxManual();
            manual.ShowDialog();
        }

        private void esteProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogBoxInfoPrograma info = new DialogBoxInfoPrograma();
            info.ShowDialog();
        }
    }
}
