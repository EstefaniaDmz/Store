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
    public partial class DialogBoxAgregar : Form
    {
        public DialogBoxAgregar()
        {
            InitializeComponent();
        }
        
        public string fecha
        { 
            get { return dtpFecha.Value.Date.ToString("dd/MMMM/yyyy"); }
        }
        public string nombre
        {
            get { return txtName.Text; }
        }
        public int cantidad
        {
            get { return int.Parse(txtCant.Text); }
        }
        public double precio
        {
            get { return double.Parse(txtPrecio.Text); }
        }
        
        private void DialogBoxAgregar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(242, 198, 221);
            dtpFecha.Value = DateTime.Now;
            txtCant.Clear();
            txtName.Clear();
            txtPrecio.Clear();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                toti.IsBalloon = true;
                toti.Show("Cáracter invalido", txtName, 3000);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                if (txtName.Text != "")
                {
                    txtCant.Focus();
                }
                else
                {
                    toti.IsBalloon = true;
                    toti.Show("No dejar campo vacío", txtName, 3000);
                }
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                toti.IsBalloon = true;
                toti.Show("Solo se permiten números", txtCant, 3000);
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (txtCant.Text != "")
                {
                    txtPrecio.Focus();
                }
                else
                {
                    toti.IsBalloon = true;
                    toti.Show("No dejar campo vacío", txtCant, 3000);
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                toti.IsBalloon = true;
                toti.Show("Solo se permiten números", txtPrecio, 3000);
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (txtPrecio.Text != "")
                {
                    btnDo.PerformClick();
                }
                else
                {
                    toti.IsBalloon = true;
                    toti.Show("No dejar campo vacío", txtPrecio, 3000);
                }
            }
        }
    }
}
