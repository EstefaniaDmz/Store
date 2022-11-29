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
    public partial class DialogBoxModicaaarrrr : Form
    {
        public DialogBoxModicaaarrrr()
        {
            InitializeComponent();
        }
        internal static int datoModificar;
        internal static int que;
        int numid = 0;
        private void DialogBoxModicaaarrrr_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(233, 244, 188);
            nmrID.Maximum = Cventas.indexContador - 1;
            nmrID.Value = 0;
            txtModi.Clear();
            dtpModi.Value = DateTime.Now;
            txtModi.Visible = false;
            dtpModi.Visible = false;
            btnDo.Visible = false;
            cmbSelecc.SelectedIndex = 0;
        }
        string textoModficar;
        public string modificaresto
        {
            get { return textoModficar; }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dtpModi.Value = DateTime.Now;
            txtModi.Clear();
            string[] lines = File.ReadAllLines("Ventas.txt");
            string[] datos = lines[(int)nmrID.Value].Split(',');
            if (cmbSelecc.SelectedIndex == 0)
            {
                txtModi.Visible = false;
                cmbPago.Visible = false;
                dtpModi.Value = Convert.ToDateTime(datos[1]);
                dtpModi.Visible = true;
            }
            else
            {
                if (cmbSelecc.SelectedIndex == 4)
                {
                    cmbPago.Visible = true;
                    dtpModi.Visible = false;
                    txtModi.Visible = false;
                    switch (datos[5])
                    {
                        case "Efectivo":
                            cmbPago.SelectedIndex = 0;
                            break;
                        case "Tarjeta débito":
                            cmbPago.SelectedIndex = 1;
                            break;
                        case "Tarjeta crédito":
                            cmbPago.SelectedIndex = 2;
                            break;
                        case "Transferencia":
                            cmbPago.SelectedIndex = 3;
                            break;
                        default:
                            cmbPago.SelectedIndex = 4;
                            txtModi.Visible = true;
                            txtModi.Text = datos[5];
                            break;
                    }
                    
                }
                else
                {
                    cmbPago.Visible = false;
                    dtpModi.Visible = false;
                    switch (cmbSelecc.SelectedIndex)
                    {
                        case 1:
                            txtModi.Text = datos[2];
                            break;
                        case 2:
                            txtModi.Text = datos[3];
                            break;
                        case 3:
                            txtModi.Text = datos[4];
                            break;
                    }
                    txtModi.Visible = true;
                }
            }
            btnDo.Visible = true;
        }

        private void txtModi_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmbSelecc.SelectedIndex)
            {
                case 1:
                    if (e.KeyChar == ',')
                    {
                        toti.IsBalloon = true;
                        toti.Show("Cáracter invalido", txtModi, 3000);
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                    if (e.KeyChar == 13)
                    {
                        if (txtModi.Text != "")
                        {
                            btnDo.PerformClick();
                        }
                        else
                        {
                            toti.IsBalloon = true;
                            toti.Show("No dejar campo vacío", txtModi, 3000);
                        }
                    }
                    break;
                case 2:
                    if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        toti.IsBalloon = true;
                        toti.Show("Solo se permiten números", txtModi, 3000);
                        e.Handled = true;
                    }
                    if (e.KeyChar == 13)
                    {
                        if (txtModi.Text != "")
                        {
                            btnDo.PerformClick();
                        }
                        else
                        {
                            toti.IsBalloon = true;
                            toti.Show("No dejar campo vacío", txtModi, 3000);
                        }
                    }
                    break;
                case 3:
                    if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        toti.IsBalloon = true;
                        toti.Show("Solo se permiten números", txtModi, 3000);
                        e.Handled = true;
                    }
                    if (e.KeyChar == 13)
                    {
                        if (txtModi.Text != "")
                        {
                            btnDo.PerformClick();
                        }
                        else
                        {
                            toti.IsBalloon = true;
                            toti.Show("No dejar campo vacío", txtModi, 3000);
                        }
                    }
                    break;
                case 4:
                    if (e.KeyChar == ',')
                    {
                        toti.IsBalloon = true;
                        toti.Show("Cáracter invalido", txtModi, 3000);
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                    if (e.KeyChar == 13)
                    {
                        if (txtModi.Text != "")
                        {
                            btnDo.PerformClick();
                        }
                        else
                        {
                            toti.IsBalloon = true;
                            toti.Show("No dejar campo vacío", txtModi, 3000);
                        }
                    }
                    break;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            switch(cmbSelecc.SelectedIndex)
            {
                case 0:
                    textoModficar = dtpModi.Value.Date.ToString("dd/MMMM/yyyy");
                    break;
                case 4:
                    if (cmbPago.SelectedIndex != 4)
                    {
                        textoModficar = cmbPago.Text;
                    }
                    else
                    {
                        textoModficar = txtModi.Text;

                    }
                    break;
                default:
                    textoModficar = txtModi.Text;
                    break;
            }
            que = cmbSelecc.SelectedIndex + 1;
            datoModificar = (int)nmrID.Value;
        }

        private void cmbPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPago.SelectedIndex == 4)
            {
                txtModi.Visible = true;
            }
            else
            {
                txtModi.Visible = false;
            }
        }
    }
}
