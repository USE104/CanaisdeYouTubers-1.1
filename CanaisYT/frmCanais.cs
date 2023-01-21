using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CanaisYT
{
    public partial class frmCanais : Form
    {
        public frmCanais()
        {
            InitializeComponent();
            trackBar1.Enabled = true;

        }

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        private void frmCanais_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            trackBar1.Enabled = true;
            textBox1.Text = ("0");
        }


        private void btnMW_Click(object sender, EventArgs e)
        { if(MessageBox.Show("Você será redirecionardo para o Canal" + " " + btnMW.Text, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@MWInformatica/videos");
                pStart.Start();
                btnMW.Focus();
            }
            else
            {
                MessageBox.Show("Você cancelou o redirecionardo para o Canal" + " " + btnMW.Text, "Mensagem do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnTecnoArt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você será redirecionardo para o Canal" + " " + btnTecnoArt.Text, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@tecnoart101/videos");
                pStart.Start();
            }
            else
            {
                MessageBox.Show("Você cancelou o redirecionardo para o Canal" + " " + btnTecnoArt.Text, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnGarimpandoagambiara_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você será redirecionardo para o Canal" + " " + btnGarimpandoagambiara.Text, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@Garimpandoagambiarra/videos");
                pStart.Start();
            }            
            else
            {
                MessageBox.Show("Você cancelou o redirecionardo para o Canal" + " " + btnGarimpandoagambiara.Text, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTecmundo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você será redirecionardo para o Canal" + " " + btnTecmundo.Text, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@tecmundo/videos");
                pStart.Start();
            }
            else
            {
                MessageBox.Show("Você cancelou o redirecionardo para o Canal" + " " + btnTecmundo.Text, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnPCdoFafa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você será redirecionardo para o Canal" + " " + btnPCdoFafa.Text, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {

                System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@pcdofafa/videos");
                pStart.Start();
            }

            else
            {
                MessageBox.Show("Você cancelou o redirecionardo para o Canal" + " " + btnPCdoFafa.Text, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnOlharDigital_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você será redirecionardo para o Canal" + " " + btnOlharDigital.Text, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@olhardigital/videos");
                pStart.Start();
            }
            else
            {
                MessageBox.Show("Você cancelou oredirecionardo para o Canal"+ " " + btnOlharDigital.Text, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnSafesrc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você será redirecionardo para o Canal " + " " + btnSafesrc.Text, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@safesrc/videos");
                pStart.Start();
            }
            else
            {
                MessageBox.Show("Você cancelou o redirecionardo para o Canal" + " " + btnSafesrc.Text, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
           
            textBox1.Text = trackBar1.Value.ToString();

            if (trackBar1.Value == 0)
            {
                btnMW.Select();
                textBox2.Text = btnMW.Text;
            }
            if (trackBar1.Value == 1)
            {
                btnTecnoArt.Select();
                textBox2.Text = btnTecnoArt.Text;
            }
            if (trackBar1.Value == 2)
            {
                btnPCdoFafa.Select();
                textBox2.Text=btnPCdoFafa.Text;
            }
            if (trackBar1.Value ==3)
            {
                btnGarimpandoagambiara.Select();
                 textBox2.Text=btnGarimpandoagambiara.Text;
            }
            if (trackBar1.Value == 4)
            {
                btnTecmundo.Select();
                textBox2.Text = btnTecmundo.Text;
            }
            if (trackBar1.Value ==5)
            {
                btnOlharDigital.Select();
                textBox2.Text = btnOlharDigital.Text;
            }
            if (trackBar1.Value ==6)
            {
                btnSafesrc.Select();
                textBox2.Text = btnSafesrc.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0"))
            {
                btnMW.Select();
                (textBox2.Text) = (btnMW.Text);
                trackBar1.Value = 0;
            }

            if ((textBox1.Text == "1"))
            {
                btnTecnoArt.Select();
                (textBox2.Text) = (btnTecnoArt.Text);
                trackBar1.Value = 1;
            }

            if ((textBox1.Text == "2"))
            {
                btnPCdoFafa.Select();
                (textBox2.Text) = (btnPCdoFafa.Text);
                trackBar1.Value = 2;
            }

            if ((textBox1.Text == "3"))
            {
                btnGarimpandoagambiara.Select();
                (textBox2.Text) = (btnGarimpandoagambiara.Text);
                trackBar1.Value = 3;
            }

            if ((textBox1.Text == "4"))
            {
                btnTecmundo.Select();
                (textBox2.Text) = (btnTecmundo.Text);
                trackBar1.Value = 4;
            }

            if ((textBox1.Text == "5"))
            {
                btnOlharDigital.Select();
                (textBox2.Text) = (btnOlharDigital.Text);
                trackBar1.Value = 5;
            }

            if ((textBox1.Text == "6"))
            {
                btnSafesrc.Select();
                (textBox2.Text) = (btnSafesrc.Text);
                trackBar1.Value = 6;
            }
               // MessageBox.Show("Pesquise somente até o número 6", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }
    }
    
}







