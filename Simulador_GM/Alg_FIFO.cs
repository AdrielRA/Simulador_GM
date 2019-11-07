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
    public partial class frm_FIFO : Form
    {
        private List<string[]> memoria;
        private string[] estado;
        private string acesso;
        private int index_vitima, count_falta;

        public frm_FIFO()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            pnl_Faltas.Visible = pnl_Controles.Visible = false;
            lbl_Falta.Text = "0";
            num_Memoria.Enabled = num_Paginas.Enabled = num_Processos.Enabled = btn_Start.Visible = true;
            data_Simulação.RowCount = data_Simulação.ColumnCount = 0;
            lbl_Selecionada.Text = lbl_Vitima.Text = "";
            btn_Pausar.Text = "⏸️";
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lbl_MENU_Hover(object sender, EventArgs e) { frm_MENU.lbl_Hover(sender as Label); }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            num_Memoria.Enabled = num_Paginas.Enabled = num_Processos.Enabled = false;
            btn_Start.Visible = false;

            memoria = new List<string[]>();
            estado = new string[(int)num_Memoria.Value];
            memoria.Add(estado);
            index_vitima = count_falta = 0;
            data_Simulação.SelectionMode = DataGridViewSelectionMode.CellSelect;
            data_Simulação.ColumnCount = 0;
            foreach (string[] estado_ in memoria)
            {
                data_Simulação.RowCount = 0;
                data_Simulação.ColumnCount++;
                data_Simulação.Columns[data_Simulação.ColumnCount - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                foreach (string i in estado_)
                {
                    data_Simulação.RowCount++;
                    data_Simulação.Rows[data_Simulação.RowCount - 1].Cells[data_Simulação.ColumnCount - 1].Value = "-";
                }
            }
            data_Simulação.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            pnl_Faltas.Visible = pnl_Controles.Visible = true;
            acesso = Get_Acesso();
            lbl_Selecionada.Text = "Próxima: " + acesso;
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
            tm_Clock.Interval = tm_Clock.Interval > 1 ? tm_Clock.Interval / 2  : 1;
        }

        private void btn_Menos_Click(object sender, EventArgs e)
        {
            tm_Clock.Interval = tm_Clock.Interval < 10000 ? tm_Clock.Interval * 2 : 10000;
        }

        private string Get_Acesso()
        {
            return "P" + new Random((int)DateTime.Now.Ticks).Next(1, (int)num_Processos.Value + 1) +
                " [" + new Random((int)DateTime.Now.Ticks).Next(1, (int)num_Paginas.Value + 1) + "]";
        }

        private void tm_Clock_Tick(object sender, EventArgs e)
        {
            int vitima_anterior = -1, pagina_encontrada = -1;

            if (estado.Contains("-"))
            {
                if (!estado.Contains(acesso))
                {
                    int pos = estado.ToList().IndexOf("-");
                    estado[pos] = acesso;
                }
                else { pagina_encontrada = estado.ToList().IndexOf(acesso); }
            }
            else
            {
                if (!estado.Contains(acesso))
                {
                    vitima_anterior = index_vitima;
                    estado[index_vitima] = acesso;
                    index_vitima = index_vitima < (int)num_Memoria.Value - 1 ? ++index_vitima : 0;
                    count_falta++;
                }
                else { pagina_encontrada = estado.ToList().IndexOf(acesso); }
            }

            estado = estado.ToArray();
            memoria.Add(estado);
            
            data_Simulação.SelectionMode = DataGridViewSelectionMode.CellSelect;
            data_Simulação.ColumnCount++;
            data_Simulação.Columns[data_Simulação.ColumnCount - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            for (int i = 0; i < estado.Length; i++)
            {
                data_Simulação.Rows[i].Cells[data_Simulação.ColumnCount - 1].Value = string.IsNullOrEmpty(estado[i]) ? "-" : estado[i];

                if (i == pagina_encontrada) // quando encontra
                {
                    data_Simulação.Rows[i].Cells[data_Simulação.ColumnCount - 1].Style.BackColor = Color.LightGreen;
                }
                else if (i == vitima_anterior) // quando há troca
                {
                    data_Simulação.Rows[i].Cells[data_Simulação.ColumnCount - 1].Style.BackColor = Color.LightYellow;
                }
                else if (i == index_vitima) // pagina vitima
                {
                    data_Simulação.Rows[i].Cells[data_Simulação.ColumnCount - 1].Style.BackColor = Color.LightCoral;
                }
            }
            data_Simulação.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;

            data_Simulação.FirstDisplayedScrollingColumnIndex = data_Simulação.ColumnCount - 1;

            acesso = Get_Acesso();
            lbl_Selecionada.Text = "Próxima: " + acesso;
            lbl_Vitima.Text = "Vitima: " + (string.IsNullOrEmpty(estado[index_vitima]) ? "?" : estado[index_vitima]);
            lbl_Falta.Text = count_falta.ToString();
        }
    }
}
