
namespace EmployeeSalaryMG
{
    partial class FrmUpdatedBaseSalary
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label baseSalaryLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.employeeSalaryMGDataSet = new EmployeeSalaryMG.EmployeeSalaryMGDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager();
            this.baseSalaryLogsTableAdapter = new EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.BaseSalaryLogsTableAdapter();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.baseSalaryLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            firstNameLabel = new System.Windows.Forms.Label();
            baseSalaryLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSalaryLogsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(20, 20);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(178, 40);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "EmployeeName:";
            // 
            // baseSalaryLabel
            // 
            baseSalaryLabel.AutoSize = true;
            baseSalaryLabel.Location = new System.Drawing.Point(20, 97);
            baseSalaryLabel.Name = "baseSalaryLabel";
            baseSalaryLabel.Size = new System.Drawing.Size(136, 40);
            baseSalaryLabel.TabIndex = 3;
            baseSalaryLabel.Text = "BaseSalary:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(20, 181);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(69, 40);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Date:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(20, 247);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(98, 40);
            amountLabel.TabIndex = 8;
            amountLabel.Text = "Amount:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(20, 300);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(133, 40);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Description:";
            // 
            // employeeSalaryMGDataSet
            // 
            this.employeeSalaryMGDataSet.DataSetName = "EmployeeSalaryMGDataSet";
            this.employeeSalaryMGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaseSalaryLogsTableAdapter = this.baseSalaryLogsTableAdapter;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.GrossTypesTableAdapter = null;
            this.tableAdapterManager.PaymentStatesTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SalaryGrossTableAdapter = null;
            this.tableAdapterManager.SalaryPaymentGrossTableAdapter = null;
            this.tableAdapterManager.SalaryPaymentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // baseSalaryLogsTableAdapter
            // 
            this.baseSalaryLogsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.employeeNameTextBox.Location = new System.Drawing.Point(204, 17);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.ReadOnly = true;
            this.employeeNameTextBox.Size = new System.Drawing.Size(327, 49);
            this.employeeNameTextBox.TabIndex = 2;
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BaseSalary", true));
            this.baseSalaryTextBox.Location = new System.Drawing.Point(178, 97);
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            this.baseSalaryTextBox.ReadOnly = true;
            this.baseSalaryTextBox.Size = new System.Drawing.Size(353, 49);
            this.baseSalaryTextBox.TabIndex = 4;
            // 
            // baseSalaryLogsBindingSource
            // 
            this.baseSalaryLogsBindingSource.DataMember = "BaseSalaryLogs";
            this.baseSalaryLogsBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.baseSalaryLogsBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(178, 181);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(363, 49);
            this.dateDateTimePicker.TabIndex = 7;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseSalaryLogsBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(178, 247);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(363, 49);
            this.amountTextBox.TabIndex = 9;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseSalaryLogsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(27, 343);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(514, 154);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(446, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 45);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(297, 503);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 46);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmUpdatedBaseSalary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(694, 590);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(baseSalaryLabel);
            this.Controls.Add(this.baseSalaryTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.employeeNameTextBox);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmUpdatedBaseSalary";
            this.Text = "FrmUpdatedBaseSalary";
            this.Load += new System.EventHandler(this.FrmUpdatedBaseSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSalaryLogsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeSalaryMGDataSet employeeSalaryMGDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private EmployeeSalaryMGDataSetTableAdapters.BaseSalaryLogsTableAdapter baseSalaryLogsTableAdapter;
        private System.Windows.Forms.BindingSource baseSalaryLogsBindingSource;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}