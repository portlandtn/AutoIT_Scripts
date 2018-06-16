namespace AutoIT_Scripts
{
    partial class FormHome
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
            this.Panel_NumberOfPhases = new System.Windows.Forms.Panel();
            this.RadioButton_OnePhase = new System.Windows.Forms.RadioButton();
            this.RadioButton_TwoPhases = new System.Windows.Forms.RadioButton();
            this.CheckBox_CreateJob = new System.Windows.Forms.CheckBox();
            this.CheckBox_BookJob = new System.Windows.Forms.CheckBox();
            this.CheckBox_CreateChangeOrder = new System.Windows.Forms.CheckBox();
            this.CheckBox_InvoiceJob = new System.Windows.Forms.CheckBox();
            this.CheckBox_RunDailySalesReport = new System.Windows.Forms.CheckBox();
            this.Panel_CreateJobOptions = new System.Windows.Forms.Panel();
            this.Button_Submit = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Label_CurrentDivision = new System.Windows.Forms.Label();
            this.Label_EnvironmentState = new System.Windows.Forms.Label();
            this.Label_AutoITTesting = new System.Windows.Forms.Label();
            this.tmrCheckDivision = new System.Windows.Forms.Timer(this.components);
            this.ComboBox_JobType = new System.Windows.Forms.ComboBox();
            this.Panel_NumberOfPhases.SuspendLayout();
            this.Panel_CreateJobOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_NumberOfPhases
            // 
            this.Panel_NumberOfPhases.Controls.Add(this.RadioButton_OnePhase);
            this.Panel_NumberOfPhases.Controls.Add(this.RadioButton_TwoPhases);
            this.Panel_NumberOfPhases.Location = new System.Drawing.Point(148, 77);
            this.Panel_NumberOfPhases.Name = "Panel_NumberOfPhases";
            this.Panel_NumberOfPhases.Size = new System.Drawing.Size(80, 54);
            this.Panel_NumberOfPhases.TabIndex = 6;
            // 
            // RadioButton_OnePhase
            // 
            this.RadioButton_OnePhase.AutoSize = true;
            this.RadioButton_OnePhase.Checked = true;
            this.RadioButton_OnePhase.Location = new System.Drawing.Point(3, 3);
            this.RadioButton_OnePhase.Name = "RadioButton_OnePhase";
            this.RadioButton_OnePhase.Size = new System.Drawing.Size(64, 17);
            this.RadioButton_OnePhase.TabIndex = 7;
            this.RadioButton_OnePhase.TabStop = true;
            this.RadioButton_OnePhase.Text = "1 Phase";
            this.RadioButton_OnePhase.UseVisualStyleBackColor = true;
            this.RadioButton_OnePhase.CheckedChanged += new System.EventHandler(this.RadioButton_OnePhase_CheckedChanged);
            // 
            // RadioButton_TwoPhases
            // 
            this.RadioButton_TwoPhases.AutoSize = true;
            this.RadioButton_TwoPhases.Location = new System.Drawing.Point(3, 26);
            this.RadioButton_TwoPhases.Name = "RadioButton_TwoPhases";
            this.RadioButton_TwoPhases.Size = new System.Drawing.Size(69, 17);
            this.RadioButton_TwoPhases.TabIndex = 8;
            this.RadioButton_TwoPhases.Text = "2 Phases";
            this.RadioButton_TwoPhases.UseVisualStyleBackColor = true;
            this.RadioButton_TwoPhases.CheckedChanged += new System.EventHandler(this.RadioButton_TwoPhases_CheckedChanged);
            // 
            // CheckBox_CreateJob
            // 
            this.CheckBox_CreateJob.AutoSize = true;
            this.CheckBox_CreateJob.Checked = true;
            this.CheckBox_CreateJob.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_CreateJob.Location = new System.Drawing.Point(3, 3);
            this.CheckBox_CreateJob.Name = "CheckBox_CreateJob";
            this.CheckBox_CreateJob.Size = new System.Drawing.Size(77, 17);
            this.CheckBox_CreateJob.TabIndex = 7;
            this.CheckBox_CreateJob.Text = "Create Job";
            this.CheckBox_CreateJob.UseVisualStyleBackColor = true;
            this.CheckBox_CreateJob.CheckedChanged += new System.EventHandler(this.CheckBox_CreateJob_CheckedChanged);
            // 
            // CheckBox_BookJob
            // 
            this.CheckBox_BookJob.AutoSize = true;
            this.CheckBox_BookJob.Checked = true;
            this.CheckBox_BookJob.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_BookJob.Location = new System.Drawing.Point(3, 26);
            this.CheckBox_BookJob.Name = "CheckBox_BookJob";
            this.CheckBox_BookJob.Size = new System.Drawing.Size(71, 17);
            this.CheckBox_BookJob.TabIndex = 8;
            this.CheckBox_BookJob.Text = "Book Job";
            this.CheckBox_BookJob.UseVisualStyleBackColor = true;
            this.CheckBox_BookJob.CheckedChanged += new System.EventHandler(this.CheckBox_BookJob_CheckedChanged);
            // 
            // CheckBox_CreateChangeOrder
            // 
            this.CheckBox_CreateChangeOrder.AutoSize = true;
            this.CheckBox_CreateChangeOrder.Location = new System.Drawing.Point(3, 49);
            this.CheckBox_CreateChangeOrder.Name = "CheckBox_CreateChangeOrder";
            this.CheckBox_CreateChangeOrder.Size = new System.Drawing.Size(126, 17);
            this.CheckBox_CreateChangeOrder.TabIndex = 9;
            this.CheckBox_CreateChangeOrder.Text = "Create Change Order";
            this.CheckBox_CreateChangeOrder.UseVisualStyleBackColor = true;
            this.CheckBox_CreateChangeOrder.CheckedChanged += new System.EventHandler(this.CheckBox_CreateChangeOrder_CheckedChanged);
            // 
            // CheckBox_InvoiceJob
            // 
            this.CheckBox_InvoiceJob.AutoSize = true;
            this.CheckBox_InvoiceJob.Location = new System.Drawing.Point(3, 72);
            this.CheckBox_InvoiceJob.Name = "CheckBox_InvoiceJob";
            this.CheckBox_InvoiceJob.Size = new System.Drawing.Size(81, 17);
            this.CheckBox_InvoiceJob.TabIndex = 10;
            this.CheckBox_InvoiceJob.Text = "Invoice Job";
            this.CheckBox_InvoiceJob.UseVisualStyleBackColor = true;
            this.CheckBox_InvoiceJob.CheckedChanged += new System.EventHandler(this.CheckBox_InvoiceJob_CheckedChanged);
            // 
            // CheckBox_RunDailySalesReport
            // 
            this.CheckBox_RunDailySalesReport.AutoSize = true;
            this.CheckBox_RunDailySalesReport.Location = new System.Drawing.Point(3, 95);
            this.CheckBox_RunDailySalesReport.Name = "CheckBox_RunDailySalesReport";
            this.CheckBox_RunDailySalesReport.Size = new System.Drawing.Size(136, 17);
            this.CheckBox_RunDailySalesReport.TabIndex = 11;
            this.CheckBox_RunDailySalesReport.Text = "Run Daily Sales Report";
            this.CheckBox_RunDailySalesReport.UseVisualStyleBackColor = true;
            this.CheckBox_RunDailySalesReport.CheckedChanged += new System.EventHandler(this.CheckBox_RunDailySalesReport_CheckedChanged);
            // 
            // Panel_CreateJobOptions
            // 
            this.Panel_CreateJobOptions.Controls.Add(this.CheckBox_CreateJob);
            this.Panel_CreateJobOptions.Controls.Add(this.CheckBox_RunDailySalesReport);
            this.Panel_CreateJobOptions.Controls.Add(this.CheckBox_BookJob);
            this.Panel_CreateJobOptions.Controls.Add(this.CheckBox_InvoiceJob);
            this.Panel_CreateJobOptions.Controls.Add(this.CheckBox_CreateChangeOrder);
            this.Panel_CreateJobOptions.Location = new System.Drawing.Point(234, 77);
            this.Panel_CreateJobOptions.Name = "Panel_CreateJobOptions";
            this.Panel_CreateJobOptions.Size = new System.Drawing.Size(202, 137);
            this.Panel_CreateJobOptions.TabIndex = 12;
            // 
            // Button_Submit
            // 
            this.Button_Submit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Submit.Location = new System.Drawing.Point(361, 220);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(92, 36);
            this.Button_Submit.TabIndex = 13;
            this.Button_Submit.Text = "Submit";
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cancel.Location = new System.Drawing.Point(263, 220);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(92, 36);
            this.Button_Cancel.TabIndex = 14;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Reset
            // 
            this.Button_Reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Reset.Location = new System.Drawing.Point(165, 220);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(92, 36);
            this.Button_Reset.TabIndex = 15;
            this.Button_Reset.Text = "Reset";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Label_CurrentDivision
            // 
            this.Label_CurrentDivision.AutoSize = true;
            this.Label_CurrentDivision.Location = new System.Drawing.Point(442, 80);
            this.Label_CurrentDivision.Name = "Label_CurrentDivision";
            this.Label_CurrentDivision.Size = new System.Drawing.Size(87, 13);
            this.Label_CurrentDivision.TabIndex = 16;
            this.Label_CurrentDivision.Text = "Current Division: ";
            // 
            // Label_EnvironmentState
            // 
            this.Label_EnvironmentState.AutoSize = true;
            this.Label_EnvironmentState.Location = new System.Drawing.Point(442, 93);
            this.Label_EnvironmentState.Name = "Label_EnvironmentState";
            this.Label_EnvironmentState.Size = new System.Drawing.Size(109, 13);
            this.Label_EnvironmentState.TabIndex = 17;
            this.Label_EnvironmentState.Text = "Current Environment: ";
            // 
            // Label_AutoITTesting
            // 
            this.Label_AutoITTesting.AutoSize = true;
            this.Label_AutoITTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AutoITTesting.Location = new System.Drawing.Point(135, 9);
            this.Label_AutoITTesting.Name = "Label_AutoITTesting";
            this.Label_AutoITTesting.Size = new System.Drawing.Size(349, 33);
            this.Label_AutoITTesting.TabIndex = 18;
            this.Label_AutoITTesting.Text = "AutoIT Testing Interface";
            // 
            // tmrCheckDivision
            // 
            this.tmrCheckDivision.Enabled = true;
            this.tmrCheckDivision.Tick += new System.EventHandler(this.Wait_Tick);
            // 
            // ComboBox_JobType
            // 
            this.ComboBox_JobType.FormattingEnabled = true;
            this.ComboBox_JobType.Location = new System.Drawing.Point(13, 77);
            this.ComboBox_JobType.Name = "ComboBox_JobType";
            this.ComboBox_JobType.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_JobType.TabIndex = 19;
            this.ComboBox_JobType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_JobType_SelectedIndexChanged);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(619, 270);
            this.Controls.Add(this.ComboBox_JobType);
            this.Controls.Add(this.Label_AutoITTesting);
            this.Controls.Add(this.Label_EnvironmentState);
            this.Controls.Add(this.Label_CurrentDivision);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Submit);
            this.Controls.Add(this.Panel_CreateJobOptions);
            this.Controls.Add(this.Panel_NumberOfPhases);
            this.Name = "FormHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.Panel_NumberOfPhases.ResumeLayout(false);
            this.Panel_NumberOfPhases.PerformLayout();
            this.Panel_CreateJobOptions.ResumeLayout(false);
            this.Panel_CreateJobOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Panel_NumberOfPhases;
        private System.Windows.Forms.RadioButton RadioButton_OnePhase;
        private System.Windows.Forms.RadioButton RadioButton_TwoPhases;
        private System.Windows.Forms.CheckBox CheckBox_CreateJob;
        private System.Windows.Forms.CheckBox CheckBox_BookJob;
        private System.Windows.Forms.CheckBox CheckBox_CreateChangeOrder;
        private System.Windows.Forms.CheckBox CheckBox_InvoiceJob;
        private System.Windows.Forms.CheckBox CheckBox_RunDailySalesReport;
        private System.Windows.Forms.Panel Panel_CreateJobOptions;
        private System.Windows.Forms.Button Button_Submit;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Label Label_CurrentDivision;
        private System.Windows.Forms.Label Label_EnvironmentState;
        private System.Windows.Forms.Label Label_AutoITTesting;
        private System.Windows.Forms.Timer tmrCheckDivision;
        private System.Windows.Forms.ComboBox ComboBox_JobType;
    }
}

