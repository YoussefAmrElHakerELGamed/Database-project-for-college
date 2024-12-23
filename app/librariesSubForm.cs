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
    public partial class librariesSubForm : Form
    {
        public int id = -1;
        public librariesSubForm()
        {
            InitializeComponent();
        }

        private void CancelB_clicked(object sender, EventArgs e)
        {
            Hide();
            CleanInputs();
        }

        private void SaveB_clicked(object sender, EventArgs e)
        {
            clsLibrary newlibrary;
            if(LabName.Text.Length < 1) { LabName.PlaceholderText = "Name is required"; return; }
            if (id == -1)
            {
                newlibrary = new clsLibrary(LabName.Text, LabDate.Value);
                newlibrary.AddLibrary();
            }
            else
            {
                newlibrary = new clsLibrary(id, LabName.Text, LabDate.Value);
                newlibrary.UpdateLibrary();
            }
            CleanInputs();
            Hide();
            MainHolder.main.refreshDataView();
        }


        public void CleanInputs()
        {
            id = -1;
            LabName.Text = "";
            LabName.PlaceholderText = "Name";
            LabDate.Value = System.DateTime.Now;
        }


    }
}
