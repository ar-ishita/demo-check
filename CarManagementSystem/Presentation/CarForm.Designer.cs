namespace CarManagementSystem
{
    partial class CarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_application_exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.CarDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_box_RegNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_Brand = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_Model = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_Available = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Search = new System.Windows.Forms.ComboBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1247, 155);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label_application_exit
            // 
            this.label_application_exit.AutoSize = true;
            this.label_application_exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_application_exit.ForeColor = System.Drawing.Color.White;
            this.label_application_exit.Location = new System.Drawing.Point(1217, 0);
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
            this.label2.Location = new System.Drawing.Point(532, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Cars";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR MANAGEMENT SYSTEM";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 905);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 27);
            this.panel3.TabIndex = 24;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.SteelBlue;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(169, 815);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(155, 41);
            this.button_back.TabIndex = 37;
            this.button_back.Text = "BACK";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // CarDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CarDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CarDGV.ColumnHeadersHeight = 30;
            this.CarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.CarDGV.GridColor = System.Drawing.Color.SteelBlue;
            this.CarDGV.Location = new System.Drawing.Point(548, 282);
            this.CarDGV.Name = "CarDGV";
            this.CarDGV.RowHeadersVisible = false;
            this.CarDGV.RowHeadersWidth = 62;
            this.CarDGV.RowTemplate.Height = 30;
            this.CarDGV.Size = new System.Drawing.Size(677, 585);
            this.CarDGV.TabIndex = 36;
            this.CarDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CarDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CarDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CarDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CarDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CarDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CarDGV.ThemeStyle.GridColor = System.Drawing.Color.SteelBlue;
            this.CarDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.CarDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CarDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CarDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CarDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.CarDGV.ThemeStyle.ReadOnly = false;
            this.CarDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CarDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CarDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CarDGV.ThemeStyle.RowsStyle.Height = 30;
            this.CarDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.CarDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDGV_CellContentClick);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(357, 735);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(154, 41);
            this.button_delete.TabIndex = 35;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.SteelBlue;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(169, 735);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(155, 41);
            this.button_edit.TabIndex = 34;
            this.button_edit.Text = "EDIT";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.SteelBlue;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(11, 735);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(130, 41);
            this.button_add.TabIndex = 33;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(11, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 37);
            this.label3.TabIndex = 31;
            this.label3.Text = "RegNo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(12, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 37);
            this.label8.TabIndex = 28;
            this.label8.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(11, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 37);
            this.label7.TabIndex = 27;
            this.label7.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(781, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 46);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cars List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(11, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 37);
            this.label4.TabIndex = 38;
            this.label4.Text = "Price";
            // 
            // text_box_RegNo
            // 
            this.text_box_RegNo.BorderColor = System.Drawing.Color.SteelBlue;
            this.text_box_RegNo.BorderRadius = 20;
            this.text_box_RegNo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.text_box_RegNo.BorderThickness = 3;
            this.text_box_RegNo.CustomizableEdges = customizableEdges9;
            this.text_box_RegNo.DefaultText = "";
            this.text_box_RegNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_RegNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_RegNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_RegNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_RegNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_RegNo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_box_RegNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_RegNo.Location = new System.Drawing.Point(180, 320);
            this.text_box_RegNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.text_box_RegNo.Name = "text_box_RegNo";
            this.text_box_RegNo.PasswordChar = '\0';
            this.text_box_RegNo.PlaceholderText = "";
            this.text_box_RegNo.SelectedText = "";
            this.text_box_RegNo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            this.text_box_RegNo.Size = new System.Drawing.Size(331, 51);
            this.text_box_RegNo.TabIndex = 41;
            this.text_box_RegNo.Tag = "RegNo";
            // 
            // text_box_Brand
            // 
            this.text_box_Brand.BorderColor = System.Drawing.Color.SteelBlue;
            this.text_box_Brand.BorderRadius = 20;
            this.text_box_Brand.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.text_box_Brand.BorderThickness = 3;
            this.text_box_Brand.CustomizableEdges = customizableEdges11;
            this.text_box_Brand.DefaultText = "";
            this.text_box_Brand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_Brand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_Brand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_Brand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_Brand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_Brand.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_box_Brand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_Brand.Location = new System.Drawing.Point(180, 404);
            this.text_box_Brand.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.text_box_Brand.Name = "text_box_Brand";
            this.text_box_Brand.PasswordChar = '\0';
            this.text_box_Brand.PlaceholderText = "";
            this.text_box_Brand.SelectedText = "";
            this.text_box_Brand.ShadowDecoration.CustomizableEdges = customizableEdges12;
            this.text_box_Brand.Size = new System.Drawing.Size(331, 51);
            this.text_box_Brand.TabIndex = 42;
            this.text_box_Brand.Tag = "Brand";
            // 
            // text_box_Model
            // 
            this.text_box_Model.BorderColor = System.Drawing.Color.SteelBlue;
            this.text_box_Model.BorderRadius = 20;
            this.text_box_Model.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.text_box_Model.BorderThickness = 3;
            this.text_box_Model.CustomizableEdges = customizableEdges13;
            this.text_box_Model.DefaultText = "";
            this.text_box_Model.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_Model.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_Model.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_Model.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_Model.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_Model.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_box_Model.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_Model.Location = new System.Drawing.Point(180, 491);
            this.text_box_Model.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.text_box_Model.Name = "text_box_Model";
            this.text_box_Model.PasswordChar = '\0';
            this.text_box_Model.PlaceholderText = "";
            this.text_box_Model.SelectedText = "";
            this.text_box_Model.ShadowDecoration.CustomizableEdges = customizableEdges14;
            this.text_box_Model.Size = new System.Drawing.Size(331, 51);
            this.text_box_Model.TabIndex = 43;
            this.text_box_Model.Tag = "Model";
            // 
            // text_box_Price
            // 
            this.text_box_Price.BorderColor = System.Drawing.Color.SteelBlue;
            this.text_box_Price.BorderRadius = 20;
            this.text_box_Price.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.text_box_Price.BorderThickness = 3;
            this.text_box_Price.CustomizableEdges = customizableEdges15;
            this.text_box_Price.DefaultText = "";
            this.text_box_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_Price.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_box_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_Price.Location = new System.Drawing.Point(180, 578);
            this.text_box_Price.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.text_box_Price.Name = "text_box_Price";
            this.text_box_Price.PasswordChar = '\0';
            this.text_box_Price.PlaceholderText = "";
            this.text_box_Price.SelectedText = "";
            this.text_box_Price.ShadowDecoration.CustomizableEdges = customizableEdges16;
            this.text_box_Price.Size = new System.Drawing.Size(331, 51);
            this.text_box_Price.TabIndex = 44;
            this.text_box_Price.Tag = "Price";
            // 
            // cb_Available
            // 
            this.cb_Available.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Available.ForeColor = System.Drawing.Color.SteelBlue;
            this.cb_Available.FormattingEnabled = true;
            this.cb_Available.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cb_Available.Location = new System.Drawing.Point(180, 658);
            this.cb_Available.Name = "cb_Available";
            this.cb_Available.Size = new System.Drawing.Size(331, 36);
            this.cb_Available.TabIndex = 45;
            this.cb_Available.Tag = "Available";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(0, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 37);
            this.label6.TabIndex = 46;
            this.label6.Text = "Available";
            // 
            // cb_Search
            // 
            this.cb_Search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Search.ForeColor = System.Drawing.Color.SteelBlue;
            this.cb_Search.FormattingEnabled = true;
            this.cb_Search.Items.AddRange(new object[] {
            "Available",
            "Rented"});
            this.cb_Search.Location = new System.Drawing.Point(663, 227);
            this.cb_Search.Name = "cb_Search";
            this.cb_Search.Size = new System.Drawing.Size(331, 36);
            this.cb_Search.TabIndex = 47;
            this.cb_Search.SelectionChangeCommitted += new System.EventHandler(this.cb_Search_SelectionChangeCommitted);
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Refresh.FlatAppearance.BorderSize = 0;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Refresh.ForeColor = System.Drawing.Color.White;
            this.button_Refresh.Location = new System.Drawing.Point(1000, 224);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(154, 41);
            this.button_Refresh.TabIndex = 48;
            this.button_Refresh.Text = "REFRESH";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 932);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.cb_Search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_Available);
            this.Controls.Add(this.text_box_Price);
            this.Controls.Add(this.text_box_Model);
            this.Controls.Add(this.text_box_Brand);
            this.Controls.Add(this.text_box_RegNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.CarDGV);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_application_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_back;
        private Guna.UI2.WinForms.Guna2DataGridView CarDGV;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox text_box_RegNo;
        private Guna.UI2.WinForms.Guna2TextBox text_box_Brand;
        private Guna.UI2.WinForms.Guna2TextBox text_box_Model;
        private Guna.UI2.WinForms.Guna2TextBox text_box_Price;
        private System.Windows.Forms.ComboBox cb_Available;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Search;
        private System.Windows.Forms.Button button_Refresh;
    }
}