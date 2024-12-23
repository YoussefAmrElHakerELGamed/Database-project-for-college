namespace Simple_Crud_App
{
    partial class StaffSubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.save = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cancel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.StaffFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.StaffLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.StaffShiftID = new Guna.UI2.WinForms.Guna2TextBox();
            this.StaffLibraryID = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.StaffAbsCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.StaffSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.StaffHireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.StaffResignDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.addBooksMainLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.save);
            this.flowLayoutPanel5.Controls.Add(this.cancel);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(189, 241);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(72, 38);
            this.flowLayoutPanel5.TabIndex = 11;
            // 
            // save
            // 
            this.save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.save.BorderThickness = 1;
            this.save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.save.Image = global::Simple_Crud_App.Properties.Resources.fi_rr_disk;
            this.save.ImageSize = new System.Drawing.Size(15, 15);
            this.save.Location = new System.Drawing.Point(3, 3);
            this.save.Name = "save";
            this.save.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.save.Size = new System.Drawing.Size(30, 30);
            this.save.TabIndex = 5;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancel
            // 
            this.cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.cancel.BorderThickness = 1;
            this.cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.cancel.Image = global::Simple_Crud_App.Properties.Resources.fi_rr_cross_small;
            this.cancel.ImageSize = new System.Drawing.Size(15, 15);
            this.cancel.Location = new System.Drawing.Point(39, 3);
            this.cancel.Name = "cancel";
            this.cancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cancel.Size = new System.Drawing.Size(30, 30);
            this.cancel.TabIndex = 6;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(426, 205);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.StaffFirstName);
            this.flowLayoutPanel2.Controls.Add(this.StaffLastName);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(423, 44);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // StaffFirstName
            // 
            this.StaffFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.StaffFirstName.BorderRadius = 10;
            this.StaffFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffFirstName.DefaultText = "";
            this.StaffFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StaffFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StaffFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.StaffFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffFirstName.ForeColor = System.Drawing.Color.White;
            this.StaffFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffFirstName.Location = new System.Drawing.Point(3, 3);
            this.StaffFirstName.Name = "StaffFirstName";
            this.StaffFirstName.PasswordChar = '\0';
            this.StaffFirstName.PlaceholderText = "First name";
            this.StaffFirstName.SelectedText = "";
            this.StaffFirstName.Size = new System.Drawing.Size(205, 34);
            this.StaffFirstName.TabIndex = 1;
            // 
            // StaffLastName
            // 
            this.StaffLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.StaffLastName.BorderRadius = 10;
            this.StaffLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffLastName.DefaultText = "";
            this.StaffLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StaffLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StaffLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.StaffLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLastName.ForeColor = System.Drawing.Color.White;
            this.StaffLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffLastName.Location = new System.Drawing.Point(214, 3);
            this.StaffLastName.Name = "StaffLastName";
            this.StaffLastName.PasswordChar = '\0';
            this.StaffLastName.PlaceholderText = "last Name";
            this.StaffLastName.SelectedText = "";
            this.StaffLastName.Size = new System.Drawing.Size(205, 34);
            this.StaffLastName.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.StaffShiftID);
            this.flowLayoutPanel3.Controls.Add(this.StaffLibraryID);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(423, 44);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // StaffShiftID
            // 
            this.StaffShiftID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.StaffShiftID.BorderRadius = 10;
            this.StaffShiftID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffShiftID.DefaultText = "";
            this.StaffShiftID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StaffShiftID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StaffShiftID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffShiftID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffShiftID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.StaffShiftID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffShiftID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffShiftID.ForeColor = System.Drawing.Color.White;
            this.StaffShiftID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffShiftID.Location = new System.Drawing.Point(3, 3);
            this.StaffShiftID.Name = "StaffShiftID";
            this.StaffShiftID.PasswordChar = '\0';
            this.StaffShiftID.PlaceholderText = "Shift ID";
            this.StaffShiftID.SelectedText = "";
            this.StaffShiftID.Size = new System.Drawing.Size(205, 36);
            this.StaffShiftID.TabIndex = 0;
            // 
            // StaffLibraryID
            // 
            this.StaffLibraryID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.StaffLibraryID.BorderRadius = 10;
            this.StaffLibraryID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffLibraryID.DefaultText = "";
            this.StaffLibraryID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StaffLibraryID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StaffLibraryID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffLibraryID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffLibraryID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.StaffLibraryID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffLibraryID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLibraryID.ForeColor = System.Drawing.Color.White;
            this.StaffLibraryID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffLibraryID.Location = new System.Drawing.Point(214, 3);
            this.StaffLibraryID.Name = "StaffLibraryID";
            this.StaffLibraryID.PasswordChar = '\0';
            this.StaffLibraryID.PlaceholderText = "Library ID";
            this.StaffLibraryID.SelectedText = "";
            this.StaffLibraryID.Size = new System.Drawing.Size(205, 36);
            this.StaffLibraryID.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.StaffAbsCount);
            this.flowLayoutPanel4.Controls.Add(this.StaffSalary);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 103);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(423, 44);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // StaffAbsCount
            // 
            this.StaffAbsCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.StaffAbsCount.BorderRadius = 10;
            this.StaffAbsCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffAbsCount.DefaultText = "";
            this.StaffAbsCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StaffAbsCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StaffAbsCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffAbsCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffAbsCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.StaffAbsCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffAbsCount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffAbsCount.ForeColor = System.Drawing.Color.White;
            this.StaffAbsCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffAbsCount.Location = new System.Drawing.Point(3, 3);
            this.StaffAbsCount.Name = "StaffAbsCount";
            this.StaffAbsCount.PasswordChar = '\0';
            this.StaffAbsCount.PlaceholderText = "Absences count";
            this.StaffAbsCount.SelectedText = "";
            this.StaffAbsCount.Size = new System.Drawing.Size(205, 36);
            this.StaffAbsCount.TabIndex = 0;
            // 
            // StaffSalary
            // 
            this.StaffSalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.StaffSalary.BorderRadius = 10;
            this.StaffSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffSalary.DefaultText = "";
            this.StaffSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StaffSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StaffSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffSalary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.StaffSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffSalary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffSalary.ForeColor = System.Drawing.Color.White;
            this.StaffSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffSalary.Location = new System.Drawing.Point(214, 3);
            this.StaffSalary.Name = "StaffSalary";
            this.StaffSalary.PasswordChar = '\0';
            this.StaffSalary.PlaceholderText = "Salary";
            this.StaffSalary.SelectedText = "";
            this.StaffSalary.Size = new System.Drawing.Size(205, 36);
            this.StaffSalary.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.StaffHireDate);
            this.flowLayoutPanel6.Controls.Add(this.StaffResignDate);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 153);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(423, 44);
            this.flowLayoutPanel6.TabIndex = 9;
            // 
            // StaffHireDate
            // 
            this.StaffHireDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffHireDate.BorderRadius = 10;
            this.StaffHireDate.BorderThickness = 1;
            this.StaffHireDate.Checked = true;
            this.StaffHireDate.FillColor = System.Drawing.Color.Empty;
            this.StaffHireDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffHireDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StaffHireDate.Location = new System.Drawing.Point(3, 3);
            this.StaffHireDate.MaxDate = new System.DateTime(2080, 12, 31, 0, 0, 0, 0);
            this.StaffHireDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.StaffHireDate.Name = "StaffHireDate";
            this.StaffHireDate.Size = new System.Drawing.Size(205, 36);
            this.StaffHireDate.TabIndex = 1;
            this.StaffHireDate.Value = new System.DateTime(2024, 12, 23, 12, 43, 38, 580);
            // 
            // StaffResignDate
            // 
            this.StaffResignDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffResignDate.BorderRadius = 10;
            this.StaffResignDate.BorderThickness = 1;
            this.StaffResignDate.FillColor = System.Drawing.Color.Empty;
            this.StaffResignDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffResignDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.StaffResignDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StaffResignDate.Location = new System.Drawing.Point(214, 3);
            this.StaffResignDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.StaffResignDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.StaffResignDate.Name = "StaffResignDate";
            this.StaffResignDate.ShowCheckBox = true;
            this.StaffResignDate.Size = new System.Drawing.Size(205, 36);
            this.StaffResignDate.TabIndex = 2;
            this.StaffResignDate.Value = new System.DateTime(2024, 12, 23, 12, 43, 38, 580);
            // 
            // addBooksMainLabel
            // 
            this.addBooksMainLabel.AccessibleName = "addStaffMainLabel";
            this.addBooksMainLabel.AutoSize = false;
            this.addBooksMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.addBooksMainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addBooksMainLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooksMainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.addBooksMainLabel.Location = new System.Drawing.Point(0, 0);
            this.addBooksMainLabel.Name = "addBooksMainLabel";
            this.addBooksMainLabel.Size = new System.Drawing.Size(450, 20);
            this.addBooksMainLabel.TabIndex = 9;
            this.addBooksMainLabel.Text = "add book";
            this.addBooksMainLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(450, 292);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.addBooksMainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffSubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffSubForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StaffSubForm_Load);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private Guna.UI2.WinForms.Guna2CircleButton save;
        private Guna.UI2.WinForms.Guna2CircleButton cancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public Guna.UI2.WinForms.Guna2TextBox StaffFirstName;
        public Guna.UI2.WinForms.Guna2TextBox StaffLastName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public Guna.UI2.WinForms.Guna2TextBox StaffShiftID;
        public Guna.UI2.WinForms.Guna2TextBox StaffLibraryID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        public Guna.UI2.WinForms.Guna2TextBox StaffAbsCount;
        public Guna.UI2.WinForms.Guna2TextBox StaffSalary;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        public Guna.UI2.WinForms.Guna2DateTimePicker StaffHireDate;
        public Guna.UI2.WinForms.Guna2DateTimePicker StaffResignDate;
        public Guna.UI2.WinForms.Guna2HtmlLabel addBooksMainLabel;
    }
}