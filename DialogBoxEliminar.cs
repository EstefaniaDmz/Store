using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_POO
{
    public partial class DialogBoxEliminar : Form
    {
        public DialogBoxEliminar()
        {
            InitializeComponent();
        }
        public int eliminar
        {
            get { return (int)nmrID.Value; }
        }
        private void DialogBoxEliminar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 157, 156);
            nmrID.Maximum = Cventas.indexContador - 1;
            nmrID.Value = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de eliminar la venta?", "Eliminar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.No)
            {
                return;
            }
            
        }
    }
}
