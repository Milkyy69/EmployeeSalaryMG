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
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSalaryMGDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.employeeSalaryMGDataSet.Departments);

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.departmentsBindingSource.AddNew();
            //AddNew is Build in Function
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Department can not empty");
                return;
            }
            
            this.departmentsBindingSource.EndEdit();
            //use for save data to table
            this.tableAdapterManager.UpdateAll(this.employeeSalaryMGDataSet);
            //use to send data from table to Database
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.departmentsBindingSource.CancelEdit();
            this.employeeSalaryMGDataSet.Departments.RejectChanges();

        }
    }
}
