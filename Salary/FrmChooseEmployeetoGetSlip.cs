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
    public partial class FrmChooseEmployeetoGetSlip : Form
    {
        public FrmChooseEmployeetoGetSlip()
        {
            InitializeComponent();
        }
        private void FrmChooseEmployeetoGetSlip_Load(object sender, EventArgs e)
        {
           
            FillDepartment();
            

        }

        private void FillDepartment()
        {
            this.departmentsTableAdapter.Fill(this.employeeSalaryMGDataSet.Departments);

            var row = this.employeeSalaryMGDataSet.Departments.NewDepartmentsRow();
            row.Name = "All Department";
            row.DepartmentID = -1;
            this.employeeSalaryMGDataSet.Departments.Rows.InsertAt(row,0);
            departmentCombox.SelectedIndex = 0;
        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void departmentCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentCombox.SelectedValue == null)return ;
            if (departmentCombox.SelectedIndex == 0)
            {
                this.employeesTableAdapter.Fill(this.employeeSalaryMGDataSet.Employees);
            }
            else
            {
                this.employeesTableAdapter.FillByDepartmentID(this.employeeSalaryMGDataSet.Employees, (int)
                departmentCombox.SelectedValue);
            }
        }
    }
}
