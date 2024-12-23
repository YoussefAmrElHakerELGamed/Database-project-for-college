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
    public partial class StaffSubForm : Form
    {
        public int id = -1;
        public StaffSubForm()
        {
            InitializeComponent();
        }

        public void cleanInputs()
        {
            StaffFirstName.Text = StaffLastName.Text = StaffLibraryID.Text = StaffShiftID.Text = StaffAbsCount.Text = StaffSalary.Text = "";
            StaffHireDate.Value = StaffResignDate.Value = System.DateTime.Now;

            StaffFirstName.PlaceholderText = "First name";
            StaffLastName.PlaceholderText = "Last Name";
            StaffShiftID.PlaceholderText = "Shift ID";
            StaffLibraryID.PlaceholderText = "Library ID";
            StaffAbsCount.PlaceholderText = "Salary";
            StaffSalary.PlaceholderText = "Absences Count";

            StaffResignDate.Checked = false;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            clsEmployee employee;
            if (StaffFirstName.Text.Length < 1) { StaffFirstName.PlaceholderText = "Name is required"; return; }
            if (StaffLastName.Text.Length < 1) { StaffLastName.PlaceholderText = "last name is required"; return; }
            if (StaffShiftID.Text.Length < 1) { StaffFirstName.Text = "1";}
            if (StaffLibraryID.Text.Length < 1) { StaffLibraryID.PlaceholderText = "Library ID is required"; return; }
            if (StaffAbsCount.Text.Length < 1) { StaffAbsCount.Text = "0"; }
            if (StaffSalary.Text.Length < 1) { StaffSalary.PlaceholderText = "Salary is required"; return; }

            if (id == -1)
            {
                employee = new clsEmployee(StaffFirstName.Text, StaffLastName.Text, int.Parse(StaffLibraryID.Text), (DateTime)StaffHireDate.Value, StaffResignDate.Checked ? (DateTime)StaffResignDate.Value : DateTime.MaxValue, int.Parse(StaffSalary.Text), int.Parse(StaffAbsCount.Text), int.Parse(StaffShiftID.Text));
                employee.AddEmployee();
            }
            else
            {
                employee = new clsEmployee(id,StaffFirstName.Text, StaffLastName.Text, int.Parse(StaffLibraryID.Text), (DateTime)StaffHireDate.Value, StaffResignDate.Checked ? (DateTime)StaffResignDate.Value : DateTime.MaxValue, int.Parse(StaffSalary.Text), int.Parse(StaffAbsCount.Text), int.Parse(StaffShiftID.Text));
                employee.UpdateEmployee();
            }
            Hide();
            cleanInputs();
            MainHolder.main.refreshDataView();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            cleanInputs();
        }

        private void StaffSubForm_Load(object sender, EventArgs e)
        {
            StaffResignDate.Checked = false;
        }
    }
}
