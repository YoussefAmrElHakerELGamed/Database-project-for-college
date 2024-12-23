namespace Simple_Crud_App
{
    partial class BooksSubForm
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
            this.addBooksMainLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.BookGenre = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.BookLibraryid = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookCopies = new Guna.UI2.WinForms.Guna2TextBox();
            this.bookDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.save = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cancel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // addBooksMainLabel
            // 
            this.addBooksMainLabel.AccessibleName = "addlibraryMainLabel";
            this.addBooksMainLabel.AutoSize = false;
            this.addBooksMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.addBooksMainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addBooksMainLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooksMainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.addBooksMainLabel.Location = new System.Drawing.Point(0, 0);
            this.addBooksMainLabel.Name = "addBooksMainLabel";
            this.addBooksMainLabel.Size = new System.Drawing.Size(450, 20);
            this.addBooksMainLabel.TabIndex = 5;
            this.addBooksMainLabel.Text = "add book";
            this.addBooksMainLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(426, 158);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.BookTitle);
            this.flowLayoutPanel2.Controls.Add(this.BookGenre);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(423, 44);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // BookTitle
            // 
            this.BookTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.BookTitle.BorderRadius = 10;
            this.BookTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookTitle.DefaultText = "";
            this.BookTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.BookTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.BookTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitle.ForeColor = System.Drawing.Color.White;
            this.BookTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.BookTitle.Location = new System.Drawing.Point(3, 3);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.PasswordChar = '\0';
            this.BookTitle.PlaceholderText = "Title";
            this.BookTitle.SelectedText = "";
            this.BookTitle.Size = new System.Drawing.Size(205, 34);
            this.BookTitle.TabIndex = 1;
            // 
            // BookGenre
            // 
            this.BookGenre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.BookGenre.BorderRadius = 10;
            this.BookGenre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookGenre.DefaultText = "";
            this.BookGenre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookGenre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookGenre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.BookGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.BookGenre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookGenre.ForeColor = System.Drawing.Color.White;
            this.BookGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.BookGenre.Location = new System.Drawing.Point(214, 3);
            this.BookGenre.Name = "BookGenre";
            this.BookGenre.PasswordChar = '\0';
            this.BookGenre.PlaceholderText = "Genre";
            this.BookGenre.SelectedText = "";
            this.BookGenre.Size = new System.Drawing.Size(205, 34);
            this.BookGenre.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.BookAuthor);
            this.flowLayoutPanel3.Controls.Add(this.BookLibraryid);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(423, 44);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // BookAuthor
            // 
            this.BookAuthor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.BookAuthor.BorderRadius = 10;
            this.BookAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookAuthor.DefaultText = "";
            this.BookAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookAuthor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.BookAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.BookAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAuthor.ForeColor = System.Drawing.Color.White;
            this.BookAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.BookAuthor.Location = new System.Drawing.Point(3, 3);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.PasswordChar = '\0';
            this.BookAuthor.PlaceholderText = "Author";
            this.BookAuthor.SelectedText = "";
            this.BookAuthor.Size = new System.Drawing.Size(205, 36);
            this.BookAuthor.TabIndex = 0;
            // 
            // BookLibraryid
            // 
            this.BookLibraryid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.BookLibraryid.BorderRadius = 10;
            this.BookLibraryid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookLibraryid.DefaultText = "";
            this.BookLibraryid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookLibraryid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookLibraryid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookLibraryid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookLibraryid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.BookLibraryid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.BookLibraryid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookLibraryid.ForeColor = System.Drawing.Color.White;
            this.BookLibraryid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.BookLibraryid.Location = new System.Drawing.Point(214, 3);
            this.BookLibraryid.Name = "BookLibraryid";
            this.BookLibraryid.PasswordChar = '\0';
            this.BookLibraryid.PlaceholderText = "Library id";
            this.BookLibraryid.SelectedText = "";
            this.BookLibraryid.Size = new System.Drawing.Size(205, 36);
            this.BookLibraryid.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.BookCopies);
            this.flowLayoutPanel4.Controls.Add(this.bookDatePicker);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 103);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(423, 44);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // BookCopies
            // 
            this.BookCopies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.BookCopies.BorderRadius = 10;
            this.BookCopies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookCopies.DefaultText = "";
            this.BookCopies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookCopies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookCopies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookCopies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookCopies.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.BookCopies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.BookCopies.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCopies.ForeColor = System.Drawing.Color.White;
            this.BookCopies.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.BookCopies.Location = new System.Drawing.Point(3, 3);
            this.BookCopies.Name = "BookCopies";
            this.BookCopies.PasswordChar = '\0';
            this.BookCopies.PlaceholderText = "Copies";
            this.BookCopies.SelectedText = "";
            this.BookCopies.Size = new System.Drawing.Size(205, 36);
            this.BookCopies.TabIndex = 0;
            // 
            // bookDatePicker
            // 
            this.bookDatePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.bookDatePicker.BorderRadius = 10;
            this.bookDatePicker.BorderThickness = 1;
            this.bookDatePicker.Checked = true;
            this.bookDatePicker.FillColor = System.Drawing.Color.Empty;
            this.bookDatePicker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.bookDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bookDatePicker.Location = new System.Drawing.Point(214, 3);
            this.bookDatePicker.MaxDate = new System.DateTime(2080, 12, 31, 0, 0, 0, 0);
            this.bookDatePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.bookDatePicker.Name = "bookDatePicker";
            this.bookDatePicker.Size = new System.Drawing.Size(200, 36);
            this.bookDatePicker.TabIndex = 1;
            this.bookDatePicker.Value = new System.DateTime(2024, 12, 23, 12, 43, 38, 580);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.save);
            this.flowLayoutPanel5.Controls.Add(this.cancel);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(189, 185);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(72, 38);
            this.flowLayoutPanel5.TabIndex = 8;
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
            // BooksSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(450, 234);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.addBooksMainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(450, 234);
            this.MinimumSize = new System.Drawing.Size(450, 234);
            this.Name = "BooksSubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksSubForm";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public Guna.UI2.WinForms.Guna2HtmlLabel addBooksMainLabel;
        public Guna.UI2.WinForms.Guna2TextBox BookGenre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public Guna.UI2.WinForms.Guna2TextBox BookTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public Guna.UI2.WinForms.Guna2TextBox BookAuthor;
        public Guna.UI2.WinForms.Guna2TextBox BookLibraryid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        public Guna.UI2.WinForms.Guna2TextBox BookCopies;
        public Guna.UI2.WinForms.Guna2DateTimePicker bookDatePicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private Guna.UI2.WinForms.Guna2CircleButton save;
        private Guna.UI2.WinForms.Guna2CircleButton cancel;
    }
}