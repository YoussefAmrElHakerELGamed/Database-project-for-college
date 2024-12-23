namespace Simple_Crud_App
{
    partial class LoansSubForm
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
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.save = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cancel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LoanBookId = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoanMemberId = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.LoanJoinDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.LoanEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.addLoanMainLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.save);
            this.flowLayoutPanel4.Controls.Add(this.cancel);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(128, 136);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(72, 36);
            this.flowLayoutPanel4.TabIndex = 11;
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
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(307, 100);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LoanBookId);
            this.flowLayoutPanel2.Controls.Add(this.LoanMemberId);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(304, 43);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // LoanBookId
            // 
            this.LoanBookId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoanBookId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.LoanBookId.BorderRadius = 10;
            this.LoanBookId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoanBookId.DefaultText = "";
            this.LoanBookId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoanBookId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoanBookId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoanBookId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoanBookId.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.LoanBookId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LoanBookId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanBookId.ForeColor = System.Drawing.Color.White;
            this.LoanBookId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LoanBookId.Location = new System.Drawing.Point(4, 3);
            this.LoanBookId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoanBookId.Name = "LoanBookId";
            this.LoanBookId.PasswordChar = '\0';
            this.LoanBookId.PlaceholderForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoanBookId.PlaceholderText = "Book ID";
            this.LoanBookId.SelectedText = "";
            this.LoanBookId.Size = new System.Drawing.Size(144, 36);
            this.LoanBookId.TabIndex = 7;
            // 
            // LoanMemberId
            // 
            this.LoanMemberId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoanMemberId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.LoanMemberId.BorderRadius = 10;
            this.LoanMemberId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoanMemberId.DefaultText = "";
            this.LoanMemberId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoanMemberId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoanMemberId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoanMemberId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoanMemberId.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.LoanMemberId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LoanMemberId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanMemberId.ForeColor = System.Drawing.Color.White;
            this.LoanMemberId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LoanMemberId.Location = new System.Drawing.Point(156, 3);
            this.LoanMemberId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoanMemberId.Name = "LoanMemberId";
            this.LoanMemberId.PasswordChar = '\0';
            this.LoanMemberId.PlaceholderForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoanMemberId.PlaceholderText = "Member ID";
            this.LoanMemberId.SelectedText = "";
            this.LoanMemberId.Size = new System.Drawing.Size(144, 36);
            this.LoanMemberId.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.LoanJoinDate);
            this.flowLayoutPanel3.Controls.Add(this.LoanEndDate);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 52);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(304, 43);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // LoanJoinDate
            // 
            this.LoanJoinDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.LoanJoinDate.BorderRadius = 10;
            this.LoanJoinDate.BorderThickness = 1;
            this.LoanJoinDate.Checked = true;
            this.LoanJoinDate.FillColor = System.Drawing.Color.Empty;
            this.LoanJoinDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoanJoinDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LoanJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LoanJoinDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LoanJoinDate.Location = new System.Drawing.Point(3, 3);
            this.LoanJoinDate.MaxDate = new System.DateTime(2080, 12, 31, 0, 0, 0, 0);
            this.LoanJoinDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.LoanJoinDate.Name = "LoanJoinDate";
            this.LoanJoinDate.Size = new System.Drawing.Size(146, 36);
            this.LoanJoinDate.TabIndex = 7;
            this.LoanJoinDate.Value = new System.DateTime(2024, 12, 23, 0, 58, 15, 177);
            // 
            // LoanEndDate
            // 
            this.LoanEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.LoanEndDate.BorderRadius = 10;
            this.LoanEndDate.BorderThickness = 1;
            this.LoanEndDate.Checked = true;
            this.LoanEndDate.FillColor = System.Drawing.Color.Empty;
            this.LoanEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoanEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LoanEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LoanEndDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LoanEndDate.Location = new System.Drawing.Point(155, 3);
            this.LoanEndDate.MaxDate = new System.DateTime(2080, 12, 31, 0, 0, 0, 0);
            this.LoanEndDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.LoanEndDate.Name = "LoanEndDate";
            this.LoanEndDate.Size = new System.Drawing.Size(146, 36);
            this.LoanEndDate.TabIndex = 8;
            this.LoanEndDate.Value = new System.DateTime(2025, 12, 23, 0, 58, 0, 0);
            // 
            // addLoanMainLabel
            // 
            this.addLoanMainLabel.AccessibleName = "";
            this.addLoanMainLabel.AutoSize = false;
            this.addLoanMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.addLoanMainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addLoanMainLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLoanMainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.addLoanMainLabel.Location = new System.Drawing.Point(0, 0);
            this.addLoanMainLabel.Name = "addLoanMainLabel";
            this.addLoanMainLabel.Size = new System.Drawing.Size(330, 20);
            this.addLoanMainLabel.TabIndex = 9;
            this.addLoanMainLabel.Text = "add member";
            this.addLoanMainLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoansSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(330, 186);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.addLoanMainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(330, 186);
            this.MinimumSize = new System.Drawing.Size(330, 186);
            this.Name = "LoansSubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoansSubForm";
            this.TopMost = true;
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Guna.UI2.WinForms.Guna2CircleButton save;
        private Guna.UI2.WinForms.Guna2CircleButton cancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public Guna.UI2.WinForms.Guna2TextBox LoanBookId;
        public Guna.UI2.WinForms.Guna2TextBox LoanMemberId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public Guna.UI2.WinForms.Guna2DateTimePicker LoanJoinDate;
        public Guna.UI2.WinForms.Guna2DateTimePicker LoanEndDate;
        public Guna.UI2.WinForms.Guna2HtmlLabel addLoanMainLabel;
    }
}