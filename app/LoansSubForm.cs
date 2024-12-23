using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTL.BusinessLayer;

namespace Simple_Crud_App
{
    public partial class LoansSubForm : Form
    {
        public int id = -1;
        public LoansSubForm()
        {
            InitializeComponent();
        }

        public void cleanInputs()
        {
            id = -1;
            LoanBookId.Text = LoanMemberId.Text = "";
            LoanBookId.PlaceholderText = "Book ID";
            LoanMemberId.PlaceholderText = "Member ID";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            cleanInputs();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            clsLoan loan;
            if (id == -1)
            {
                loan = new clsLoan(int.Parse(LoanMemberId.Text), int.Parse(LoanBookId.Text), LoanJoinDate.Value, LoanEndDate.Value);
                loan.AddLoan();
            }
            else
            {
                loan = new clsLoan(id, int.Parse(LoanMemberId.Text), int.Parse(LoanBookId.Text), LoanJoinDate.Value, LoanEndDate.Value);
                loan.UpdateLoan();
            }
            Hide();
            cleanInputs();
            MainHolder.main.refreshDataView();

        }
    }
}
