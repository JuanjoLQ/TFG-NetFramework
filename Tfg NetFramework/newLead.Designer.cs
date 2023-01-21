namespace Tfg_NetFramework
{
    partial class newLead
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
            this.tbNewLeadAmount = new System.Windows.Forms.TextBox();
            this.lbNewLeadAmount = new System.Windows.Forms.Label();
            this.lbNewLeadStage = new System.Windows.Forms.Label();
            this.lbNewLeadDate = new System.Windows.Forms.Label();
            this.tbNewLeadName = new System.Windows.Forms.TextBox();
            this.lbNewLeadName = new System.Windows.Forms.Label();
            this.btnNewLeadSave = new System.Windows.Forms.Button();
            this.btnNewLeadCancel = new System.Windows.Forms.Button();
            this.dtpNewLeadDate = new System.Windows.Forms.DateTimePicker();
            this.cbNewLeadStage = new System.Windows.Forms.ComboBox();
            this.cbNewLeadAssignedTo = new System.Windows.Forms.ComboBox();
            this.lbNewLeadNotes = new System.Windows.Forms.Label();
            this.tbNewLeadNotes = new System.Windows.Forms.TextBox();
            this.lbNewLeadAssignedTo = new System.Windows.Forms.Label();
            this.dtpNewLeadCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.lbNewLeadCreatedAt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNewLeadAmount
            // 
            this.tbNewLeadAmount.Location = new System.Drawing.Point(105, 197);
            this.tbNewLeadAmount.Name = "tbNewLeadAmount";
            this.tbNewLeadAmount.Size = new System.Drawing.Size(116, 20);
            this.tbNewLeadAmount.TabIndex = 15;
            // 
            // lbNewLeadAmount
            // 
            this.lbNewLeadAmount.AutoSize = true;
            this.lbNewLeadAmount.Location = new System.Drawing.Point(35, 200);
            this.lbNewLeadAmount.Name = "lbNewLeadAmount";
            this.lbNewLeadAmount.Size = new System.Drawing.Size(43, 13);
            this.lbNewLeadAmount.TabIndex = 14;
            this.lbNewLeadAmount.Text = "Amount";
            // 
            // lbNewLeadStage
            // 
            this.lbNewLeadStage.AutoSize = true;
            this.lbNewLeadStage.Location = new System.Drawing.Point(35, 150);
            this.lbNewLeadStage.Name = "lbNewLeadStage";
            this.lbNewLeadStage.Size = new System.Drawing.Size(39, 13);
            this.lbNewLeadStage.TabIndex = 12;
            this.lbNewLeadStage.Text = "Stage*";
            // 
            // lbNewLeadDate
            // 
            this.lbNewLeadDate.AutoSize = true;
            this.lbNewLeadDate.Location = new System.Drawing.Point(35, 100);
            this.lbNewLeadDate.Name = "lbNewLeadDate";
            this.lbNewLeadDate.Size = new System.Drawing.Size(34, 13);
            this.lbNewLeadDate.TabIndex = 10;
            this.lbNewLeadDate.Text = "Date*";
            // 
            // tbNewLeadName
            // 
            this.tbNewLeadName.Location = new System.Drawing.Point(105, 47);
            this.tbNewLeadName.Name = "tbNewLeadName";
            this.tbNewLeadName.Size = new System.Drawing.Size(116, 20);
            this.tbNewLeadName.TabIndex = 9;
            // 
            // lbNewLeadName
            // 
            this.lbNewLeadName.AutoSize = true;
            this.lbNewLeadName.Location = new System.Drawing.Point(35, 50);
            this.lbNewLeadName.Name = "lbNewLeadName";
            this.lbNewLeadName.Size = new System.Drawing.Size(66, 13);
            this.lbNewLeadName.TabIndex = 8;
            this.lbNewLeadName.Text = "Lead Name*";
            // 
            // btnNewLeadSave
            // 
            this.btnNewLeadSave.Location = new System.Drawing.Point(189, 491);
            this.btnNewLeadSave.Name = "btnNewLeadSave";
            this.btnNewLeadSave.Size = new System.Drawing.Size(75, 23);
            this.btnNewLeadSave.TabIndex = 28;
            this.btnNewLeadSave.Text = "Save";
            this.btnNewLeadSave.UseVisualStyleBackColor = true;
            this.btnNewLeadSave.Click += new System.EventHandler(this.btnNewLeadSave_Click);
            // 
            // btnNewLeadCancel
            // 
            this.btnNewLeadCancel.Location = new System.Drawing.Point(87, 491);
            this.btnNewLeadCancel.Name = "btnNewLeadCancel";
            this.btnNewLeadCancel.Size = new System.Drawing.Size(75, 23);
            this.btnNewLeadCancel.TabIndex = 27;
            this.btnNewLeadCancel.Text = "Cancel";
            this.btnNewLeadCancel.UseVisualStyleBackColor = true;
            this.btnNewLeadCancel.Click += new System.EventHandler(this.btnNewLeadCancel_Click);
            // 
            // dtpNewLeadDate
            // 
            this.dtpNewLeadDate.Location = new System.Drawing.Point(105, 97);
            this.dtpNewLeadDate.Name = "dtpNewLeadDate";
            this.dtpNewLeadDate.Size = new System.Drawing.Size(213, 20);
            this.dtpNewLeadDate.TabIndex = 29;
            this.dtpNewLeadDate.Value = new System.DateTime(2023, 1, 21, 11, 37, 35, 0);
            // 
            // cbNewLeadStage
            // 
            this.cbNewLeadStage.FormattingEnabled = true;
            this.cbNewLeadStage.Items.AddRange(new object[] {
            "Prospecting",
            "Appointment",
            "Presentation",
            "Bought in",
            "Contract",
            "Closed Won",
            "Closed Lost"});
            this.cbNewLeadStage.Location = new System.Drawing.Point(105, 147);
            this.cbNewLeadStage.Name = "cbNewLeadStage";
            this.cbNewLeadStage.Size = new System.Drawing.Size(121, 21);
            this.cbNewLeadStage.TabIndex = 30;
            // 
            // cbNewLeadAssignedTo
            // 
            this.cbNewLeadAssignedTo.FormattingEnabled = true;
            this.cbNewLeadAssignedTo.Items.AddRange(new object[] {
            "Empleados"});
            this.cbNewLeadAssignedTo.Location = new System.Drawing.Point(105, 380);
            this.cbNewLeadAssignedTo.Name = "cbNewLeadAssignedTo";
            this.cbNewLeadAssignedTo.Size = new System.Drawing.Size(121, 21);
            this.cbNewLeadAssignedTo.TabIndex = 34;
            // 
            // lbNewLeadNotes
            // 
            this.lbNewLeadNotes.AutoSize = true;
            this.lbNewLeadNotes.Location = new System.Drawing.Point(35, 250);
            this.lbNewLeadNotes.Name = "lbNewLeadNotes";
            this.lbNewLeadNotes.Size = new System.Drawing.Size(35, 13);
            this.lbNewLeadNotes.TabIndex = 33;
            this.lbNewLeadNotes.Text = "Notes";
            // 
            // tbNewLeadNotes
            // 
            this.tbNewLeadNotes.Location = new System.Drawing.Point(105, 247);
            this.tbNewLeadNotes.Multiline = true;
            this.tbNewLeadNotes.Name = "tbNewLeadNotes";
            this.tbNewLeadNotes.Size = new System.Drawing.Size(116, 105);
            this.tbNewLeadNotes.TabIndex = 32;
            // 
            // lbNewLeadAssignedTo
            // 
            this.lbNewLeadAssignedTo.AutoSize = true;
            this.lbNewLeadAssignedTo.Location = new System.Drawing.Point(35, 380);
            this.lbNewLeadAssignedTo.Name = "lbNewLeadAssignedTo";
            this.lbNewLeadAssignedTo.Size = new System.Drawing.Size(70, 13);
            this.lbNewLeadAssignedTo.TabIndex = 31;
            this.lbNewLeadAssignedTo.Text = "Assigned To*";
            // 
            // dtpNewLeadCreatedAt
            // 
            this.dtpNewLeadCreatedAt.Location = new System.Drawing.Point(105, 430);
            this.dtpNewLeadCreatedAt.Name = "dtpNewLeadCreatedAt";
            this.dtpNewLeadCreatedAt.Size = new System.Drawing.Size(200, 20);
            this.dtpNewLeadCreatedAt.TabIndex = 35;
            this.dtpNewLeadCreatedAt.Value = new System.DateTime(2023, 1, 21, 11, 39, 34, 0);
            // 
            // lbNewLeadCreatedAt
            // 
            this.lbNewLeadCreatedAt.AutoSize = true;
            this.lbNewLeadCreatedAt.Location = new System.Drawing.Point(35, 430);
            this.lbNewLeadCreatedAt.Name = "lbNewLeadCreatedAt";
            this.lbNewLeadCreatedAt.Size = new System.Drawing.Size(61, 13);
            this.lbNewLeadCreatedAt.TabIndex = 36;
            this.lbNewLeadCreatedAt.Text = "Created At*";
            // 
            // newLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 759);
            this.Controls.Add(this.lbNewLeadCreatedAt);
            this.Controls.Add(this.dtpNewLeadCreatedAt);
            this.Controls.Add(this.cbNewLeadAssignedTo);
            this.Controls.Add(this.lbNewLeadNotes);
            this.Controls.Add(this.tbNewLeadNotes);
            this.Controls.Add(this.lbNewLeadAssignedTo);
            this.Controls.Add(this.cbNewLeadStage);
            this.Controls.Add(this.dtpNewLeadDate);
            this.Controls.Add(this.btnNewLeadSave);
            this.Controls.Add(this.btnNewLeadCancel);
            this.Controls.Add(this.tbNewLeadAmount);
            this.Controls.Add(this.lbNewLeadAmount);
            this.Controls.Add(this.lbNewLeadStage);
            this.Controls.Add(this.lbNewLeadDate);
            this.Controls.Add(this.tbNewLeadName);
            this.Controls.Add(this.lbNewLeadName);
            this.Name = "newLead";
            this.Text = "newLead";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewLeadAmount;
        private System.Windows.Forms.Label lbNewLeadAmount;
        private System.Windows.Forms.Label lbNewLeadStage;
        private System.Windows.Forms.Label lbNewLeadDate;
        private System.Windows.Forms.TextBox tbNewLeadName;
        private System.Windows.Forms.Label lbNewLeadName;
        private System.Windows.Forms.Button btnNewLeadSave;
        private System.Windows.Forms.Button btnNewLeadCancel;
        private System.Windows.Forms.DateTimePicker dtpNewLeadDate;
        private System.Windows.Forms.ComboBox cbNewLeadStage;
        private System.Windows.Forms.ComboBox cbNewLeadAssignedTo;
        private System.Windows.Forms.Label lbNewLeadNotes;
        private System.Windows.Forms.TextBox tbNewLeadNotes;
        private System.Windows.Forms.Label lbNewLeadAssignedTo;
        private System.Windows.Forms.DateTimePicker dtpNewLeadCreatedAt;
        private System.Windows.Forms.Label lbNewLeadCreatedAt;
    }
}