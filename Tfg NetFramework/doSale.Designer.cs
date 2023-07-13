namespace Tfg_NetFramework
{
    partial class doSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doSale));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bdgvProductsIntoSale = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitOfMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbtnDoSale = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.blbTitleDoSale = new Bunifu.UI.WinForms.BunifuLabel();
            this.bdgvProductsIntoWarehouse = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blbTitleProductsIntoWarehouses = new Bunifu.UI.WinForms.BunifuLabel();
            this.blbTitleTableToSale = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bdgvProductsIntoSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgvProductsIntoWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // bdgvProductsIntoSale
            // 
            this.bdgvProductsIntoSale.AllowCustomTheming = false;
            this.bdgvProductsIntoSale.AllowUserToAddRows = false;
            this.bdgvProductsIntoSale.AllowUserToDeleteRows = false;
            this.bdgvProductsIntoSale.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bdgvProductsIntoSale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bdgvProductsIntoSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bdgvProductsIntoSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdgvProductsIntoSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bdgvProductsIntoSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bdgvProductsIntoSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bdgvProductsIntoSale.ColumnHeadersHeight = 40;
            this.bdgvProductsIntoSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.dataGridViewTextBoxColumn4,
            this.pricePerUnit,
            this.amount,
            this.unitOfMeasure,
            this.productCategory,
            this.stateProduct});
            this.bdgvProductsIntoSale.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bdgvProductsIntoSale.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bdgvProductsIntoSale.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bdgvProductsIntoSale.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bdgvProductsIntoSale.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bdgvProductsIntoSale.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bdgvProductsIntoSale.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bdgvProductsIntoSale.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bdgvProductsIntoSale.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bdgvProductsIntoSale.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bdgvProductsIntoSale.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bdgvProductsIntoSale.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bdgvProductsIntoSale.CurrentTheme.Name = null;
            this.bdgvProductsIntoSale.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bdgvProductsIntoSale.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bdgvProductsIntoSale.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bdgvProductsIntoSale.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bdgvProductsIntoSale.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bdgvProductsIntoSale.DefaultCellStyle = dataGridViewCellStyle3;
            this.bdgvProductsIntoSale.EnableHeadersVisualStyles = false;
            this.bdgvProductsIntoSale.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bdgvProductsIntoSale.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bdgvProductsIntoSale.HeaderBgColor = System.Drawing.Color.Empty;
            this.bdgvProductsIntoSale.HeaderForeColor = System.Drawing.Color.White;
            this.bdgvProductsIntoSale.Location = new System.Drawing.Point(36, 62);
            this.bdgvProductsIntoSale.Name = "bdgvProductsIntoSale";
            this.bdgvProductsIntoSale.ReadOnly = true;
            this.bdgvProductsIntoSale.RowHeadersVisible = false;
            this.bdgvProductsIntoSale.RowHeadersWidth = 51;
            this.bdgvProductsIntoSale.RowTemplate.Height = 40;
            this.bdgvProductsIntoSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdgvProductsIntoSale.Size = new System.Drawing.Size(839, 227);
            this.bdgvProductsIntoSale.TabIndex = 15;
            this.bdgvProductsIntoSale.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bdgvProductsIntoSale.DoubleClick += new System.EventHandler(this.bdgvProductsIntoSale_DoubleClick);
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
            // bbtnDoSale
            // 
            this.bbtnDoSale.AllowAnimations = true;
            this.bbtnDoSale.AllowMouseEffects = true;
            this.bbtnDoSale.AllowToggling = false;
            this.bbtnDoSale.AnimationSpeed = 200;
            this.bbtnDoSale.AutoGenerateColors = false;
            this.bbtnDoSale.AutoRoundBorders = false;
            this.bbtnDoSale.AutoSizeLeftIcon = true;
            this.bbtnDoSale.AutoSizeRightIcon = true;
            this.bbtnDoSale.BackColor = System.Drawing.Color.Transparent;
            this.bbtnDoSale.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.bbtnDoSale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bbtnDoSale.BackgroundImage")));
            this.bbtnDoSale.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bbtnDoSale.ButtonText = "Do Sale";
            this.bbtnDoSale.ButtonTextMarginLeft = 0;
            this.bbtnDoSale.ColorContrastOnClick = 45;
            this.bbtnDoSale.ColorContrastOnHover = 45;
            this.bbtnDoSale.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bbtnDoSale.CustomizableEdges = borderEdges1;
            this.bbtnDoSale.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bbtnDoSale.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bbtnDoSale.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bbtnDoSale.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bbtnDoSale.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bbtnDoSale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bbtnDoSale.ForeColor = System.Drawing.Color.White;
            this.bbtnDoSale.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bbtnDoSale.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bbtnDoSale.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bbtnDoSale.IconMarginLeft = 11;
            this.bbtnDoSale.IconPadding = 10;
            this.bbtnDoSale.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bbtnDoSale.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bbtnDoSale.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bbtnDoSale.IconSize = 25;
            this.bbtnDoSale.IdleBorderColor = System.Drawing.Color.RoyalBlue;
            this.bbtnDoSale.IdleBorderRadius = 10;
            this.bbtnDoSale.IdleBorderThickness = 1;
            this.bbtnDoSale.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.bbtnDoSale.IdleIconLeftImage = null;
            this.bbtnDoSale.IdleIconRightImage = null;
            this.bbtnDoSale.IndicateFocus = false;
            this.bbtnDoSale.Location = new System.Drawing.Point(896, 439);
            this.bbtnDoSale.Name = "bbtnDoSale";
            this.bbtnDoSale.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bbtnDoSale.OnDisabledState.BorderRadius = 10;
            this.bbtnDoSale.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bbtnDoSale.OnDisabledState.BorderThickness = 1;
            this.bbtnDoSale.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bbtnDoSale.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bbtnDoSale.OnDisabledState.IconLeftImage = null;
            this.bbtnDoSale.OnDisabledState.IconRightImage = null;
            this.bbtnDoSale.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bbtnDoSale.onHoverState.BorderRadius = 10;
            this.bbtnDoSale.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bbtnDoSale.onHoverState.BorderThickness = 1;
            this.bbtnDoSale.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bbtnDoSale.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bbtnDoSale.onHoverState.IconLeftImage = null;
            this.bbtnDoSale.onHoverState.IconRightImage = null;
            this.bbtnDoSale.OnIdleState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.bbtnDoSale.OnIdleState.BorderRadius = 10;
            this.bbtnDoSale.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bbtnDoSale.OnIdleState.BorderThickness = 1;
            this.bbtnDoSale.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.bbtnDoSale.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bbtnDoSale.OnIdleState.IconLeftImage = null;
            this.bbtnDoSale.OnIdleState.IconRightImage = null;
            this.bbtnDoSale.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bbtnDoSale.OnPressedState.BorderRadius = 10;
            this.bbtnDoSale.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bbtnDoSale.OnPressedState.BorderThickness = 1;
            this.bbtnDoSale.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bbtnDoSale.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bbtnDoSale.OnPressedState.IconLeftImage = null;
            this.bbtnDoSale.OnPressedState.IconRightImage = null;
            this.bbtnDoSale.Size = new System.Drawing.Size(95, 57);
            this.bbtnDoSale.TabIndex = 16;
            this.bbtnDoSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bbtnDoSale.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bbtnDoSale.TextMarginLeft = 0;
            this.bbtnDoSale.TextPadding = new System.Windows.Forms.Padding(0);
            this.bbtnDoSale.UseDefaultRadiusAndThickness = true;
            this.bbtnDoSale.Click += new System.EventHandler(this.bbtnDoSale_Click);
            // 
            // blbTitleDoSale
            // 
            this.blbTitleDoSale.AllowParentOverrides = false;
            this.blbTitleDoSale.AutoEllipsis = false;
            this.blbTitleDoSale.AutoSize = false;
            this.blbTitleDoSale.Cursor = System.Windows.Forms.Cursors.Default;
            this.blbTitleDoSale.CursorType = System.Windows.Forms.Cursors.Default;
            this.blbTitleDoSale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.blbTitleDoSale.Location = new System.Drawing.Point(36, -9);
            this.blbTitleDoSale.Name = "blbTitleDoSale";
            this.blbTitleDoSale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blbTitleDoSale.Size = new System.Drawing.Size(88, 44);
            this.blbTitleDoSale.TabIndex = 17;
            this.blbTitleDoSale.Text = "<h2>Do Sale</h2>";
            this.blbTitleDoSale.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.blbTitleDoSale.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bdgvProductsIntoWarehouse
            // 
            this.bdgvProductsIntoWarehouse.AllowCustomTheming = false;
            this.bdgvProductsIntoWarehouse.AllowUserToAddRows = false;
            this.bdgvProductsIntoWarehouse.AllowUserToDeleteRows = false;
            this.bdgvProductsIntoWarehouse.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bdgvProductsIntoWarehouse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bdgvProductsIntoWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bdgvProductsIntoWarehouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdgvProductsIntoWarehouse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bdgvProductsIntoWarehouse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bdgvProductsIntoWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bdgvProductsIntoWarehouse.ColumnHeadersHeight = 40;
            this.bdgvProductsIntoWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.bdgvProductsIntoWarehouse.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bdgvProductsIntoWarehouse.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bdgvProductsIntoWarehouse.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bdgvProductsIntoWarehouse.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bdgvProductsIntoWarehouse.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bdgvProductsIntoWarehouse.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bdgvProductsIntoWarehouse.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bdgvProductsIntoWarehouse.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bdgvProductsIntoWarehouse.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bdgvProductsIntoWarehouse.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bdgvProductsIntoWarehouse.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bdgvProductsIntoWarehouse.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bdgvProductsIntoWarehouse.CurrentTheme.Name = null;
            this.bdgvProductsIntoWarehouse.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bdgvProductsIntoWarehouse.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bdgvProductsIntoWarehouse.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bdgvProductsIntoWarehouse.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bdgvProductsIntoWarehouse.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bdgvProductsIntoWarehouse.DefaultCellStyle = dataGridViewCellStyle6;
            this.bdgvProductsIntoWarehouse.EnableHeadersVisualStyles = false;
            this.bdgvProductsIntoWarehouse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bdgvProductsIntoWarehouse.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bdgvProductsIntoWarehouse.HeaderBgColor = System.Drawing.Color.Empty;
            this.bdgvProductsIntoWarehouse.HeaderForeColor = System.Drawing.Color.White;
            this.bdgvProductsIntoWarehouse.Location = new System.Drawing.Point(36, 336);
            this.bdgvProductsIntoWarehouse.Name = "bdgvProductsIntoWarehouse";
            this.bdgvProductsIntoWarehouse.ReadOnly = true;
            this.bdgvProductsIntoWarehouse.RowHeadersVisible = false;
            this.bdgvProductsIntoWarehouse.RowHeadersWidth = 51;
            this.bdgvProductsIntoWarehouse.RowTemplate.Height = 40;
            this.bdgvProductsIntoWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdgvProductsIntoWarehouse.Size = new System.Drawing.Size(839, 227);
            this.bdgvProductsIntoWarehouse.TabIndex = 18;
            this.bdgvProductsIntoWarehouse.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bdgvProductsIntoWarehouse.DoubleClick += new System.EventHandler(this.bdgvProductsIntoWarehouse_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Product";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price Per Unit";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Unit Of Measure";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Product Category";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "State";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // blbTitleProductsIntoWarehouses
            // 
            this.blbTitleProductsIntoWarehouses.AllowParentOverrides = false;
            this.blbTitleProductsIntoWarehouses.AutoEllipsis = false;
            this.blbTitleProductsIntoWarehouses.AutoSize = false;
            this.blbTitleProductsIntoWarehouses.CursorType = null;
            this.blbTitleProductsIntoWarehouses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.blbTitleProductsIntoWarehouses.Location = new System.Drawing.Point(36, 295);
            this.blbTitleProductsIntoWarehouses.Name = "blbTitleProductsIntoWarehouses";
            this.blbTitleProductsIntoWarehouses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blbTitleProductsIntoWarehouses.Size = new System.Drawing.Size(244, 39);
            this.blbTitleProductsIntoWarehouses.TabIndex = 19;
            this.blbTitleProductsIntoWarehouses.Text = "<h3>Products Into Warehouses</h3>";
            this.blbTitleProductsIntoWarehouses.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.blbTitleProductsIntoWarehouses.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // blbTitleTableToSale
            // 
            this.blbTitleTableToSale.AllowParentOverrides = false;
            this.blbTitleTableToSale.AutoEllipsis = false;
            this.blbTitleTableToSale.AutoSize = false;
            this.blbTitleTableToSale.CursorType = null;
            this.blbTitleTableToSale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.blbTitleTableToSale.Location = new System.Drawing.Point(36, 24);
            this.blbTitleTableToSale.Name = "blbTitleTableToSale";
            this.blbTitleTableToSale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blbTitleTableToSale.Size = new System.Drawing.Size(278, 41);
            this.blbTitleTableToSale.TabIndex = 20;
            this.blbTitleTableToSale.Text = "<h3>Products included in the sale</h3>";
            this.blbTitleTableToSale.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.blbTitleTableToSale.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowMouseEffects = true;
            this.btnClose.AllowToggling = false;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.AutoGenerateColors = true;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges2;
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
            this.btnClose.Location = new System.Drawing.Point(896, 500);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 10;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 1;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(125)))), ((int)(((byte)(147)))));
            this.btnClose.onHoverState.BorderRadius = 10;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 1;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(125)))), ((int)(((byte)(147)))));
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
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(11)))), ((int)(((byte)(33)))));
            this.btnClose.OnPressedState.BorderRadius = 10;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(11)))), ((int)(((byte)(33)))));
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(95, 57);
            this.btnClose.TabIndex = 30;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // doSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 588);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.blbTitleProductsIntoWarehouses);
            this.Controls.Add(this.bdgvProductsIntoWarehouse);
            this.Controls.Add(this.blbTitleDoSale);
            this.Controls.Add(this.bbtnDoSale);
            this.Controls.Add(this.bdgvProductsIntoSale);
            this.Controls.Add(this.blbTitleTableToSale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "doSale";
            this.Text = "doSale";
            this.Load += new System.EventHandler(this.doSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgvProductsIntoSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgvProductsIntoWarehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView bdgvProductsIntoSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitOfMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateProduct;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bbtnDoSale;
        private Bunifu.UI.WinForms.BunifuLabel blbTitleDoSale;
        private Bunifu.UI.WinForms.BunifuDataGridView bdgvProductsIntoWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Bunifu.UI.WinForms.BunifuLabel blbTitleProductsIntoWarehouses;
        private Bunifu.UI.WinForms.BunifuLabel blbTitleTableToSale;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnClose;
    }
}