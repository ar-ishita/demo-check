namespace CarManagementSystem
{
    partial class RentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_application_exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.text_box_RentPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_box_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.cb_CarReg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.text_box_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_CustId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1078);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 32);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_application_exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 184);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label_application_exit
            // 
            this.label_application_exit.AutoSize = true;
            this.label_application_exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_application_exit.ForeColor = System.Drawing.Color.White;
            this.label_application_exit.Location = new System.Drawing.Point(1352, 0);
            this.label_application_exit.Name = "label_application_exit";
            this.label_application_exit.Size = new System.Drawing.Size(31, 32);
            this.label_application_exit.TabIndex = 2;
            this.label_application_exit.Text = "X";
            this.label_application_exit.Click += new System.EventHandler(this.label_application_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(628, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR MANAGEMENT SYSTEM";
            // 
            // RentDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.RentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RentDGV.ColumnHeadersHeight = 30;
            this.RentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RentDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.RentDGV.GridColor = System.Drawing.Color.SteelBlue;
            this.RentDGV.Location = new System.Drawing.Point(628, 311);
            this.RentDGV.Name = "RentDGV";
            this.RentDGV.RowHeadersVisible = false;
            this.RentDGV.RowHeadersWidth = 62;
            this.RentDGV.RowTemplate.Height = 30;
            this.RentDGV.Size = new System.Drawing.Size(719, 699);
            this.RentDGV.TabIndex = 76;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RentDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.GridColor = System.Drawing.Color.SteelBlue;
            this.RentDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.RentDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RentDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RentDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.RentDGV.ThemeStyle.ReadOnly = false;
            this.RentDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RentDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RentDGV.ThemeStyle.RowsStyle.Height = 30;
            this.RentDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.RentDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentDGV_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(849, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 46);
            this.label5.TabIndex = 75;
            this.label5.Text = "Cars on Rent";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.SteelBlue;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(393, 869);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(155, 41);
            this.button_back.TabIndex = 69;
            this.button_back.Text = "BACK";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // text_box_RentPrice
            // 
            this.text_box_RentPrice.BorderColor = System.Drawing.Color.SteelBlue;
            this.text_box_RentPrice.BorderRadius = 20;
            this.text_box_RentPrice.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.text_box_RentPrice.BorderThickness = 3;
            this.text_box_RentPrice.CustomizableEdges = customizableEdges1;
            this.text_box_RentPrice.DefaultText = "";
            this.text_box_RentPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_RentPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_RentPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_RentPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_RentPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_RentPrice.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_box_RentPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_RentPrice.Location = new System.Drawing.Point(236, 790);
            this.text_box_RentPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.text_box_RentPrice.Name = "text_box_RentPrice";
            this.text_box_RentPrice.PasswordChar = '\0';
            this.text_box_RentPrice.PlaceholderText = "";
            this.text_box_RentPrice.SelectedText = "";
            this.text_box_RentPrice.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.text_box_RentPrice.Size = new System.Drawing.Size(331, 51);
            this.text_box_RentPrice.TabIndex = 73;
            this.text_box_RentPrice.Tag = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(33, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 37);
            this.label7.TabIndex = 63;
            this.label7.Text = "CustId";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(32, 790);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 37);
            this.label8.TabIndex = 64;
            this.label8.Text = "Price";
            // 
            // text_box_Id
            // 
            this.text_box_Id.BorderColor = System.Drawing.Color.SteelBlue;
            this.text_box_Id.BorderRadius = 20;
            this.text_box_Id.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.text_box_Id.BorderThickness = 3;
            this.text_box_Id.CustomizableEdges = customizableEdges3;
            this.text_box_Id.DefaultText = "";
            this.text_box_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_Id.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_box_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_Id.Location = new System.Drawing.Point(237, 345);
            this.text_box_Id.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.text_box_Id.Name = "text_box_Id";
            this.text_box_Id.PasswordChar = '\0';
            this.text_box_Id.PlaceholderText = "";
            this.text_box_Id.SelectedText = "";
            this.text_box_Id.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.text_box_Id.Size = new System.Drawing.Size(331, 51);
            this.text_box_Id.TabIndex = 71;
            this.text_box_Id.Tag = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(33, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 37);
            this.label3.TabIndex = 65;
            this.label3.Text = "Id";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.SteelBlue;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(33, 869);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(130, 41);
            this.button_add.TabIndex = 66;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(210, 869);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(154, 41);
            this.button_delete.TabIndex = 68;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // cb_CarReg
            // 
            this.cb_CarReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_CarReg.ForeColor = System.Drawing.Color.SteelBlue;
            this.cb_CarReg.FormattingEnabled = true;
            this.cb_CarReg.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cb_CarReg.Location = new System.Drawing.Point(237, 432);
            this.cb_CarReg.Name = "cb_CarReg";
            this.cb_CarReg.Size = new System.Drawing.Size(331, 36);
            this.cb_CarReg.TabIndex = 77;
            this.cb_CarReg.Tag = "CarReg";
            this.cb_CarReg.SelectionChangeCommitted += new System.EventHandler(this.cb_CarReg_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(33, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 37);
            this.label6.TabIndex = 78;
            this.label6.Text = "CarReg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(33, 581);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 37);
            this.label9.TabIndex = 79;
            this.label9.Text = "Name";
            // 
            // text_box_Name
            // 
            this.text_box_Name.BorderColor = System.Drawing.Color.SteelBlue;
            this.text_box_Name.BorderRadius = 20;
            this.text_box_Name.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.text_box_Name.BorderThickness = 3;
            this.text_box_Name.CustomizableEdges = customizableEdges5;
            this.text_box_Name.DefaultText = "";
            this.text_box_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_Name.Enabled = false;
            this.text_box_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_Name.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_box_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_Name.Location = new System.Drawing.Point(237, 581);
            this.text_box_Name.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.text_box_Name.Name = "text_box_Name";
            this.text_box_Name.PasswordChar = '\0';
            this.text_box_Name.PlaceholderText = "";
            this.text_box_Name.SelectedText = "";
            this.text_box_Name.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.text_box_Name.Size = new System.Drawing.Size(331, 51);
            this.text_box_Name.TabIndex = 80;
            this.text_box_Name.Tag = "CustomerName";
            this.text_box_Name.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(33, 656);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 37);
            this.label4.TabIndex = 81;
            this.label4.Text = "Rental Date";
            // 
            // RentDate
            // 
            this.RentDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RentDate.CalendarForeColor = System.Drawing.Color.SteelBlue;
            this.RentDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.RentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RentDate.Location = new System.Drawing.Point(237, 656);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(331, 39);
            this.RentDate.TabIndex = 83;
            this.RentDate.ValueChanged += new System.EventHandler(this.RentDate_ValueChanged);
            // 
            // ReturnDate
            // 
            this.ReturnDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReturnDate.CalendarForeColor = System.Drawing.Color.SteelBlue;
            this.ReturnDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.ReturnDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReturnDate.Location = new System.Drawing.Point(236, 724);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(331, 39);
            this.ReturnDate.TabIndex = 85;
            this.ReturnDate.ValueChanged += new System.EventHandler(this.ReturnDate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(32, 724);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 37);
            this.label10.TabIndex = 84;
            this.label10.Text = "Return Date";
            // 
            // cb_CustId
            // 
            this.cb_CustId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_CustId.ForeColor = System.Drawing.Color.SteelBlue;
            this.cb_CustId.FormattingEnabled = true;
            this.cb_CustId.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cb_CustId.Location = new System.Drawing.Point(237, 502);
            this.cb_CustId.Name = "cb_CustId";
            this.cb_CustId.Size = new System.Drawing.Size(331, 36);
            this.cb_CustId.TabIndex = 86;
            this.cb_CustId.Tag = "CustId";
            this.cb_CustId.SelectionChangeCommitted += new System.EventHandler(this.cb_CustId_SelectionChangeCommitted);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 1110);
            this.Controls.Add(this.cb_CustId);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RentDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_box_Name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_CarReg);
            this.Controls.Add(this.RentDGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.text_box_RentPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_box_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_application_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView RentDGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_back;
        private Guna.UI2.WinForms.Guna2TextBox text_box_RentPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox text_box_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ComboBox cb_CarReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox text_box_Name;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_CustId;
    }
}