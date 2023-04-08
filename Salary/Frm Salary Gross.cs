using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryMG.Salary
{
    public partial class Frm_Salary_Gross : Form
    {
        public Frm_Salary_Gross()
        {
            InitializeComponent();
        }


        private void Frm_Salary_Gross_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSalaryMGDataSet.GrossTypes' table. You can move, or remove it, as needed.
            this.grossTypesTableAdapter.Fill(this.employeeSalaryMGDataSet.GrossTypes);
            // TODO: This line of code loads data into the 'employeeSalaryMGDataSet.SalaryGross' table. You can move, or remove it, as needed.
            this.salaryGrossTableAdapter.Fill(this.employeeSalaryMGDataSet.SalaryGross);

        }



        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.salaryGrossBindingSource.EndEdit();
            this.salaryGrossTableAdapter.Update(this.employeeSalaryMGDataSet.SalaryGross);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.salaryGrossBindingSource.AddNew();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.salaryGrossBindingSource.CancelEdit();

        }
    }
}
