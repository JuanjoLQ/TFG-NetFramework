namespace Tfg_NetFramework
{
    partial class ItemList
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbNameCustomer = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbCreatedAt = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbStage = new System.Windows.Forms.Label();
            this.lbNotes = new System.Windows.Forms.Label();
            this.lbAssignedTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(19, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "lbName";
            // 
            // lbNameCustomer
            // 
            this.lbNameCustomer.AutoSize = true;
            this.lbNameCustomer.Location = new System.Drawing.Point(22, 184);
            this.lbNameCustomer.Name = "lbNameCustomer";
            this.lbNameCustomer.Size = new System.Drawing.Size(87, 13);
            this.lbNameCustomer.TabIndex = 1;
            this.lbNameCustomer.Text = "lbNameCustomer";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(19, 93);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(51, 13);
            this.lbAmount.TabIndex = 2;
            this.lbAmount.Text = "lbAmount";
            // 
            // lbCreatedAt
            // 
            this.lbCreatedAt.AutoSize = true;
            this.lbCreatedAt.Location = new System.Drawing.Point(19, 161);
            this.lbCreatedAt.Name = "lbCreatedAt";
            this.lbCreatedAt.Size = new System.Drawing.Size(62, 13);
            this.lbCreatedAt.TabIndex = 3;
            this.lbCreatedAt.Text = "lbCreatedAt";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(19, 40);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(38, 13);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "lbDate";
            // 
            // lbStage
            // 
            this.lbStage.AutoSize = true;
            this.lbStage.Location = new System.Drawing.Point(19, 67);
            this.lbStage.Name = "lbStage";
            this.lbStage.Size = new System.Drawing.Size(43, 13);
            this.lbStage.TabIndex = 5;
            this.lbStage.Text = "lbStage";
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Location = new System.Drawing.Point(19, 116);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(43, 13);
            this.lbNotes.TabIndex = 6;
            this.lbNotes.Text = "lbNotes";
            // 
            // lbAssignedTo
            // 
            this.lbAssignedTo.AutoSize = true;
            this.lbAssignedTo.Location = new System.Drawing.Point(19, 137);
            this.lbAssignedTo.Name = "lbAssignedTo";
            this.lbAssignedTo.Size = new System.Drawing.Size(71, 13);
            this.lbAssignedTo.TabIndex = 7;
            this.lbAssignedTo.Text = "lbAssignedTo";
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lbAssignedTo);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.lbStage);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbCreatedAt);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbNameCustomer);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ItemList";
            this.Size = new System.Drawing.Size(318, 257);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemList_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNameCustomer;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbCreatedAt;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbStage;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.Label lbAssignedTo;
    }
}
