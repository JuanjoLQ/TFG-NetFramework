using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using capaDatos;
using capaEntidad;
using capaNegocio;
using System.IO;
using System.Collections;
using CapaNegocio;
using Bunifu.UI.WinForms;

namespace Tfg_NetFramework
{
    public partial class HomePage : Form
    {
        bool sidebarExpand;
        bool sidebarSubMenu;
        cnUser cnUser = new cnUser();
        cnAllowance cnAllowance = new cnAllowance();
        cnMileage cnMileage = new cnMileage();
        cnDgvAllowance cnDgvAllowance = new cnDgvAllowance();
        cnDgvMileage cnDgvMileage = new cnDgvMileage();
        cnDgvUser cnDgvUser = new cnDgvUser();
        cnPipelineFlps cnPipelineFlps = new cnPipelineFlps();
        cnLead cnLead = new cnLead();
        cnDgvCustomer cnDgvCustomer = new cnDgvCustomer();
        cnDgvLead cnDgvLead = new cnDgvLead();
        cnCustomer cnCustomer = new cnCustomer();
        cnDoBackup cnDoBackup = new cnDoBackup();
        cnRestoreBackUp cnRestoreBackUp = new cnRestoreBackUp();
        cnRole cnRole = new cnRole();
        cnDepartment cnDepartment = new cnDepartment();
        cnWarehouse cnWarehouse = new cnWarehouse();
        cnProduct cnProduct = new cnProduct();
        cnSale cnSale = new cnSale();

        cdGlobals cdGlobals = new cdGlobals();
        Hashtable pdfs = new Hashtable();

        string emailUser;

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            pSolicitudDieta.Visible = false;
            pUsuarios.Visible = false;
            pGestionDietas.Visible = false;
            pCRMGest.Visible = false;
            pInventory.Visible = false;

            pGestDietasDietas.Visible = false;
            pGestDietasKilometraje.Visible = false;

            StringBuilder sb = new StringBuilder("User: ", 50);
            sb.Append(ceGlobals.email);

            this.emailUser = ceGlobals.email;

            cdGlobals.setId(ceGlobals.email);

            lbUser.Text = sb.ToString();

            ceGlobals.role = cnUser.nameRole(ceGlobals.email);
            lbRole.Text = ceGlobals.role;
            if (ceGlobals.privileges[1] == 1)
            {
                pGestDietas.Visible = true;
                aux++;
            }
            if (ceGlobals.privileges[2] == 1)
            {
                pGestionUsers.Visible = true;
                aux++;
            }
            if (ceGlobals.privileges[3] == 1)
            {
                pSoliDietas.Visible = true;
                aux++;
            }
            aux++;
            aux++;
            aux++;

            containerModulos.MaximumSize = new Size(180, 37 + 55 * aux);
            containerModulos.Size = new Size(180, 37);

            cnUser.dgvUsers(dgvUser);

            cnDgvAllowance.dgvAllowance(dgvAllowances, pdfs);
            cnDgvMileage.dgvMileage(dgvMileage);

            pSolSolicitudDietas.Visible = false;
            pSolKilometraje.Visible = false;

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(ceGlobals.lang);
            GetLanguage();

            axAcroPDF1.Visible = false;

            cnRole.getRoles(this.cbRole);
            cnDepartment.getDepartments(this.cbDepartamento);

            cnRole.getRoles(this.cbUserNewRole);
            cnDepartment.getDepartments(this.cbUserNewDepartment);

            cdGlobals.newLogEntry(emailUser, "Inicio de sesión de " + emailUser);
        }

        private void GetLanguage()
        {
            translateBars();
            translateModules();
        }

        private void translateBars()
        {
            if (Res.Exit == "Salir")
            {
                btnGestUsers.Text = Res.pManUsers.Replace(" ", "\n");
                btnSolDietas.Text = Res.pSolAllowance.Replace(" ", "\n");
                btnGestDietas.Text = Res.pManAllowance.Replace(" ", "\n");
                btnSettings.Text = Res.pSettings;
            }
            else
            {
                btnGestUsers.Text = Res.pManUsers.Replace(" ", "\n");
                btnSolDietas.Text = Res.pSolAllowance.Replace(" ", "\n");
                btnGestDietas.Text = Res.pManAllowance.Replace(" ", "\n");
                btnSettings.Text = Res.pSettings;
            }
            btnSalirHome.Text = Res.Exit;
            btnSubMenu.Text = Res.modules;
            lbTitle.Text = Res.lbHomePage;
            lbRole.Text = Res.lbRole;
            lbUser.Text = Res.lbUser;
            lbMenu.Text = Res.lbMenu;

        }

        private void translateModules()
        {
            translateUsers();
            translateSolAllowances();
            translateManageAllowances();
            translateCrm();
            translateInventory();
            translateSettings();
        }

        private void translateUsers()
        {
            // Labels
            lbGestUsers.Text = "<h2>" + Res.lbGestUsers + "</h2>";
            lbRegisterUser.Text = "<h3>" + Res.lbRegisterUser + "</h3>";

            //lbIdUser
            //lbEmail
            //lbPassword
            //lbDepartment
            //lbJob

            // Textboxs
            tbREmail.PlaceholderText = Res.Email;
            tbRPassword.PlaceholderText = Res.Pass;

            tbIdUser.PlaceholderText = Res.idUser;
            tbEmail.PlaceholderText = Res.Email;

            //tbEmail.PlaceholderText(Res.Email);
            tbPassword.PlaceholderText = Res.Pass;
            tbDepartment.PlaceholderText = Res.department;
            //tbIdUser.start(Res.idUser);
            tbJob.PlaceholderText = Res.job;

            // Buttons
            btnRRegistrar.Text = Res.btnRegistrar;
            btnUpdateDtgUsers.Text = Res.updateTable;
            btnEliminarUser.Text = Res.removeUser;

            // dgvUser
            dgvUser.Columns[0].HeaderText = Res.idUser;
            dgvUser.Columns[1].HeaderText = Res.Email;
            dgvUser.Columns[2].HeaderText = Res.Pass;
            dgvUser.Columns[3].HeaderText = Res.department;
            dgvUser.Columns[4].HeaderText = Res.job;

        }

        private void translateSolAllowances()
        {
            lbTitleSolDieta.Text = "<h2>" + Res.lbTitleReqAllowances + "</h2>";
            lbReqAllowancesOptions.Text = "<h3>" + Res.lbReqAllowancesOptions + "</h3>";

            // Allowances
            // Labels
            lbReqAllowancesTitleAllowances.Text = "<h3>" + Res.allowances + "</h3>";
            lbReqAllowancesTitle.Text = "<h4>" + Res.title + "</h4>";
            lbReqAllowancesObservations.Text = "<h4>" + Res.observations + "</h4>";
            lbReqAllowancesStartHour.Text = "<h4>" + Res.startHour + "</h4>";
            lbReqAllowancesEndHour.Text = "<h4>" + Res.endHour + "</h4>";
            lbReqAllowancesDate.Text = "<h4>" + Res.date + "</h4>";

            // TextBoxs
            tbReqAllowancesTitle.PlaceholderText = Res.title;
            tbReqAllowancesObservations.PlaceholderText = Res.observations;

            // Buttons
            btnReqAllowancesUploadFile.Text = Res.UploadFile;
            btnRequestAllowances.Text = Res.requestAllowance;

            // Mileages
            // Labels
            lbMileageTitle.Text = "<h3>" + Res.mileage + "</h3>";
            lbReqMileage.Text = "<h3>" + Res.mileage + "</h3>";
            lbTitleMileage.Text = "<h3>" + Res.title + "</h3>";
            lbReqMileageDate.Text = "<h3>" + Res.date + "</h3>";
            lbReqMileageSubcategory.Text = "<h3>" + Res.subcategory + "</h3>";
            lbReqMileageOrigin.Text = "<h3>" + Res.origin + "</h3>";
            lbReqMileageDestination.Text = "<h3>" + Res.destination + "</h3>";
            lbReqMileageTotal.Text = "<h3>" + Res.total + "</h3>";
            lbReqMileagePricePerKilometer.Text = "<h3>" + Res.pricePerKilometer + "</h3>";

            // Textboxs
            tbReqMileageMileage.PlaceholderText = Res.kilometers;
            tbReqMileageTitle.PlaceholderText = Res.title;
            tbReqMileageOrigin.PlaceholderText = Res.origin;
            tbReqMileageDestination.PlaceholderText = Res.destination;
            tbReqMileageTotal.PlaceholderText = Res.total;
            tbReqMileagePricePerKilometer.PlaceholderText = Res.pricePerKilometer;

            // Button
            btnSolDietasSolKilometraje.Text = Res.requestMileage;

        }

        private void translateManageAllowances()
        {
            lbManAllowances.Text = "<h2>" + Res.manageAllowances + "</h2>";
            lbManAllowancesOptions.Text = "<h3>" + Res.lbReqAllowancesOptions + "</h3>";

            // Allowances
            lbTitleManAllowance.Text = "<h2>" + Res.allowances + "</h2>";

            // dgvAllowances
            dgvAllowances.Columns[0].HeaderText = Res.idAllowance;
            dgvAllowances.Columns[1].HeaderText = Res.Email;
            dgvAllowances.Columns[2].HeaderText = Res.title;
            dgvAllowances.Columns[3].HeaderText = Res.observations;
            dgvAllowances.Columns[4].HeaderText = Res.date;
            dgvAllowances.Columns[5].HeaderText = Res.startHour;
            dgvAllowances.Columns[6].HeaderText = Res.endHour;
            dgvAllowances.Columns[7].HeaderText = Res.invoice;
            dgvAllowances.Columns[8].HeaderText = Res.state;

            // Labels
            lbManAllowancesEmail.Text = "<h3>" + Res.Email + "</h3>";
            lbManAllowancesTitle.Text = "<h3>" + Res.title + "</h3>";
            lbManAllowanceObservation.Text = "<h3>" + Res.observations + "</h3>";
            lbManAllowancesDate.Text = "<h3>" + Res.date + "</h3>";
            lbManAllowancesStartHour.Text = "<h3>" + Res.startHour + "</h3>";
            lbManAllowanceEndHour.Text = "<h3>" + Res.endHour + "</h3>";
            lbManAllowanceState.Text = "<h3>" + Res.state + "</h3>";
            lbManAllowanceNewState.Text = "<h3>" + Res.newState + "</h3>";
            lbManAllowancesIdAllowance.Text = "<h3>" + Res.idAllowance + "</h3>";

            // Textboxs
            tbManAllowancesEmail.PlaceholderText = Res.Email;
            tbManAllowancesTitle.PlaceholderText = Res.title;
            tbManAllowancesObservations.PlaceholderText = Res.observations;
            tbManAllowancesDate.PlaceholderText = Res.date;
            tbManAllowancesStartHour.PlaceholderText = Res.startHour;
            tbManAllowancesEndHour.PlaceholderText = Res.endHour;
            tbManAllowancesState.PlaceholderText = Res.state;
            tbManAllowancesIdAllowance.PlaceholderText = Res.idAllowance;

            // Buttons
            btnManAllowancesDietasRefresh.Text = Res.updateTable;
            btnManAllowancesUpdateData.Text = Res.updateAllowance;
            btnManAllowancesAllowanceRemove.Text = Res.removeAllowance;

            // Mileages
            lbTitleManMileage.Text = "<h2>" + Res.mileage + "</h2>";

            // dgvMileage
            dgvMileage.Columns[0].HeaderText = Res.idMileage;
            dgvMileage.Columns[1].HeaderText = Res.Email;
            dgvMileage.Columns[2].HeaderText = Res.title;
            dgvMileage.Columns[3].HeaderText = Res.date;
            dgvMileage.Columns[4].HeaderText = Res.subcategory;
            dgvMileage.Columns[5].HeaderText = Res.origin;
            dgvMileage.Columns[6].HeaderText = Res.destination;
            dgvMileage.Columns[7].HeaderText = Res.kilometers;
            dgvMileage.Columns[8].HeaderText = Res.pricePerKilometer;
            dgvMileage.Columns[9].HeaderText = Res.final;
            dgvMileage.Columns[10].HeaderText = Res.state;

            // Labels
            lbManMileageEmail.Text = "<h3>" + Res.Email + "</h3>";
            lbManMileageTitle.Text = "<h3>" + Res.title + "</h3>";
            lbManMileageDate.Text = "<h3>" + Res.date + "</h3>";
            lbManMileageSubcategory.Text = "<h3>" + Res.subcategory + "</h3>";
            lbManMileageIdMileage.Text = "<h3>" + Res.idMileage + "</h3>";
            lbManMileageOrigin.Text = "<h3>" + Res.origin + "</h3>";
            lbManMileageDestination.Text = "<h3>" + Res.destination + "</h3>";
            lbManMileageKilometers.Text = "<h3>" + Res.kilometers + "</h3>";
            lbManMileagePricePerKilometer.Text = "<h3>" + Res.pricePerKilometer + "</h3>";
            lbManMileageFinal.Text = "<h3>" + Res.final + "</h3>";
            lbManMileageState.Text = "<h3>" + Res.state + "</h3>";
            lbManMileageNewState.Text = "<h3>" + Res.newState + "</h3>";

            // Textboxs
            tbManMileageEmail.PlaceholderText = Res.Email;
            tbManMileageTitle.PlaceholderText = Res.title;
            tbManMileageDate.PlaceholderText = Res.date;
            tbManMileageSubcategory.PlaceholderText = Res.subcategory;
            tbManMileageIdMileage.PlaceholderText = Res.idMileage;
            tbManMileageOrigin.PlaceholderText = Res.origin;
            tbManMileageDestination.PlaceholderText = Res.destination;
            tbManMileageKilometers.PlaceholderText = Res.kilometers;
            tbManMileagePricePerKilometer.PlaceholderText = Res.pricePerKilometer;
            tbManMileageFinal.PlaceholderText = Res.final;
            tbManMileageState.PlaceholderText = Res.state;

            // Buttons
            btnManMileageRefreshDgvMileage.Text = Res.updateTable;
            btnManMileageUpdateStateMileage.Text = Res.updateMileage;
            btnManMileageRemoveMileage.Text = Res.removeMileage;

        }

        private void translateCrm()
        {
            // Labels Pipeline
            lbNew.Text = "<h2>" + Res.new + "</h2>";
            lbQualified.Text = "<h2>" + Res.qualified + "</h2>";
            lbProposition.Text = "<h2>" + Res.proposition + "</h2>";
            lbWon.Text = "<h2>" + Res.won + "</h2>";
            lbSales.Text = "<h2>" + Res.sales + "</h2>";

            // Buttons Pipeline
            btnPipelineAddLead.Text = Res.addLeadToPipeline;
            btnUpdateFlps.Text = Res.updatePipeline;

            // Labels Customers
            blbCrmTitleCustomers.Text = "<h2>" + Res.customers + "</h2>";
            lbDateStart.Text = "<h3>" + Res.startDate + "</h3>";
            lbDateEnd.Text = "<h3>" + Res.endDate + "</h3>";
            blbCrmTitleLeads.Text = "<h2>" + "" + "</h2>";
            lbCustomerName.Text = "<h3>" + Res.nameCustomer + "</h3>";
            lbStateDateLead.Text = "<h3>" + "" + "</h3>";

            // Buttons Customers
            btnCustomersAddCustomers.Text = Res.addCustomer;
            btnCustomersRemoveCustomers.Text = Res.deleteCustomer;
            btnUpdateDgvCustomer.Text = Res.updateTable;

        }

        private void translateInventory()
        {
            // Labels Inventory
            lbInventory.Text = "<h2>" + Res.inventory + "</h2>";
            blbTitleStateProducts.Text = "<h3>" + Res.storedProducts + "</h3>";
            blbTitleProductsAboutType.Text = "<h3>" + Res.warehouses + "</h3>";
            blbAmountUpdate.Text = "<h4>" + Res.quantityToStore + " </4h>";
            blbMaxQuantity.Text = "<h4>" + Res.max + "</h4>";

            // TextBoxs
            btbStoreAmount.PlaceholderText = Res.quantityToStore;

            // Buttons
            bbtnAddProductToWarehouse.Text = Res.addNewProduct;
            bbtnAddProductToWarehouse.Text = Res.addProductToWarehouse;

        }

        private void translateSettings()
        {
            // Labels
            lbSettings.Text = "<h2>" + Res.settings + "</h2>";

            // Buttons
            btnSettingsSaveBackup.Text = Res.doBackUp;
            btnRestoreBackup.Text = Res.restoreBackUp;

        }

        // Define min and max size of sizebar
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void timerSubMenu_Tick(object sender, EventArgs e)
        {
            if (sidebarSubMenu)
            {
                containerModulos.Height -= 5;
                if (containerModulos.Height == containerModulos.MinimumSize.Height)
                {
                    sidebarSubMenu = false;
                    timerSubMenu.Stop();
                }
            }
            else
            {
                containerModulos.Height += 5;
                if (containerModulos.Height == containerModulos.MaximumSize.Height)
                {
                    sidebarSubMenu = true;
                    timerSubMenu.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnSubMenu_Click(object sender, EventArgs e)
        {
            timerSubMenu.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pUsuarios.Visible = false;
            pSolicitudDieta.Visible = false;
            pGestionDietas.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         
            .----------------.  .----------------.  .----------------.  .----------------.  .----------------. 
        | .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
        | | _____  _____ | || |    _______   | || |  _________   | || |  _______     | || |    _______   | |
        | ||_   _||_   _|| || |   /  ___  |  | || | |_   ___  |  | || | |_   __ \    | || |   /  ___  |  | |
        | |  | |    | |  | || |  |  (__ \_|  | || |   | |_  \_|  | || |   | |__) |   | || |  |  (__ \_|  | |
        | |  | '    ' |  | || |   '.___`-.   | || |   |  _|  _   | || |   |  __ /    | || |   '.___`-.   | |
        | |   \ `--' /   | || |  |`\____) |  | || |  _| |___/ |  | || |  _| |  \ \_  | || |  |`\____) |  | |
        | |    `.__.'    | || |  |_______.'  | || | |_________|  | || | |____| |___| | || |  |_______.'  | |
        | |              | || |              | || |              | || |              | || |              | |
        | '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
            '----------------'  '----------------'  '----------------'  '----------------'  '----------------' 

         */

        private void btnRRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string role, departament;
                ceUser user = new ceUser(0, tbREmail.Text, tbRPassword.Text);

                role = cbRole.SelectedItem == null ? String.Empty :
                    cbRole.SelectedItem.ToString();

                departament = cbDepartamento.SelectedItem == null ? String.Empty :
                    cbDepartamento.SelectedItem.ToString();

                if (cnUser.ValidarDatos(user) == false || role == string.Empty || departament == string.Empty)
                {
                    MessageBox.Show("Faltan por rellenar campos");
                    return;
                }
                if (cnUser.CrearUser(user, role, departament))
                {
                    MessageBox.Show("Usuario creado con éxito.");
                    cdGlobals.newLogEntry(emailUser, "Usuario creado");

                    tbREmail.Text = "";
                    tbRPassword.Text = "";
                    cbRole.SelectedItem = string.Empty;
                    cbDepartamento.SelectedItem = string.Empty;
                }
                else
                {
                    MessageBox.Show("Usuario NO creado con éxito");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo");
                throw;
            }
        }

        private void btnGestUser_Click(object sender, EventArgs e)
        {
            pUsuarios.Visible = true;
            pGestionDietas.Visible = false;
            pSolicitudDieta.Visible = false;
            pCRMGest.Visible = false;
            pSettingsModule.Visible = false;
            pInventory.Visible = false;
        }

        private void btnSolDietas_Click(object sender, EventArgs e)
        {
            pUsuarios.Visible = false;
            pGestionDietas.Visible = false;
            pSolicitudDieta.Visible = true;
            pCRMGest.Visible = false;
            pSettingsModule.Visible = false;
            pInventory.Visible = false;
        }

        private void btnGestDietas_Click(object sender, EventArgs e)
        {
            pUsuarios.Visible = false;
            pGestionDietas.Visible = true;
            pSolicitudDieta.Visible = false;
            pCRMGest.Visible = false;
            pSettingsModule.Visible = false;
            pInventory.Visible = false;
        }

        private void btnCRM_Click(object sender, EventArgs e)
        {
            pUsuarios.Visible = false;
            pGestionDietas.Visible = false;
            pSolicitudDieta.Visible = false;
            pCRMGest.Visible = true;
            pSettingsModule.Visible = false;
            pInventory.Visible = false;
        }

        private void btnModuleAux_Click(object sender, EventArgs e)
        {
            pSettingsModule.Visible = false;
            pUsuarios.Visible = false;
            pGestionDietas.Visible = false;
            pSolicitudDieta.Visible = false;
            pCRMGest.Visible = false;
            pInventory.Visible = true;
        }

        private void dgvKilometraje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdUser.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            //tbIdUser.defectColor(Color.Black);
            tbEmail.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            //tbEmail.defectColor(Color.Black);
            tbPassword.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            //tbPassword.defectColor(Color.Black);
            tbDepartment.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            //tbDepartment.defectColor(Color.Black);
            tbJob.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
            //tbJob.defectColor(Color.Black);
        }

        private void dgvDietas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbManAllowancesIdAllowance.Text = dgvAllowances.CurrentRow.Cells[0].Value.ToString();
            tbManAllowancesEmail.Text = dgvAllowances.CurrentRow.Cells[1].Value.ToString();
            tbManAllowancesTitle.Text = dgvAllowances.CurrentRow.Cells[2].Value.ToString();
            tbManAllowancesObservations.Text = dgvAllowances.CurrentRow.Cells[3].Value.ToString();
            tbManAllowancesDate.Text = dgvAllowances.CurrentRow.Cells[4].Value.ToString();
            tbManAllowancesStartHour.Text = dgvAllowances.CurrentRow.Cells[5].Value.ToString();
            tbManAllowancesEndHour.Text = dgvAllowances.CurrentRow.Cells[6].Value.ToString();
            tbManAllowancesState.Text = dgvAllowances.CurrentRow.Cells[8].Value.ToString();
        }

        private void dgvKilometraje_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbManMileageIdMileage.Text = dgvMileage.CurrentRow.Cells[0].Value.ToString();
            tbManMileageEmail.Text = dgvMileage.CurrentRow.Cells[1].Value.ToString();
            tbManMileageTitle.Text = dgvMileage.CurrentRow.Cells[2].Value.ToString();
            tbManMileageDate.Text = dgvMileage.CurrentRow.Cells[3].Value.ToString();
            tbManMileageSubcategory.Text = dgvMileage.CurrentRow.Cells[4].Value.ToString();
            tbManMileageOrigin.Text = dgvMileage.CurrentRow.Cells[5].Value.ToString();
            tbManMileageDestination.Text = dgvMileage.CurrentRow.Cells[6].Value.ToString();
            tbManMileageKilometers.Text = dgvMileage.CurrentRow.Cells[7].Value.ToString();
            tbManMileagePricePerKilometer.Text = dgvMileage.CurrentRow.Cells[8].Value.ToString();
            tbManMileageFinal.Text = dgvMileage.CurrentRow.Cells[9].Value.ToString();
            tbManMileageState.Text = dgvMileage.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string newDepartment = cbUserNewDepartment.SelectedItem == null ? String.Empty :
                    cbUserNewDepartment.SelectedItem.ToString();
            string newRole = cbUserNewRole.SelectedItem == null ? String.Empty :
                    cbUserNewRole.SelectedItem.ToString();

            if (email != string.Empty && password != string.Empty)
            {
                if (newDepartment == string.Empty)
                {
                    newDepartment = tbDepartment.Text;
                }
                if (newRole == string.Empty)
                {
                    newRole = tbJob.Text;
                }

                ceUser user = new ceUser(int.Parse(tbIdUser.Text), email, password, newDepartment, newRole);
                cnUser.updateUser(user);

                btnUpdateDtgUsers_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No ha rellenado todos los campos correspondientes");
            }

        }

        /*
        
         .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .-----------------. .----------------.  .----------------.  .----------------. 
        | .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
        | |      __      | || |   _____      | || |   _____      | || |     ____     | || | _____  _____ | || |      __      | || | ____  _____  | || |     ______   | || |  _________   | || |    _______   | |
        | |     /  \     | || |  |_   _|     | || |  |_   _|     | || |   .'    `.   | || ||_   _||_   _|| || |     /  \     | || ||_   \|_   _| | || |   .' ___  |  | || | |_   ___  |  | || |   /  ___  |  | |
        | |    / /\ \    | || |    | |       | || |    | |       | || |  /  .--.  \  | || |  | | /\ | |  | || |    / /\ \    | || |  |   \ | |   | || |  / .'   \_|  | || |   | |_  \_|  | || |  |  (__ \_|  | |
        | |   / ____ \   | || |    | |   _   | || |    | |   _   | || |  | |    | |  | || |  | |/  \| |  | || |   / ____ \   | || |  | |\ \| |   | || |  | |         | || |   |  _|  _   | || |   '.___`-.   | |
        | | _/ /    \ \_ | || |   _| |__/ |  | || |   _| |__/ |  | || |  \  `--'  /  | || |  |   /\   |  | || | _/ /    \ \_ | || | _| |_\   |_  | || |  \ `.___.'\  | || |  _| |___/ |  | || |  |`\____) |  | |
        | ||____|  |____|| || |  |________|  | || |  |________|  | || |   `.____.'   | || |  |__/  \__|  | || ||____|  |____|| || ||_____|\____| | || |   `._____.'  | || | |_________|  | || |  |_______.'  | |
        | |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | |
        | '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
         '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' 

        */

        private void cbGestDietas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbGestDietas.SelectedItem.Equals("Dietas"))
            {
                pGestDietasDietas.Visible = true;
                pGestDietasKilometraje.Visible = false;
            }
            else
            {
                pGestDietasDietas.Visible = false;
                pGestDietasKilometraje.Visible = true;
            }
        }

        private void cbSolicitudDietas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbSolicitudDietas.SelectedItem.Equals("Dietas"))
            {
                pSolSolicitudDietas.Visible = true;
                pSolKilometraje.Visible = false;
            }
            else
            {
                pSolSolicitudDietas.Visible = false;
                pSolKilometraje.Visible = true;
            }
        }

        private void mtbStartTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string[] arr = mtbReqAllowancesStartHour.Text.Split(':');
                int hours = int.Parse(arr[0].ToString());
                int mins = int.Parse(arr[1].ToString());
                DateTime time = Convert.ToDateTime(mtbReqAllowancesStartHour.Text).AddHours(hours).AddMinutes(mins);
                tbReqAllowancesTitle.Text = time.ToString("hh:mm");
            }
        }

        private void mtbStartTime_Click(object sender, EventArgs e)
        {
            mtbReqAllowancesStartHour.SelectionStart = 0;
        }

        private void mtbReqAllowancesEndHour_Click(object sender, EventArgs e)
        {
            mtbReqAllowancesEndHour.SelectionStart = 0;
        }

        private void mtbStartTime_Leave(object sender, EventArgs e)
        {
            char[] arr = mtbReqAllowancesStartHour.Text.ToCharArray(0, 5);

            if (int.Parse(arr[0].ToString()) > 2 || int.Parse(arr[1].ToString()) > 4 || int.Parse(arr[3].ToString()) > 5)
            {
                mtbReqAllowancesStartHour.Text = "";
                MessageBox.Show("Fecha no válida");
            }
        }

        private void mtbEndTime_Leave(object sender, EventArgs e)
        {
            char[] arr = mtbReqAllowancesEndHour.Text.ToCharArray(0, 5);

            if (int.Parse(arr[0].ToString()) > 2 || int.Parse(arr[1].ToString()) > 4 || int.Parse(arr[3].ToString()) > 5)
            {
                mtbReqAllowancesStartHour.Text = "";
                MessageBox.Show("Fecha no válida");
            }
        }

        private void btnUpdateDtgUsers_Click(object sender, EventArgs e)
        {
            dgvUser.Update();
            dgvUser.Refresh();
            cnUser.dgvUsers(dgvUser);
            tbDepartment.Text = string.Empty;
            tbJob.Text = string.Empty;
            tbIdUser.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbEmail.Text = string.Empty;
        }

        private void btnGestDietasDietasRefresh_Click(object sender, EventArgs e)
        {
            dgvAllowances.Update();
            dgvAllowances.Refresh();
            cnDgvAllowance.dgvAllowance(dgvAllowances, pdfs);
            dgvUser.Update();
            dgvUser.Refresh();
            cnUser.dgvUsers(dgvUser);
            tbManAllowancesEmail.Text = string.Empty;
            tbManAllowancesTitle.Text = string.Empty;
            tbManAllowancesObservations.Text = string.Empty;
            tbManAllowancesDate.Text = string.Empty;
            tbManAllowancesStartHour.Text = string.Empty;
            tbManAllowancesEndHour.Text = string.Empty;
            tbManAllowancesState.Text = string.Empty;
            tbManAllowancesIdAllowance.Text = string.Empty;
            cbStateDietas.Text = string.Empty;
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            string idUser = dgvUser.CurrentRow.Cells[0].Value.ToString();

            if (cnUser.delUser(int.Parse(idUser)))
            {
                tbDepartment.Text = string.Empty;
                tbJob.Text = string.Empty;
                tbIdUser.Text = string.Empty;
                tbPassword.Text = string.Empty;
                tbEmail.Text = string.Empty;
                cdGlobals.newLogEntry(emailUser, "Usuario eliminado");
                MessageBox.Show("Usuario eliminado");
            }
        }

        //string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        //public void UploadFile(String file)
        //{
        //    MySqlConnection conn = new MySqlConnection(cadenaConexion);
        //    MySqlCommand cmd;
        //    conn.Open();

        //    /*
        //    System.IO.FileStream fileStream = File.OpenRead(file);
        //    byte[] contents = new byte[fileStream.Length];
        //    fileStream.Read(contents, 0, (int)fileStream.Length);
        //    fileStream.Close();
        //    */

        //    //
        //    string name = Path.GetFileName(fileName);
        //    string newPath = @"C:\Users\Jesus\Tfg Net Framework\Tfg NetFramework\files\";
        //    string locationCopy = newPath + name;
        //    MessageBox.Show("Location Copy: " + locationCopy + "\nFileName: " + fileName);

        //    if (File.Exists(fileName))
        //    {
        //        File.Copy(fileName, locationCopy, true);
        //        MessageBox.Show("File Copied");
        //    }
        //    //

        //    using (cmd = new MySqlCommand("insert into allowance(User_idUser, Title, Observations, State, StartTime, StartHour, EndHour, Invoice) " +
        //        "values(@idUser, @title, @observations, @state, @startTime, @startHour, @endHour, @invoice)", conn))
        //    {
        //        cmd.Parameters.AddWithValue("@idUser", cnUser.idUser(ceGlobals.email));
        //        cmd.Parameters.AddWithValue("@title", tbReqAllowancesTitle.Text);
        //        cmd.Parameters.AddWithValue("@observations", tbReqAllowancesObservations.Text);
        //        cmd.Parameters.AddWithValue("@state", "Solicitado");
        //        cmd.Parameters.AddWithValue("@startTime", dtpReqAllowancesStartTime.Text);
        //        cmd.Parameters.AddWithValue("@startHour", mtbReqAllowancesStartHour.Text);
        //        cmd.Parameters.AddWithValue("@endHour", mtbReqAllowancesEndHour.Text);
        //        cmd.Parameters.AddWithValue("@invoice", locationCopy);
        //        cmd.ExecuteNonQuery();
        //    }
        //    MessageBox.Show("Finished uploading files", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    conn.Close();
        //}

        private string fileName = "";
        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofdUpload = new OpenFileDialog() { Filter = "Text Documents (*.pdf;) |*.pdf", ValidateNames = true })
            {
                if (ofdUpload.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure want to upload this files?", "Juanjo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        fileName = ofdUpload.FileName; // Ruta absoluta del archivo
                        cdGlobals.newLogEntry(emailUser, "Dieta: Archivo seleccionado");
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void btnSolDieta_Click(object sender, EventArgs e)
        {
            if (!tbReqAllowancesTitle.Equals("") && !tbReqAllowancesObservations.Equals("") && !dtpReqAllowancesStartTime.Equals("")
                && !mtbReqAllowancesStartHour.Equals("") && !mtbReqAllowancesEndHour.Equals("") && !fileName.Equals(""))
            {
                ceAllowance allowance = new ceAllowance(0, int.Parse(cnUser.idUser(ceGlobals.email)), tbReqAllowancesTitle.Text,
                    tbReqAllowancesObservations.Text, "Solicitado", dtpReqAllowancesStartTime.Text, null, mtbReqAllowancesStartHour.Text, mtbReqAllowancesEndHour.Text,
                     "");
                cnAllowance.uploadFile(allowance, fileName);
                //UploadFile(fileName);
                cdGlobals.newLogEntry(emailUser, "Dieta solicitada");
            }
            else
            {
                MessageBox.Show("Dieta no subida");
            }
        }

        private void btnSalirHome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbStateDietas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbManAllowancesState.Text = cbStateDietas.SelectedItem.ToString();
        }

        private void btnGestDietasUpdate_Click(object sender, EventArgs e)
        {
            cnAllowance.updateAllowance(int.Parse(dgvAllowances.CurrentRow.Cells[0].Value.ToString()), tbManAllowancesState.Text);
            cdGlobals.newLogEntry(emailUser, "Dieta modificada");
            tbManAllowancesEmail.Text = string.Empty;
            tbManAllowancesTitle.Text = string.Empty;
            tbManAllowancesObservations.Text = string.Empty;
            tbManAllowancesDate.Text = string.Empty;
            tbManAllowancesStartHour.Text = string.Empty;
            tbManAllowancesEndHour.Text = string.Empty;
            tbManAllowancesState.Text = string.Empty;
            tbManAllowancesIdAllowance.Text = string.Empty;
            cbStateDietas.Text = string.Empty;
        }

        private void btnAllowanceRemove_Click(object sender, EventArgs e)
        {
            cnAllowance.deleteAllowance(int.Parse(dgvAllowances.CurrentRow.Cells[0].Value.ToString()));
            cdGlobals.newLogEntry(emailUser, "Dieta eliminada");
            dgvUser.Update();
            dgvUser.Refresh();
            cnUser.dgvUsers(dgvUser);
            tbManAllowancesEmail.Text = string.Empty;
            tbManAllowancesTitle.Text = string.Empty;
            tbManAllowancesObservations.Text = string.Empty;
            tbManAllowancesDate.Text = string.Empty;
            tbManAllowancesStartHour.Text = string.Empty;
            tbManAllowancesEndHour.Text = string.Empty;
            tbManAllowancesState.Text = string.Empty;
            tbManAllowancesIdAllowance.Text = string.Empty;
            cbStateDietas.Text = string.Empty;
        }

        /*

         .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------. 
        | .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
        | | ____    ____ | || |     _____    | || |   _____      | || |  _________   | || |      __      | || |    ______    | || |  _________   | || |    _______   | |
        | ||_   \  /   _|| || |    |_   _|   | || |  |_   _|     | || | |_   ___  |  | || |     /  \     | || |  .' ___  |   | || | |_   ___  |  | || |   /  ___  |  | |
        | |  |   \/   |  | || |      | |     | || |    | |       | || |   | |_  \_|  | || |    / /\ \    | || | / .'   \_|   | || |   | |_  \_|  | || |  |  (__ \_|  | |
        | |  | |\  /| |  | || |      | |     | || |    | |   _   | || |   |  _|  _   | || |   / ____ \   | || | | |    ____  | || |   |  _|  _   | || |   '.___`-.   | |
        | | _| |_\/_| |_ | || |     _| |_    | || |   _| |__/ |  | || |  _| |___/ |  | || | _/ /    \ \_ | || | \ `.___]  _| | || |  _| |___/ |  | || |  |`\____) |  | |
        | ||_____||_____|| || |    |_____|   | || |  |________|  | || | |_________|  | || ||____|  |____|| || |  `._____.'   | || | |_________|  | || |  |_______.'  | |
        | |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | |
        | '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
         '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' 

        */

        private void cbMileageState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbManMileageState.Text = cbManMileageNewState.SelectedItem.ToString();
        }

        private void btnUpdateStateMileage_Click(object sender, EventArgs e)
        {
            cnMileage.updateMileage(int.Parse(dgvMileage.CurrentRow.Cells[0].Value.ToString()), tbManMileageState.Text);
            cdGlobals.newLogEntry(emailUser, "Kilometraje actualizado");
        }

        private void btnRefreshDgvMileage_Click(object sender, EventArgs e)
        {
            dgvMileage.Update();
            dgvMileage.Refresh();
            cnDgvMileage.dgvMileage(dgvMileage);

            tbManMileageEmail.Text = string.Empty;
            tbManMileageTitle.Text = string.Empty;
            tbManMileageDate.Text = string.Empty;
            tbManMileageSubcategory.Text = string.Empty;
            tbManMileageIdMileage.Text = string.Empty;
            tbManMileageOrigin.Text = string.Empty;
            tbManMileageDestination.Text = string.Empty;
            tbManMileageKilometers.Text = string.Empty;
            tbManMileagePricePerKilometer.Text = string.Empty;
            tbManMileageFinal.Text = string.Empty;
            tbManMileageState.Text = string.Empty;
            cbManMileageNewState.Text = string.Empty;
        }

        private void btnKilometrajeEliminar_Click(object sender, EventArgs e)
        {
            cnMileage.deleteMileage(int.Parse(dgvMileage.CurrentRow.Cells[0].Value.ToString()));
            cdGlobals.newLogEntry(emailUser, "Kilometraje eliminado");

            tbManMileageEmail.Text = string.Empty;
            tbManMileageTitle.Text = string.Empty;
            tbManMileageDate.Text = string.Empty;
            tbManMileageSubcategory.Text = string.Empty;
            tbManMileageIdMileage.Text = string.Empty;
            tbManMileageOrigin.Text = string.Empty;
            tbManMileageDestination.Text = string.Empty;
            tbManMileageKilometers.Text = string.Empty;
            tbManMileagePricePerKilometer.Text = string.Empty;
            tbManMileageFinal.Text = string.Empty;
            tbManMileageState.Text = string.Empty;
            cbManMileageNewState.Text = string.Empty;
        }

        private void btnSolDietasSolKilometraje_Click(object sender, EventArgs e)
        {
            cnMileage.insertMileage(new ceMileage(0, int.Parse(ceGlobals.id),
                tbReqMileageTitle.Text, dtpReqDietasMileageDate.Text, cbReqMileageSubCategory.SelectedItem.ToString(),
                tbReqMileageOrigin.Text, tbReqMileageDestination.Text, float.Parse(tbReqMileageMileage.Text),
                float.Parse(tbReqMileagePricePerKilometer.Text), float.Parse(tbReqMileageTotal.Text), "Solicitado"));
            cdGlobals.newLogEntry(emailUser, "Kilometraje solicitado");
        }

        private void cbMileageSubCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbReqMileageSubCategory.SelectedItem.ToString() == "Vehículo propio")
            {
                tbReqMileagePricePerKilometer.Text = "0,17";
            }
            else
            {
                tbReqMileagePricePerKilometer.Text = "0,13";
            }
            tbSolMileageMileage_Leave(sender, e);
        }

        private void tbSolMileageMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbSolMileageMileage_Leave(object sender, EventArgs e)
        {
            if (tbReqMileageMileage.Text != string.Empty && tbReqMileagePricePerKilometer.Text != string.Empty)
            {
                tbReqMileageTotal.Text = (float.Parse(tbReqMileageMileage.Text) * float.Parse(tbReqMileagePricePerKilometer.Text)).ToString("0.00€");
            }
        }

        private void dgvAllowances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAllowances.Columns[e.ColumnIndex].Name == "invoice")
            {
                pGestDietasDietas.AutoScroll = false;
                pGestDietasDietas.HorizontalScroll.Enabled = false;
                pGestDietasDietas.HorizontalScroll.Visible = false;
                pGestDietasDietas.HorizontalScroll.Maximum = 0;
                pGestDietasDietas.AutoScroll = true;

                axAcroPDF1.Visible = true;
                axAcroPDF1.src = pdfs[dgvAllowances.CurrentRow.Cells[0].Value.ToString()].ToString();
                axAcroPDF1.src = pdfs[dgvAllowances.CurrentRow.Cells[0].Value.ToString()].ToString();
            }

        }

        /*
         .----------------.  .----------------.  .----------------. 
        | .--------------. || .--------------. || .--------------. |
        | |     ______   | || |  _______     | || | ____ ____ | |
        | |   .' ___  |  | || | |_   __ \    | || ||_   \  /   _|| |
        | |  / .'   \_|  | || |   | |__) |   | || |  |   \/   |  | |
        | |  | |         | || |   |  __ /    | || |  | |\  /| |  | |
        | |  \ `.___.'\  | || |  _| |  \ \_  | || | _| |_\/_| |_ | |
        | |   `._____.'  | || | |____| |___| | || ||_____||_____|| |
        | |              | || |              | || |              | |
        | '--------------' || '--------------' || '--------------' |
         '----------------'  '----------------'  '----------------' 
        */

        private int aux = 0;

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void flp_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string)))
                return;

            var name = e.Data.GetData(typeof(string)) as string;
            var control = this.Controls.Find(name, true).FirstOrDefault();
            if (control != null)
            {
                e.Effect = DragDropEffects.Move;

            }
        }

        private void flp_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string)))
                return;

            var name = e.Data.GetData(typeof(string)) as string;
            var control = this.Controls.Find(name, true).FirstOrDefault();

            if (flpNew.Controls.Contains(control))
            {
                flpNew.Controls.Remove(control);
            }

            if (control != null)
            {
                var panel = sender as FlowLayoutPanel;
                ((FlowLayoutPanel)sender).Controls.Add(control);
            }
        }

        private void btnPipelineAddLead_Click(object sender, EventArgs e)
        {
            Form newLead = new newLead(emailUser);

            newLead.Show();

        }

        private void btnCustomersAddCustomers_Click(object sender, EventArgs e)
        {
            Form newCustomer = new newCustomer(emailUser);

            newCustomer.Show();
        }

        private void btnCustomersRemoveCustomers_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Si eliminas un customer también se eliminarán los leads asociados",
                "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string idCustomer = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
                if (idCustomer != null)
                {
                    cnCustomer.deleteCustomer(int.Parse(idCustomer));
                    dgvCustomer_Lead.RowCount = 0;
                    btnUpdateDgvCustomer_Click(sender, e);
                    cdGlobals.newLogEntry(emailUser, "Customer y leads asociados eliminados");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void stageNew(ItemList item)
        {
            flpNew.Controls.Add(item);
        }

        private void btnUpdateFlps_Click(object sender, EventArgs e)
        {
            flpNew.Controls.Clear();
            flpQualified.Controls.Clear();
            flpProposition.Controls.Clear();
            flpWon.Controls.Clear();
            flpSale.Controls.Clear();

            ArrayList arrayDescrItemList = new ArrayList();
            arrayDescrItemList = cnPipelineFlps.updateFpls();
            MessageBox.Show(arrayDescrItemList.Count.ToString());

            foreach (ceDescripcionItem item in arrayDescrItemList)
            {
                ItemList itemFlp = new ItemList(item.User, item.Lead, item.Customer);

                itemFlp.Id = item.Lead.Idlead;
                itemFlp.Name = item.Lead.Name;
                itemFlp.Date = item.Lead.Date;
                itemFlp.Stage = item.Lead.Stage;
                itemFlp.Amount = item.Lead.Amount;
                itemFlp.Notes = item.Lead.Notes;
                itemFlp.AssignedTo = item.User.Email;
                itemFlp.CreatedAt = item.Lead.CreatedAt;
                itemFlp.NameCustomer = item.Customer.Name;

                itemFlp.User = item.User;
                itemFlp.Lead = item.Lead;
                itemFlp.Customer = item.Customer;

                if (item.Lead.Stage == "New")
                {
                    flpNew.Controls.Add(itemFlp);
                }
                else if (item.Lead.Stage == "Qualified")
                {
                    flpQualified.Controls.Add(itemFlp);
                }
                else if (item.Lead.Stage == "Proposition")
                {
                    flpProposition.Controls.Add(itemFlp);
                }
                else if (item.Lead.Stage == "Won")
                {
                    flpWon.Controls.Add(itemFlp);
                }
                else if (item.Lead.Stage == "Sale")
                {
                    flpSale.Controls.Add(itemFlp);
                }
            }
        }

        private void btnUpdateDgvCustomer_Click(object sender, EventArgs e)
        {
            dgvCustomer.Update();
            dgvCustomer.Refresh();
            cnDgvCustomer.updateDgvCustomer(dgvCustomer);
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbCustomerName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            lbStateDateLead.Text = "";
            cnDgvLead.updateDgvLead(int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString()), dgvCustomer_Lead);
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            ceCustomer customer = cnCustomer.getCustomer(int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString()));

            descrCustomer descrCustomer = new descrCustomer(cnCustomer.getCustomer(int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString())));
            descrCustomer.Show();
            cdGlobals.newLogEntry(emailUser, "Customer visualización de información, idCustomer: " + dgvCustomer.CurrentRow.Cells[0].Value.ToString());

        }

        private void dgvCustomer_Lead_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCustomer_Lead.CurrentRow == null)
            {
                MessageBox.Show("No lead seleccionado");
            }
            else
            {
                ceDescripcionItem description = cnLead.getLead(int.Parse(dgvCustomer_Lead.CurrentRow.Cells[0].Value.ToString()));

                descripcionItemList descripcionItemList = new descripcionItemList
                (description);
                descripcionItemList.Show();
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            var startDate = DateTime.Parse(dtpFechaInicio.Value.ToString("yyyy-MM-dd"));
            var endDate = DateTime.Parse(dtpFechaFin.Value.ToString("yyyy-MM-dd"));

            if (startDate > endDate && dgvCustomer.CurrentRow != null)
            {
                lbStateDateLead.Text = "La fecha inicio no puede ser más antigua que la fecha fin";
            }
            else
            {
                cnLead.leadsByDate(lbStateDateLead, dgvCustomer_Lead, int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString()), startDate, endDate);
            }
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaInicio_ValueChanged(sender, e);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pSettingsModule.Visible = true;
            pUsuarios.Visible = false;
            pGestionDietas.Visible = false;
            pSolicitudDieta.Visible = false;
            pCRMGest.Visible = false;
        }

        private void btnSettingsSaveBackup_Click(object sender, EventArgs e)
        {
            // Guardar copia BBDD en CSV
            cnDoBackup.doBackUp(emailUser);
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {
            string filePath = null;
            // Restaurar copia BBDD en CSV
            using (OpenFileDialog ofdUpload = new OpenFileDialog() { Filter = "Text Documents (*.csv;) |*.csv", ValidateNames = true })
            {
                if (ofdUpload.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure want to restore this file?", "Juanjo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        filePath = ofdUpload.FileName; // Ruta absoluta del archivo
                    }
                    else
                    {
                        return;
                    }
                }
            }

            if (File.Exists(filePath))
            {
                cnRestoreBackUp.restoreBackUp(filePath, emailUser);
            }

        }

        /*        

         .----------------.  .-----------------. .----------------.  .----------------.  .-----------------. .----------------.  .----------------.  .----------------.  .----------------. 
        | .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
        | |     _____    | || | ____ _____  | || | ____ ____  | || |  _________   | || | ____ _____  | || |  _________   | || |     ____     | || |  _______     | || |  ____ ____  | |
        | |    |_ _|   | || ||_   \|_ _| | || ||_ _| |_ _| | || | |_ ___  |  | || ||_   \|_ _| | || | |  _ _  |  | || |   .'    `.   | || | |_   __ \    | || | |_  _||_  _| | |
        | |      | |     | || |  |   \ | |   | || |  \ \   / /   | || |   | |_  \_|  | || |  |   \ | |   | || | |_/ | | \_|  | || |  /  .--.  \  | || |   | |__) |   | || |   \ \  / /   | |
        | |      | |     | || |  | |\ \| |   | || |   \ \ / /    | || |   |  _|  _   | || |  | |\ \| |   | || |     | |      | || |  | |    | |  | || |   |  __ /    | || |    \ \/ /    | |
        | |     _| |_    | || | _| |_\   |_  | || |    \ ' /     | || |  _| |___/ |  | || | _| |_\   |_  | || |    _| |_     | || |  \  `--'  /  | || |  _| |  \ \_  | || |    _|  |_    | |
        | |    |_____|   | || ||_____|\____| | || |     \_/      | || | |_________|  | || ||_____|\____| | || |   |_____|    | || |   `.____.'   | || | |____| |___| | || |   |______|   | |
        | |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | |
        | '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
         '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' 

        */

        private void bbtnAddProduct_Click(object sender, EventArgs e)
        {
            Form newInventoryItem = new newInventoryItem();

            newInventoryItem.Show();
        }

        private void pInventory_VisibleChanged(object sender, EventArgs e)
        {
            if (pInventory.Visible == true)
            {
                ArrayList array = new ArrayList();
                array = cnWarehouse.getWarehouses();
                fillBdgvStoredProducts(array);

            }
        }

        private void fillBdgvStoredProducts(ArrayList arr)
        {
            bdgvStoredProducts.RowCount = 0;
            ceWarehouse warehouse = null;
            for (int i = 0; i < arr.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                warehouse = (ceWarehouse)arr[i];

                newRow.CreateCells(bdgvStoredProducts);
                newRow.Cells[0].Value = warehouse.idWarehouse;
                newRow.Cells[1].Value = warehouse.Name;
                bdgvStoredProducts.Rows.Add(newRow);
            }
        }

        private void bdgvStoredProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ArrayList arr = null;
            int idWarehouse = int.Parse(bdgvStoredProducts.CurrentRow.Cells[0].Value.ToString());
            blbTitleProductsAboutType.Text = bdgvStoredProducts.CurrentRow.Cells[1].Value.ToString();

            if (bdgvStoredProducts.CurrentRow.Cells[1].Value.ToString() == "No stored")
            {
                blbMaxQuantity.Visible = true;
                blbAmountUpdate.Visible = true;
                btbStoreAmount.Visible = true;
                bdStoreIntoWarehouses.Visible = true;
                bbtnAddProductToWarehouse.Visible = true;

                bdStoreIntoWarehouses.Items.Clear();
                arr = cnWarehouse.getWarehouses();
                foreach (ceWarehouse i in arr)
                {
                    if (i.Name != "No stored")
                        bdStoreIntoWarehouses.Items.Add(i.Name);
                }

            }
            else
            {
                blbMaxQuantity.Visible = false;
                blbAmountUpdate.Visible = false;
                btbStoreAmount.Visible = false;
                bdStoreIntoWarehouses.Visible = false;
                bbtnAddProductToWarehouse.Visible = false;
            }

            if (idWarehouse != 0)
            {
                arr = cnWarehouse.obtainProductsFromWarehouses(idWarehouse);
            }
            else
            {
                arr = cnProduct.obtainNoStoredProducts();
            }

            fillBdgvItemsPerType(arr);
        }

        private void fillBdgvItemsPerType(ArrayList arr)
        {
            bdgvItemsPerType.RowCount = 0;
            ceProduct p = null;
            for (int i = 0; i < arr.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                p = (ceProduct)arr[i];

                newRow.CreateCells(bdgvItemsPerType);
                newRow.Cells[0].Value = p.idProduct;
                newRow.Cells[1].Value = p.name;
                newRow.Cells[2].Value = p.pricePerUnit;
                newRow.Cells[3].Value = p.amount;
                newRow.Cells[4].Value = p.unitOfMeasure;
                newRow.Cells[5].Value = p.productCategory;
                newRow.Cells[6].Value = p.state;

                bdgvItemsPerType.Rows.Add(newRow);
            }
        }

        private void bbtnAddProductToWarehouse_Click(object sender, EventArgs e)
        {
            int idProduct = int.Parse(bdgvItemsPerType.CurrentRow.Cells[0].Value.ToString());
            int amount = int.Parse(btbStoreAmount.Text);
            string newWarehouse = bdStoreIntoWarehouses.SelectedItem == null ? String.Empty :
                    bdStoreIntoWarehouses.SelectedItem.ToString();
            int maxQt = int.Parse(bdgvItemsPerType.CurrentRow.Cells[3].Value.ToString());

            if (newWarehouse != string.Empty && newWarehouse != "No stored" && maxQt >= amount)
            {
                if (maxQt == amount)
                {
                    cnWarehouse.productNoStoredToStored(idProduct, amount, newWarehouse);
                }

                if (maxQt > amount)
                {
                    string name = bdgvItemsPerType.CurrentRow.Cells[1].Value.ToString();
                    float pricePerUnit = float.Parse(bdgvItemsPerType.CurrentRow.Cells[2].Value.ToString());
                    float actualAmount = float.Parse(bdgvItemsPerType.CurrentRow.Cells[3].Value.ToString());
                    string unitOfMeasure = bdgvItemsPerType.CurrentRow.Cells[4].Value.ToString();
                    string productCategory = bdgvItemsPerType.CurrentRow.Cells[5].Value.ToString();
                    string state = "Stored";

                    ceProduct p = new ceProduct(name, pricePerUnit, actualAmount, unitOfMeasure, productCategory, state);
                    cnWarehouse.splitProductNoStoredAndStored(p, idProduct, amount, maxQt, newWarehouse);
                }

            }

        }

        private void bdgvItemsPerType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            blbMaxQuantity.Text = "Max: " + bdgvItemsPerType.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
