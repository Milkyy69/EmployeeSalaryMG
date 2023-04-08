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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeSalaryMGDataSet);

        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSalaryMGDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeSalaryMGDataSet.Employees);

        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Console.WriteLine(e.ColumnIndex);
            // Console.WriteLine(e.RowIndex);
            // Use to show the Column and Row Index
            //ColumninDex 8= Edit Column
            if (e.ColumnIndex == -1) return;
            if (e.ColumnIndex == 8)
            {
                var dataRowView = employeesBindingSource.Current as DataRowView;//can use binding source or datagrid view
                var emloyeeRow = dataRowView.Row as EmployeeSalaryMGDataSet.EmployeesRow;
                FrmAddorModifyEmployee frm = new FrmAddorModifyEmployee()
                {
                    EmployeeRow = emloyeeRow,

                };
                frm.ShowDialog();
               
            }
        }
        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            FrmAddorModifyEmployee frm = new FrmAddorModifyEmployee();
            frm.IsAdded = true;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.employeeSalaryMGDataSet.Employees.ImportRow(frm.EmployeeRow);
            }
        }
        // Search Create by Qurey
        //private void searchEmployeeToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.employeesTableAdapter.SearchEmployee(this.employeeSalaryMGDataSet.Employees, searchToolStripTextBox.Text);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Search Value is Empty", "Error");
                return;
            }
                this.employeesTableAdapter.SearchEmployee(this.employeeSalaryMGDataSet.Employees,
                    txtSearch.Text);
                //SearchEmployee() Qurey that we create;
            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.employeeSalaryMGDataSet.Employees);
        }
    }
}
