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
    public partial class DialogBoxBuscar : Form
    {
        public DialogBoxBuscar()
        {
            InitializeComponent();
        }
        string buscar;
        public string busqueda
        {
            get { return buscar; }
        }
        private void DialogBoxBuscar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 186);
            switch(Form1.buscarQue)
            {
                case 1: label1.Text = "Seleccione una fecha.";
                    pictureBox1.Image = Image.FromFile("iconfinder_35_5027829.png");
                    dtpBusca.Value = DateTime.Now;
                    dtpBusca.Visible = true;
                    break;
                case 2: label1.Text = "Escriba el nombre del producto";
                    pictureBox1.Image = Image.FromFile("iconfinder_27_5027821.png");
                    txtBuscaN.Clear();
                    txtBuscaN.Visible = true;
                    break;
                case 3: label1.Text = "Seleccione la forma de pago";
                    pictureBox1.Image = Image.FromFile("iconfinder_74_5027868.png");
                    cmbBuscaPago.SelectedIndex = 1;
                    cmbBuscaPago.Visible = true;
                    break;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            switch (Form1.buscarQue)
            {
                case 1: buscar = dtpBusca.Value.ToString("dd/MMMM/yyyy"); break;
                case 2: buscar = txtBuscaN.Text.ToLower(); break;
                case 3: buscar = cmbBuscaPago.Text; break;
            }
        }

        private void txtBuscaN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                toti.IsBalloon = true;
                toti.Show("Cáracter invalido", txtBuscaN, 3000);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                if (txtBuscaN.Text != "")
                {
                    btnDo.PerformClick();
                }
                else
                {
                    toti.IsBalloon = true;
                    toti.Show("No dejar campo vacío", txtBuscaN, 3000);
                }
            }
        }
    }
}
