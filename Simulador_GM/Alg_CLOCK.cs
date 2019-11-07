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
    public partial class frm_CLOCK : Form
    {
        private Endereço[] memoria;
        private Endereço estado;
        private int count_falta, index_memoria;

        public struct Endereço
        {
            public string dados;
            public int bit_R;
        }

        public frm_CLOCK()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            pnl_Faltas.Visible = pnl_Controles.Visible = false;
            num_Paginas.Enabled = num_Processos.Enabled = btn_Start.Visible = true;
            pnl_Relogio.BackgroundImage = Properties.Resources.clock_bg;
            lbl_Selecionada.Text = lbl_BitR.Text = "";
            Reset_Relogio_BG();
            lbl_Bit0.Text = lbl_Bit1.Text = lbl_Bit2.Text = lbl_Bit3.Text = lbl_Bit4.Text =
                lbl_Bit5.Text = lbl_Bit6.Text = lbl_Bit7.Text = "R = ?";
            lbl_Pag0.Text = lbl_Pag1.Text = lbl_Pag2.Text = lbl_Pag3.Text = lbl_Pag4.Text =
                lbl_Pag5.Text = lbl_Pag6.Text = lbl_Pag7.Text = "-";
            btn_Pausar.Text = "⏸️";
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lbl_MENU_Hover(object sender, EventArgs e) { frm_MENU.lbl_Hover(sender as Label); }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            num_Paginas.Enabled = num_Processos.Enabled = false;
            btn_Start.Visible = false;
            index_memoria = 0;

            memoria = new Endereço[8];
            for (int i = 0; i < memoria.Length; i++)
            {
                memoria[i].dados = "-";
                memoria[i].bit_R = -1;
            }
            estado = Get_New_Page();
            lbl_Selecionada.Text = "Próxima: " + (string.IsNullOrEmpty(estado.dados) ? "?" : estado.dados);
            lbl_BitR.Text = "Bit R: " + (memoria[index_memoria].bit_R == 1 ? "0" : "1");

            pnl_Faltas.Visible = pnl_Controles.Visible = true;
            tm_Clock.Start();
        }
        private void btn_Pausar_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton btn = sender as Bunifu.Framework.UI.BunifuFlatButton;

            if (tm_Clock.Enabled) { tm_Clock.Stop(); btn.Text = "▶"; }
            else { tm_Clock.Start(); btn.Text = "⏸️"; }
        }
        private void btn_Parar_Click(object sender, EventArgs e)
        {
            tm_Clock.Stop();
            Reset();
        }
        private void btn_Mais_Click(object sender, EventArgs e)
        {
            tm_Clock.Interval = tm_Clock.Interval > 1 ? tm_Clock.Interval / 2 : 1;
        }
        private void btn_Menos_Click(object sender, EventArgs e)
        {
            tm_Clock.Interval = tm_Clock.Interval < 10000 ? tm_Clock.Interval * 2 : 10000;
        }

        private Endereço Get_New_Page()
        {
            Endereço endereço = new Endereço();

            int processo = new Random((int)DateTime.Now.Ticks).Next(1, (int)num_Processos.Value + 1),
                pagina = new Random((int)DateTime.Now.Ticks).Next(1, (int)num_Paginas.Value + 1);
            endereço.dados = "P" + processo + " [" + pagina + "]";
            endereço.bit_R = 1;

            return endereço;
        }

        private void tm_Clock_Tick(object sender, EventArgs e)
        {
            Reset_Relogio_BG();
            
            Endereço end_result = memoria.ToList().FirstOrDefault(end => end.dados == estado.dados);
            if (!string.IsNullOrEmpty(end_result.dados))
            {
                int index_encontrado = memoria.ToList().IndexOf(end_result);
                memoria[index_encontrado].bit_R = 1;

                Atualizar_Relogio(index_encontrado);
                Colorir_Cell(index_encontrado, Color.LightGreen, 0);

                estado = new Endereço();

                if (index_encontrado == index_memoria) 
                    index_memoria = index_memoria < 7 ? ++index_memoria : 0;
            }
            else
            {
                if (memoria[index_memoria].bit_R != 1)
                {
                    memoria[index_memoria].bit_R = 1;
                    memoria[index_memoria].dados = estado.dados;
                    estado = new Endereço();
                    Colorir_Cell(index_memoria, Color.LightYellow, 1);
                    count_falta++;
                }
                else
                {
                    memoria[index_memoria].bit_R = 0;
                    Colorir_Cell(index_memoria, Color.LightCoral, 0);
                }
                Atualizar_Relogio(index_memoria);
                index_memoria = index_memoria < 7 ? ++index_memoria : 0;
            }

            pnl_Relogio.BackgroundImage = Rotate_Img(Properties.Resources.clock_bg, index_memoria * 45);

            if (estado.dados == null)
            {
                estado = Get_New_Page();
            }
            lbl_Selecionada.Text = "Próxima: " + (string.IsNullOrEmpty(estado.dados) ? "?" : estado.dados);
            lbl_BitR.Text = "Bit R: " + (memoria[index_memoria].bit_R == 1 ? "0" :"1");
            lbl_Falta.Text = count_falta.ToString();
        }

        private void Colorir_Cell(int index, Color cor, int bit_or_data)
        {
            if(bit_or_data == 0)
            {
                switch (index)
                {
                    case 0:
                        lbl_Bit0.BackColor = cor;
                        break;
                    case 1:
                        lbl_Bit1.BackColor = cor;
                        break;
                    case 2:
                        lbl_Bit2.BackColor = cor;
                        break;
                    case 3:
                        lbl_Bit3.BackColor = cor;
                        break;
                    case 4:
                        lbl_Bit4.BackColor = cor;
                        break;
                    case 5:
                        lbl_Bit5.BackColor = cor;
                        break;
                    case 6:
                        lbl_Bit6.BackColor = cor;
                        break;
                    case 7:
                        lbl_Bit7.BackColor = cor;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (index)
                {
                    case 0:
                        lbl_Pag0.BackColor = cor;
                        break;
                    case 1:
                        lbl_Pag1.BackColor = cor;
                        break;
                    case 2:
                        lbl_Pag2.BackColor = cor;
                        break;
                    case 3:
                        lbl_Pag3.BackColor = cor;
                        break;
                    case 4:
                        lbl_Pag4.BackColor = cor;
                        break;
                    case 5:
                        lbl_Pag5.BackColor = cor;
                        break;
                    case 6:
                        lbl_Pag6.BackColor = cor;
                        break;
                    case 7:
                        lbl_Pag7.BackColor = cor;
                        break;
                    default:
                        break;
                }
            }
        }
        private void Reset_Relogio_BG()
        {
            lbl_Bit0.BackColor = lbl_Bit1.BackColor = lbl_Bit2.BackColor = lbl_Bit3.BackColor = lbl_Bit4.BackColor =
                lbl_Bit5.BackColor = lbl_Bit6.BackColor = lbl_Bit7.BackColor = Color.WhiteSmoke;
            lbl_Pag0.BackColor = lbl_Pag1.BackColor = lbl_Pag2.BackColor = lbl_Pag3.BackColor = lbl_Pag4.BackColor =
                lbl_Pag5.BackColor = lbl_Pag6.BackColor = lbl_Pag7.BackColor = Color.WhiteSmoke;
        }

        private void Atualizar_Relogio(int index_memoria)
        {
            switch (index_memoria)
            {
                case 0:
                    lbl_Bit0.Text = "R = " + memoria[index_memoria].bit_R;
                    lbl_Pag0.Text = memoria[index_memoria].dados;
                    break;
                case 1:
                    lbl_Bit1.Text = "R = " + memoria[index_memoria].bit_R;
                    lbl_Pag1.Text = memoria[index_memoria].dados;
                    break;
                case 2:
                    lbl_Bit2.Text = "R = " + memoria[index_memoria].bit_R;
                    lbl_Pag2.Text = memoria[index_memoria].dados;
                    break;
                case 3:
                    lbl_Bit3.Text = "R = " + memoria[index_memoria].bit_R;
                    lbl_Pag3.Text = memoria[index_memoria].dados;
                    break;
                case 4:
                    lbl_Bit4.Text = "R = " + memoria[index_memoria].bit_R;
                    lbl_Pag4.Text = memoria[index_memoria].dados;
                    break;
                case 5:
                    lbl_Bit5.Text = "R = " + memoria[index_memoria].bit_R;
                    lbl_Pag5.Text = memoria[index_memoria].dados;
                    break;
                case 6:
                    lbl_Bit6.Text = "R = " + memoria[index_memoria].bit_R;
                    lbl_Pag6.Text = memoria[index_memoria].dados;
                    break;
                case 7:
                    lbl_Bit7.Text = "R = " + memoria[index_memoria].bit_R;
                    lbl_Pag7.Text = memoria[index_memoria].dados;
                    break;
                default:
                    break;
            }
        }

        private Bitmap Rotate_Img(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }
    }
}
