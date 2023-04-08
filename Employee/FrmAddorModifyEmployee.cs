using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryMG
{
    public partial class FrmAddorModifyEmployee : Form
    {
        public EmployeeSalaryMGDataSet.EmployeesRow EmployeeRow { get; set; }
        public EmployeeSalaryMGDataSet.BaseSalaryLogsRow BaseSalaryLogsRow { get; set; }
        public bool IsAdded { get; set; }
        public FrmAddorModifyEmployee()
        {
            InitializeComponent();
        }



        private void FrmAddorModifyEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSalaryMGDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.employeeSalaryMGDataSet.Departments);
            // TODO: This line of code loads data into the 'employeeSalaryMGDataSet.Employees' table. You can move, or remove it, as needed.
            // this.employeesTableAdapter.Fill(this.employeeSalaryMGDataSet.Employees);
            if (IsAdded)
            {
                EmployeeRow = this.employeeSalaryMGDataSet.Employees.NewEmployeesRow();
            }
            else
            {
                label1.Text="Updating Employee";
                this.employeeSalaryMGDataSet.Employees.ImportRow(EmployeeRow);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SetEmployee(EmployeeRow);
            if (IsAdded)
                this.employeeSalaryMGDataSet.Employees.AddEmployeesRow(EmployeeRow);
                this.employeesTableAdapter.Update(EmployeeRow);
                if (BaseSalaryLogsRow != null)
                {
                    BaseSalaryLogsRow.EmployeeID = EmployeeRow.EmployeeID;
                    this.baseSalaryLogsTableAdapter.Update(BaseSalaryLogsRow);
                }
                this.DialogResult = DialogResult.OK;
            

        }

        private void SetEmployee(EmployeeSalaryMGDataSet.EmployeesRow employeeRow)
        {

            if (employeeRow != null)
            {
                employeeRow.FirstName = firstNameTextBox.Text;
                employeeRow.LastName = lastNameTextBox.Text;
                employeeRow.Gender = genderComboBox.Text;
                employeeRow.BirthDate = birthDateDateTimePicker.Value;
                employeeRow.BaseSalary = Convert.ToDecimal(baseSalaryTextBox.Text);
                //Because BasseSalary has been Convert to Object;
                employeeRow.DepartmentID = (int)departmentIDComboBox.SelectedValue;
                employeeRow.Active = activeCheckBox.Checked;
            }

        }

        private void btnUpdateBaseSalary_Click(object sender, EventArgs e)
        {
            FrmUpdatedBaseSalary frmUpdated = new FrmUpdatedBaseSalary()
            {
               //Format to From UpdateBaseSalary;
                EmployeeName = $"{ firstNameTextBox.Text} {lastNameTextBox.Text }",
                BaseSalary = Convert.ToDecimal(baseSalaryTextBox.Text)
            };
            frmUpdated.ShowDialog();
            if (frmUpdated.DialogResult == DialogResult.OK)
            {
                BaseSalaryLogsRow = frmUpdated.BaseSalaryLogsRow;
                baseSalaryTextBox.Text = frmUpdated.BaseSalaryLogsRow.Amount.ToString();
            }
        }

        private void baseSalaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
