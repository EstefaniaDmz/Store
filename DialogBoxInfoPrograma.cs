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
    public partial class DialogBoxInfoPrograma : Form
    {
        public DialogBoxInfoPrograma()
        {
            InitializeComponent();
        }

        private void DialogBoxInfoPrograma_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(219, 148, 255);
        }
    }
}
