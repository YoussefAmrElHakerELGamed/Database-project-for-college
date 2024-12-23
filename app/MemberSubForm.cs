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
    public partial class MemberSubForm : Form
    {
        public int id = -1;
        public MemberSubForm()
        {
            InitializeComponent();
        }

        public void clearInputs()
        {
            MemberFirstName.Text = MemberLastName.Text = "";
            MemberJoinDate.Value = MemberEndDate.Value = System.DateTime.Now;
            MemberFirstName.PlaceholderText = "Firs tName";
            MemberLastName.PlaceholderText = "Last Name";
            id = -1;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            clearInputs();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            clsMember member;
            if(MemberFirstName.Text.Length < 1) { MemberFirstName.PlaceholderText = "First name is required"; return; }
            if(MemberLastName.Text.Length < 1) { MemberLastName.PlaceholderText = "Last name is required"; return; }
            if(id == -1)
            {
                member = new clsMember(MemberFirstName.Text, MemberLastName.Text, MemberJoinDate.Value, MemberEndDate.Value);
                member.AddMember();
            }
            else
            {
                member = new clsMember(id, MemberFirstName.Text, MemberLastName.Text, MemberJoinDate.Value, MemberEndDate.Value);
                member.UpdateMember();
            }
            Hide();
            clearInputs();
            MainHolder.main.refreshDataView();
        }
    }
}
