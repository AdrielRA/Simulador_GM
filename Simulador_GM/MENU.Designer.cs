namespace Simulador_GM
{
    partial class frm_MENU
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MENU));
            this.elip_MENU = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_BarraTitulo = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Minimizar = new System.Windows.Forms.Label();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.drag_MENU = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_FIFO = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_LRU = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_REL = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.lbl_Informação = new System.Windows.Forms.Label();
            this.pic_Git = new System.Windows.Forms.PictureBox();
            this.pnl_BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Git)).BeginInit();
            this.SuspendLayout();
            // 
            // elip_MENU
            // 
            this.elip_MENU.ElipseRadius = 10;
            this.elip_MENU.TargetControl = this;
            // 
            // pnl_BarraTitulo
            // 
            this.pnl_BarraTitulo.BackColor = System.Drawing.Color.White;
            this.pnl_BarraTitulo.Controls.Add(this.lbl_Titulo);
            this.pnl_BarraTitulo.Controls.Add(this.lbl_Minimizar);
            this.pnl_BarraTitulo.Controls.Add(this.lbl_Fechar);
            this.pnl_BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_BarraTitulo.Name = "pnl_BarraTitulo";
            this.pnl_BarraTitulo.Size = new System.Drawing.Size(330, 40);
            this.pnl_BarraTitulo.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoEllipsis = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(268, 40);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "   Simulador de Gerencia de Memória";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Minimizar
            // 
            this.lbl_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Minimizar.AutoEllipsis = true;
            this.lbl_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Minimizar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Minimizar.ForeColor = System.Drawing.Color.Black;
            this.lbl_Minimizar.Location = new System.Drawing.Point(267, 0);
            this.lbl_Minimizar.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Minimizar.Name = "lbl_Minimizar";
            this.lbl_Minimizar.Size = new System.Drawing.Size(30, 40);
            this.lbl_Minimizar.TabIndex = 1;
            this.lbl_Minimizar.Text = "🗕";
            this.lbl_Minimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Minimizar.Click += new System.EventHandler(this.lbl_Minimizar_Click);
            this.lbl_Minimizar.MouseEnter += new System.EventHandler(this.lbl_MENU_Hover);
            this.lbl_Minimizar.MouseLeave += new System.EventHandler(this.lbl_MENU_Hover);
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Fechar.AutoEllipsis = true;
            this.lbl_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Fechar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.Black;
            this.lbl_Fechar.Location = new System.Drawing.Point(297, 0);
            this.lbl_Fechar.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(30, 40);
            this.lbl_Fechar.TabIndex = 0;
            this.lbl_Fechar.Text = "🗙";
            this.lbl_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_MENU_Hover);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_MENU_Hover);
            // 
            // drag_MENU
            // 
            this.drag_MENU.Fixed = true;
            this.drag_MENU.Horizontal = true;
            this.drag_MENU.TargetControl = this.lbl_Titulo;
            this.drag_MENU.Vertical = true;
            // 
            // btn_FIFO
            // 
            this.btn_FIFO.Active = false;
            this.btn_FIFO.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_FIFO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FIFO.BackColor = System.Drawing.Color.White;
            this.btn_FIFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FIFO.BorderRadius = 0;
            this.btn_FIFO.ButtonText = "FIFO";
            this.btn_FIFO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FIFO.DisabledColor = System.Drawing.Color.Gray;
            this.btn_FIFO.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_FIFO.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_FIFO.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_FIFO.Iconimage")));
            this.btn_FIFO.Iconimage_right = null;
            this.btn_FIFO.Iconimage_right_Selected = null;
            this.btn_FIFO.Iconimage_Selected = null;
            this.btn_FIFO.IconMarginLeft = 0;
            this.btn_FIFO.IconMarginRight = 0;
            this.btn_FIFO.IconRightVisible = false;
            this.btn_FIFO.IconRightZoom = 0D;
            this.btn_FIFO.IconVisible = false;
            this.btn_FIFO.IconZoom = 100D;
            this.btn_FIFO.IsTab = false;
            this.btn_FIFO.Location = new System.Drawing.Point(50, 78);
            this.btn_FIFO.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FIFO.Name = "btn_FIFO";
            this.btn_FIFO.Normalcolor = System.Drawing.Color.White;
            this.btn_FIFO.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_FIFO.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_FIFO.selected = false;
            this.btn_FIFO.Size = new System.Drawing.Size(230, 50);
            this.btn_FIFO.TabIndex = 1;
            this.btn_FIFO.Text = "FIFO";
            this.btn_FIFO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_FIFO.Textcolor = System.Drawing.Color.Black;
            this.btn_FIFO.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FIFO.Click += new System.EventHandler(this.btn_FIFO_Click);
            // 
            // btn_LRU
            // 
            this.btn_LRU.Active = false;
            this.btn_LRU.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_LRU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LRU.BackColor = System.Drawing.Color.White;
            this.btn_LRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LRU.BorderRadius = 0;
            this.btn_LRU.ButtonText = "LRU";
            this.btn_LRU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LRU.DisabledColor = System.Drawing.Color.Gray;
            this.btn_LRU.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_LRU.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_LRU.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_LRU.Iconimage")));
            this.btn_LRU.Iconimage_right = null;
            this.btn_LRU.Iconimage_right_Selected = null;
            this.btn_LRU.Iconimage_Selected = null;
            this.btn_LRU.IconMarginLeft = 0;
            this.btn_LRU.IconMarginRight = 0;
            this.btn_LRU.IconRightVisible = false;
            this.btn_LRU.IconRightZoom = 0D;
            this.btn_LRU.IconVisible = false;
            this.btn_LRU.IconZoom = 100D;
            this.btn_LRU.IsTab = false;
            this.btn_LRU.Location = new System.Drawing.Point(50, 160);
            this.btn_LRU.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LRU.Name = "btn_LRU";
            this.btn_LRU.Normalcolor = System.Drawing.Color.White;
            this.btn_LRU.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_LRU.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_LRU.selected = false;
            this.btn_LRU.Size = new System.Drawing.Size(230, 50);
            this.btn_LRU.TabIndex = 2;
            this.btn_LRU.Text = "LRU";
            this.btn_LRU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_LRU.Textcolor = System.Drawing.Color.Black;
            this.btn_LRU.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LRU.Click += new System.EventHandler(this.btn_LRU_Click);
            // 
            // btn_REL
            // 
            this.btn_REL.Active = false;
            this.btn_REL.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_REL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_REL.BackColor = System.Drawing.Color.White;
            this.btn_REL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_REL.BorderRadius = 0;
            this.btn_REL.ButtonText = "RELÓGIO";
            this.btn_REL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_REL.DisabledColor = System.Drawing.Color.Gray;
            this.btn_REL.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_REL.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_REL.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_REL.Iconimage")));
            this.btn_REL.Iconimage_right = null;
            this.btn_REL.Iconimage_right_Selected = null;
            this.btn_REL.Iconimage_Selected = null;
            this.btn_REL.IconMarginLeft = 0;
            this.btn_REL.IconMarginRight = 0;
            this.btn_REL.IconRightVisible = false;
            this.btn_REL.IconRightZoom = 0D;
            this.btn_REL.IconVisible = false;
            this.btn_REL.IconZoom = 100D;
            this.btn_REL.IsTab = false;
            this.btn_REL.Location = new System.Drawing.Point(50, 242);
            this.btn_REL.Margin = new System.Windows.Forms.Padding(4);
            this.btn_REL.Name = "btn_REL";
            this.btn_REL.Normalcolor = System.Drawing.Color.White;
            this.btn_REL.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_REL.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_REL.selected = false;
            this.btn_REL.Size = new System.Drawing.Size(230, 50);
            this.btn_REL.TabIndex = 3;
            this.btn_REL.Text = "RELÓGIO";
            this.btn_REL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_REL.Textcolor = System.Drawing.Color.Black;
            this.btn_REL.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_REL.Click += new System.EventHandler(this.btn_REL_Click);
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoEllipsis = true;
            this.lbl_Info.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Info.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Info.Location = new System.Drawing.Point(0, 310);
            this.lbl_Info.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(330, 40);
            this.lbl_Info.TabIndex = 4;
            this.lbl_Info.Text = "UNIFENAS - 2019";
            this.lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Informação
            // 
            this.lbl_Informação.AutoEllipsis = true;
            this.lbl_Informação.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Informação.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Informação.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Informação.Location = new System.Drawing.Point(4, 309);
            this.lbl_Informação.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Informação.Name = "lbl_Informação";
            this.lbl_Informação.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_Informação.Size = new System.Drawing.Size(40, 40);
            this.lbl_Informação.TabIndex = 5;
            this.lbl_Informação.Text = "🛈";
            this.lbl_Informação.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Informação.Click += new System.EventHandler(this.lbl_Info_Click);
            // 
            // pic_Git
            // 
            this.pic_Git.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Git.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Git.Image = global::Simulador_GM.Properties.Resources.icon_git;
            this.pic_Git.Location = new System.Drawing.Point(296, 318);
            this.pic_Git.Name = "pic_Git";
            this.pic_Git.Size = new System.Drawing.Size(23, 23);
            this.pic_Git.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Git.TabIndex = 7;
            this.pic_Git.TabStop = false;
            this.pic_Git.Click += new System.EventHandler(this.pic_Git_Click);
            // 
            // frm_MENU
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(330, 350);
            this.Controls.Add(this.pic_Git);
            this.Controls.Add(this.lbl_Informação);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.btn_REL);
            this.Controls.Add(this.btn_LRU);
            this.Controls.Add(this.btn_FIFO);
            this.Controls.Add(this.pnl_BarraTitulo);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Gerencia de Memória";
            this.pnl_BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Git)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elip_MENU;
        private System.Windows.Forms.Panel pnl_BarraTitulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Minimizar;
        private System.Windows.Forms.Label lbl_Fechar;
        private Bunifu.Framework.UI.BunifuDragControl drag_MENU;
        private System.Windows.Forms.Label lbl_Info;
        private Bunifu.Framework.UI.BunifuFlatButton btn_REL;
        private Bunifu.Framework.UI.BunifuFlatButton btn_LRU;
        private Bunifu.Framework.UI.BunifuFlatButton btn_FIFO;
        private System.Windows.Forms.Label lbl_Informação;
        private System.Windows.Forms.PictureBox pic_Git;
    }
}

