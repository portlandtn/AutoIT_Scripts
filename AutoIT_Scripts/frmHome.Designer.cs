namespace AutoIT_Scripts
{
    partial class frmHome
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
            this.pnlNumberofPhases = new System.Windows.Forms.Panel();
            this.rboOnePhase = new System.Windows.Forms.RadioButton();
            this.rboTwoPhases = new System.Windows.Forms.RadioButton();
            this.chkCreateJob = new System.Windows.Forms.CheckBox();
            this.chkBookJob = new System.Windows.Forms.CheckBox();
            this.chkCreateCO = new System.Windows.Forms.CheckBox();
            this.chkInvoiceJob = new System.Windows.Forms.CheckBox();
            this.chkRunDailySalesReport = new System.Windows.Forms.CheckBox();
            this.pnlCreateJobOptions = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCurrentDivision = new System.Windows.Forms.Label();
            this.lblTestOrProdState = new System.Windows.Forms.Label();
            this.lblAutoITTesting = new System.Windows.Forms.Label();
            this.tmrCheckDivision = new System.Windows.Forms.Timer(this.components);
            this.cboJobTypeComboBox = new System.Windows.Forms.ComboBox();
            this.pnlNumberofPhases.SuspendLayout();
            this.pnlCreateJobOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNumberofPhases
            // 
            this.pnlNumberofPhases.Controls.Add(this.rboOnePhase);
            this.pnlNumberofPhases.Controls.Add(this.rboTwoPhases);
            this.pnlNumberofPhases.Location = new System.Drawing.Point(148, 77);
            this.pnlNumberofPhases.Name = "pnlNumberofPhases";
            this.pnlNumberofPhases.Size = new System.Drawing.Size(80, 54);
            this.pnlNumberofPhases.TabIndex = 6;
            // 
            // rboOnePhase
            // 
            this.rboOnePhase.AutoSize = true;
            this.rboOnePhase.Checked = true;
            this.rboOnePhase.Location = new System.Drawing.Point(3, 3);
            this.rboOnePhase.Name = "rboOnePhase";
            this.rboOnePhase.Size = new System.Drawing.Size(64, 17);
            this.rboOnePhase.TabIndex = 7;
            this.rboOnePhase.TabStop = true;
            this.rboOnePhase.Text = "1 Phase";
            this.rboOnePhase.UseVisualStyleBackColor = true;
            this.rboOnePhase.CheckedChanged += new System.EventHandler(this.rboOnePhase_CheckedChanged);
            // 
            // rboTwoPhases
            // 
            this.rboTwoPhases.AutoSize = true;
            this.rboTwoPhases.Location = new System.Drawing.Point(3, 26);
            this.rboTwoPhases.Name = "rboTwoPhases";
            this.rboTwoPhases.Size = new System.Drawing.Size(69, 17);
            this.rboTwoPhases.TabIndex = 8;
            this.rboTwoPhases.Text = "2 Phases";
            this.rboTwoPhases.UseVisualStyleBackColor = true;
            this.rboTwoPhases.CheckedChanged += new System.EventHandler(this.rboTwoPhases_CheckedChanged);
            // 
            // chkCreateJob
            // 
            this.chkCreateJob.AutoSize = true;
            this.chkCreateJob.Checked = true;
            this.chkCreateJob.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateJob.Location = new System.Drawing.Point(3, 3);
            this.chkCreateJob.Name = "chkCreateJob";
            this.chkCreateJob.Size = new System.Drawing.Size(77, 17);
            this.chkCreateJob.TabIndex = 7;
            this.chkCreateJob.Text = "Create Job";
            this.chkCreateJob.UseVisualStyleBackColor = true;
            this.chkCreateJob.CheckedChanged += new System.EventHandler(this.chkCreateJob_CheckedChanged);
            // 
            // chkBookJob
            // 
            this.chkBookJob.AutoSize = true;
            this.chkBookJob.Checked = true;
            this.chkBookJob.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBookJob.Location = new System.Drawing.Point(3, 26);
            this.chkBookJob.Name = "chkBookJob";
            this.chkBookJob.Size = new System.Drawing.Size(71, 17);
            this.chkBookJob.TabIndex = 8;
            this.chkBookJob.Text = "Book Job";
            this.chkBookJob.UseVisualStyleBackColor = true;
            this.chkBookJob.CheckedChanged += new System.EventHandler(this.chkBookJob_CheckedChanged);
            // 
            // chkCreateCO
            // 
            this.chkCreateCO.AutoSize = true;
            this.chkCreateCO.Location = new System.Drawing.Point(3, 49);
            this.chkCreateCO.Name = "chkCreateCO";
            this.chkCreateCO.Size = new System.Drawing.Size(126, 17);
            this.chkCreateCO.TabIndex = 9;
            this.chkCreateCO.Text = "Create Change Order";
            this.chkCreateCO.UseVisualStyleBackColor = true;
            this.chkCreateCO.CheckedChanged += new System.EventHandler(this.chkCreateCO_CheckedChanged);
            // 
            // chkInvoiceJob
            // 
            this.chkInvoiceJob.AutoSize = true;
            this.chkInvoiceJob.Location = new System.Drawing.Point(3, 72);
            this.chkInvoiceJob.Name = "chkInvoiceJob";
            this.chkInvoiceJob.Size = new System.Drawing.Size(81, 17);
            this.chkInvoiceJob.TabIndex = 10;
            this.chkInvoiceJob.Text = "Invoice Job";
            this.chkInvoiceJob.UseVisualStyleBackColor = true;
            this.chkInvoiceJob.CheckedChanged += new System.EventHandler(this.chkInvoiceJob_CheckedChanged);
            // 
            // chkRunDailySalesReport
            // 
            this.chkRunDailySalesReport.AutoSize = true;
            this.chkRunDailySalesReport.Location = new System.Drawing.Point(3, 95);
            this.chkRunDailySalesReport.Name = "chkRunDailySalesReport";
            this.chkRunDailySalesReport.Size = new System.Drawing.Size(136, 17);
            this.chkRunDailySalesReport.TabIndex = 11;
            this.chkRunDailySalesReport.Text = "Run Daily Sales Report";
            this.chkRunDailySalesReport.UseVisualStyleBackColor = true;
            this.chkRunDailySalesReport.CheckedChanged += new System.EventHandler(this.chkRunDailySalesReport_CheckedChanged);
            // 
            // pnlCreateJobOptions
            // 
            this.pnlCreateJobOptions.Controls.Add(this.chkCreateJob);
            this.pnlCreateJobOptions.Controls.Add(this.chkRunDailySalesReport);
            this.pnlCreateJobOptions.Controls.Add(this.chkBookJob);
            this.pnlCreateJobOptions.Controls.Add(this.chkInvoiceJob);
            this.pnlCreateJobOptions.Controls.Add(this.chkCreateCO);
            this.pnlCreateJobOptions.Location = new System.Drawing.Point(234, 77);
            this.pnlCreateJobOptions.Name = "pnlCreateJobOptions";
            this.pnlCreateJobOptions.Size = new System.Drawing.Size(202, 137);
            this.pnlCreateJobOptions.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(361, 220);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 36);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(263, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(165, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 36);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCurrentDivision
            // 
            this.lblCurrentDivision.AutoSize = true;
            this.lblCurrentDivision.Location = new System.Drawing.Point(442, 80);
            this.lblCurrentDivision.Name = "lblCurrentDivision";
            this.lblCurrentDivision.Size = new System.Drawing.Size(87, 13);
            this.lblCurrentDivision.TabIndex = 16;
            this.lblCurrentDivision.Text = "Current Division: ";
            // 
            // lblTestOrProdState
            // 
            this.lblTestOrProdState.AutoSize = true;
            this.lblTestOrProdState.Location = new System.Drawing.Point(442, 93);
            this.lblTestOrProdState.Name = "lblTestOrProdState";
            this.lblTestOrProdState.Size = new System.Drawing.Size(109, 13);
            this.lblTestOrProdState.TabIndex = 17;
            this.lblTestOrProdState.Text = "Current Environment: ";
            // 
            // lblAutoITTesting
            // 
            this.lblAutoITTesting.AutoSize = true;
            this.lblAutoITTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoITTesting.Location = new System.Drawing.Point(135, 9);
            this.lblAutoITTesting.Name = "lblAutoITTesting";
            this.lblAutoITTesting.Size = new System.Drawing.Size(349, 33);
            this.lblAutoITTesting.TabIndex = 18;
            this.lblAutoITTesting.Text = "AutoIT Testing Interface";
            // 
            // tmrCheckDivision
            // 
            this.tmrCheckDivision.Enabled = true;
            this.tmrCheckDivision.Tick += new System.EventHandler(this.wait_Tick);
            // 
            // cboJobTypeComboBox
            // 
            this.cboJobTypeComboBox.FormattingEnabled = true;
            this.cboJobTypeComboBox.Location = new System.Drawing.Point(13, 77);
            this.cboJobTypeComboBox.Name = "cboJobTypeComboBox";
            this.cboJobTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.cboJobTypeComboBox.TabIndex = 19;
            this.cboJobTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.cboJobTypeComboBox_SelectedIndexChanged);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(619, 270);
            this.Controls.Add(this.cboJobTypeComboBox);
            this.Controls.Add(this.lblAutoITTesting);
            this.Controls.Add(this.lblTestOrProdState);
            this.Controls.Add(this.lblCurrentDivision);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlCreateJobOptions);
            this.Controls.Add(this.pnlNumberofPhases);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlNumberofPhases.ResumeLayout(false);
            this.pnlNumberofPhases.PerformLayout();
            this.pnlCreateJobOptions.ResumeLayout(false);
            this.pnlCreateJobOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlNumberofPhases;
        private System.Windows.Forms.RadioButton rboOnePhase;
        private System.Windows.Forms.RadioButton rboTwoPhases;
        private System.Windows.Forms.CheckBox chkCreateJob;
        private System.Windows.Forms.CheckBox chkBookJob;
        private System.Windows.Forms.CheckBox chkCreateCO;
        private System.Windows.Forms.CheckBox chkInvoiceJob;
        private System.Windows.Forms.CheckBox chkRunDailySalesReport;
        private System.Windows.Forms.Panel pnlCreateJobOptions;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCurrentDivision;
        private System.Windows.Forms.Label lblTestOrProdState;
        private System.Windows.Forms.Label lblAutoITTesting;
        private System.Windows.Forms.Timer tmrCheckDivision;
        private System.Windows.Forms.ComboBox cboJobTypeComboBox;
    }
}

