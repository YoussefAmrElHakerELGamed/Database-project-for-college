namespace Simple_Crud_App
{
    partial class librariesSubForm
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
            this.addlibraryMainLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabName = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.save = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cancel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // addlibraryMainLabel
            // 
            this.addlibraryMainLabel.AccessibleName = "addlibraryMainLabel";
            this.addlibraryMainLabel.AutoSize = false;
            this.addlibraryMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.addlibraryMainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addlibraryMainLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlibraryMainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.addlibraryMainLabel.Location = new System.Drawing.Point(0, 0);
            this.addlibraryMainLabel.Name = "addlibraryMainLabel";
            this.addlibraryMainLabel.Size = new System.Drawing.Size(325, 20);
            this.addlibraryMainLabel.TabIndex = 4;
            this.addlibraryMainLabel.Text = "add library";
            this.addlibraryMainLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabName
            // 
            this.LabName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.LabName.BorderRadius = 10;
            this.LabName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LabName.DefaultText = "";
            this.LabName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LabName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LabName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LabName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LabName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.LabName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LabName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LabName.Location = new System.Drawing.Point(57, 58);
            this.LabName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LabName.Name = "LabName";
            this.LabName.PasswordChar = '\0';
            this.LabName.PlaceholderForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LabName.PlaceholderText = "Name";
            this.LabName.SelectedText = "";
            this.LabName.Size = new System.Drawing.Size(211, 36);
            this.LabName.TabIndex = 5;
            // 
            // LabDate
            // 
            this.LabDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.LabDate.BorderRadius = 10;
            this.LabDate.BorderThickness = 1;
            this.LabDate.Checked = true;
            this.LabDate.FillColor = System.Drawing.Color.Empty;
            this.LabDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LabDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.LabDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.LabDate.Location = new System.Drawing.Point(57, 106);
            this.LabDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.LabDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.LabDate.Name = "LabDate";
            this.LabDate.Size = new System.Drawing.Size(211, 36);
            this.LabDate.TabIndex = 6;
            this.LabDate.Value = new System.DateTime(2024, 12, 23, 0, 58, 15, 177);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.save);
            this.flowLayoutPanel1.Controls.Add(this.cancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(126, 154);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(72, 36);
            this.flowLayoutPanel1.TabIndex = 7;
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
            this.save.Click += new System.EventHandler(this.SaveB_clicked);
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
            this.cancel.Click += new System.EventHandler(this.CancelB_clicked);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // librariesSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(325, 201);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LabDate);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.addlibraryMainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(325, 201);
            this.MinimumSize = new System.Drawing.Size(325, 201);
            this.Name = "librariesSubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public Guna.UI2.WinForms.Guna2TextBox LabName;
        public Guna.UI2.WinForms.Guna2HtmlLabel addlibraryMainLabel;
        public Guna.UI2.WinForms.Guna2DateTimePicker LabDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton save;
        private Guna.UI2.WinForms.Guna2CircleButton cancel;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
    }
}