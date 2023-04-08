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
    public partial class FrmUpdatedBaseSalary : Form
    {
        public EmployeeSalaryMGDataSet.BaseSalaryLogsRow BaseSalaryLogsRow { get; set; }
        public string EmployeeName
        {
            get => employeeNameTextBox.Text;
            set => employeeNameTextBox.Text = value;
        }
        public decimal BaseSalary
        {
            set
            {
                //Convert baseSalaryTextBox to String Because baseSalaryTextBox is decimal
                baseSalaryTextBox.Text = value.ToString();
                //
                amountTextBox.Text = value.ToString();
            }
        }
        public FrmUpdatedBaseSalary()
        {
            InitializeComponent();
        }
        private void FrmUpdatedBaseSalary_Load(object sender, EventArgs e)
        {
            BaseSalaryLogsRow = this.employeeSalaryMGDataSet.BaseSalaryLogs.NewBaseSalaryLogsRow();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BaseSalaryLogsRow!=null)
            {
                BaseSalaryLogsRow.Date = dateDateTimePicker.Value;
                BaseSalaryLogsRow.Amount = Convert.ToDecimal(amountTextBox.Text);
                BaseSalaryLogsRow.Description = descriptionTextBox.Text;
                this.employeeSalaryMGDataSet.BaseSalaryLogs.AddBaseSalaryLogsRow(BaseSalaryLogsRow);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
