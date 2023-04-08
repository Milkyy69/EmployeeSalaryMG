
namespace EmployeeSalaryMG.Salary
{
    partial class Frm_Salary_Gross
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
            System.Windows.Forms.Label salaryGrossIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label grossTypeIDLabel;
            this.employeeSalaryMGDataSet = new EmployeeSalaryMG.EmployeeSalaryMGDataSet();
            this.salaryGrossBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryGrossTableAdapter = new EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.SalaryGrossTableAdapter();
            this.tableAdapterManager = new EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager();
            this.grossTypesTableAdapter = new EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.GrossTypesTableAdapter();
            this.salaryGrossDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grossTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryGrossIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.grossTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            salaryGrossIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            grossTypeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryGrossBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryGrossDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // salaryGrossIDLabel
            // 
            salaryGrossIDLabel.AutoSize = true;
            salaryGrossIDLabel.Location = new System.Drawing.Point(50, 70);
            salaryGrossIDLabel.Name = "salaryGrossIDLabel";
            salaryGrossIDLabel.Size = new System.Drawing.Size(179, 40);
            salaryGrossIDLabel.TabIndex = 2;
            salaryGrossIDLabel.Text = "Salary Gross ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(50, 170);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(81, 40);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(718, 67);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(98, 40);
            amountLabel.TabIndex = 6;
            amountLabel.Text = "Amount:";
            // 
            // grossTypeIDLabel
            // 
            grossTypeIDLabel.AutoSize = true;
            grossTypeIDLabel.Location = new System.Drawing.Point(718, 165);
            grossTypeIDLabel.Name = "grossTypeIDLabel";
            grossTypeIDLabel.Size = new System.Drawing.Size(142, 40);
            grossTypeIDLabel.TabIndex = 7;
            grossTypeIDLabel.Text = "Gross Type :";
            // 
            // employeeSalaryMGDataSet
            // 
            this.employeeSalaryMGDataSet.DataSetName = "EmployeeSalaryMGDataSet";
            this.employeeSalaryMGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryGrossBindingSource
            // 
            this.salaryGrossBindingSource.DataMember = "SalaryGross";
            this.salaryGrossBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // salaryGrossTableAdapter
            // 
            this.salaryGrossTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaseSalaryLogsTableAdapter = null;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.GrossTypesTableAdapter = this.grossTypesTableAdapter;
            this.tableAdapterManager.PaymentStatesTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SalaryGrossTableAdapter = this.salaryGrossTableAdapter;
            this.tableAdapterManager.SalaryPaymentGrossTableAdapter = null;
            this.tableAdapterManager.SalaryPaymentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EmployeeSalaryMG.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // grossTypesTableAdapter
            // 
            this.grossTypesTableAdapter.ClearBeforeFill = true;
            // 
            // salaryGrossDataGridView
            // 
            this.salaryGrossDataGridView.AllowUserToAddRows = false;
            this.salaryGrossDataGridView.AllowUserToDeleteRows = false;
            this.salaryGrossDataGridView.AutoGenerateColumns = false;
            this.salaryGrossDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaryGrossDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.salaryGrossDataGridView.DataSource = this.salaryGrossBindingSource;
            this.salaryGrossDataGridView.Location = new System.Drawing.Point(0, 316);
            this.salaryGrossDataGridView.Name = "salaryGrossDataGridView";
            this.salaryGrossDataGridView.ReadOnly = true;
            this.salaryGrossDataGridView.RowHeadersWidth = 62;
            this.salaryGrossDataGridView.RowTemplate.Height = 28;
            this.salaryGrossDataGridView.Size = new System.Drawing.Size(1151, 220);
            this.salaryGrossDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SalaryGrossID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SalaryGrossID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 197;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GrossTypeID";
            this.dataGridViewTextBoxColumn4.DataSource = this.grossTypesBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Gross Type:";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "GrossTypeID";
            // 
            // grossTypesBindingSource
            // 
            this.grossTypesBindingSource.DataMember = "GrossTypes";
            this.grossTypesBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // salaryGrossIDTextBox
            // 
            this.salaryGrossIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryGrossBindingSource, "SalaryGrossID", true));
            this.salaryGrossIDTextBox.Location = new System.Drawing.Point(235, 67);
            this.salaryGrossIDTextBox.Name = "salaryGrossIDTextBox";
            this.salaryGrossIDTextBox.Size = new System.Drawing.Size(300, 49);
            this.salaryGrossIDTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryGrossBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(235, 161);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(300, 49);
            this.nameTextBox.TabIndex = 5;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryGrossBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(856, 58);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(267, 49);
            this.amountTextBox.TabIndex = 7;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // grossTypeIDComboBox
            // 
            this.grossTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salaryGrossBindingSource, "GrossTypeID", true));
            this.grossTypeIDComboBox.DataSource = this.grossTypesBindingSource;
            this.grossTypeIDComboBox.DisplayMember = "Name";
            this.grossTypeIDComboBox.FormattingEnabled = true;
            this.grossTypeIDComboBox.Location = new System.Drawing.Point(856, 157);
            this.grossTypeIDComboBox.Name = "grossTypeIDComboBox";
            this.grossTypeIDComboBox.Size = new System.Drawing.Size(267, 48);
            this.grossTypeIDComboBox.TabIndex = 8;
            this.grossTypeIDComboBox.ValueMember = "GrossTypeID";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(856, 221);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(128, 48);
            this.btnAddNew.TabIndex = 10;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1025, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 48);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(718, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 48);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1171, 55);
            this.label1.TabIndex = 20;
            this.label1.Text = "Salary Gross";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Salary_Gross
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1171, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(grossTypeIDLabel);
            this.Controls.Add(this.grossTypeIDComboBox);
            this.Controls.Add(salaryGrossIDLabel);
            this.Controls.Add(this.salaryGrossIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.salaryGrossDataGridView);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Salary_Gross";
            this.Text = "Frm_Salary_Gross";
            this.Load += new System.EventHandler(this.Frm_Salary_Gross_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryGrossBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryGrossDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeSalaryMGDataSet employeeSalaryMGDataSet;
        private System.Windows.Forms.BindingSource salaryGrossBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.SalaryGrossTableAdapter salaryGrossTableAdapter;
        private EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private EmployeeSalaryMGDataSetTableAdapters.GrossTypesTableAdapter grossTypesTableAdapter;
        private System.Windows.Forms.DataGridView salaryGrossDataGridView;
        private System.Windows.Forms.TextBox salaryGrossIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox grossTypeIDComboBox;
        private System.Windows.Forms.BindingSource grossTypesBindingSource;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
    }
}