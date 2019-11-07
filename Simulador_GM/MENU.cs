using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_GM
{
    public partial class frm_MENU : Form
    {
        public frm_MENU()
        {
            InitializeComponent();
        }

        public static void lbl_Minimizar_Control(Form form)
        {
            form.WindowState = form.WindowState == FormWindowState.Minimized ? FormWindowState.Normal : FormWindowState.Minimized;
        }
        public static void lbl_Hover(Label lbl) { lbl.ForeColor = lbl.ForeColor == Color.Black ? Color.FromArgb(90, 90, 90) : Color.Black; }
        private void lbl_Minimizar_Click(object sender, EventArgs e)
        {
            lbl_Minimizar_Control(this);
        }
        private void lbl_MENU_Hover(object sender, EventArgs e) { lbl_Hover(sender as Label); }
        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Abrir(Form form)
        {
            Visible = false;
            form.ShowDialog();
            Visible = true;
        }

        private void btn_FIFO_Click(object sender, EventArgs e) { Abrir(new frm_FIFO()); }
        private void btn_LRU_Click(object sender, EventArgs e) { Abrir(new frm_LRU()); }
        private void btn_REL_Click(object sender, EventArgs e) {  Abrir(new frm_CLOCK()); }

        private void lbl_Info_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/adriel.ricardo.a");
            System.Diagnostics.Process.Start("https://www.facebook.com/littlesuuuh");
        }
        private void pic_Git_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AdrielRA/Simulador_GM");
        }
    }
}
