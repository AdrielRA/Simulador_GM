namespace Simulador_GM
{
    partial class frm_FIFO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FIFO));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_BarraTitulo = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.elip_MENU = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.drag_MENU = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gp_Dados = new System.Windows.Forms.GroupBox();
            this.num_Memoria = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.num_Paginas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new Bunifu.Framework.UI.BunifuFlatButton();
            this.num_Processos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Simular = new System.Windows.Forms.GroupBox();
            this.pnl_Faltas = new System.Windows.Forms.Panel();
            this.lbl_Falta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Vitima = new System.Windows.Forms.Label();
            this.lbl_Selecionada = new System.Windows.Forms.Label();
            this.pnl_Controles = new System.Windows.Forms.Panel();
            this.btn_Parar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Menos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Pausar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Mais = new Bunifu.Framework.UI.BunifuFlatButton();
            this.data_Simulação = new System.Windows.Forms.DataGridView();
            this.elip_Controle = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tm_Clock = new System.Windows.Forms.Timer(this.components);
            this.pnl_BarraTitulo.SuspendLayout();
            this.gp_Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Memoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Paginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Processos)).BeginInit();
            this.gb_Simular.SuspendLayout();
            this.pnl_Faltas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Controles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Simulação)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_BarraTitulo
            // 
            this.pnl_BarraTitulo.BackColor = System.Drawing.Color.White;
            this.pnl_BarraTitulo.Controls.Add(this.lbl_Titulo);
            this.pnl_BarraTitulo.Controls.Add(this.lbl_Fechar);
            this.pnl_BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_BarraTitulo.Name = "pnl_BarraTitulo";
            this.pnl_BarraTitulo.Size = new System.Drawing.Size(800, 40);
            this.pnl_BarraTitulo.TabIndex = 1;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoEllipsis = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(767, 40);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "   FIFO";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Fechar.AutoEllipsis = true;
            this.lbl_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Fechar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.Black;
            this.lbl_Fechar.Location = new System.Drawing.Point(767, 0);
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
            // elip_MENU
            // 
            this.elip_MENU.ElipseRadius = 10;
            this.elip_MENU.TargetControl = this;
            // 
            // drag_MENU
            // 
            this.drag_MENU.Fixed = true;
            this.drag_MENU.Horizontal = true;
            this.drag_MENU.TargetControl = this.lbl_Titulo;
            this.drag_MENU.Vertical = true;
            // 
            // gp_Dados
            // 
            this.gp_Dados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_Dados.Controls.Add(this.num_Memoria);
            this.gp_Dados.Controls.Add(this.label3);
            this.gp_Dados.Controls.Add(this.num_Paginas);
            this.gp_Dados.Controls.Add(this.label1);
            this.gp_Dados.Controls.Add(this.btn_Start);
            this.gp_Dados.Controls.Add(this.num_Processos);
            this.gp_Dados.Controls.Add(this.label2);
            this.gp_Dados.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gp_Dados.Location = new System.Drawing.Point(13, 47);
            this.gp_Dados.Name = "gp_Dados";
            this.gp_Dados.Size = new System.Drawing.Size(775, 100);
            this.gp_Dados.TabIndex = 2;
            this.gp_Dados.TabStop = false;
            this.gp_Dados.Text = "Dados";
            // 
            // num_Memoria
            // 
            this.num_Memoria.Location = new System.Drawing.Point(13, 54);
            this.num_Memoria.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Memoria.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Memoria.Name = "num_Memoria";
            this.num_Memoria.Size = new System.Drawing.Size(87, 27);
            this.num_Memoria.TabIndex = 1;
            this.num_Memoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Memoria.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(11, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "MEMÓRIA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_Paginas
            // 
            this.num_Paginas.Location = new System.Drawing.Point(225, 54);
            this.num_Paginas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Paginas.Name = "num_Paginas";
            this.num_Paginas.Size = new System.Drawing.Size(87, 27);
            this.num_Paginas.TabIndex = 9;
            this.num_Paginas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Paginas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(223, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "PÁGINAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Start
            // 
            this.btn_Start.Active = false;
            this.btn_Start.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Start.BackColor = System.Drawing.Color.White;
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Start.BorderRadius = 0;
            this.btn_Start.ButtonText = "INICIAR SIMULAÇÃO   ▶";
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Start.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Start.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Start.Iconimage")));
            this.btn_Start.Iconimage_right = null;
            this.btn_Start.Iconimage_right_Selected = null;
            this.btn_Start.Iconimage_Selected = null;
            this.btn_Start.IconMarginLeft = 0;
            this.btn_Start.IconMarginRight = 0;
            this.btn_Start.IconRightVisible = false;
            this.btn_Start.IconRightZoom = 0D;
            this.btn_Start.IconVisible = false;
            this.btn_Start.IconZoom = 100D;
            this.btn_Start.IsTab = false;
            this.btn_Start.Location = new System.Drawing.Point(326, 31);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Normalcolor = System.Drawing.Color.White;
            this.btn_Start.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Start.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Start.selected = false;
            this.btn_Start.Size = new System.Drawing.Size(235, 50);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Tag = "";
            this.btn_Start.Text = "INICIAR SIMULAÇÃO   ▶";
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Start.Textcolor = System.Drawing.Color.Black;
            this.btn_Start.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // num_Processos
            // 
            this.num_Processos.Location = new System.Drawing.Point(119, 54);
            this.num_Processos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Processos.Name = "num_Processos";
            this.num_Processos.Size = new System.Drawing.Size(87, 27);
            this.num_Processos.TabIndex = 6;
            this.num_Processos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Processos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(117, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "PROCESSOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_Simular
            // 
            this.gb_Simular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Simular.Controls.Add(this.pnl_Faltas);
            this.gb_Simular.Controls.Add(this.panel1);
            this.gb_Simular.Controls.Add(this.pnl_Controles);
            this.gb_Simular.Controls.Add(this.data_Simulação);
            this.gb_Simular.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_Simular.Location = new System.Drawing.Point(13, 153);
            this.gb_Simular.Name = "gb_Simular";
            this.gb_Simular.Size = new System.Drawing.Size(775, 285);
            this.gb_Simular.TabIndex = 3;
            this.gb_Simular.TabStop = false;
            this.gb_Simular.Text = "Simulação";
            // 
            // pnl_Faltas
            // 
            this.pnl_Faltas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Faltas.Controls.Add(this.lbl_Falta);
            this.pnl_Faltas.Controls.Add(this.label4);
            this.pnl_Faltas.Location = new System.Drawing.Point(569, 125);
            this.pnl_Faltas.Name = "pnl_Faltas";
            this.pnl_Faltas.Size = new System.Drawing.Size(200, 92);
            this.pnl_Faltas.TabIndex = 8;
            // 
            // lbl_Falta
            // 
            this.lbl_Falta.AutoEllipsis = true;
            this.lbl_Falta.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Falta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Falta.Location = new System.Drawing.Point(13, 36);
            this.lbl_Falta.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Falta.Name = "lbl_Falta";
            this.lbl_Falta.Size = new System.Drawing.Size(172, 52);
            this.lbl_Falta.TabIndex = 12;
            this.lbl_Falta.Text = "0";
            this.lbl_Falta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Faltas de Página";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbl_Vitima);
            this.panel1.Controls.Add(this.lbl_Selecionada);
            this.panel1.Location = new System.Drawing.Point(569, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 92);
            this.panel1.TabIndex = 7;
            // 
            // lbl_Vitima
            // 
            this.lbl_Vitima.AutoEllipsis = true;
            this.lbl_Vitima.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vitima.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Vitima.Location = new System.Drawing.Point(13, 53);
            this.lbl_Vitima.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Vitima.Name = "lbl_Vitima";
            this.lbl_Vitima.Size = new System.Drawing.Size(172, 27);
            this.lbl_Vitima.TabIndex = 10;
            this.lbl_Vitima.Text = "Vitima:";
            this.lbl_Vitima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Selecionada
            // 
            this.lbl_Selecionada.AutoEllipsis = true;
            this.lbl_Selecionada.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selecionada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Selecionada.Location = new System.Drawing.Point(13, 13);
            this.lbl_Selecionada.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Selecionada.Name = "lbl_Selecionada";
            this.lbl_Selecionada.Size = new System.Drawing.Size(172, 27);
            this.lbl_Selecionada.TabIndex = 9;
            this.lbl_Selecionada.Text = "Próxima:";
            this.lbl_Selecionada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Controles
            // 
            this.pnl_Controles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Controles.BackColor = System.Drawing.Color.White;
            this.pnl_Controles.Controls.Add(this.btn_Parar);
            this.pnl_Controles.Controls.Add(this.btn_Menos);
            this.pnl_Controles.Controls.Add(this.btn_Pausar);
            this.pnl_Controles.Controls.Add(this.btn_Mais);
            this.pnl_Controles.Location = new System.Drawing.Point(569, 224);
            this.pnl_Controles.Name = "pnl_Controles";
            this.pnl_Controles.Size = new System.Drawing.Size(200, 50);
            this.pnl_Controles.TabIndex = 6;
            // 
            // btn_Parar
            // 
            this.btn_Parar.Active = false;
            this.btn_Parar.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Parar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Parar.BackColor = System.Drawing.Color.White;
            this.btn_Parar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Parar.BorderRadius = 0;
            this.btn_Parar.ButtonText = "⏹️";
            this.btn_Parar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Parar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Parar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Parar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Parar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Parar.Iconimage")));
            this.btn_Parar.Iconimage_right = null;
            this.btn_Parar.Iconimage_right_Selected = null;
            this.btn_Parar.Iconimage_Selected = null;
            this.btn_Parar.IconMarginLeft = 0;
            this.btn_Parar.IconMarginRight = 0;
            this.btn_Parar.IconRightVisible = false;
            this.btn_Parar.IconRightZoom = 0D;
            this.btn_Parar.IconVisible = false;
            this.btn_Parar.IconZoom = 100D;
            this.btn_Parar.IsTab = false;
            this.btn_Parar.Location = new System.Drawing.Point(100, 0);
            this.btn_Parar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Parar.Name = "btn_Parar";
            this.btn_Parar.Normalcolor = System.Drawing.Color.White;
            this.btn_Parar.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Parar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Parar.selected = false;
            this.btn_Parar.Size = new System.Drawing.Size(50, 50);
            this.btn_Parar.TabIndex = 6;
            this.btn_Parar.Tag = "";
            this.btn_Parar.Text = "⏹️";
            this.btn_Parar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Parar.Textcolor = System.Drawing.Color.Black;
            this.btn_Parar.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Parar.Click += new System.EventHandler(this.btn_Parar_Click);
            // 
            // btn_Menos
            // 
            this.btn_Menos.Active = false;
            this.btn_Menos.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Menos.BackColor = System.Drawing.Color.White;
            this.btn_Menos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Menos.BorderRadius = 0;
            this.btn_Menos.ButtonText = "⏪";
            this.btn_Menos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menos.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Menos.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Menos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Menos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Menos.Iconimage")));
            this.btn_Menos.Iconimage_right = null;
            this.btn_Menos.Iconimage_right_Selected = null;
            this.btn_Menos.Iconimage_Selected = null;
            this.btn_Menos.IconMarginLeft = 0;
            this.btn_Menos.IconMarginRight = 0;
            this.btn_Menos.IconRightVisible = false;
            this.btn_Menos.IconRightZoom = 0D;
            this.btn_Menos.IconVisible = false;
            this.btn_Menos.IconZoom = 100D;
            this.btn_Menos.IsTab = false;
            this.btn_Menos.Location = new System.Drawing.Point(0, 0);
            this.btn_Menos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Menos.Name = "btn_Menos";
            this.btn_Menos.Normalcolor = System.Drawing.Color.White;
            this.btn_Menos.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Menos.selected = false;
            this.btn_Menos.Size = new System.Drawing.Size(50, 50);
            this.btn_Menos.TabIndex = 3;
            this.btn_Menos.Text = "⏪";
            this.btn_Menos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Menos.Textcolor = System.Drawing.Color.Black;
            this.btn_Menos.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menos.Click += new System.EventHandler(this.btn_Menos_Click);
            // 
            // btn_Pausar
            // 
            this.btn_Pausar.Active = false;
            this.btn_Pausar.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pausar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pausar.BackColor = System.Drawing.Color.White;
            this.btn_Pausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pausar.BorderRadius = 0;
            this.btn_Pausar.ButtonText = "⏸️";
            this.btn_Pausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pausar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Pausar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Pausar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Pausar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Pausar.Iconimage")));
            this.btn_Pausar.Iconimage_right = null;
            this.btn_Pausar.Iconimage_right_Selected = null;
            this.btn_Pausar.Iconimage_Selected = null;
            this.btn_Pausar.IconMarginLeft = 0;
            this.btn_Pausar.IconMarginRight = 0;
            this.btn_Pausar.IconRightVisible = false;
            this.btn_Pausar.IconRightZoom = 0D;
            this.btn_Pausar.IconVisible = false;
            this.btn_Pausar.IconZoom = 100D;
            this.btn_Pausar.IsTab = false;
            this.btn_Pausar.Location = new System.Drawing.Point(50, 0);
            this.btn_Pausar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Pausar.Name = "btn_Pausar";
            this.btn_Pausar.Normalcolor = System.Drawing.Color.White;
            this.btn_Pausar.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pausar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Pausar.selected = false;
            this.btn_Pausar.Size = new System.Drawing.Size(50, 50);
            this.btn_Pausar.TabIndex = 5;
            this.btn_Pausar.Tag = "▶";
            this.btn_Pausar.Text = "⏸️";
            this.btn_Pausar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Pausar.Textcolor = System.Drawing.Color.Black;
            this.btn_Pausar.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pausar.Click += new System.EventHandler(this.btn_Pausar_Click);
            // 
            // btn_Mais
            // 
            this.btn_Mais.Active = false;
            this.btn_Mais.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Mais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Mais.BackColor = System.Drawing.Color.White;
            this.btn_Mais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Mais.BorderRadius = 0;
            this.btn_Mais.ButtonText = "⏩";
            this.btn_Mais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Mais.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Mais.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Mais.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Mais.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Mais.Iconimage")));
            this.btn_Mais.Iconimage_right = null;
            this.btn_Mais.Iconimage_right_Selected = null;
            this.btn_Mais.Iconimage_Selected = null;
            this.btn_Mais.IconMarginLeft = 0;
            this.btn_Mais.IconMarginRight = 0;
            this.btn_Mais.IconRightVisible = false;
            this.btn_Mais.IconRightZoom = 0D;
            this.btn_Mais.IconVisible = false;
            this.btn_Mais.IconZoom = 100D;
            this.btn_Mais.IsTab = false;
            this.btn_Mais.Location = new System.Drawing.Point(150, 0);
            this.btn_Mais.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Mais.Name = "btn_Mais";
            this.btn_Mais.Normalcolor = System.Drawing.Color.White;
            this.btn_Mais.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Mais.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Mais.selected = false;
            this.btn_Mais.Size = new System.Drawing.Size(50, 50);
            this.btn_Mais.TabIndex = 2;
            this.btn_Mais.Text = "⏩";
            this.btn_Mais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Mais.Textcolor = System.Drawing.Color.Black;
            this.btn_Mais.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mais.Click += new System.EventHandler(this.btn_Mais_Click);
            // 
            // data_Simulação
            // 
            this.data_Simulação.AllowUserToAddRows = false;
            this.data_Simulação.AllowUserToDeleteRows = false;
            this.data_Simulação.AllowUserToResizeColumns = false;
            this.data_Simulação.AllowUserToResizeRows = false;
            this.data_Simulação.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Simulação.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data_Simulação.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.data_Simulação.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_Simulação.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.data_Simulação.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.data_Simulação.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_Simulação.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_Simulação.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_Simulação.EnableHeadersVisualStyles = false;
            this.data_Simulação.Location = new System.Drawing.Point(6, 24);
            this.data_Simulação.MultiSelect = false;
            this.data_Simulação.Name = "data_Simulação";
            this.data_Simulação.ReadOnly = true;
            this.data_Simulação.RowHeadersVisible = false;
            this.data_Simulação.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_Simulação.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.data_Simulação.ShowCellErrors = false;
            this.data_Simulação.ShowCellToolTips = false;
            this.data_Simulação.ShowEditingIcon = false;
            this.data_Simulação.ShowRowErrors = false;
            this.data_Simulação.Size = new System.Drawing.Size(555, 250);
            this.data_Simulação.TabIndex = 0;
            // 
            // elip_Controle
            // 
            this.elip_Controle.ElipseRadius = 10;
            this.elip_Controle.TargetControl = this.pnl_Controles;
            // 
            // tm_Clock
            // 
            this.tm_Clock.Interval = 1000;
            this.tm_Clock.Tick += new System.EventHandler(this.tm_Clock_Tick);
            // 
            // frm_FIFO
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_Simular);
            this.Controls.Add(this.gp_Dados);
            this.Controls.Add(this.pnl_BarraTitulo);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_FIFO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulando: FIFO";
            this.pnl_BarraTitulo.ResumeLayout(false);
            this.gp_Dados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Memoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Paginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Processos)).EndInit();
            this.gb_Simular.ResumeLayout(false);
            this.pnl_Faltas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_Controles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_Simulação)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BarraTitulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Fechar;
        private Bunifu.Framework.UI.BunifuElipse elip_MENU;
        private Bunifu.Framework.UI.BunifuDragControl drag_MENU;
        private System.Windows.Forms.GroupBox gb_Simular;
        private System.Windows.Forms.GroupBox gp_Dados;
        private System.Windows.Forms.Panel pnl_Controles;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Menos;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Pausar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Mais;
        private Bunifu.Framework.UI.BunifuElipse elip_Controle;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Parar;
        private System.Windows.Forms.NumericUpDown num_Paginas;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Start;
        private System.Windows.Forms.NumericUpDown num_Processos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_Simulação;
        private System.Windows.Forms.NumericUpDown num_Memoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_Faltas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tm_Clock;
        private System.Windows.Forms.Label lbl_Selecionada;
        private System.Windows.Forms.Label lbl_Vitima;
        private System.Windows.Forms.Label lbl_Falta;
        private System.Windows.Forms.Label label4;
    }
}