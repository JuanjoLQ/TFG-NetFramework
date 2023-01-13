using System.Windows.Forms;

namespace Tfg_NetFramework
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.containerModulos = new System.Windows.Forms.Panel();
            this.pGestDietas = new System.Windows.Forms.Panel();
            this.btnGestDietas = new System.Windows.Forms.Button();
            this.pSoliDietas = new System.Windows.Forms.Panel();
            this.btnSolDietas = new System.Windows.Forms.Button();
            this.pGestionUsers = new System.Windows.Forms.Panel();
            this.btnGestUsers = new System.Windows.Forms.Button();
            this.btnSubMenu = new System.Windows.Forms.Button();
            this.pSettings = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.lbMenu = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.timerSubMenu = new System.Windows.Forms.Timer(this.components);
            this.pHeader = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSalirHome = new System.Windows.Forms.Button();
            this.pSolicitudDieta = new System.Windows.Forms.Panel();
            this.lbReqAllowancesOptions = new System.Windows.Forms.Label();
            this.cbSolicitudDietas = new System.Windows.Forms.ComboBox();
            this.lbTitleSolDieta = new System.Windows.Forms.Label();
            this.pSolKilometraje = new System.Windows.Forms.Panel();
            this.btnSolDietasSolKilometraje = new System.Windows.Forms.Button();
            this.lbMileageTitle = new System.Windows.Forms.Label();
            this.dtpReqDietasMileageDate = new System.Windows.Forms.DateTimePicker();
            this.tbReqMileageTitle = new System.Windows.Forms.TextBox();
            this.tbReqMileagePricePerKilometer = new System.Windows.Forms.TextBox();
            this.tbReqMileageTotal = new System.Windows.Forms.TextBox();
            this.tbReqMileageDestination = new System.Windows.Forms.TextBox();
            this.tbReqMileageOrigin = new System.Windows.Forms.TextBox();
            this.tbReqMileageMileage = new System.Windows.Forms.TextBox();
            this.cbReqMileageSubCategory = new System.Windows.Forms.ComboBox();
            this.lbTitleMileage = new System.Windows.Forms.Label();
            this.lbReqMileageDate = new System.Windows.Forms.Label();
            this.lbReqMileageSubcategory = new System.Windows.Forms.Label();
            this.lbReqMileageOrigin = new System.Windows.Forms.Label();
            this.lbReqMileageDestination = new System.Windows.Forms.Label();
            this.lbReqMileageTotal = new System.Windows.Forms.Label();
            this.lbReqMileagePricePerKilometer = new System.Windows.Forms.Label();
            this.lbReqMileage = new System.Windows.Forms.Label();
            this.pSolSolicitudDietas = new System.Windows.Forms.Panel();
            this.labelURL = new System.Windows.Forms.Label();
            this.lbReqAllowancesEndHour = new System.Windows.Forms.Label();
            this.lbReqAllowancesStartHour = new System.Windows.Forms.Label();
            this.mtbReqAllowancesEndHour = new System.Windows.Forms.MaskedTextBox();
            this.mtbReqAllowancesStartHour = new System.Windows.Forms.MaskedTextBox();
            this.lbReqAllowancesTitleAllowances = new System.Windows.Forms.Label();
            this.lbReqAllowancesTitle = new System.Windows.Forms.Label();
            this.tbReqAllowancesTitle = new System.Windows.Forms.TextBox();
            this.lbReqAllowancesObservations = new System.Windows.Forms.Label();
            this.tbReqAllowancesObservations = new System.Windows.Forms.TextBox();
            this.thumbNailInvoice = new System.Windows.Forms.PictureBox();
            this.btnRequestAllowances = new System.Windows.Forms.Button();
            this.btnReqAllowancesUploadFile = new System.Windows.Forms.Button();
            this.dtpReqAllowancesStartTime = new System.Windows.Forms.DateTimePicker();
            this.lbReqAllowancesDate = new System.Windows.Forms.Label();
            this.pGestionDietas = new System.Windows.Forms.Panel();
            this.lbManAllowancesOptions = new System.Windows.Forms.Label();
            this.cbGestDietas = new System.Windows.Forms.ComboBox();
            this.lbManAllowances = new System.Windows.Forms.Label();
            this.pGestDietasDietas = new System.Windows.Forms.Panel();
            this.btnManAllowancesAllowanceRemove = new System.Windows.Forms.Button();
            this.lbManAllowancesIdAllowance = new System.Windows.Forms.Label();
            this.tbManAllowancesIdAllowance = new System.Windows.Forms.TextBox();
            this.btnManAllowancesUpdateData = new System.Windows.Forms.Button();
            this.lbManAllowancesNewState = new System.Windows.Forms.Label();
            this.cbStateDietas = new System.Windows.Forms.ComboBox();
            this.btnManAllowancesDietasRefresh = new System.Windows.Forms.Button();
            this.lbManAllowancesObservations = new System.Windows.Forms.Label();
            this.tbManAllowancesObservations = new System.Windows.Forms.TextBox();
            this.lbManAllowancesDate = new System.Windows.Forms.Label();
            this.tbManAllowancesDate = new System.Windows.Forms.TextBox();
            this.lbManAllowancesStartHour = new System.Windows.Forms.Label();
            this.tbManAllowancesStartHour = new System.Windows.Forms.TextBox();
            this.lbManAllowancesEndHour = new System.Windows.Forms.Label();
            this.tbManAllowancesEndHour = new System.Windows.Forms.TextBox();
            this.lbManAllowancesState = new System.Windows.Forms.Label();
            this.tbManAllowancesState = new System.Windows.Forms.TextBox();
            this.lbManAllowancesTitle = new System.Windows.Forms.Label();
            this.tbManAllowancesTitle = new System.Windows.Forms.TextBox();
            this.lbManAllowancesEmail = new System.Windows.Forms.Label();
            this.dgvAllowances = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice = new System.Windows.Forms.DataGridViewImageColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbManAllowancesEmail = new System.Windows.Forms.TextBox();
            this.lbTitleManAllowance = new System.Windows.Forms.Label();
            this.pGestDietasKilometraje = new System.Windows.Forms.Panel();
            this.btnManMileageRemoveMileage = new System.Windows.Forms.Button();
            this.lbManMileageIdMileage = new System.Windows.Forms.Label();
            this.tbManMileageIdMileage = new System.Windows.Forms.TextBox();
            this.btnManMileageRefreshDgvMileage = new System.Windows.Forms.Button();
            this.btnManMileageUpdateStateMileage = new System.Windows.Forms.Button();
            this.lbManMileageNewState = new System.Windows.Forms.Label();
            this.cbManMileageNewState = new System.Windows.Forms.ComboBox();
            this.lbManMileageKilometers = new System.Windows.Forms.Label();
            this.tbManMileageKilometers = new System.Windows.Forms.TextBox();
            this.lbManMileageState = new System.Windows.Forms.Label();
            this.tbManMileageState = new System.Windows.Forms.TextBox();
            this.lbManMileagePricePerKilometer = new System.Windows.Forms.Label();
            this.tbManMileagePricePerKilometer = new System.Windows.Forms.TextBox();
            this.lbManMileageFinal = new System.Windows.Forms.Label();
            this.tbManMileageFinal = new System.Windows.Forms.TextBox();
            this.lbManMileageDate = new System.Windows.Forms.Label();
            this.tbManMileageDate = new System.Windows.Forms.TextBox();
            this.lbManMileageSubcategory = new System.Windows.Forms.Label();
            this.tbManMileageSubcategory = new System.Windows.Forms.TextBox();
            this.lbManMileageOrigin = new System.Windows.Forms.Label();
            this.tbManMileageOrigin = new System.Windows.Forms.TextBox();
            this.lbManMileageDestination = new System.Windows.Forms.Label();
            this.tbManMileageDestination = new System.Windows.Forms.TextBox();
            this.lbManMileageTitle = new System.Windows.Forms.Label();
            this.tbManMileageTitle = new System.Windows.Forms.TextBox();
            this.lbManMileageEmail = new System.Windows.Forms.Label();
            this.tbManMileageEmail = new System.Windows.Forms.TextBox();
            this.lbTitleManMileage = new System.Windows.Forms.Label();
            this.dgvMileage = new System.Windows.Forms.DataGridView();
            this.idMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerKilometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUsuarios = new System.Windows.Forms.Panel();
            this.btnEliminarUser = new System.Windows.Forms.Button();
            this.btnUpdateDtgUsers = new System.Windows.Forms.Button();
            this.lbJob = new System.Windows.Forms.Label();
            this.lbIdUser = new System.Windows.Forms.Label();
            this.tbOcupacion = new System.Windows.Forms.TextBox();
            this.tbIdUser = new System.Windows.Forms.TextBox();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbGestUsers = new System.Windows.Forms.Label();
            this.pRegister = new System.Windows.Forms.Panel();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnRRegistrar = new System.Windows.Forms.Button();
            this.lbRegisterUser = new System.Windows.Forms.Label();
            this.tbRPassword = new System.Windows.Forms.TextBox();
            this.tbREmail = new System.Windows.Forms.TextBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.opfSeleccionarArchivo = new System.Windows.Forms.OpenFileDialog();
            this.sidebar.SuspendLayout();
            this.pHome.SuspendLayout();
            this.containerModulos.SuspendLayout();
            this.pGestDietas.SuspendLayout();
            this.pSoliDietas.SuspendLayout();
            this.pGestionUsers.SuspendLayout();
            this.pSettings.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.pHeader.SuspendLayout();
            this.pSolicitudDieta.SuspendLayout();
            this.pSolKilometraje.SuspendLayout();
            this.pSolSolicitudDietas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNailInvoice)).BeginInit();
            this.pGestionDietas.SuspendLayout();
            this.pGestDietasDietas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllowances)).BeginInit();
            this.pGestDietasKilometraje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMileage)).BeginInit();
            this.pUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.pRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.sidebar.Controls.Add(this.pHome);
            this.sidebar.Controls.Add(this.containerModulos);
            this.sidebar.Controls.Add(this.pSettings);
            this.sidebar.Location = new System.Drawing.Point(0, 92);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sidebar.MaximumSize = new System.Drawing.Size(257, 733);
            this.sidebar.MinimumSize = new System.Drawing.Size(73, 729);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(257, 733);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pHome
            // 
            this.pHome.BackColor = System.Drawing.Color.Transparent;
            this.pHome.Controls.Add(this.btnHome);
            this.pHome.Location = new System.Drawing.Point(3, 1);
            this.pHome.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(206, 53);
            this.pHome.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-3, -12);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(211, 80);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // containerModulos
            // 
            this.containerModulos.BackColor = System.Drawing.Color.Transparent;
            this.containerModulos.Controls.Add(this.pGestDietas);
            this.containerModulos.Controls.Add(this.pSoliDietas);
            this.containerModulos.Controls.Add(this.pGestionUsers);
            this.containerModulos.Controls.Add(this.btnSubMenu);
            this.containerModulos.Location = new System.Drawing.Point(3, 56);
            this.containerModulos.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.containerModulos.MaximumSize = new System.Drawing.Size(206, 229);
            this.containerModulos.MinimumSize = new System.Drawing.Size(206, 67);
            this.containerModulos.Name = "containerModulos";
            this.containerModulos.Size = new System.Drawing.Size(206, 229);
            this.containerModulos.TabIndex = 2;
            // 
            // pGestDietas
            // 
            this.pGestDietas.Controls.Add(this.btnGestDietas);
            this.pGestDietas.Location = new System.Drawing.Point(1, 183);
            this.pGestDietas.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pGestDietas.Name = "pGestDietas";
            this.pGestDietas.Size = new System.Drawing.Size(205, 60);
            this.pGestDietas.TabIndex = 12;
            this.pGestDietas.Visible = false;
            // 
            // btnGestDietas
            // 
            this.btnGestDietas.BackColor = System.Drawing.Color.Transparent;
            this.btnGestDietas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestDietas.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnGestDietas.ForeColor = System.Drawing.Color.White;
            this.btnGestDietas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestDietas.Location = new System.Drawing.Point(-5, -17);
            this.btnGestDietas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGestDietas.Name = "btnGestDietas";
            this.btnGestDietas.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnGestDietas.Size = new System.Drawing.Size(219, 80);
            this.btnGestDietas.TabIndex = 11;
            this.btnGestDietas.Text = "          Gest. Dietas";
            this.btnGestDietas.UseVisualStyleBackColor = false;
            this.btnGestDietas.Click += new System.EventHandler(this.btnGestDietas_Click);
            // 
            // pSoliDietas
            // 
            this.pSoliDietas.Controls.Add(this.btnSolDietas);
            this.pSoliDietas.Location = new System.Drawing.Point(1, 124);
            this.pSoliDietas.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pSoliDietas.Name = "pSoliDietas";
            this.pSoliDietas.Size = new System.Drawing.Size(205, 60);
            this.pSoliDietas.TabIndex = 8;
            this.pSoliDietas.Visible = false;
            // 
            // btnSolDietas
            // 
            this.btnSolDietas.BackColor = System.Drawing.Color.Transparent;
            this.btnSolDietas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolDietas.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnSolDietas.ForeColor = System.Drawing.Color.White;
            this.btnSolDietas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolDietas.Location = new System.Drawing.Point(-5, -16);
            this.btnSolDietas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSolDietas.Name = "btnSolDietas";
            this.btnSolDietas.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnSolDietas.Size = new System.Drawing.Size(219, 80);
            this.btnSolDietas.TabIndex = 11;
            this.btnSolDietas.Text = "          Sol. Dietas";
            this.btnSolDietas.UseVisualStyleBackColor = false;
            this.btnSolDietas.Click += new System.EventHandler(this.btnSolDietas_Click);
            // 
            // pGestionUsers
            // 
            this.pGestionUsers.Controls.Add(this.btnGestUsers);
            this.pGestionUsers.Location = new System.Drawing.Point(0, 65);
            this.pGestionUsers.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pGestionUsers.Name = "pGestionUsers";
            this.pGestionUsers.Size = new System.Drawing.Size(206, 60);
            this.pGestionUsers.TabIndex = 9;
            this.pGestionUsers.Visible = false;
            // 
            // btnGestUsers
            // 
            this.btnGestUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnGestUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestUsers.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnGestUsers.ForeColor = System.Drawing.Color.White;
            this.btnGestUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestUsers.Location = new System.Drawing.Point(-3, -12);
            this.btnGestUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGestUsers.Name = "btnGestUsers";
            this.btnGestUsers.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnGestUsers.Size = new System.Drawing.Size(219, 80);
            this.btnGestUsers.TabIndex = 6;
            this.btnGestUsers.Text = "          Gest. Users";
            this.btnGestUsers.UseVisualStyleBackColor = false;
            this.btnGestUsers.Click += new System.EventHandler(this.btnGestUser_Click);
            // 
            // btnSubMenu
            // 
            this.btnSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenu.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnSubMenu.ForeColor = System.Drawing.Color.White;
            this.btnSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSubMenu.Image")));
            this.btnSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu.Location = new System.Drawing.Point(-3, -7);
            this.btnSubMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubMenu.Name = "btnSubMenu";
            this.btnSubMenu.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnSubMenu.Size = new System.Drawing.Size(211, 80);
            this.btnSubMenu.TabIndex = 8;
            this.btnSubMenu.Text = "Módulos";
            this.btnSubMenu.UseVisualStyleBackColor = false;
            this.btnSubMenu.Click += new System.EventHandler(this.btnSubMenu_Click);
            // 
            // pSettings
            // 
            this.pSettings.BackColor = System.Drawing.Color.Transparent;
            this.pSettings.Controls.Add(this.btnSettings);
            this.pSettings.Location = new System.Drawing.Point(3, 287);
            this.pSettings.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(206, 53);
            this.pSettings.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(-3, -12);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(211, 80);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.lbMenu);
            this.pMenu.Controls.Add(this.btnMenu);
            this.pMenu.Location = new System.Drawing.Point(15, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(194, 77);
            this.pMenu.TabIndex = 0;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.lbMenu.Location = new System.Drawing.Point(77, 28);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(61, 24);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.Text = "Menu";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.InitialImage")));
            this.btnMenu.Location = new System.Drawing.Point(10, 13);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(48, 56);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // timerSubMenu
            // 
            this.timerSubMenu.Interval = 20;
            this.timerSubMenu.Tick += new System.EventHandler(this.timerSubMenu_Tick);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(205)))));
            this.pHeader.Controls.Add(this.lbUser);
            this.pHeader.Controls.Add(this.lbRole);
            this.pHeader.Controls.Add(this.lbTitle);
            this.pHeader.Controls.Add(this.btnSalirHome);
            this.pHeader.Controls.Add(this.pMenu);
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1627, 92);
            this.pHeader.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(1267, 57);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(55, 15);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "labelUser";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(1267, 27);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(51, 13);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "labelRole";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.lbTitle.Location = new System.Drawing.Point(698, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(146, 31);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Home Page";
            // 
            // btnSalirHome
            // 
            this.btnSalirHome.Location = new System.Drawing.Point(242, 13);
            this.btnSalirHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalirHome.Name = "btnSalirHome";
            this.btnSalirHome.Size = new System.Drawing.Size(165, 47);
            this.btnSalirHome.TabIndex = 4;
            this.btnSalirHome.Text = "Salir";
            this.btnSalirHome.UseVisualStyleBackColor = true;
            this.btnSalirHome.Click += new System.EventHandler(this.btnSalirHome_Click);
            // 
            // pSolicitudDieta
            // 
            this.pSolicitudDieta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pSolicitudDieta.Controls.Add(this.lbReqAllowancesOptions);
            this.pSolicitudDieta.Controls.Add(this.cbSolicitudDietas);
            this.pSolicitudDieta.Controls.Add(this.lbTitleSolDieta);
            this.pSolicitudDieta.Controls.Add(this.pSolKilometraje);
            this.pSolicitudDieta.Controls.Add(this.pSolSolicitudDietas);
            this.pSolicitudDieta.Location = new System.Drawing.Point(261, 95);
            this.pSolicitudDieta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pSolicitudDieta.Name = "pSolicitudDieta";
            this.pSolicitudDieta.Size = new System.Drawing.Size(1025, 483);
            this.pSolicitudDieta.TabIndex = 4;
            this.pSolicitudDieta.Visible = false;
            // 
            // lbReqAllowancesOptions
            // 
            this.lbReqAllowancesOptions.AutoSize = true;
            this.lbReqAllowancesOptions.Location = new System.Drawing.Point(126, 22);
            this.lbReqAllowancesOptions.Name = "lbReqAllowancesOptions";
            this.lbReqAllowancesOptions.Size = new System.Drawing.Size(85, 13);
            this.lbReqAllowancesOptions.TabIndex = 13;
            this.lbReqAllowancesOptions.Text = "Elija una opción:";
            // 
            // cbSolicitudDietas
            // 
            this.cbSolicitudDietas.FormattingEnabled = true;
            this.cbSolicitudDietas.Items.AddRange(new object[] {
            "Dietas",
            "Kilometraje"});
            this.cbSolicitudDietas.Location = new System.Drawing.Point(212, 19);
            this.cbSolicitudDietas.Name = "cbSolicitudDietas";
            this.cbSolicitudDietas.Size = new System.Drawing.Size(115, 21);
            this.cbSolicitudDietas.TabIndex = 1;
            this.cbSolicitudDietas.SelectionChangeCommitted += new System.EventHandler(this.cbSolicitudDietas_SelectionChangeCommitted);
            // 
            // lbTitleSolDieta
            // 
            this.lbTitleSolDieta.AutoSize = true;
            this.lbTitleSolDieta.Location = new System.Drawing.Point(21, 12);
            this.lbTitleSolDieta.Name = "lbTitleSolDieta";
            this.lbTitleSolDieta.Size = new System.Drawing.Size(93, 13);
            this.lbTitleSolDieta.TabIndex = 0;
            this.lbTitleSolDieta.Text = "Solicitud de dietas";
            // 
            // pSolKilometraje
            // 
            this.pSolKilometraje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pSolKilometraje.Controls.Add(this.btnSolDietasSolKilometraje);
            this.pSolKilometraje.Controls.Add(this.lbMileageTitle);
            this.pSolKilometraje.Controls.Add(this.dtpReqDietasMileageDate);
            this.pSolKilometraje.Controls.Add(this.tbReqMileageTitle);
            this.pSolKilometraje.Controls.Add(this.tbReqMileagePricePerKilometer);
            this.pSolKilometraje.Controls.Add(this.tbReqMileageTotal);
            this.pSolKilometraje.Controls.Add(this.tbReqMileageDestination);
            this.pSolKilometraje.Controls.Add(this.tbReqMileageOrigin);
            this.pSolKilometraje.Controls.Add(this.tbReqMileageMileage);
            this.pSolKilometraje.Controls.Add(this.cbReqMileageSubCategory);
            this.pSolKilometraje.Controls.Add(this.lbTitleMileage);
            this.pSolKilometraje.Controls.Add(this.lbReqMileageDate);
            this.pSolKilometraje.Controls.Add(this.lbReqMileageSubcategory);
            this.pSolKilometraje.Controls.Add(this.lbReqMileageOrigin);
            this.pSolKilometraje.Controls.Add(this.lbReqMileageDestination);
            this.pSolKilometraje.Controls.Add(this.lbReqMileageTotal);
            this.pSolKilometraje.Controls.Add(this.lbReqMileagePricePerKilometer);
            this.pSolKilometraje.Controls.Add(this.lbReqMileage);
            this.pSolKilometraje.Location = new System.Drawing.Point(21, 45);
            this.pSolKilometraje.Name = "pSolKilometraje";
            this.pSolKilometraje.Size = new System.Drawing.Size(459, 388);
            this.pSolKilometraje.TabIndex = 7;
            // 
            // btnSolDietasSolKilometraje
            // 
            this.btnSolDietasSolKilometraje.Location = new System.Drawing.Point(39, 293);
            this.btnSolDietasSolKilometraje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSolDietasSolKilometraje.Name = "btnSolDietasSolKilometraje";
            this.btnSolDietasSolKilometraje.Size = new System.Drawing.Size(127, 34);
            this.btnSolDietasSolKilometraje.TabIndex = 10;
            this.btnSolDietasSolKilometraje.Text = "Solicitar kilometraje";
            this.btnSolDietasSolKilometraje.UseVisualStyleBackColor = true;
            this.btnSolDietasSolKilometraje.Click += new System.EventHandler(this.btnSolDietasSolKilometraje_Click);
            // 
            // lbMileageTitle
            // 
            this.lbMileageTitle.AutoSize = true;
            this.lbMileageTitle.Location = new System.Drawing.Point(46, 7);
            this.lbMileageTitle.Name = "lbMileageTitle";
            this.lbMileageTitle.Size = new System.Drawing.Size(58, 13);
            this.lbMileageTitle.TabIndex = 29;
            this.lbMileageTitle.Text = "Kilometraje";
            // 
            // dtpReqDietasMileageDate
            // 
            this.dtpReqDietasMileageDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReqDietasMileageDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReqDietasMileageDate.Location = new System.Drawing.Point(92, 107);
            this.dtpReqDietasMileageDate.Name = "dtpReqDietasMileageDate";
            this.dtpReqDietasMileageDate.Size = new System.Drawing.Size(93, 20);
            this.dtpReqDietasMileageDate.TabIndex = 4;
            this.dtpReqDietasMileageDate.Value = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            // 
            // tbReqMileageTitle
            // 
            this.tbReqMileageTitle.Location = new System.Drawing.Point(92, 68);
            this.tbReqMileageTitle.Name = "tbReqMileageTitle";
            this.tbReqMileageTitle.Size = new System.Drawing.Size(81, 20);
            this.tbReqMileageTitle.TabIndex = 3;
            // 
            // tbReqMileagePricePerKilometer
            // 
            this.tbReqMileagePricePerKilometer.Location = new System.Drawing.Point(136, 259);
            this.tbReqMileagePricePerKilometer.Name = "tbReqMileagePricePerKilometer";
            this.tbReqMileagePricePerKilometer.ReadOnly = true;
            this.tbReqMileagePricePerKilometer.Size = new System.Drawing.Size(81, 20);
            this.tbReqMileagePricePerKilometer.TabIndex = 9;
            // 
            // tbReqMileageTotal
            // 
            this.tbReqMileageTotal.Location = new System.Drawing.Point(129, 231);
            this.tbReqMileageTotal.Name = "tbReqMileageTotal";
            this.tbReqMileageTotal.ReadOnly = true;
            this.tbReqMileageTotal.Size = new System.Drawing.Size(81, 20);
            this.tbReqMileageTotal.TabIndex = 8;
            // 
            // tbReqMileageDestination
            // 
            this.tbReqMileageDestination.Location = new System.Drawing.Point(121, 205);
            this.tbReqMileageDestination.Name = "tbReqMileageDestination";
            this.tbReqMileageDestination.Size = new System.Drawing.Size(81, 20);
            this.tbReqMileageDestination.TabIndex = 7;
            // 
            // tbReqMileageOrigin
            // 
            this.tbReqMileageOrigin.Location = new System.Drawing.Point(87, 179);
            this.tbReqMileageOrigin.Name = "tbReqMileageOrigin";
            this.tbReqMileageOrigin.Size = new System.Drawing.Size(81, 20);
            this.tbReqMileageOrigin.TabIndex = 6;
            // 
            // tbReqMileageMileage
            // 
            this.tbReqMileageMileage.Location = new System.Drawing.Point(92, 34);
            this.tbReqMileageMileage.Name = "tbReqMileageMileage";
            this.tbReqMileageMileage.Size = new System.Drawing.Size(81, 20);
            this.tbReqMileageMileage.TabIndex = 2;
            this.tbReqMileageMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSolMileageMileage_KeyPress);
            this.tbReqMileageMileage.Leave += new System.EventHandler(this.tbSolMileageMileage_Leave);
            // 
            // cbReqMileageSubCategory
            // 
            this.cbReqMileageSubCategory.FormattingEnabled = true;
            this.cbReqMileageSubCategory.Items.AddRange(new object[] {
            "Vehículo propio",
            "Vehículo empresa"});
            this.cbReqMileageSubCategory.Location = new System.Drawing.Point(79, 141);
            this.cbReqMileageSubCategory.Name = "cbReqMileageSubCategory";
            this.cbReqMileageSubCategory.Size = new System.Drawing.Size(94, 21);
            this.cbReqMileageSubCategory.TabIndex = 5;
            this.cbReqMileageSubCategory.SelectionChangeCommitted += new System.EventHandler(this.cbMileageSubCategory_SelectionChangeCommitted);
            // 
            // lbTitleMileage
            // 
            this.lbTitleMileage.AutoSize = true;
            this.lbTitleMileage.Location = new System.Drawing.Point(1, 75);
            this.lbTitleMileage.Name = "lbTitleMileage";
            this.lbTitleMileage.Size = new System.Drawing.Size(35, 13);
            this.lbTitleMileage.TabIndex = 14;
            this.lbTitleMileage.Text = "Título";
            // 
            // lbReqMileageDate
            // 
            this.lbReqMileageDate.AutoSize = true;
            this.lbReqMileageDate.Location = new System.Drawing.Point(6, 111);
            this.lbReqMileageDate.Name = "lbReqMileageDate";
            this.lbReqMileageDate.Size = new System.Drawing.Size(37, 13);
            this.lbReqMileageDate.TabIndex = 15;
            this.lbReqMileageDate.Text = "Fecha";
            // 
            // lbReqMileageSubcategory
            // 
            this.lbReqMileageSubcategory.AutoSize = true;
            this.lbReqMileageSubcategory.Location = new System.Drawing.Point(1, 144);
            this.lbReqMileageSubcategory.Name = "lbReqMileageSubcategory";
            this.lbReqMileageSubcategory.Size = new System.Drawing.Size(67, 13);
            this.lbReqMileageSubcategory.TabIndex = 16;
            this.lbReqMileageSubcategory.Text = "Subcategory";
            // 
            // lbReqMileageOrigin
            // 
            this.lbReqMileageOrigin.AutoSize = true;
            this.lbReqMileageOrigin.Location = new System.Drawing.Point(6, 180);
            this.lbReqMileageOrigin.Name = "lbReqMileageOrigin";
            this.lbReqMileageOrigin.Size = new System.Drawing.Size(38, 13);
            this.lbReqMileageOrigin.TabIndex = 17;
            this.lbReqMileageOrigin.Text = "Origen";
            // 
            // lbReqMileageDestination
            // 
            this.lbReqMileageDestination.AutoSize = true;
            this.lbReqMileageDestination.Location = new System.Drawing.Point(6, 205);
            this.lbReqMileageDestination.Name = "lbReqMileageDestination";
            this.lbReqMileageDestination.Size = new System.Drawing.Size(43, 13);
            this.lbReqMileageDestination.TabIndex = 18;
            this.lbReqMileageDestination.Text = "Destino";
            // 
            // lbReqMileageTotal
            // 
            this.lbReqMileageTotal.AutoSize = true;
            this.lbReqMileageTotal.Location = new System.Drawing.Point(6, 233);
            this.lbReqMileageTotal.Name = "lbReqMileageTotal";
            this.lbReqMileageTotal.Size = new System.Drawing.Size(31, 13);
            this.lbReqMileageTotal.TabIndex = 19;
            this.lbReqMileageTotal.Text = "Total";
            // 
            // lbReqMileagePricePerKilometer
            // 
            this.lbReqMileagePricePerKilometer.AutoSize = true;
            this.lbReqMileagePricePerKilometer.Location = new System.Drawing.Point(6, 259);
            this.lbReqMileagePricePerKilometer.Name = "lbReqMileagePricePerKilometer";
            this.lbReqMileagePricePerKilometer.Size = new System.Drawing.Size(100, 13);
            this.lbReqMileagePricePerKilometer.TabIndex = 20;
            this.lbReqMileagePricePerKilometer.Text = "Precio por kilómetro";
            // 
            // lbReqMileage
            // 
            this.lbReqMileage.AutoSize = true;
            this.lbReqMileage.Location = new System.Drawing.Point(1, 36);
            this.lbReqMileage.Name = "lbReqMileage";
            this.lbReqMileage.Size = new System.Drawing.Size(58, 13);
            this.lbReqMileage.TabIndex = 14;
            this.lbReqMileage.Text = "Kilometraje";
            // 
            // pSolSolicitudDietas
            // 
            this.pSolSolicitudDietas.Controls.Add(this.labelURL);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesEndHour);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesStartHour);
            this.pSolSolicitudDietas.Controls.Add(this.mtbReqAllowancesEndHour);
            this.pSolSolicitudDietas.Controls.Add(this.mtbReqAllowancesStartHour);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesTitleAllowances);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesTitle);
            this.pSolSolicitudDietas.Controls.Add(this.tbReqAllowancesTitle);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesObservations);
            this.pSolSolicitudDietas.Controls.Add(this.tbReqAllowancesObservations);
            this.pSolSolicitudDietas.Controls.Add(this.thumbNailInvoice);
            this.pSolSolicitudDietas.Controls.Add(this.btnRequestAllowances);
            this.pSolSolicitudDietas.Controls.Add(this.btnReqAllowancesUploadFile);
            this.pSolSolicitudDietas.Controls.Add(this.dtpReqAllowancesStartTime);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesDate);
            this.pSolSolicitudDietas.Location = new System.Drawing.Point(21, 45);
            this.pSolSolicitudDietas.Name = "pSolSolicitudDietas";
            this.pSolSolicitudDietas.Size = new System.Drawing.Size(459, 388);
            this.pSolSolicitudDietas.TabIndex = 14;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(196, 185);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(29, 13);
            this.labelURL.TabIndex = 18;
            this.labelURL.Text = "URL";
            // 
            // lbReqAllowancesEndHour
            // 
            this.lbReqAllowancesEndHour.AutoSize = true;
            this.lbReqAllowancesEndHour.Location = new System.Drawing.Point(190, 44);
            this.lbReqAllowancesEndHour.Name = "lbReqAllowancesEndHour";
            this.lbReqAllowancesEndHour.Size = new System.Drawing.Size(52, 13);
            this.lbReqAllowancesEndHour.TabIndex = 17;
            this.lbReqAllowancesEndHour.Text = "End Hour";
            // 
            // lbReqAllowancesStartHour
            // 
            this.lbReqAllowancesStartHour.AutoSize = true;
            this.lbReqAllowancesStartHour.Location = new System.Drawing.Point(190, 18);
            this.lbReqAllowancesStartHour.Name = "lbReqAllowancesStartHour";
            this.lbReqAllowancesStartHour.Size = new System.Drawing.Size(55, 13);
            this.lbReqAllowancesStartHour.TabIndex = 16;
            this.lbReqAllowancesStartHour.Text = "Start Hour";
            // 
            // mtbReqAllowancesEndHour
            // 
            this.mtbReqAllowancesEndHour.Location = new System.Drawing.Point(250, 42);
            this.mtbReqAllowancesEndHour.Mask = "00:00";
            this.mtbReqAllowancesEndHour.Name = "mtbReqAllowancesEndHour";
            this.mtbReqAllowancesEndHour.Size = new System.Drawing.Size(28, 20);
            this.mtbReqAllowancesEndHour.TabIndex = 5;
            this.mtbReqAllowancesEndHour.ValidatingType = typeof(System.DateTime);
            this.mtbReqAllowancesEndHour.Leave += new System.EventHandler(this.mtbEndTime_Leave);
            // 
            // mtbReqAllowancesStartHour
            // 
            this.mtbReqAllowancesStartHour.Location = new System.Drawing.Point(250, 14);
            this.mtbReqAllowancesStartHour.Mask = "00:00";
            this.mtbReqAllowancesStartHour.Name = "mtbReqAllowancesStartHour";
            this.mtbReqAllowancesStartHour.Size = new System.Drawing.Size(28, 20);
            this.mtbReqAllowancesStartHour.TabIndex = 4;
            this.mtbReqAllowancesStartHour.ValidatingType = typeof(System.DateTime);
            this.mtbReqAllowancesStartHour.Click += new System.EventHandler(this.mtbStartTime_Click);
            this.mtbReqAllowancesStartHour.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbStartTime_KeyDown);
            this.mtbReqAllowancesStartHour.Leave += new System.EventHandler(this.mtbStartTime_Leave);
            // 
            // lbReqAllowancesTitleAllowances
            // 
            this.lbReqAllowancesTitleAllowances.AutoSize = true;
            this.lbReqAllowancesTitleAllowances.Location = new System.Drawing.Point(14, 10);
            this.lbReqAllowancesTitleAllowances.Name = "lbReqAllowancesTitleAllowances";
            this.lbReqAllowancesTitleAllowances.Size = new System.Drawing.Size(37, 13);
            this.lbReqAllowancesTitleAllowances.TabIndex = 13;
            this.lbReqAllowancesTitleAllowances.Text = "Dietas";
            // 
            // lbReqAllowancesTitle
            // 
            this.lbReqAllowancesTitle.AutoSize = true;
            this.lbReqAllowancesTitle.Location = new System.Drawing.Point(3, 46);
            this.lbReqAllowancesTitle.Name = "lbReqAllowancesTitle";
            this.lbReqAllowancesTitle.Size = new System.Drawing.Size(35, 13);
            this.lbReqAllowancesTitle.TabIndex = 9;
            this.lbReqAllowancesTitle.Text = "Título";
            // 
            // tbReqAllowancesTitle
            // 
            this.tbReqAllowancesTitle.Location = new System.Drawing.Point(52, 43);
            this.tbReqAllowancesTitle.Name = "tbReqAllowancesTitle";
            this.tbReqAllowancesTitle.Size = new System.Drawing.Size(73, 20);
            this.tbReqAllowancesTitle.TabIndex = 2;
            // 
            // lbReqAllowancesObservations
            // 
            this.lbReqAllowancesObservations.AutoSize = true;
            this.lbReqAllowancesObservations.Location = new System.Drawing.Point(3, 75);
            this.lbReqAllowancesObservations.Name = "lbReqAllowancesObservations";
            this.lbReqAllowancesObservations.Size = new System.Drawing.Size(69, 13);
            this.lbReqAllowancesObservations.TabIndex = 4;
            this.lbReqAllowancesObservations.Text = "Observations";
            // 
            // tbReqAllowancesObservations
            // 
            this.tbReqAllowancesObservations.Location = new System.Drawing.Point(77, 78);
            this.tbReqAllowancesObservations.Multiline = true;
            this.tbReqAllowancesObservations.Name = "tbReqAllowancesObservations";
            this.tbReqAllowancesObservations.Size = new System.Drawing.Size(198, 83);
            this.tbReqAllowancesObservations.TabIndex = 3;
            // 
            // thumbNailInvoice
            // 
            this.thumbNailInvoice.Location = new System.Drawing.Point(28, 180);
            this.thumbNailInvoice.Name = "thumbNailInvoice";
            this.thumbNailInvoice.Size = new System.Drawing.Size(135, 103);
            this.thumbNailInvoice.TabIndex = 12;
            this.thumbNailInvoice.TabStop = false;
            // 
            // btnRequestAllowances
            // 
            this.btnRequestAllowances.Location = new System.Drawing.Point(179, 318);
            this.btnRequestAllowances.Name = "btnRequestAllowances";
            this.btnRequestAllowances.Size = new System.Drawing.Size(135, 40);
            this.btnRequestAllowances.TabIndex = 8;
            this.btnRequestAllowances.Text = "Solicitar Dieta";
            this.btnRequestAllowances.UseVisualStyleBackColor = true;
            this.btnRequestAllowances.Click += new System.EventHandler(this.btnSolDieta_Click);
            // 
            // btnReqAllowancesUploadFile
            // 
            this.btnReqAllowancesUploadFile.Location = new System.Drawing.Point(179, 221);
            this.btnReqAllowancesUploadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReqAllowancesUploadFile.Name = "btnReqAllowancesUploadFile";
            this.btnReqAllowancesUploadFile.Size = new System.Drawing.Size(121, 25);
            this.btnReqAllowancesUploadFile.TabIndex = 7;
            this.btnReqAllowancesUploadFile.Text = "Upload File";
            this.btnReqAllowancesUploadFile.UseVisualStyleBackColor = true;
            this.btnReqAllowancesUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // dtpReqAllowancesStartTime
            // 
            this.dtpReqAllowancesStartTime.CustomFormat = "dd/MM/yyyy";
            this.dtpReqAllowancesStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReqAllowancesStartTime.Location = new System.Drawing.Point(351, 18);
            this.dtpReqAllowancesStartTime.Name = "dtpReqAllowancesStartTime";
            this.dtpReqAllowancesStartTime.Size = new System.Drawing.Size(93, 20);
            this.dtpReqAllowancesStartTime.TabIndex = 6;
            this.dtpReqAllowancesStartTime.Value = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            // 
            // lbReqAllowancesDate
            // 
            this.lbReqAllowancesDate.AutoSize = true;
            this.lbReqAllowancesDate.Location = new System.Drawing.Point(291, 22);
            this.lbReqAllowancesDate.Name = "lbReqAllowancesDate";
            this.lbReqAllowancesDate.Size = new System.Drawing.Size(55, 13);
            this.lbReqAllowancesDate.TabIndex = 3;
            this.lbReqAllowancesDate.Text = "Start Time";
            // 
            // pGestionDietas
            // 
            this.pGestionDietas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pGestionDietas.Controls.Add(this.lbManAllowancesOptions);
            this.pGestionDietas.Controls.Add(this.cbGestDietas);
            this.pGestionDietas.Controls.Add(this.lbManAllowances);
            this.pGestionDietas.Controls.Add(this.pGestDietasDietas);
            this.pGestionDietas.Controls.Add(this.pGestDietasKilometraje);
            this.pGestionDietas.Location = new System.Drawing.Point(261, 95);
            this.pGestionDietas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pGestionDietas.Name = "pGestionDietas";
            this.pGestionDietas.Size = new System.Drawing.Size(1025, 483);
            this.pGestionDietas.TabIndex = 3;
            this.pGestionDietas.Visible = false;
            // 
            // lbManAllowancesOptions
            // 
            this.lbManAllowancesOptions.AutoSize = true;
            this.lbManAllowancesOptions.Location = new System.Drawing.Point(126, 22);
            this.lbManAllowancesOptions.Name = "lbManAllowancesOptions";
            this.lbManAllowancesOptions.Size = new System.Drawing.Size(88, 13);
            this.lbManAllowancesOptions.TabIndex = 10;
            this.lbManAllowancesOptions.Text = "Elija una opción: ";
            // 
            // cbGestDietas
            // 
            this.cbGestDietas.FormattingEnabled = true;
            this.cbGestDietas.Items.AddRange(new object[] {
            "Dietas",
            "Kilometraje"});
            this.cbGestDietas.Location = new System.Drawing.Point(208, 17);
            this.cbGestDietas.Name = "cbGestDietas";
            this.cbGestDietas.Size = new System.Drawing.Size(104, 21);
            this.cbGestDietas.TabIndex = 1;
            this.cbGestDietas.SelectionChangeCommitted += new System.EventHandler(this.cbGestDietas_SelectionChangeCommitted);
            // 
            // lbManAllowances
            // 
            this.lbManAllowances.AutoSize = true;
            this.lbManAllowances.Location = new System.Drawing.Point(27, 20);
            this.lbManAllowances.Name = "lbManAllowances";
            this.lbManAllowances.Size = new System.Drawing.Size(89, 13);
            this.lbManAllowances.TabIndex = 2;
            this.lbManAllowances.Text = "Gestión de dietas";
            // 
            // pGestDietasDietas
            // 
            this.pGestDietasDietas.Controls.Add(this.btnManAllowancesAllowanceRemove);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesIdAllowance);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesIdAllowance);
            this.pGestDietasDietas.Controls.Add(this.btnManAllowancesUpdateData);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesNewState);
            this.pGestDietasDietas.Controls.Add(this.cbStateDietas);
            this.pGestDietasDietas.Controls.Add(this.btnManAllowancesDietasRefresh);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesObservations);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesObservations);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesDate);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesDate);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesStartHour);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesStartHour);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesEndHour);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesEndHour);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesState);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesState);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesTitle);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesTitle);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesEmail);
            this.pGestDietasDietas.Controls.Add(this.dgvAllowances);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesEmail);
            this.pGestDietasDietas.Controls.Add(this.lbTitleManAllowance);
            this.pGestDietasDietas.Location = new System.Drawing.Point(14, 56);
            this.pGestDietasDietas.Name = "pGestDietasDietas";
            this.pGestDietasDietas.Size = new System.Drawing.Size(972, 379);
            this.pGestDietasDietas.TabIndex = 8;
            // 
            // btnManAllowancesAllowanceRemove
            // 
            this.btnManAllowancesAllowanceRemove.Location = new System.Drawing.Point(600, 251);
            this.btnManAllowancesAllowanceRemove.Name = "btnManAllowancesAllowanceRemove";
            this.btnManAllowancesAllowanceRemove.Size = new System.Drawing.Size(145, 31);
            this.btnManAllowancesAllowanceRemove.TabIndex = 13;
            this.btnManAllowancesAllowanceRemove.Text = "Eliminar dieta";
            this.btnManAllowancesAllowanceRemove.UseVisualStyleBackColor = true;
            this.btnManAllowancesAllowanceRemove.Click += new System.EventHandler(this.btnAllowanceRemove_Click);
            // 
            // lbManAllowancesIdAllowance
            // 
            this.lbManAllowancesIdAllowance.AutoSize = true;
            this.lbManAllowancesIdAllowance.Location = new System.Drawing.Point(420, 310);
            this.lbManAllowancesIdAllowance.Name = "lbManAllowancesIdAllowance";
            this.lbManAllowancesIdAllowance.Size = new System.Drawing.Size(65, 13);
            this.lbManAllowancesIdAllowance.TabIndex = 29;
            this.lbManAllowancesIdAllowance.Text = "IdAllowance";
            // 
            // tbManAllowancesIdAllowance
            // 
            this.tbManAllowancesIdAllowance.Location = new System.Drawing.Point(491, 305);
            this.tbManAllowancesIdAllowance.Name = "tbManAllowancesIdAllowance";
            this.tbManAllowancesIdAllowance.ReadOnly = true;
            this.tbManAllowancesIdAllowance.Size = new System.Drawing.Size(94, 20);
            this.tbManAllowancesIdAllowance.TabIndex = 10;
            // 
            // btnManAllowancesUpdateData
            // 
            this.btnManAllowancesUpdateData.Location = new System.Drawing.Point(450, 243);
            this.btnManAllowancesUpdateData.Name = "btnManAllowancesUpdateData";
            this.btnManAllowancesUpdateData.Size = new System.Drawing.Size(121, 40);
            this.btnManAllowancesUpdateData.TabIndex = 11;
            this.btnManAllowancesUpdateData.Text = "Actualizar datos";
            this.btnManAllowancesUpdateData.UseVisualStyleBackColor = true;
            this.btnManAllowancesUpdateData.Click += new System.EventHandler(this.btnGestDietasUpdate_Click);
            // 
            // lbManAllowancesNewState
            // 
            this.lbManAllowancesNewState.AutoSize = true;
            this.lbManAllowancesNewState.Location = new System.Drawing.Point(426, 202);
            this.lbManAllowancesNewState.Name = "lbManAllowancesNewState";
            this.lbManAllowancesNewState.Size = new System.Drawing.Size(43, 13);
            this.lbManAllowancesNewState.TabIndex = 26;
            this.lbManAllowancesNewState.Text = "Estado:";
            // 
            // cbStateDietas
            // 
            this.cbStateDietas.FormattingEnabled = true;
            this.cbStateDietas.Items.AddRange(new object[] {
            "Solicitado",
            "En trámite",
            "Aceptado"});
            this.cbStateDietas.Location = new System.Drawing.Point(472, 199);
            this.cbStateDietas.Name = "cbStateDietas";
            this.cbStateDietas.Size = new System.Drawing.Size(115, 21);
            this.cbStateDietas.TabIndex = 9;
            this.cbStateDietas.SelectionChangeCommitted += new System.EventHandler(this.cbStateDietas_SelectionChangeCommitted);
            // 
            // btnManAllowancesDietasRefresh
            // 
            this.btnManAllowancesDietasRefresh.Location = new System.Drawing.Point(602, 193);
            this.btnManAllowancesDietasRefresh.Name = "btnManAllowancesDietasRefresh";
            this.btnManAllowancesDietasRefresh.Size = new System.Drawing.Size(145, 35);
            this.btnManAllowancesDietasRefresh.TabIndex = 12;
            this.btnManAllowancesDietasRefresh.Text = "Refrescar tabla";
            this.btnManAllowancesDietasRefresh.UseVisualStyleBackColor = true;
            this.btnManAllowancesDietasRefresh.Click += new System.EventHandler(this.btnGestDietasDietasRefresh_Click);
            // 
            // lbManAllowancesObservations
            // 
            this.lbManAllowancesObservations.AutoSize = true;
            this.lbManAllowancesObservations.Location = new System.Drawing.Point(-1, 269);
            this.lbManAllowancesObservations.Name = "lbManAllowancesObservations";
            this.lbManAllowancesObservations.Size = new System.Drawing.Size(78, 13);
            this.lbManAllowancesObservations.TabIndex = 23;
            this.lbManAllowancesObservations.Text = "Observaciones";
            // 
            // tbManAllowancesObservations
            // 
            this.tbManAllowancesObservations.Location = new System.Drawing.Point(70, 269);
            this.tbManAllowancesObservations.Multiline = true;
            this.tbManAllowancesObservations.Name = "tbManAllowancesObservations";
            this.tbManAllowancesObservations.ReadOnly = true;
            this.tbManAllowancesObservations.Size = new System.Drawing.Size(121, 68);
            this.tbManAllowancesObservations.TabIndex = 4;
            // 
            // lbManAllowancesDate
            // 
            this.lbManAllowancesDate.AutoSize = true;
            this.lbManAllowancesDate.Location = new System.Drawing.Point(209, 200);
            this.lbManAllowancesDate.Name = "lbManAllowancesDate";
            this.lbManAllowancesDate.Size = new System.Drawing.Size(30, 13);
            this.lbManAllowancesDate.TabIndex = 21;
            this.lbManAllowancesDate.Text = "Date";
            // 
            // tbManAllowancesDate
            // 
            this.tbManAllowancesDate.Location = new System.Drawing.Point(261, 195);
            this.tbManAllowancesDate.Name = "tbManAllowancesDate";
            this.tbManAllowancesDate.ReadOnly = true;
            this.tbManAllowancesDate.Size = new System.Drawing.Size(101, 20);
            this.tbManAllowancesDate.TabIndex = 5;
            // 
            // lbManAllowancesStartHour
            // 
            this.lbManAllowancesStartHour.AutoSize = true;
            this.lbManAllowancesStartHour.Location = new System.Drawing.Point(218, 233);
            this.lbManAllowancesStartHour.Name = "lbManAllowancesStartHour";
            this.lbManAllowancesStartHour.Size = new System.Drawing.Size(55, 13);
            this.lbManAllowancesStartHour.TabIndex = 19;
            this.lbManAllowancesStartHour.Text = "Start Hour";
            // 
            // tbManAllowancesStartHour
            // 
            this.tbManAllowancesStartHour.Location = new System.Drawing.Point(276, 231);
            this.tbManAllowancesStartHour.Name = "tbManAllowancesStartHour";
            this.tbManAllowancesStartHour.ReadOnly = true;
            this.tbManAllowancesStartHour.Size = new System.Drawing.Size(101, 20);
            this.tbManAllowancesStartHour.TabIndex = 6;
            // 
            // lbManAllowancesEndHour
            // 
            this.lbManAllowancesEndHour.AutoSize = true;
            this.lbManAllowancesEndHour.Location = new System.Drawing.Point(220, 278);
            this.lbManAllowancesEndHour.Name = "lbManAllowancesEndHour";
            this.lbManAllowancesEndHour.Size = new System.Drawing.Size(52, 13);
            this.lbManAllowancesEndHour.TabIndex = 17;
            this.lbManAllowancesEndHour.Text = "End Hour";
            // 
            // tbManAllowancesEndHour
            // 
            this.tbManAllowancesEndHour.Location = new System.Drawing.Point(279, 276);
            this.tbManAllowancesEndHour.Name = "tbManAllowancesEndHour";
            this.tbManAllowancesEndHour.ReadOnly = true;
            this.tbManAllowancesEndHour.Size = new System.Drawing.Size(101, 20);
            this.tbManAllowancesEndHour.TabIndex = 7;
            // 
            // lbManAllowancesState
            // 
            this.lbManAllowancesState.AutoSize = true;
            this.lbManAllowancesState.Location = new System.Drawing.Point(220, 316);
            this.lbManAllowancesState.Name = "lbManAllowancesState";
            this.lbManAllowancesState.Size = new System.Drawing.Size(32, 13);
            this.lbManAllowancesState.TabIndex = 15;
            this.lbManAllowancesState.Text = "State";
            // 
            // tbManAllowancesState
            // 
            this.tbManAllowancesState.Location = new System.Drawing.Point(279, 314);
            this.tbManAllowancesState.Name = "tbManAllowancesState";
            this.tbManAllowancesState.ReadOnly = true;
            this.tbManAllowancesState.Size = new System.Drawing.Size(101, 20);
            this.tbManAllowancesState.TabIndex = 8;
            // 
            // lbManAllowancesTitle
            // 
            this.lbManAllowancesTitle.AutoSize = true;
            this.lbManAllowancesTitle.Location = new System.Drawing.Point(2, 233);
            this.lbManAllowancesTitle.Name = "lbManAllowancesTitle";
            this.lbManAllowancesTitle.Size = new System.Drawing.Size(35, 13);
            this.lbManAllowancesTitle.TabIndex = 13;
            this.lbManAllowancesTitle.Text = "Título";
            // 
            // tbManAllowancesTitle
            // 
            this.tbManAllowancesTitle.Location = new System.Drawing.Point(39, 233);
            this.tbManAllowancesTitle.Name = "tbManAllowancesTitle";
            this.tbManAllowancesTitle.ReadOnly = true;
            this.tbManAllowancesTitle.Size = new System.Drawing.Size(101, 20);
            this.tbManAllowancesTitle.TabIndex = 3;
            // 
            // lbManAllowancesEmail
            // 
            this.lbManAllowancesEmail.AutoSize = true;
            this.lbManAllowancesEmail.Location = new System.Drawing.Point(3, 205);
            this.lbManAllowancesEmail.Name = "lbManAllowancesEmail";
            this.lbManAllowancesEmail.Size = new System.Drawing.Size(32, 13);
            this.lbManAllowancesEmail.TabIndex = 11;
            this.lbManAllowancesEmail.Text = "Email";
            // 
            // dgvAllowances
            // 
            this.dgvAllowances.AllowUserToAddRows = false;
            this.dgvAllowances.AllowUserToDeleteRows = false;
            this.dgvAllowances.AllowUserToOrderColumns = true;
            this.dgvAllowances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllowances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.observations,
            this.cDate,
            this.startHour,
            this.endHour,
            this.invoice,
            this.state});
            this.dgvAllowances.Location = new System.Drawing.Point(0, 26);
            this.dgvAllowances.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllowances.Name = "dgvAllowances";
            this.dgvAllowances.RowHeadersWidth = 51;
            this.dgvAllowances.RowTemplate.Height = 29;
            this.dgvAllowances.Size = new System.Drawing.Size(913, 157);
            this.dgvAllowances.TabIndex = 14;
            this.dgvAllowances.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDietas_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "idAllowance";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // observations
            // 
            this.observations.HeaderText = "Observations";
            this.observations.MinimumWidth = 6;
            this.observations.Name = "observations";
            this.observations.Width = 125;
            // 
            // cDate
            // 
            this.cDate.HeaderText = "Date";
            this.cDate.MinimumWidth = 6;
            this.cDate.Name = "cDate";
            this.cDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cDate.Width = 125;
            // 
            // startHour
            // 
            this.startHour.HeaderText = "Start Hour";
            this.startHour.MinimumWidth = 6;
            this.startHour.Name = "startHour";
            this.startHour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startHour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.startHour.Width = 125;
            // 
            // endHour
            // 
            this.endHour.HeaderText = "End Hour";
            this.endHour.MinimumWidth = 6;
            this.endHour.Name = "endHour";
            this.endHour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endHour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.endHour.Width = 125;
            // 
            // invoice
            // 
            this.invoice.HeaderText = "Invoice";
            this.invoice.MinimumWidth = 6;
            this.invoice.Name = "invoice";
            this.invoice.Width = 125;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.state.Width = 125;
            // 
            // tbManAllowancesEmail
            // 
            this.tbManAllowancesEmail.Location = new System.Drawing.Point(39, 202);
            this.tbManAllowancesEmail.Name = "tbManAllowancesEmail";
            this.tbManAllowancesEmail.ReadOnly = true;
            this.tbManAllowancesEmail.Size = new System.Drawing.Size(101, 20);
            this.tbManAllowancesEmail.TabIndex = 2;
            // 
            // lbTitleManAllowance
            // 
            this.lbTitleManAllowance.AutoSize = true;
            this.lbTitleManAllowance.Location = new System.Drawing.Point(3, 7);
            this.lbTitleManAllowance.Name = "lbTitleManAllowance";
            this.lbTitleManAllowance.Size = new System.Drawing.Size(37, 13);
            this.lbTitleManAllowance.TabIndex = 4;
            this.lbTitleManAllowance.Text = "Dietas";
            // 
            // pGestDietasKilometraje
            // 
            this.pGestDietasKilometraje.Controls.Add(this.btnManMileageRemoveMileage);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageIdMileage);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageIdMileage);
            this.pGestDietasKilometraje.Controls.Add(this.btnManMileageRefreshDgvMileage);
            this.pGestDietasKilometraje.Controls.Add(this.btnManMileageUpdateStateMileage);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageNewState);
            this.pGestDietasKilometraje.Controls.Add(this.cbManMileageNewState);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageKilometers);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageKilometers);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageState);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageState);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileagePricePerKilometer);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileagePricePerKilometer);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageFinal);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageFinal);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageDate);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageDate);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageSubcategory);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageSubcategory);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageOrigin);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageOrigin);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageDestination);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageDestination);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageTitle);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageTitle);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageEmail);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageEmail);
            this.pGestDietasKilometraje.Controls.Add(this.lbTitleManMileage);
            this.pGestDietasKilometraje.Controls.Add(this.dgvMileage);
            this.pGestDietasKilometraje.Location = new System.Drawing.Point(14, 56);
            this.pGestDietasKilometraje.Name = "pGestDietasKilometraje";
            this.pGestDietasKilometraje.Size = new System.Drawing.Size(972, 379);
            this.pGestDietasKilometraje.TabIndex = 9;
            // 
            // btnManMileageRemoveMileage
            // 
            this.btnManMileageRemoveMileage.Location = new System.Drawing.Point(576, 269);
            this.btnManMileageRemoveMileage.Name = "btnManMileageRemoveMileage";
            this.btnManMileageRemoveMileage.Size = new System.Drawing.Size(99, 47);
            this.btnManMileageRemoveMileage.TabIndex = 52;
            this.btnManMileageRemoveMileage.Text = "Eliminar kilometraje";
            this.btnManMileageRemoveMileage.UseVisualStyleBackColor = true;
            this.btnManMileageRemoveMileage.Click += new System.EventHandler(this.btnKilometrajeEliminar_Click);
            // 
            // lbManMileageIdMileage
            // 
            this.lbManMileageIdMileage.AutoSize = true;
            this.lbManMileageIdMileage.Location = new System.Drawing.Point(17, 325);
            this.lbManMileageIdMileage.Name = "lbManMileageIdMileage";
            this.lbManMileageIdMileage.Size = new System.Drawing.Size(69, 13);
            this.lbManMileageIdMileage.TabIndex = 51;
            this.lbManMileageIdMileage.Text = "Id kilometraje";
            // 
            // tbManMileageIdMileage
            // 
            this.tbManMileageIdMileage.Location = new System.Drawing.Point(42, 341);
            this.tbManMileageIdMileage.Name = "tbManMileageIdMileage";
            this.tbManMileageIdMileage.ReadOnly = true;
            this.tbManMileageIdMileage.Size = new System.Drawing.Size(77, 20);
            this.tbManMileageIdMileage.TabIndex = 6;
            // 
            // btnManMileageRefreshDgvMileage
            // 
            this.btnManMileageRefreshDgvMileage.Location = new System.Drawing.Point(433, 322);
            this.btnManMileageRefreshDgvMileage.Name = "btnManMileageRefreshDgvMileage";
            this.btnManMileageRefreshDgvMileage.Size = new System.Drawing.Size(112, 32);
            this.btnManMileageRefreshDgvMileage.TabIndex = 49;
            this.btnManMileageRefreshDgvMileage.Text = "Refrescar tabla";
            this.btnManMileageRefreshDgvMileage.UseVisualStyleBackColor = true;
            this.btnManMileageRefreshDgvMileage.Click += new System.EventHandler(this.btnRefreshDgvMileage_Click);
            // 
            // btnManMileageUpdateStateMileage
            // 
            this.btnManMileageUpdateStateMileage.Location = new System.Drawing.Point(433, 269);
            this.btnManMileageUpdateStateMileage.Name = "btnManMileageUpdateStateMileage";
            this.btnManMileageUpdateStateMileage.Size = new System.Drawing.Size(112, 30);
            this.btnManMileageUpdateStateMileage.TabIndex = 48;
            this.btnManMileageUpdateStateMileage.Text = "Actualizar Kilometraje";
            this.btnManMileageUpdateStateMileage.UseVisualStyleBackColor = true;
            this.btnManMileageUpdateStateMileage.Click += new System.EventHandler(this.btnUpdateStateMileage_Click);
            // 
            // lbManMileageNewState
            // 
            this.lbManMileageNewState.AutoSize = true;
            this.lbManMileageNewState.Location = new System.Drawing.Point(417, 236);
            this.lbManMileageNewState.Name = "lbManMileageNewState";
            this.lbManMileageNewState.Size = new System.Drawing.Size(130, 13);
            this.lbManMileageNewState.TabIndex = 47;
            this.lbManMileageNewState.Text = "Nuevo estado kilometraje:";
            // 
            // cbManMileageNewState
            // 
            this.cbManMileageNewState.FormattingEnabled = true;
            this.cbManMileageNewState.Items.AddRange(new object[] {
            "Solicitado",
            "En trámite",
            "Pagado"});
            this.cbManMileageNewState.Location = new System.Drawing.Point(558, 233);
            this.cbManMileageNewState.Name = "cbManMileageNewState";
            this.cbManMileageNewState.Size = new System.Drawing.Size(106, 21);
            this.cbManMileageNewState.TabIndex = 13;
            this.cbManMileageNewState.SelectionChangeCommitted += new System.EventHandler(this.cbMileageState_SelectionChangeCommitted);
            // 
            // lbManMileageKilometers
            // 
            this.lbManMileageKilometers.AutoSize = true;
            this.lbManMileageKilometers.Location = new System.Drawing.Point(210, 257);
            this.lbManMileageKilometers.Name = "lbManMileageKilometers";
            this.lbManMileageKilometers.Size = new System.Drawing.Size(55, 13);
            this.lbManMileageKilometers.TabIndex = 45;
            this.lbManMileageKilometers.Text = "Kilometers";
            // 
            // tbManMileageKilometers
            // 
            this.tbManMileageKilometers.Location = new System.Drawing.Point(268, 255);
            this.tbManMileageKilometers.Name = "tbManMileageKilometers";
            this.tbManMileageKilometers.Size = new System.Drawing.Size(101, 20);
            this.tbManMileageKilometers.TabIndex = 9;
            // 
            // lbManMileageState
            // 
            this.lbManMileageState.AutoSize = true;
            this.lbManMileageState.Location = new System.Drawing.Point(414, 188);
            this.lbManMileageState.Name = "lbManMileageState";
            this.lbManMileageState.Size = new System.Drawing.Size(32, 13);
            this.lbManMileageState.TabIndex = 43;
            this.lbManMileageState.Text = "State";
            // 
            // tbManMileageState
            // 
            this.tbManMileageState.Location = new System.Drawing.Point(472, 185);
            this.tbManMileageState.Name = "tbManMileageState";
            this.tbManMileageState.Size = new System.Drawing.Size(101, 20);
            this.tbManMileageState.TabIndex = 12;
            // 
            // lbManMileagePricePerKilometer
            // 
            this.lbManMileagePricePerKilometer.AutoSize = true;
            this.lbManMileagePricePerKilometer.Location = new System.Drawing.Point(207, 291);
            this.lbManMileagePricePerKilometer.Name = "lbManMileagePricePerKilometer";
            this.lbManMileagePricePerKilometer.Size = new System.Drawing.Size(96, 13);
            this.lbManMileagePricePerKilometer.TabIndex = 41;
            this.lbManMileagePricePerKilometer.Text = "Price Per Kilometer";
            // 
            // tbManMileagePricePerKilometer
            // 
            this.tbManMileagePricePerKilometer.Location = new System.Drawing.Point(303, 287);
            this.tbManMileagePricePerKilometer.Name = "tbManMileagePricePerKilometer";
            this.tbManMileagePricePerKilometer.Size = new System.Drawing.Size(101, 20);
            this.tbManMileagePricePerKilometer.TabIndex = 10;
            // 
            // lbManMileageFinal
            // 
            this.lbManMileageFinal.AutoSize = true;
            this.lbManMileageFinal.Location = new System.Drawing.Point(210, 325);
            this.lbManMileageFinal.Name = "lbManMileageFinal";
            this.lbManMileageFinal.Size = new System.Drawing.Size(29, 13);
            this.lbManMileageFinal.TabIndex = 39;
            this.lbManMileageFinal.Text = "Final";
            // 
            // tbManMileageFinal
            // 
            this.tbManMileageFinal.Location = new System.Drawing.Point(268, 322);
            this.tbManMileageFinal.Name = "tbManMileageFinal";
            this.tbManMileageFinal.Size = new System.Drawing.Size(101, 20);
            this.tbManMileageFinal.TabIndex = 11;
            // 
            // lbManMileageDate
            // 
            this.lbManMileageDate.AutoSize = true;
            this.lbManMileageDate.Location = new System.Drawing.Point(21, 252);
            this.lbManMileageDate.Name = "lbManMileageDate";
            this.lbManMileageDate.Size = new System.Drawing.Size(30, 13);
            this.lbManMileageDate.TabIndex = 35;
            this.lbManMileageDate.Text = "Date";
            // 
            // tbManMileageDate
            // 
            this.tbManMileageDate.Location = new System.Drawing.Point(57, 250);
            this.tbManMileageDate.Name = "tbManMileageDate";
            this.tbManMileageDate.Size = new System.Drawing.Size(101, 20);
            this.tbManMileageDate.TabIndex = 4;
            // 
            // lbManMileageSubcategory
            // 
            this.lbManMileageSubcategory.AutoSize = true;
            this.lbManMileageSubcategory.Location = new System.Drawing.Point(20, 287);
            this.lbManMileageSubcategory.Name = "lbManMileageSubcategory";
            this.lbManMileageSubcategory.Size = new System.Drawing.Size(67, 13);
            this.lbManMileageSubcategory.TabIndex = 33;
            this.lbManMileageSubcategory.Text = "Subcategory";
            // 
            // tbManMileageSubcategory
            // 
            this.tbManMileageSubcategory.Location = new System.Drawing.Point(87, 287);
            this.tbManMileageSubcategory.Name = "tbManMileageSubcategory";
            this.tbManMileageSubcategory.Size = new System.Drawing.Size(101, 20);
            this.tbManMileageSubcategory.TabIndex = 5;
            // 
            // lbManMileageOrigin
            // 
            this.lbManMileageOrigin.AutoSize = true;
            this.lbManMileageOrigin.Location = new System.Drawing.Point(210, 188);
            this.lbManMileageOrigin.Name = "lbManMileageOrigin";
            this.lbManMileageOrigin.Size = new System.Drawing.Size(38, 13);
            this.lbManMileageOrigin.TabIndex = 31;
            this.lbManMileageOrigin.Text = "Origen";
            // 
            // tbManMileageOrigin
            // 
            this.tbManMileageOrigin.Location = new System.Drawing.Point(268, 185);
            this.tbManMileageOrigin.Name = "tbManMileageOrigin";
            this.tbManMileageOrigin.Size = new System.Drawing.Size(101, 20);
            this.tbManMileageOrigin.TabIndex = 7;
            // 
            // lbManMileageDestination
            // 
            this.lbManMileageDestination.AutoSize = true;
            this.lbManMileageDestination.Location = new System.Drawing.Point(210, 226);
            this.lbManMileageDestination.Name = "lbManMileageDestination";
            this.lbManMileageDestination.Size = new System.Drawing.Size(43, 13);
            this.lbManMileageDestination.TabIndex = 29;
            this.lbManMileageDestination.Text = "Destino";
            // 
            // tbManMileageDestination
            // 
            this.tbManMileageDestination.Location = new System.Drawing.Point(268, 224);
            this.tbManMileageDestination.Name = "tbManMileageDestination";
            this.tbManMileageDestination.ReadOnly = true;
            this.tbManMileageDestination.Size = new System.Drawing.Size(101, 20);
            this.tbManMileageDestination.TabIndex = 8;
            // 
            // lbManMileageTitle
            // 
            this.lbManMileageTitle.AutoSize = true;
            this.lbManMileageTitle.Location = new System.Drawing.Point(20, 217);
            this.lbManMileageTitle.Name = "lbManMileageTitle";
            this.lbManMileageTitle.Size = new System.Drawing.Size(35, 13);
            this.lbManMileageTitle.TabIndex = 27;
            this.lbManMileageTitle.Text = "Título";
            // 
            // tbManMileageTitle
            // 
            this.tbManMileageTitle.Location = new System.Drawing.Point(57, 217);
            this.tbManMileageTitle.Name = "tbManMileageTitle";
            this.tbManMileageTitle.Size = new System.Drawing.Size(101, 20);
            this.tbManMileageTitle.TabIndex = 3;
            // 
            // lbManMileageEmail
            // 
            this.lbManMileageEmail.AutoSize = true;
            this.lbManMileageEmail.Location = new System.Drawing.Point(21, 188);
            this.lbManMileageEmail.Name = "lbManMileageEmail";
            this.lbManMileageEmail.Size = new System.Drawing.Size(32, 13);
            this.lbManMileageEmail.TabIndex = 25;
            this.lbManMileageEmail.Text = "Email";
            // 
            // tbManMileageEmail
            // 
            this.tbManMileageEmail.Location = new System.Drawing.Point(57, 185);
            this.tbManMileageEmail.Name = "tbManMileageEmail";
            this.tbManMileageEmail.Size = new System.Drawing.Size(101, 20);
            this.tbManMileageEmail.TabIndex = 2;
            // 
            // lbTitleManMileage
            // 
            this.lbTitleManMileage.AutoSize = true;
            this.lbTitleManMileage.Location = new System.Drawing.Point(3, 7);
            this.lbTitleManMileage.Name = "lbTitleManMileage";
            this.lbTitleManMileage.Size = new System.Drawing.Size(58, 13);
            this.lbTitleManMileage.TabIndex = 5;
            this.lbTitleManMileage.Text = "Kilometraje";
            // 
            // dgvMileage
            // 
            this.dgvMileage.AllowUserToAddRows = false;
            this.dgvMileage.AllowUserToDeleteRows = false;
            this.dgvMileage.AllowUserToOrderColumns = true;
            this.dgvMileage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMileage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMileage,
            this.dataGridViewTextBoxColumn1,
            this.title,
            this.date,
            this.subcategory,
            this.origen,
            this.destino,
            this.kilometers,
            this.pricePerKilometer,
            this.Final,
            this.dataGridViewComboBoxColumn1});
            this.dgvMileage.Location = new System.Drawing.Point(3, 27);
            this.dgvMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMileage.Name = "dgvMileage";
            this.dgvMileage.RowHeadersWidth = 51;
            this.dgvMileage.RowTemplate.Height = 29;
            this.dgvMileage.Size = new System.Drawing.Size(985, 149);
            this.dgvMileage.TabIndex = 6;
            this.dgvMileage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKilometraje_CellClick);
            this.dgvMileage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKilometraje_CellContentClick);
            // 
            // idMileage
            // 
            this.idMileage.HeaderText = "idMileage";
            this.idMileage.MinimumWidth = 6;
            this.idMileage.Name = "idMileage";
            this.idMileage.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Email";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 75;
            // 
            // subcategory
            // 
            this.subcategory.HeaderText = "Subcategory";
            this.subcategory.MinimumWidth = 6;
            this.subcategory.Name = "subcategory";
            this.subcategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subcategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.subcategory.Width = 125;
            // 
            // origen
            // 
            this.origen.HeaderText = "Origen";
            this.origen.MinimumWidth = 6;
            this.origen.Name = "origen";
            this.origen.Width = 125;
            // 
            // destino
            // 
            this.destino.HeaderText = "Destino";
            this.destino.MinimumWidth = 6;
            this.destino.Name = "destino";
            this.destino.Width = 125;
            // 
            // kilometers
            // 
            this.kilometers.HeaderText = "Kilometers";
            this.kilometers.MinimumWidth = 6;
            this.kilometers.Name = "kilometers";
            this.kilometers.Width = 125;
            // 
            // pricePerKilometer
            // 
            this.pricePerKilometer.HeaderText = "Price Per Kilometer";
            this.pricePerKilometer.MinimumWidth = 6;
            this.pricePerKilometer.Name = "pricePerKilometer";
            this.pricePerKilometer.Width = 125;
            // 
            // Final
            // 
            this.Final.HeaderText = "Final";
            this.Final.MinimumWidth = 6;
            this.Final.Name = "Final";
            this.Final.ReadOnly = true;
            this.Final.Width = 75;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "State";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewComboBoxColumn1.Width = 125;
            // 
            // pUsuarios
            // 
            this.pUsuarios.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pUsuarios.Controls.Add(this.btnEliminarUser);
            this.pUsuarios.Controls.Add(this.btnUpdateDtgUsers);
            this.pUsuarios.Controls.Add(this.lbJob);
            this.pUsuarios.Controls.Add(this.lbIdUser);
            this.pUsuarios.Controls.Add(this.tbOcupacion);
            this.pUsuarios.Controls.Add(this.tbIdUser);
            this.pUsuarios.Controls.Add(this.tbDepartment);
            this.pUsuarios.Controls.Add(this.tbPassword);
            this.pUsuarios.Controls.Add(this.tbEmail);
            this.pUsuarios.Controls.Add(this.lbPassword);
            this.pUsuarios.Controls.Add(this.lbEmail);
            this.pUsuarios.Controls.Add(this.lbDepartment);
            this.pUsuarios.Controls.Add(this.dgvUser);
            this.pUsuarios.Controls.Add(this.lbGestUsers);
            this.pUsuarios.Controls.Add(this.pRegister);
            this.pUsuarios.Location = new System.Drawing.Point(261, 95);
            this.pUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pUsuarios.Name = "pUsuarios";
            this.pUsuarios.Size = new System.Drawing.Size(1025, 483);
            this.pUsuarios.TabIndex = 2;
            this.pUsuarios.Visible = false;
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.Location = new System.Drawing.Point(167, 216);
            this.btnEliminarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(103, 35);
            this.btnEliminarUser.TabIndex = 7;
            this.btnEliminarUser.Text = "Eliminar";
            this.btnEliminarUser.UseVisualStyleBackColor = true;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnUpdateDtgUsers
            // 
            this.btnUpdateDtgUsers.Location = new System.Drawing.Point(21, 216);
            this.btnUpdateDtgUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateDtgUsers.Name = "btnUpdateDtgUsers";
            this.btnUpdateDtgUsers.Size = new System.Drawing.Size(103, 35);
            this.btnUpdateDtgUsers.TabIndex = 6;
            this.btnUpdateDtgUsers.Text = "Actualizar";
            this.btnUpdateDtgUsers.UseVisualStyleBackColor = true;
            this.btnUpdateDtgUsers.Click += new System.EventHandler(this.btnUpdateDtgUsers_Click);
            // 
            // lbJob
            // 
            this.lbJob.AutoSize = true;
            this.lbJob.Location = new System.Drawing.Point(20, 408);
            this.lbJob.Name = "lbJob";
            this.lbJob.Size = new System.Drawing.Size(59, 13);
            this.lbJob.TabIndex = 22;
            this.lbJob.Text = "Ocupación";
            // 
            // lbIdUser
            // 
            this.lbIdUser.AutoSize = true;
            this.lbIdUser.Location = new System.Drawing.Point(27, 268);
            this.lbIdUser.Name = "lbIdUser";
            this.lbIdUser.Size = new System.Drawing.Size(41, 13);
            this.lbIdUser.TabIndex = 21;
            this.lbIdUser.Text = "Id User";
            // 
            // tbOcupacion
            // 
            this.tbOcupacion.Location = new System.Drawing.Point(101, 408);
            this.tbOcupacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOcupacion.Name = "tbOcupacion";
            this.tbOcupacion.Size = new System.Drawing.Size(101, 20);
            this.tbOcupacion.TabIndex = 5;
            // 
            // tbIdUser
            // 
            this.tbIdUser.Location = new System.Drawing.Point(105, 266);
            this.tbIdUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdUser.Name = "tbIdUser";
            this.tbIdUser.Size = new System.Drawing.Size(101, 20);
            this.tbIdUser.TabIndex = 4;
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(126, 355);
            this.tbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(101, 20);
            this.tbDepartment.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(141, 328);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(89, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(113, 294);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(89, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(33, 328);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(38, 294);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "Email";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(5, 355);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(74, 13);
            this.lbDepartment.TabIndex = 7;
            this.lbDepartment.Text = "Departamento";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToOrderColumns = true;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.email,
            this.password,
            this.dept,
            this.role});
            this.dgvUser.Location = new System.Drawing.Point(293, 19);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 25;
            this.dgvUser.Size = new System.Drawing.Size(612, 222);
            this.dgvUser.TabIndex = 6;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // idUser
            // 
            this.idUser.HeaderText = "Id User";
            this.idUser.MinimumWidth = 6;
            this.idUser.Name = "idUser";
            this.idUser.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Width = 125;
            // 
            // dept
            // 
            this.dept.HeaderText = "Departamento";
            this.dept.MinimumWidth = 6;
            this.dept.Name = "dept";
            this.dept.Width = 125;
            // 
            // role
            // 
            this.role.HeaderText = "Ocupación";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.Width = 125;
            // 
            // lbGestUsers
            // 
            this.lbGestUsers.AutoSize = true;
            this.lbGestUsers.Location = new System.Drawing.Point(38, 10);
            this.lbGestUsers.Name = "lbGestUsers";
            this.lbGestUsers.Size = new System.Drawing.Size(100, 13);
            this.lbGestUsers.TabIndex = 1;
            this.lbGestUsers.Text = "Gestión de usuarios";
            // 
            // pRegister
            // 
            this.pRegister.BackColor = System.Drawing.Color.LightGray;
            this.pRegister.Controls.Add(this.cbRole);
            this.pRegister.Controls.Add(this.btnRRegistrar);
            this.pRegister.Controls.Add(this.lbRegisterUser);
            this.pRegister.Controls.Add(this.tbRPassword);
            this.pRegister.Controls.Add(this.tbREmail);
            this.pRegister.Controls.Add(this.cbDepartamento);
            this.pRegister.Location = new System.Drawing.Point(21, 42);
            this.pRegister.Name = "pRegister";
            this.pRegister.Size = new System.Drawing.Size(249, 167);
            this.pRegister.TabIndex = 5;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Técnico de selección",
            "Vendedor",
            "Contable"});
            this.cbRole.Location = new System.Drawing.Point(120, 47);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(104, 21);
            this.cbRole.TabIndex = 3;
            // 
            // btnRRegistrar
            // 
            this.btnRRegistrar.Location = new System.Drawing.Point(15, 128);
            this.btnRRegistrar.Name = "btnRRegistrar";
            this.btnRRegistrar.Size = new System.Drawing.Size(79, 23);
            this.btnRRegistrar.TabIndex = 5;
            this.btnRRegistrar.Text = "Registrar";
            this.btnRRegistrar.UseVisualStyleBackColor = true;
            this.btnRRegistrar.Click += new System.EventHandler(this.btnRRegistrar_Click);
            // 
            // lbRegisterUser
            // 
            this.lbRegisterUser.AutoSize = true;
            this.lbRegisterUser.Location = new System.Drawing.Point(15, 12);
            this.lbRegisterUser.Name = "lbRegisterUser";
            this.lbRegisterUser.Size = new System.Drawing.Size(46, 13);
            this.lbRegisterUser.TabIndex = 7;
            this.lbRegisterUser.Text = "Register";
            // 
            // tbRPassword
            // 
            this.tbRPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbRPassword.Location = new System.Drawing.Point(15, 94);
            this.tbRPassword.Name = "tbRPassword";
            this.tbRPassword.Size = new System.Drawing.Size(91, 20);
            this.tbRPassword.TabIndex = 2;
            this.tbRPassword.Text = "Password";
            this.tbRPassword.GotFocus += new System.EventHandler(this.tbRPassword_Focus);
            this.tbRPassword.LostFocus += new System.EventHandler(this.tbRPassword_LostFocus);
            // 
            // tbREmail
            // 
            this.tbREmail.ForeColor = System.Drawing.Color.DimGray;
            this.tbREmail.Location = new System.Drawing.Point(15, 48);
            this.tbREmail.Name = "tbREmail";
            this.tbREmail.Size = new System.Drawing.Size(91, 20);
            this.tbREmail.TabIndex = 1;
            this.tbREmail.Text = "Email";
            this.tbREmail.TextChanged += new System.EventHandler(this.tbREmail_TextChanged);
            this.tbREmail.GotFocus += new System.EventHandler(this.tbREmail_Focus);
            this.tbREmail.LostFocus += new System.EventHandler(this.tbREmail_LostFocus);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Items.AddRange(new object[] {
            "Gerencia",
            "Contabilidad",
            "RRHH",
            "Ventas"});
            this.cbDepartamento.Location = new System.Drawing.Point(120, 92);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(104, 21);
            this.cbDepartamento.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(48, 548);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 19);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "cerrar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // opfSeleccionarArchivo
            // 
            this.opfSeleccionarArchivo.FileName = "openFileDialog1";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 849);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.pGestionDietas);
            this.Controls.Add(this.pSolicitudDieta);
            this.Controls.Add(this.pUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.sidebar.ResumeLayout(false);
            this.pHome.ResumeLayout(false);
            this.containerModulos.ResumeLayout(false);
            this.pGestDietas.ResumeLayout(false);
            this.pSoliDietas.ResumeLayout(false);
            this.pGestionUsers.ResumeLayout(false);
            this.pSettings.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pSolicitudDieta.ResumeLayout(false);
            this.pSolicitudDieta.PerformLayout();
            this.pSolKilometraje.ResumeLayout(false);
            this.pSolKilometraje.PerformLayout();
            this.pSolSolicitudDietas.ResumeLayout(false);
            this.pSolSolicitudDietas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNailInvoice)).EndInit();
            this.pGestionDietas.ResumeLayout(false);
            this.pGestionDietas.PerformLayout();
            this.pGestDietasDietas.ResumeLayout(false);
            this.pGestDietasDietas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllowances)).EndInit();
            this.pGestDietasKilometraje.ResumeLayout(false);
            this.pGestDietasKilometraje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMileage)).EndInit();
            this.pUsuarios.ResumeLayout(false);
            this.pUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.pRegister.ResumeLayout(false);
            this.pRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel pMenu;
        private Panel containerModulos;
        private Panel pSettings;
        private Label lbMenu;
        private PictureBox btnMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button btnSubMenu;
        private Button btnGestUsers;
        private Button btnSettings;
        private Panel pGestionUsers;
        private System.Windows.Forms.Timer timerSubMenu;
        private Panel pHeader;
        private Label lbTitle;
        private Panel pSolicitudDieta;
        private Panel pGestionDietas;
        private Panel pUsuarios;
        private Label lbUser;
        private Label lbRole;
        private Panel pSoliDietas;
        private Button btnSolDietas;
        private Panel pGestDietas;
        private Button btnGestDietas;
        private Label lbTitleSolDieta;
        private Label lbManAllowances;
        private Label lbGestUsers;
        private Button btnSalir;
        private Panel pRegister;
        private Button btnRRegistrar;
        private Label lbRegisterUser;
        private TextBox tbRPassword;
        private TextBox tbREmail;
        private Button btnRequestAllowances;
        private DateTimePicker dtpReqAllowancesStartTime;
        private Label lbReqAllowancesObservations;
        private Label lbReqAllowancesDate;
        private TextBox tbReqAllowancesObservations;
        private ComboBox cbRole;
        private DataGridView dgvUser;
        private Label lbPassword;
        private Label lbEmail;
        private Label lbDepartment;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Button btnReqAllowancesUploadFile;
        private DataGridView dgvAllowances;
        private DataGridView dgvMileage;
        private Label lbTitleManMileage;
        private Label lbTitleManAllowance;
        private ComboBox cbSolicitudDietas;
        private TextBox tbReqAllowancesTitle;
        private Label lbReqAllowancesTitle;
        private Label lbReqAllowancesOptions;
        private PictureBox thumbNailInvoice;
        private Panel pSolKilometraje;
        private Label lbMileageTitle;
        private DateTimePicker dtpReqDietasMileageDate;
        private TextBox tbReqMileageTitle;
        private TextBox tbReqMileagePricePerKilometer;
        private TextBox tbReqMileageTotal;
        private TextBox tbReqMileageDestination;
        private TextBox tbReqMileageOrigin;
        private TextBox tbReqMileageMileage;
        private ComboBox cbReqMileageSubCategory;
        private Label lbTitleMileage;
        private Label lbReqMileageDate;
        private Label lbReqMileageSubcategory;
        private Label lbReqMileageOrigin;
        private Label lbReqMileageDestination;
        private Label lbReqMileageTotal;
        private Label lbReqMileagePricePerKilometer;
        private Label lbReqMileage;
        private ComboBox cbGestDietas;
        private Panel pGestDietasKilometraje;
        private Panel pGestDietasDietas;
        private Panel pHome;
        private Button btnHome;
        private Label lbManAllowancesObservations;
        private TextBox tbManAllowancesObservations;
        private Label lbManAllowancesDate;
        private TextBox tbManAllowancesDate;
        private Label lbManAllowancesStartHour;
        private TextBox tbManAllowancesStartHour;
        private Label lbManAllowancesEndHour;
        private TextBox tbManAllowancesEndHour;
        private Label lbManAllowancesState;
        private TextBox tbManAllowancesState;
        private Label lbManAllowancesTitle;
        private TextBox tbManAllowancesTitle;
        private Label lbManAllowancesEmail;
        private TextBox tbManAllowancesEmail;
        private Label lbManMileageState;
        private TextBox tbManMileageState;
        private Label lbManMileagePricePerKilometer;
        private TextBox tbManMileagePricePerKilometer;
        private Label lbManMileageFinal;
        private TextBox tbManMileageFinal;
        private Label lbManMileageDate;
        private TextBox tbManMileageDate;
        private Label lbManMileageSubcategory;
        private TextBox tbManMileageSubcategory;
        private Label lbManMileageOrigin;
        private TextBox tbManMileageOrigin;
        private Label lbManMileageDestination;
        private TextBox tbManMileageDestination;
        private Label lbManMileageTitle;
        private TextBox tbManMileageTitle;
        private Label lbManMileageEmail;
        private TextBox tbManMileageEmail;
        private Label lbManMileageKilometers;
        private TextBox tbManMileageKilometers;
        private Panel pSolSolicitudDietas;
        private Label lbReqAllowancesTitleAllowances;
        private MaskedTextBox mtbReqAllowancesStartHour;
        private MaskedTextBox mtbReqAllowancesEndHour;
        private ComboBox cbDepartamento;
        private TextBox tbIdUser;
        private TextBox tbDepartment;
        private Label lbJob;
        private Label lbIdUser;
        private TextBox tbOcupacion;
        private Button btnUpdateDtgUsers;
        private Button btnEliminarUser;
        private Label lbReqAllowancesEndHour;
        private Label lbReqAllowancesStartHour;
        private OpenFileDialog opfSeleccionarArchivo;
        private Label labelURL;
        private Button btnManAllowancesDietasRefresh;
        private Button btnSalirHome;
        private Label lbManAllowancesNewState;
        private ComboBox cbStateDietas;
        private Button btnManAllowancesUpdateData;
        private DataGridViewTextBoxColumn idUser;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn dept;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn observations;
        private DataGridViewTextBoxColumn cDate;
        private DataGridViewTextBoxColumn startHour;
        private DataGridViewTextBoxColumn endHour;
        private DataGridViewImageColumn invoice;
        private DataGridViewTextBoxColumn state;
        private Label lbManAllowancesIdAllowance;
        private TextBox tbManAllowancesIdAllowance;
        private Label lbManMileageNewState;
        private ComboBox cbManMileageNewState;
        private Button btnManMileageRefreshDgvMileage;
        private Button btnManMileageUpdateStateMileage;
        private DataGridViewTextBoxColumn idMileage;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn subcategory;
        private DataGridViewTextBoxColumn origen;
        private DataGridViewTextBoxColumn destino;
        private DataGridViewTextBoxColumn kilometers;
        private DataGridViewTextBoxColumn pricePerKilometer;
        private DataGridViewTextBoxColumn Final;
        private DataGridViewTextBoxColumn dataGridViewComboBoxColumn1;
        private Label lbManMileageIdMileage;
        private TextBox tbManMileageIdMileage;
        private Button btnManMileageRemoveMileage;
        private Button btnManAllowancesAllowanceRemove;
        private Button btnSolDietasSolKilometraje;
        private Label lbManAllowancesOptions;
    }
}