using System.Windows.Forms;

namespace Tfg_NetFramework
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.tbPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tbEmail = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbPassword = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.bbtnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLanguage
            // 
            this.cbLanguage.BackColor = System.Drawing.Color.White;
            this.cbLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "ES - Spanish",
            "EN - English"});
            this.cbLanguage.Location = new System.Drawing.Point(95, 185);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(136, 24);
            this.cbLanguage.TabIndex = 8;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            this.cbLanguage.SelectedValueChanged += new System.EventHandler(this.cbLanguage_SelectedValueChanged);
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.tbEmail);
            this.gbLogin.Controls.Add(this.lbPassword);
            this.gbLogin.Controls.Add(this.lbEmail);
            this.gbLogin.Controls.Add(this.cbLanguage);
            this.gbLogin.Controls.Add(this.bbtnLogin);
            this.gbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogin.Location = new System.Drawing.Point(135, 49);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLogin.Size = new System.Drawing.Size(345, 286);
            this.gbLogin.TabIndex = 9;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Please Login";
            // 
            // tbPassword
            // 
            this.tbPassword.AcceptsReturn = false;
            this.tbPassword.AcceptsTab = false;
            this.tbPassword.AnimationSpeed = 200;
            this.tbPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPassword.AutoSizeHeight = true;
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPassword.BackgroundImage")));
            this.tbPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbPassword.BorderRadius = 10;
            this.tbPassword.BorderThickness = 1;
            this.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbPassword.DefaultText = "";
            this.tbPassword.FillColor = System.Drawing.Color.White;
            this.tbPassword.HideSelection = true;
            this.tbPassword.IconLeft = null;
            this.tbPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.IconPadding = 3;
            this.tbPassword.IconRight = null;
            this.tbPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(54, 129);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbPassword.Modified = false;
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassword.OnIdleState = stateProperties4;
            this.tbPassword.Padding = new System.Windows.Forms.Padding(3);
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.ReadOnly = false;
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(230, 39);
            this.tbPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbPassword.TabIndex = 11;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TextMarginBottom = 0;
            this.tbPassword.TextMarginLeft = 3;
            this.tbPassword.TextMarginTop = 1;
            this.tbPassword.TextPlaceholder = "Password";
            this.tbPassword.UseSystemPasswordChar = false;
            this.tbPassword.WordWrap = true;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // tbEmail
            // 
            this.tbEmail.AcceptsReturn = false;
            this.tbEmail.AcceptsTab = false;
            this.tbEmail.AnimationSpeed = 200;
            this.tbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbEmail.AutoSizeHeight = true;
            this.tbEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbEmail.BackgroundImage")));
            this.tbEmail.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbEmail.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbEmail.BorderRadius = 10;
            this.tbEmail.BorderThickness = 1;
            this.tbEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbEmail.DefaultText = "";
            this.tbEmail.FillColor = System.Drawing.Color.White;
            this.tbEmail.HideSelection = true;
            this.tbEmail.IconLeft = null;
            this.tbEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.IconPadding = 3;
            this.tbEmail.IconRight = null;
            this.tbEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Lines = new string[0];
            this.tbEmail.Location = new System.Drawing.Point(54, 57);
            this.tbEmail.MaxLength = 32767;
            this.tbEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbEmail.Modified = false;
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbEmail.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbEmail.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbEmail.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbEmail.OnIdleState = stateProperties8;
            this.tbEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.ReadOnly = false;
            this.tbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.ShortcutsEnabled = true;
            this.tbEmail.Size = new System.Drawing.Size(230, 39);
            this.tbEmail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbEmail.TabIndex = 12;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEmail.TextMarginBottom = 0;
            this.tbEmail.TextMarginLeft = 3;
            this.tbEmail.TextMarginTop = 1;
            this.tbEmail.TextPlaceholder = "Email";
            this.tbEmail.UseSystemPasswordChar = false;
            this.tbEmail.WordWrap = true;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress);
            // 
            // lbPassword
            // 
            this.lbPassword.AllowParentOverrides = false;
            this.lbPassword.AutoEllipsis = false;
            this.lbPassword.AutoSize = false;
            this.lbPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPassword.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbPassword.Location = new System.Drawing.Point(54, 87);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPassword.Size = new System.Drawing.Size(90, 36);
            this.lbPassword.TabIndex = 12;
            this.lbPassword.Text = "<h3>Password:</h3>";
            this.lbPassword.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbPassword.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbEmail
            // 
            this.lbEmail.AllowParentOverrides = false;
            this.lbEmail.AutoEllipsis = false;
            this.lbEmail.AutoSize = false;
            this.lbEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbEmail.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbEmail.Location = new System.Drawing.Point(54, 13);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbEmail.Size = new System.Drawing.Size(61, 35);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "<h3>Email: </h3>";
            this.lbEmail.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbEmail.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bbtnLogin
            // 
            this.bbtnLogin.AllowAnimations = true;
            this.bbtnLogin.AllowMouseEffects = true;
            this.bbtnLogin.AllowToggling = false;
            this.bbtnLogin.AnimationSpeed = 200;
            this.bbtnLogin.AutoGenerateColors = false;
            this.bbtnLogin.AutoRoundBorders = false;
            this.bbtnLogin.AutoSizeLeftIcon = true;
            this.bbtnLogin.AutoSizeRightIcon = true;
            this.bbtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.bbtnLogin.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.bbtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bbtnLogin.BackgroundImage")));
            this.bbtnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bbtnLogin.ButtonText = "Login";
            this.bbtnLogin.ButtonTextMarginLeft = 0;
            this.bbtnLogin.ColorContrastOnClick = 45;
            this.bbtnLogin.ColorContrastOnHover = 45;
            this.bbtnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bbtnLogin.CustomizableEdges = borderEdges1;
            this.bbtnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bbtnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bbtnLogin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bbtnLogin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bbtnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bbtnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bbtnLogin.ForeColor = System.Drawing.Color.White;
            this.bbtnLogin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bbtnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bbtnLogin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bbtnLogin.IconMarginLeft = 11;
            this.bbtnLogin.IconPadding = 10;
            this.bbtnLogin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bbtnLogin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bbtnLogin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bbtnLogin.IconSize = 25;
            this.bbtnLogin.IdleBorderColor = System.Drawing.Color.RoyalBlue;
            this.bbtnLogin.IdleBorderRadius = 10;
            this.bbtnLogin.IdleBorderThickness = 1;
            this.bbtnLogin.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.bbtnLogin.IdleIconLeftImage = null;
            this.bbtnLogin.IdleIconRightImage = null;
            this.bbtnLogin.IndicateFocus = false;
            this.bbtnLogin.Location = new System.Drawing.Point(54, 226);
            this.bbtnLogin.Name = "bbtnLogin";
            this.bbtnLogin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bbtnLogin.OnDisabledState.BorderRadius = 10;
            this.bbtnLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bbtnLogin.OnDisabledState.BorderThickness = 1;
            this.bbtnLogin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bbtnLogin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bbtnLogin.OnDisabledState.IconLeftImage = null;
            this.bbtnLogin.OnDisabledState.IconRightImage = null;
            this.bbtnLogin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bbtnLogin.onHoverState.BorderRadius = 10;
            this.bbtnLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bbtnLogin.onHoverState.BorderThickness = 1;
            this.bbtnLogin.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bbtnLogin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bbtnLogin.onHoverState.IconLeftImage = null;
            this.bbtnLogin.onHoverState.IconRightImage = null;
            this.bbtnLogin.OnIdleState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.bbtnLogin.OnIdleState.BorderRadius = 10;
            this.bbtnLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bbtnLogin.OnIdleState.BorderThickness = 1;
            this.bbtnLogin.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.bbtnLogin.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bbtnLogin.OnIdleState.IconLeftImage = null;
            this.bbtnLogin.OnIdleState.IconRightImage = null;
            this.bbtnLogin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bbtnLogin.OnPressedState.BorderRadius = 10;
            this.bbtnLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bbtnLogin.OnPressedState.BorderThickness = 1;
            this.bbtnLogin.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bbtnLogin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bbtnLogin.OnPressedState.IconLeftImage = null;
            this.bbtnLogin.OnPressedState.IconRightImage = null;
            this.bbtnLogin.Size = new System.Drawing.Size(230, 39);
            this.bbtnLogin.TabIndex = 17;
            this.bbtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bbtnLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bbtnLogin.TextMarginLeft = 0;
            this.bbtnLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.bbtnLogin.UseDefaultRadiusAndThickness = true;
            this.bbtnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 377);
            this.Controls.Add(this.gbLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gbLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox cbLanguage;
        private GroupBox gbLogin;
        private Bunifu.UI.WinForms.BunifuLabel lbEmail;
        private Bunifu.UI.WinForms.BunifuLabel lbPassword;
        private Bunifu.UI.WinForms.BunifuTextBox tbPassword;
        private Bunifu.UI.WinForms.BunifuTextBox tbEmail;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bbtnLogin;
    }
}

