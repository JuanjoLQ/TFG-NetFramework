namespace Tfg_NetFramework
{
    partial class detailsSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detailsSale));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.blbDetailsSale = new Bunifu.UI.WinForms.BunifuLabel();
            this.bdgvDetailsSale = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitOfMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blbDetailsSaleNameCustomer = new Bunifu.UI.WinForms.BunifuLabel();
            this.blbDetailsSaleNameLead = new Bunifu.UI.WinForms.BunifuLabel();
            this.blbDetailsSaleDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bdgvDetailsSale)).BeginInit();
            this.SuspendLayout();
            // 
            // blbDetailsSale
            // 
            this.blbDetailsSale.AllowParentOverrides = false;
            this.blbDetailsSale.AutoEllipsis = false;
            this.blbDetailsSale.AutoSize = false;
            this.blbDetailsSale.Cursor = System.Windows.Forms.Cursors.Default;
            this.blbDetailsSale.CursorType = System.Windows.Forms.Cursors.Default;
            this.blbDetailsSale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.blbDetailsSale.Location = new System.Drawing.Point(21, 3);
            this.blbDetailsSale.Name = "blbDetailsSale";
            this.blbDetailsSale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blbDetailsSale.Size = new System.Drawing.Size(118, 58);
            this.blbDetailsSale.TabIndex = 0;
            this.blbDetailsSale.Text = "<h3>Details Sale</h3>";
            this.blbDetailsSale.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.blbDetailsSale.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bdgvDetailsSale
            // 
            this.bdgvDetailsSale.AllowCustomTheming = false;
            this.bdgvDetailsSale.AllowUserToAddRows = false;
            this.bdgvDetailsSale.AllowUserToDeleteRows = false;
            this.bdgvDetailsSale.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bdgvDetailsSale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bdgvDetailsSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bdgvDetailsSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdgvDetailsSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bdgvDetailsSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bdgvDetailsSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bdgvDetailsSale.ColumnHeadersHeight = 40;
            this.bdgvDetailsSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.dataGridViewTextBoxColumn4,
            this.pricePerUnit,
            this.amount,
            this.unitOfMeasure,
            this.productCategory,
            this.stateProduct});
            this.bdgvDetailsSale.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bdgvDetailsSale.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bdgvDetailsSale.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bdgvDetailsSale.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bdgvDetailsSale.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bdgvDetailsSale.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bdgvDetailsSale.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bdgvDetailsSale.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bdgvDetailsSale.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bdgvDetailsSale.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bdgvDetailsSale.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bdgvDetailsSale.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bdgvDetailsSale.CurrentTheme.Name = null;
            this.bdgvDetailsSale.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bdgvDetailsSale.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bdgvDetailsSale.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bdgvDetailsSale.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bdgvDetailsSale.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bdgvDetailsSale.DefaultCellStyle = dataGridViewCellStyle3;
            this.bdgvDetailsSale.EnableHeadersVisualStyles = false;
            this.bdgvDetailsSale.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bdgvDetailsSale.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bdgvDetailsSale.HeaderBgColor = System.Drawing.Color.Empty;
            this.bdgvDetailsSale.HeaderForeColor = System.Drawing.Color.White;
            this.bdgvDetailsSale.Location = new System.Drawing.Point(21, 46);
            this.bdgvDetailsSale.Name = "bdgvDetailsSale";
            this.bdgvDetailsSale.ReadOnly = true;
            this.bdgvDetailsSale.RowHeadersVisible = false;
            this.bdgvDetailsSale.RowHeadersWidth = 51;
            this.bdgvDetailsSale.RowTemplate.Height = 40;
            this.bdgvDetailsSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdgvDetailsSale.Size = new System.Drawing.Size(739, 317);
            this.bdgvDetailsSale.TabIndex = 16;
            this.bdgvDetailsSale.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // idProduct
            // 
            this.idProduct.HeaderText = "Id Product";
            this.idProduct.MinimumWidth = 6;
            this.idProduct.Name = "idProduct";
            this.idProduct.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // pricePerUnit
            // 
            this.pricePerUnit.HeaderText = "Price Per Unit";
            this.pricePerUnit.MinimumWidth = 6;
            this.pricePerUnit.Name = "pricePerUnit";
            this.pricePerUnit.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // unitOfMeasure
            // 
            this.unitOfMeasure.HeaderText = "Unit Of Measure";
            this.unitOfMeasure.MinimumWidth = 6;
            this.unitOfMeasure.Name = "unitOfMeasure";
            this.unitOfMeasure.ReadOnly = true;
            // 
            // productCategory
            // 
            this.productCategory.HeaderText = "Product Category";
            this.productCategory.MinimumWidth = 6;
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            // 
            // stateProduct
            // 
            this.stateProduct.HeaderText = "State";
            this.stateProduct.MinimumWidth = 6;
            this.stateProduct.Name = "stateProduct";
            this.stateProduct.ReadOnly = true;
            // 
            // blbDetailsSaleNameCustomer
            // 
            this.blbDetailsSaleNameCustomer.AllowParentOverrides = false;
            this.blbDetailsSaleNameCustomer.AutoEllipsis = false;
            this.blbDetailsSaleNameCustomer.AutoSize = false;
            this.blbDetailsSaleNameCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.blbDetailsSaleNameCustomer.CursorType = System.Windows.Forms.Cursors.Default;
            this.blbDetailsSaleNameCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.blbDetailsSaleNameCustomer.Location = new System.Drawing.Point(174, 4);
            this.blbDetailsSaleNameCustomer.Name = "blbDetailsSaleNameCustomer";
            this.blbDetailsSaleNameCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blbDetailsSaleNameCustomer.Size = new System.Drawing.Size(117, 36);
            this.blbDetailsSaleNameCustomer.TabIndex = 17;
            this.blbDetailsSaleNameCustomer.Text = "<h4>Name Customer</h4>";
            this.blbDetailsSaleNameCustomer.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.blbDetailsSaleNameCustomer.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // blbDetailsSaleNameLead
            // 
            this.blbDetailsSaleNameLead.AllowParentOverrides = false;
            this.blbDetailsSaleNameLead.AutoEllipsis = false;
            this.blbDetailsSaleNameLead.AutoSize = false;
            this.blbDetailsSaleNameLead.CursorType = null;
            this.blbDetailsSaleNameLead.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.blbDetailsSaleNameLead.Location = new System.Drawing.Point(351, 4);
            this.blbDetailsSaleNameLead.Name = "blbDetailsSaleNameLead";
            this.blbDetailsSaleNameLead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blbDetailsSaleNameLead.Size = new System.Drawing.Size(88, 36);
            this.blbDetailsSaleNameLead.TabIndex = 18;
            this.blbDetailsSaleNameLead.Text = "<h4>Name Lead</h4>";
            this.blbDetailsSaleNameLead.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.blbDetailsSaleNameLead.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // blbDetailsSaleDate
            // 
            this.blbDetailsSaleDate.AllowParentOverrides = false;
            this.blbDetailsSaleDate.AutoEllipsis = false;
            this.blbDetailsSaleDate.AutoSize = false;
            this.blbDetailsSaleDate.CursorType = null;
            this.blbDetailsSaleDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.blbDetailsSaleDate.Location = new System.Drawing.Point(511, 3);
            this.blbDetailsSaleDate.Name = "blbDetailsSaleDate";
            this.blbDetailsSaleDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blbDetailsSaleDate.Size = new System.Drawing.Size(90, 36);
            this.blbDetailsSaleDate.TabIndex = 21;
            this.blbDetailsSaleDate.Text = "<h4>Date of Sale</h4>";
            this.blbDetailsSaleDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.blbDetailsSaleDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowMouseEffects = true;
            this.btnClose.AllowToggling = false;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.AutoGenerateColors = false;
            this.btnClose.AutoRoundBorders = false;
            this.btnClose.AutoSizeLeftIcon = true;
            this.btnClose.AutoSizeRightIcon = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor1 = System.Drawing.Color.Crimson;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.ButtonText = "Close";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.ColorContrastOnClick = 45;
            this.btnClose.ColorContrastOnHover = 45;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClose.IconMarginLeft = 11;
            this.btnClose.IconPadding = 10;
            this.btnClose.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClose.IconSize = 25;
            this.btnClose.IdleBorderColor = System.Drawing.Color.Crimson;
            this.btnClose.IdleBorderRadius = 10;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleFillColor = System.Drawing.Color.Crimson;
            this.btnClose.IdleIconLeftImage = null;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.IndicateFocus = false;
            this.btnClose.Location = new System.Drawing.Point(351, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 10;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 1;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.BorderRadius = 10;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 1;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.Crimson;
            this.btnClose.OnIdleState.BorderRadius = 10;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 1;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.Crimson;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.IconLeftImage = null;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.BorderRadius = 10;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(91, 42);
            this.btnClose.TabIndex = 31;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // detailsSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 418);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.blbDetailsSaleDate);
            this.Controls.Add(this.blbDetailsSaleNameLead);
            this.Controls.Add(this.blbDetailsSaleNameCustomer);
            this.Controls.Add(this.bdgvDetailsSale);
            this.Controls.Add(this.blbDetailsSale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "detailsSale";
            this.Text = "detailsSale";
            this.Load += new System.EventHandler(this.detailsSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgvDetailsSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel blbDetailsSale;
        private Bunifu.UI.WinForms.BunifuDataGridView bdgvDetailsSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitOfMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateProduct;
        private Bunifu.UI.WinForms.BunifuLabel blbDetailsSaleNameCustomer;
        private Bunifu.UI.WinForms.BunifuLabel blbDetailsSaleNameLead;
        private Bunifu.UI.WinForms.BunifuLabel blbDetailsSaleDate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnClose;
    }
}