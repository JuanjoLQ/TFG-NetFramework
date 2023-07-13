using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using capaEntidad;
using capaNegocio;
using K4os.Hash.xxHash;

namespace Tfg_NetFramework
{
    public partial class Login : Form
    {
        cnUser cnUser = new cnUser();

        public Login()
        {
            ceGlobals.initializeDataUser();
            InitializeComponent();
        }

        private void tbEmail_Focus(object sender, EventArgs e)
        {
            if (tbEmail.Text == Res.Email)
            {
                tbEmail.Text = string.Empty;
                tbEmail.ForeColor = Color.Black;
            }
        }

        private void tbEmail_LostFocus(object sender, EventArgs e)
        {
            if (tbEmail.Text == string.Empty)
            {
                tbEmail.Text = Res.Email;
                tbEmail.ForeColor = Color.DimGray;
            }
        }

        private void tbPassword_Focus(object sender, EventArgs e)
        {
            if (tbPassword.Text == Res.Pass)
            {
                tbPassword.Text = string.Empty;
                tbPassword.ForeColor = Color.Black;
            }
        }

        private void tbPassword_LostFocus(object sender, EventArgs e)
        {
            if (tbPassword.Text == string.Empty)
            {
                tbPassword.Text = Res.Pass;
                tbPassword.ForeColor = Color.DimGray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cnUser.CheckUser(new ceUser(0, tbEmail.Text, tbPassword.Text)))
            {
                ceGlobals.email = tbEmail.Text;
                ceGlobals.password = tbPassword.Text;

                this.Hide();

                HomePage homePage = new HomePage();
                homePage.Show();

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (ceGlobals.lang == null)
            {
                Debug.WriteLine("Form load Lang Default");
                ceGlobals.lang = "en-US";
            }

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(ceGlobals.lang);
            cbLanguage.SelectedIndex = 0;
            GetLanguage();
        }

        private void GetLanguage()
        {
            gbLogin.Text = Res.gbLogin;
            tbEmail.Text = Res.user;
            tbPassword.Text = Res.passwd;
            bbtnLogin.Text = Res.Login;
            

            // Labels
            lbEmail.Text = "<h3>" + Res.Email + ":" + "</h3>";
            lbPassword.Text = "<h3>" + Res.Pass + ":" + "</h3>";

            /*
            lbRegister.Text = Res.Register;
            tbREmail.Text = Res.Email;
            tbRPassword.Text= Res.Pass;
            btnRRegistrar.Text = Res.Register;   
            */

            //btnSalir.Text = Res.Exit;

        }

        private void cbLanguage_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbLanguage.SelectedItem.Equals("ES - Spanish"))
            {
                ceGlobals.lang = "";
            }
            else
            {
                ceGlobals.lang = "en-US";
            }
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(ceGlobals.lang);
            GetLanguage();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
