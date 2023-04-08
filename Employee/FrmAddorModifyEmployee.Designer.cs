
namespace EmployeeSalaryMG
{
    partial class FrmAddorModifyEmployee
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
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label baseSalaryLabel;
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label departmentIDLabel;
            this.employeeSalaryMGDataSet = new EmployeeSalaryMG.EmployeeSalaryMGDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager();
            this.baseSalaryLogsTableAdapter = new EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.BaseSalaryLogsTableAdapter();
            this.departmentsTableAdapter = new EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.departmentIDComboBox = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdateBaseSalary = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            employeeIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            baseSalaryLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            departmentIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(31, 128);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(148, 40);
            employeeIDLabel.TabIndex = 1;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(31, 183);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(130, 40);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(31, 238);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(128, 40);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(31, 349);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(121, 40);
            birthDateLabel.TabIndex = 9;
            birthDateLabel.Text = "Birth Date:";
            // 
            // baseSalaryLabel
            // 
            baseSalaryLabel.AutoSize = true;
            baseSalaryLabel.Location = new System.Drawing.Point(31, 403);
            baseSalaryLabel.Name = "baseSalaryLabel";
            baseSalaryLabel.Size = new System.Drawing.Size(142, 40);
            baseSalaryLabel.TabIndex = 11;
            baseSalaryLabel.Text = "Base Salary:";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(31, 515);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(83, 40);
            activeLabel.TabIndex = 15;
            activeLabel.Text = "Active:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(31, 294);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(96, 40);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "Gender:";
            // 
            // departmentIDLabel
            // 
            departmentIDLabel.AutoSize = true;
            departmentIDLabel.Location = new System.Drawing.Point(31, 458);
            departmentIDLabel.Name = "departmentIDLabel";
            departmentIDLabel.Size = new System.Drawing.Size(143, 40);
            departmentIDLabel.TabIndex = 17;
            departmentIDLabel.Text = "Department :";
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
            this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
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
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(202, 125);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.ReadOnly = true;
            this.employeeIDTextBox.Size = new System.Drawing.Size(267, 49);
            this.employeeIDTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(202, 180);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(267, 49);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(202, 235);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(267, 49);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(202, 345);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(267, 49);
            this.birthDateDateTimePicker.TabIndex = 3;
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BaseSalary", true));
            this.baseSalaryTextBox.Location = new System.Drawing.Point(202, 400);
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            this.baseSalaryTextBox.ReadOnly = true;
            this.baseSalaryTextBox.Size = new System.Drawing.Size(201, 49);
            this.baseSalaryTextBox.TabIndex = 12;
            this.baseSalaryTextBox.Text = "0.00";
            this.baseSalaryTextBox.TextChanged += new System.EventHandler(this.baseSalaryTextBox_TextChanged);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeesBindingSource, "Active", true));
            this.activeCheckBox.Location = new System.Drawing.Point(202, 510);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(267, 49);
            this.activeCheckBox.TabIndex = 5;
            this.activeCheckBox.Text = "Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(202, 290);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(267, 48);
            this.genderComboBox.TabIndex = 2;
            // 
            // departmentIDComboBox
            // 
            this.departmentIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "DepartmentID", true));
            this.departmentIDComboBox.DataSource = this.departmentsBindingSource;
            this.departmentIDComboBox.DisplayMember = "Name";
            this.departmentIDComboBox.FormattingEnabled = true;
            this.departmentIDComboBox.Location = new System.Drawing.Point(202, 455);
            this.departmentIDComboBox.Name = "departmentIDComboBox";
            this.departmentIDComboBox.Size = new System.Drawing.Size(267, 48);
            this.departmentIDComboBox.TabIndex = 4;
            this.departmentIDComboBox.ValueMember = "DepartmentID";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 56);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add New Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(229, 564);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 46);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdateBaseSalary
            // 
            this.btnUpdateBaseSalary.Location = new System.Drawing.Point(404, 400);
            this.btnUpdateBaseSalary.Name = "btnUpdateBaseSalary";
            this.btnUpdateBaseSalary.Size = new System.Drawing.Size(65, 49);
            this.btnUpdateBaseSalary.TabIndex = 21;
            this.btnUpdateBaseSalary.Text = "...";
            this.btnUpdateBaseSalary.UseVisualStyleBackColor = true;
            this.btnUpdateBaseSalary.Click += new System.EventHandler(this.btnUpdateBaseSalary_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 565);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddorModifyEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(510, 664);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateBaseSalary);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(departmentIDLabel);
            this.Controls.Add(this.departmentIDComboBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(baseSalaryLabel);
            this.Controls.Add(this.baseSalaryTextBox);
            this.Controls.Add(activeLabel);
            this.Controls.Add(this.activeCheckBox);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAddorModifyEmployee";
            this.Text = "FrmAddorModifyEmployee";
            this.Load += new System.EventHandler(this.FrmAddorModifyEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeSalaryMGDataSet employeeSalaryMGDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox departmentIDComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdateBaseSalary;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.BaseSalaryLogsTableAdapter baseSalaryLogsTableAdapter;
    }
}