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
    public partial class DialogBoxResultado : Form
    {
        public DialogBoxResultado()
        {
            InitializeComponent();
        }
        double total;
        string formapago;
        public string pago
        {
            get { return formapago; }
        }

        private void DialogBoxResultado_Load(object sender, EventArgs e)
        {
            total = Cventas.totalPagar;
            this.BackColor = Color.FromArgb(205, 246, 252);
            TodoInvicible();
            txtcambio.Clear();
            txtOtro.Clear();
            lblTot.Text ="$" + total.ToString();
            grpbxPago.Visible = true;
            grbxHOLA.Location = new Point(254, 42);
        }

        

        private void txtcambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                toti.IsBalloon = true;
                toti.Show("Solo se permiten números", txtcambio, 3000);
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                btnDo.PerformClick();
            }
            
        }
        int cualprogress = 0;
        int x = 0;
        private void TodoInvicible()
        {
            txtOtro.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            prgbCre.Visible = false;
            prgbDebi.Visible = false;
            prgbTrans.Visible = false;
            btnDo.Visible = false;
            grbxHOLA.Visible = false;
            txtcambio.Visible = false;
        }
        private void ControlBar(ProgressBar prgb)
        {
            if (x <= 100)
            {
                prgb.Value = x;
                x++;
                if (x == 100)
                {
                    MessageBox.Show("Pago aceptado", "Forma de pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDo.Visible = true;
                }
            }
            else
            {
                timer1.Enabled = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          switch (cualprogress)
            {
                case 1:
                    ControlBar(prgbDebi);
                    break;
                case 2:
                    ControlBar(prgbCre);
                    break;
                case 3:
                    ControlBar(prgbTrans);
                    break;
            }
        }

        private void txtOtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                toti.IsBalloon = true;
                toti.Show("Cáracter invalido", txtOtro, 3000);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                if (txtOtro.Text != "")
                {
                    btnDo.PerformClick();
                }
                else
                {
                    toti.IsBalloon = true;
                    toti.Show("No dejar campo vacío", txtOtro, 3000);
                }
            }
        }

        private void btnDo_Click_1(object sender, EventArgs e)
        {
            if (rdbtnEfec.Checked == true)
            {
                if (total > double.Parse(txtcambio.Text))
                {
                    MessageBox.Show("Fondos insuficientes, la venta no se puede procesar", "Total a pagar",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
                else
                {
                    MessageBox.Show("El cambio es de: $" + (double.Parse(txtcambio.Text) - total), "Total a pagar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formapago = "Efectivo";
                }
                
            }
            else
            {
                if (rdbtnTarDeb.Checked == true)
                {
                    formapago = "Tarjeta débito";
                }
                else
                {
                    if (rdbtnTarCre.Checked == true)
                    {
                        formapago = "Tarjeta crédito";
                    }
                    else
                    {
                        if (rdbtnTrans.Checked == true)
                        {
                            formapago = "Transferencia";
                        }
                        else
                        {
                            formapago = txtOtro.Text;
                        }
                    }
                }
            }
        }

        private void btnRdbtn_Click_1(object sender, EventArgs e)
        {
            TodoInvicible();
            grbxHOLA.Location = new Point(12, 42);
            grpbxPago.Visible = false;
            if (rdbtnEfec.Checked == true)
            {
                grbxHOLA.Visible = true;
                label2.Visible = true;
                txtcambio.Visible = true;
                txtcambio.Focus();
                btnDo.Visible = true;
            }
            else
            {
                if (rdbtnTarDeb.Checked == true)
                {
                    grbxHOLA.Visible = true;
                    label3.Visible = true;
                    prgbDebi.Visible = true;
                    cualprogress = 1;
                    timer1.Interval = 50;
                    timer1.Start();
                    prgbDebi.Enabled = true;
                }
                else
                {
                    if (rdbtnTarCre.Checked == true)
                    {
                        grbxHOLA.Visible = true;
                        label4.Visible = true;
                        prgbCre.Visible = true;
                        cualprogress = 2;
                        timer1.Start();
                        timer1.Interval = 50;
                        prgbCre.Enabled = true;

                    }
                    else
                    {
                        if (rdbtnTrans.Checked == true)
                        {
                            grbxHOLA.Visible = true;
                            label5.Visible = true;
                            prgbTrans.Visible = true;
                            cualprogress = 3;
                            timer1.Interval = 100;
                            timer1.Start();
                            prgbTrans.Enabled = true;

                        }
                        else
                        {
                            if (rdbtnOtro.Checked == true)
                            {
                                grbxHOLA.Visible = true;
                                label6.Visible = true;
                                txtOtro.Visible = true;
                                txtOtro.Focus();
                                btnDo.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Favor de seleccionar una forma de pago", "Forma de pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }

        private void txtcambio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ('.'))
            {
                e.Handled = false;
            }
            else
            {
                toti.IsBalloon = true;
                toti.Show("Solo se permiten números", txtcambio, 3000);
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (txtcambio.Text != "")
                {
                    btnDo.PerformClick();
                }
                else
                {
                    toti.IsBalloon = true;
                    toti.Show("No dejar campo vacío", txtcambio, 3000);
                }
            }
        }

        private void btnDOOO_Click(object sender, EventArgs e)
        {
            
        }
    }
}
