using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanaisYT
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            tmrSplash.Enabled = true;
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (pgbCarregando.Value < 100)
            {

                pgbCarregando.Value = pgbCarregando.Value + 2;


            }
            else
            {
                tmrSplash.Enabled = false;
                this.Visible = false;

                frmCanais abrir = new frmCanais();
                abrir.Show();
                this.Hide();
            }
        }
    }
}
