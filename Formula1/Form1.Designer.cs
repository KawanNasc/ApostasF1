namespace Formula1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEtapa = new System.Windows.Forms.Label();
            this.btnApostar = new System.Windows.Forms.Button();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.ddlSelecionar = new System.Windows.Forms.ComboBox();
            this.rdbMercedes = new System.Windows.Forms.RadioButton();
            this.tkbDinheiro = new System.Windows.Forms.TrackBar();
            this.pcbPiloto = new System.Windows.Forms.PictureBox();
            this.pcbHeader = new System.Windows.Forms.PictureBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.rdbAstonMartin = new System.Windows.Forms.RadioButton();
            this.rdbMclaren = new System.Windows.Forms.RadioButton();
            this.rdbAlfaRomeo = new System.Windows.Forms.RadioButton();
            this.rdbWilliams = new System.Windows.Forms.RadioButton();
            this.rdbAlpine = new System.Windows.Forms.RadioButton();
            this.rdbHaas = new System.Windows.Forms.RadioButton();
            this.rdbAlphaTauri = new System.Windows.Forms.RadioButton();
            this.rdbFerrari = new System.Windows.Forms.RadioButton();
            this.rdbRedBull = new System.Windows.Forms.RadioButton();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.lblConfianca = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.pcbVencedor = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblVencedor = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.lblSeleciona = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblPiloto = new System.Windows.Forms.Label();
            this.mthCalendario = new System.Windows.Forms.MonthCalendar();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.ddlMoeda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDinheiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPiloto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVencedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblEtapa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEtapa.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.ForeColor = System.Drawing.Color.Snow;
            this.lblEtapa.Location = new System.Drawing.Point(12, 9);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(204, 23);
            this.lblEtapa.TabIndex = 0;
            this.lblEtapa.Text = "Próxima etapa: Singapura";
            this.lblEtapa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApostar
            // 
            this.btnApostar.BackColor = System.Drawing.Color.Black;
            this.btnApostar.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnApostar.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostar.ForeColor = System.Drawing.Color.Lime;
            this.btnApostar.Location = new System.Drawing.Point(339, 564);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(75, 23);
            this.btnApostar.TabIndex = 1;
            this.btnApostar.Text = "Apostar!";
            this.btnApostar.UseVisualStyleBackColor = false;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // mskData
            // 
            this.mskData.BackColor = System.Drawing.SystemColors.InfoText;
            this.mskData.ForeColor = System.Drawing.SystemColors.Window;
            this.mskData.Location = new System.Drawing.Point(420, 489);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(61, 20);
            this.mskData.TabIndex = 2;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // ddlSelecionar
            // 
            this.ddlSelecionar.BackColor = System.Drawing.Color.Black;
            this.ddlSelecionar.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.ddlSelecionar.DropDownHeight = 133;
            this.ddlSelecionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSelecionar.ForeColor = System.Drawing.Color.White;
            this.ddlSelecionar.FormattingEnabled = true;
            this.ddlSelecionar.IntegralHeight = false;
            this.ddlSelecionar.ItemHeight = 13;
            this.ddlSelecionar.Items.AddRange(new object[] {
            "Verstappen",
            "Pérez",
            "Lecrerc",
            "Sainz",
            "Hamilton",
            "Russell",
            "Norris",
            "Piastri",
            "Bottas",
            "Zhou",
            "Gasly",
            "Ocon",
            "Tsunoda",
            "De Vries",
            "Magnussen",
            "Hülkenberg",
            "Stroll",
            "Alonso",
            "Albon",
            "Sargeant"});
            this.ddlSelecionar.Location = new System.Drawing.Point(29, 499);
            this.ddlSelecionar.Name = "ddlSelecionar";
            this.ddlSelecionar.Size = new System.Drawing.Size(80, 21);
            this.ddlSelecionar.TabIndex = 3;
            this.ddlSelecionar.SelectedIndexChanged += new System.EventHandler(this.ddlSelecionar_SelectedIndexChanged);
            // 
            // rdbMercedes
            // 
            this.rdbMercedes.AutoSize = true;
            this.rdbMercedes.BackColor = System.Drawing.Color.PaleGreen;
            this.rdbMercedes.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.rdbMercedes.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMercedes.ForeColor = System.Drawing.Color.DimGray;
            this.rdbMercedes.Location = new System.Drawing.Point(775, 88);
            this.rdbMercedes.Name = "rdbMercedes";
            this.rdbMercedes.Size = new System.Drawing.Size(77, 17);
            this.rdbMercedes.TabIndex = 4;
            this.rdbMercedes.TabStop = true;
            this.rdbMercedes.Text = "Mercedes";
            this.rdbMercedes.UseVisualStyleBackColor = false;
            // 
            // tkbDinheiro
            // 
            this.tkbDinheiro.BackColor = System.Drawing.Color.Black;
            this.tkbDinheiro.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.tkbDinheiro.Location = new System.Drawing.Point(339, 590);
            this.tkbDinheiro.Maximum = 255;
            this.tkbDinheiro.Name = "tkbDinheiro";
            this.tkbDinheiro.Size = new System.Drawing.Size(367, 45);
            this.tkbDinheiro.TabIndex = 7;
            this.tkbDinheiro.Scroll += new System.EventHandler(this.tkbDinheiro_Scroll);
            // 
            // pcbPiloto
            // 
            this.pcbPiloto.Image = global::Formula1.Properties.Resources.driverlineup;
            this.pcbPiloto.Location = new System.Drawing.Point(131, 535);
            this.pcbPiloto.Name = "pcbPiloto";
            this.pcbPiloto.Size = new System.Drawing.Size(145, 115);
            this.pcbPiloto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPiloto.TabIndex = 8;
            this.pcbPiloto.TabStop = false;
            // 
            // pcbHeader
            // 
            this.pcbHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pcbHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbHeader.Image = global::Formula1.Properties.Resources.logo;
            this.pcbHeader.Location = new System.Drawing.Point(289, 9);
            this.pcbHeader.Name = "pcbHeader";
            this.pcbHeader.Size = new System.Drawing.Size(378, 98);
            this.pcbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHeader.TabIndex = 8;
            this.pcbHeader.TabStop = false;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblRegistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegistro.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblRegistro.Location = new System.Drawing.Point(313, 158);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(354, 23);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Aproveite para se registrar neste mundo da F1";
            // 
            // rdbAstonMartin
            // 
            this.rdbAstonMartin.AutoSize = true;
            this.rdbAstonMartin.BackColor = System.Drawing.Color.SeaGreen;
            this.rdbAstonMartin.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.rdbAstonMartin.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAstonMartin.ForeColor = System.Drawing.Color.Black;
            this.rdbAstonMartin.Location = new System.Drawing.Point(768, 209);
            this.rdbAstonMartin.Name = "rdbAstonMartin";
            this.rdbAstonMartin.Size = new System.Drawing.Size(100, 17);
            this.rdbAstonMartin.TabIndex = 4;
            this.rdbAstonMartin.TabStop = true;
            this.rdbAstonMartin.Text = "Aston Martin";
            this.rdbAstonMartin.UseVisualStyleBackColor = false;
            // 
            // rdbMclaren
            // 
            this.rdbMclaren.AutoSize = true;
            this.rdbMclaren.BackColor = System.Drawing.Color.DarkOrange;
            this.rdbMclaren.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.rdbMclaren.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMclaren.ForeColor = System.Drawing.Color.Aqua;
            this.rdbMclaren.Location = new System.Drawing.Point(865, 88);
            this.rdbMclaren.Name = "rdbMclaren";
            this.rdbMclaren.Size = new System.Drawing.Size(75, 17);
            this.rdbMclaren.TabIndex = 4;
            this.rdbMclaren.TabStop = true;
            this.rdbMclaren.Text = "McLaren";
            this.rdbMclaren.UseVisualStyleBackColor = false;
            // 
            // rdbAlfaRomeo
            // 
            this.rdbAlfaRomeo.AutoSize = true;
            this.rdbAlfaRomeo.BackColor = System.Drawing.Color.Maroon;
            this.rdbAlfaRomeo.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.rdbAlfaRomeo.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlfaRomeo.ForeColor = System.Drawing.Color.White;
            this.rdbAlfaRomeo.Location = new System.Drawing.Point(772, 128);
            this.rdbAlfaRomeo.Name = "rdbAlfaRomeo";
            this.rdbAlfaRomeo.Size = new System.Drawing.Size(92, 17);
            this.rdbAlfaRomeo.TabIndex = 4;
            this.rdbAlfaRomeo.TabStop = true;
            this.rdbAlfaRomeo.Text = "Alfa Romeo";
            this.rdbAlfaRomeo.UseVisualStyleBackColor = false;
            // 
            // rdbWilliams
            // 
            this.rdbWilliams.AutoSize = true;
            this.rdbWilliams.BackColor = System.Drawing.Color.Aqua;
            this.rdbWilliams.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.rdbWilliams.ForeColor = System.Drawing.Color.SteelBlue;
            this.rdbWilliams.Location = new System.Drawing.Point(874, 208);
            this.rdbWilliams.Name = "rdbWilliams";
            this.rdbWilliams.Size = new System.Drawing.Size(63, 17);
            this.rdbWilliams.TabIndex = 4;
            this.rdbWilliams.TabStop = true;
            this.rdbWilliams.Text = "Williams";
            this.rdbWilliams.UseVisualStyleBackColor = false;
            // 
            // rdbAlpine
            // 
            this.rdbAlpine.AutoSize = true;
            this.rdbAlpine.BackColor = System.Drawing.Color.DodgerBlue;
            this.rdbAlpine.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.rdbAlpine.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlpine.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbAlpine.Location = new System.Drawing.Point(878, 126);
            this.rdbAlpine.Name = "rdbAlpine";
            this.rdbAlpine.Size = new System.Drawing.Size(62, 17);
            this.rdbAlpine.TabIndex = 4;
            this.rdbAlpine.TabStop = true;
            this.rdbAlpine.Text = "Alpine";
            this.rdbAlpine.UseVisualStyleBackColor = false;
            // 
            // rdbHaas
            // 
            this.rdbHaas.AutoSize = true;
            this.rdbHaas.BackColor = System.Drawing.Color.White;
            this.rdbHaas.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.rdbHaas.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHaas.ForeColor = System.Drawing.Color.Red;
            this.rdbHaas.Location = new System.Drawing.Point(879, 174);
            this.rdbHaas.Name = "rdbHaas";
            this.rdbHaas.Size = new System.Drawing.Size(61, 17);
            this.rdbHaas.TabIndex = 4;
            this.rdbHaas.TabStop = true;
            this.rdbHaas.Text = "HAAS";
            this.rdbHaas.UseVisualStyleBackColor = false;
            // 
            // rdbAlphaTauri
            // 
            this.rdbAlphaTauri.AutoSize = true;
            this.rdbAlphaTauri.BackColor = System.Drawing.Color.Black;
            this.rdbAlphaTauri.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.rdbAlphaTauri.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlphaTauri.ForeColor = System.Drawing.Color.White;
            this.rdbAlphaTauri.Location = new System.Drawing.Point(773, 174);
            this.rdbAlphaTauri.Name = "rdbAlphaTauri";
            this.rdbAlphaTauri.Size = new System.Drawing.Size(93, 17);
            this.rdbAlphaTauri.TabIndex = 4;
            this.rdbAlphaTauri.TabStop = true;
            this.rdbAlphaTauri.Text = "Alpha Tauri";
            this.rdbAlphaTauri.UseVisualStyleBackColor = false;
            // 
            // rdbFerrari
            // 
            this.rdbFerrari.AutoSize = true;
            this.rdbFerrari.BackColor = System.Drawing.Color.Red;
            this.rdbFerrari.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.rdbFerrari.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFerrari.ForeColor = System.Drawing.Color.Yellow;
            this.rdbFerrari.Location = new System.Drawing.Point(865, 41);
            this.rdbFerrari.Name = "rdbFerrari";
            this.rdbFerrari.Size = new System.Drawing.Size(64, 17);
            this.rdbFerrari.TabIndex = 4;
            this.rdbFerrari.TabStop = true;
            this.rdbFerrari.Text = "Ferrari";
            this.rdbFerrari.UseVisualStyleBackColor = false;
            // 
            // rdbRedBull
            // 
            this.rdbRedBull.AutoSize = true;
            this.rdbRedBull.BackColor = System.Drawing.Color.DarkBlue;
            this.rdbRedBull.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.rdbRedBull.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRedBull.ForeColor = System.Drawing.Color.Yellow;
            this.rdbRedBull.Location = new System.Drawing.Point(772, 42);
            this.rdbRedBull.Name = "rdbRedBull";
            this.rdbRedBull.Size = new System.Drawing.Size(75, 17);
            this.rdbRedBull.TabIndex = 4;
            this.rdbRedBull.TabStop = true;
            this.rdbRedBull.Text = "Red Bull";
            this.rdbRedBull.UseVisualStyleBackColor = false;
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.BackColor = System.Drawing.Color.Black;
            this.lblEquipe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEquipe.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipe.ForeColor = System.Drawing.Color.Khaki;
            this.lblEquipe.Location = new System.Drawing.Point(785, 9);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(125, 23);
            this.lblEquipe.TabIndex = 0;
            this.lblEquipe.Text = "Equipe favorita";
            // 
            // lblConfianca
            // 
            this.lblConfianca.AutoSize = true;
            this.lblConfianca.BackColor = System.Drawing.Color.Black;
            this.lblConfianca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConfianca.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfianca.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblConfianca.Location = new System.Drawing.Point(420, 564);
            this.lblConfianca.Name = "lblConfianca";
            this.lblConfianca.Size = new System.Drawing.Size(286, 23);
            this.lblConfianca.TabIndex = 0;
            this.lblConfianca.Text = "O quão confiante está com a vitória?";
            this.lblConfianca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(48, 1179);
            this.trackBar2.Maximum = 1000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(484, 45);
            this.trackBar2.TabIndex = 7;
            // 
            // pcbVencedor
            // 
            this.pcbVencedor.Image = global::Formula1.Properties.Resources.vencedor;
            this.pcbVencedor.Location = new System.Drawing.Point(767, 535);
            this.pcbVencedor.Name = "pcbVencedor";
            this.pcbVencedor.Size = new System.Drawing.Size(143, 115);
            this.pcbVencedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVencedor.TabIndex = 8;
            this.pcbVencedor.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnRestart.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Gold;
            this.btnRestart.Location = new System.Drawing.Point(405, 535);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(138, 23);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Tentar novamente";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Black;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnFechar.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(542, 535);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(164, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Poupar dinheiro(Fechar)";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuario.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblUsuario.Location = new System.Drawing.Point(405, 371);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(184, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Como podemos te chamar?";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Location = new System.Drawing.Point(405, 411);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblIntro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntro.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.Red;
            this.lblIntro.Location = new System.Drawing.Point(240, 124);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(514, 23);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Aposte no piloto e equipe do seu coração quem irá ganhar a corrida";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblData.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblData.Location = new System.Drawing.Point(405, 446);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(78, 20);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data Nasc.";
            // 
            // lblVencedor
            // 
            this.lblVencedor.AutoSize = true;
            this.lblVencedor.BackColor = System.Drawing.Color.Black;
            this.lblVencedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVencedor.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencedor.ForeColor = System.Drawing.Color.Aqua;
            this.lblVencedor.Location = new System.Drawing.Point(767, 499);
            this.lblVencedor.Name = "lblVencedor";
            this.lblVencedor.Size = new System.Drawing.Size(86, 23);
            this.lblVencedor.TabIndex = 0;
            this.lblVencedor.Text = "Vencedor:";
            this.lblVencedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.BackColor = System.Drawing.Color.Black;
            this.txtDinheiro.Enabled = false;
            this.txtDinheiro.ForeColor = System.Drawing.Color.MintCream;
            this.txtDinheiro.Location = new System.Drawing.Point(469, 641);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(88, 20);
            this.txtDinheiro.TabIndex = 9;
            this.txtDinheiro.Text = "R$ 0.00";
            // 
            // lblSeleciona
            // 
            this.lblSeleciona.AutoSize = true;
            this.lblSeleciona.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblSeleciona.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeleciona.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleciona.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSeleciona.Location = new System.Drawing.Point(2, 446);
            this.lblSeleciona.Name = "lblSeleciona";
            this.lblSeleciona.Size = new System.Drawing.Size(191, 20);
            this.lblSeleciona.TabIndex = 0;
            this.lblSeleciona.Text = "Selecione quem você bota fé";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblConta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConta.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.ForeColor = System.Drawing.Color.Ivory;
            this.lblConta.Location = new System.Drawing.Point(793, 245);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(147, 20);
            this.lblConta.TabIndex = 0;
            this.lblConta.Text = "Insira sua conta atual:";
            // 
            // lblPiloto
            // 
            this.lblPiloto.AutoSize = true;
            this.lblPiloto.BackColor = System.Drawing.Color.Black;
            this.lblPiloto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPiloto.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiloto.ForeColor = System.Drawing.Color.Aqua;
            this.lblPiloto.Location = new System.Drawing.Point(131, 499);
            this.lblPiloto.Name = "lblPiloto";
            this.lblPiloto.Size = new System.Drawing.Size(145, 23);
            this.lblPiloto.TabIndex = 0;
            this.lblPiloto.Text = "Você confiou no...";
            this.lblPiloto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mthCalendario
            // 
            this.mthCalendario.BackColor = System.Drawing.SystemColors.Window;
            this.mthCalendario.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.mthCalendario.Location = new System.Drawing.Point(12, 41);
            this.mthCalendario.MaxSelectionCount = 365;
            this.mthCalendario.Name = "mthCalendario";
            this.mthCalendario.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2023, 9, 5, 0, 0, 0, 0), new System.DateTime(2023, 9, 17, 0, 0, 0, 0));
            this.mthCalendario.TabIndex = 10;
            this.mthCalendario.TodayDate = new System.DateTime(2023, 9, 17, 0, 0, 0, 0);
            // 
            // txtConta
            // 
            this.txtConta.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtConta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConta.ForeColor = System.Drawing.SystemColors.Window;
            this.txtConta.Location = new System.Drawing.Point(874, 281);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(80, 20);
            this.txtConta.TabIndex = 11;
            this.txtConta.Text = "0,00";
            this.txtConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConta_KeyPress);
            // 
            // ddlMoeda
            // 
            this.ddlMoeda.BackColor = System.Drawing.SystemColors.InfoText;
            this.ddlMoeda.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.ddlMoeda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMoeda.ForeColor = System.Drawing.SystemColors.Window;
            this.ddlMoeda.FormattingEnabled = true;
            this.ddlMoeda.Items.AddRange(new object[] {
            "BRL",
            "USD",
            "EUR",
            "JPY",
            "GPB",
            "CNY",
            "VEF",
            "BTC"});
            this.ddlMoeda.Location = new System.Drawing.Point(824, 281);
            this.ddlMoeda.Name = "ddlMoeda";
            this.ddlMoeda.Size = new System.Drawing.Size(44, 21);
            this.ddlMoeda.TabIndex = 12;
            this.ddlMoeda.SelectedIndexChanged += new System.EventHandler(this.ddlMoeda_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 665);
            this.Controls.Add(this.ddlMoeda);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.mthCalendario);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pcbHeader);
            this.Controls.Add(this.pcbVencedor);
            this.Controls.Add(this.pcbPiloto);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.tkbDinheiro);
            this.Controls.Add(this.rdbAlphaTauri);
            this.Controls.Add(this.rdbHaas);
            this.Controls.Add(this.rdbAlpine);
            this.Controls.Add(this.rdbFerrari);
            this.Controls.Add(this.rdbWilliams);
            this.Controls.Add(this.rdbAlfaRomeo);
            this.Controls.Add(this.rdbMclaren);
            this.Controls.Add(this.rdbAstonMartin);
            this.Controls.Add(this.rdbRedBull);
            this.Controls.Add(this.rdbMercedes);
            this.Controls.Add(this.ddlSelecionar);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.lblPiloto);
            this.Controls.Add(this.lblVencedor);
            this.Controls.Add(this.lblConfianca);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSeleciona);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblEquipe);
            this.Controls.Add(this.lblEtapa);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cadastro e Apostas F1";
            ((System.ComponentModel.ISupportInitialize)(this.tkbDinheiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPiloto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVencedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.ComboBox ddlSelecionar;
        private System.Windows.Forms.RadioButton rdbMercedes;
        private System.Windows.Forms.TrackBar tkbDinheiro;
        private System.Windows.Forms.PictureBox pcbPiloto;
        private System.Windows.Forms.PictureBox pcbHeader;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.RadioButton rdbAstonMartin;
        private System.Windows.Forms.RadioButton rdbMclaren;
        private System.Windows.Forms.RadioButton rdbAlfaRomeo;
        private System.Windows.Forms.RadioButton rdbWilliams;
        private System.Windows.Forms.RadioButton rdbAlpine;
        private System.Windows.Forms.RadioButton rdbHaas;
        private System.Windows.Forms.RadioButton rdbAlphaTauri;
        private System.Windows.Forms.RadioButton rdbFerrari;
        private System.Windows.Forms.RadioButton rdbRedBull;
        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.Label lblConfianca;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.PictureBox pcbVencedor;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblVencedor;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label lblSeleciona;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblPiloto;
        private System.Windows.Forms.MonthCalendar mthCalendario;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.ComboBox ddlMoeda;
    }
}

