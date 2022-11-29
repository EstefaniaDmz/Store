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
    public partial class DialogBoxManual : Form
    {
        public DialogBoxManual()
        {
            InitializeComponent();
        }

        private void DialogBoxManual_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(233, 244, 188);
        }
    }
}
