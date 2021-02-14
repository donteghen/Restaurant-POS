namespace Restaurant
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mydataGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.toppanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutpictureBox = new System.Windows.Forms.PictureBox();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.loadDBbutton = new System.Windows.Forms.Button();
            this.CatIDcomboBox = new System.Windows.Forms.ComboBox();
            this.Importbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.itempictureBox = new System.Windows.Forms.PictureBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemPricetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydataGridView)).BeginInit();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutpictureBox)).BeginInit();
            this.leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itempictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.toppanel);
            this.panel1.Controls.Add(this.leftpanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 586);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.mydataGridView);
            this.panel2.Location = new System.Drawing.Point(454, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 457);
            this.panel2.TabIndex = 3;
            // 
            // mydataGridView
            // 
            this.mydataGridView.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.mydataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mydataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.mydataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mydataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mydataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mydataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mydataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.ItemPrice,
            this.CatID,
            this.ItemImage});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mydataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.mydataGridView.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.mydataGridView.Location = new System.Drawing.Point(12, 12);
            this.mydataGridView.MultiSelect = false;
            this.mydataGridView.Name = "mydataGridView";
            this.mydataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mydataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mydataGridView.Size = new System.Drawing.Size(553, 430);
            this.mydataGridView.TabIndex = 0;
            this.mydataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mydataGridView_MouseClick);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.Name = "ItemID";
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            // 
            // ItemPrice
            // 
            this.ItemPrice.DataPropertyName = "ItemPrice";
            this.ItemPrice.HeaderText = "Item Price";
            this.ItemPrice.Name = "ItemPrice";
            // 
            // CatID
            // 
            this.CatID.DataPropertyName = "CatID";
            this.CatID.HeaderText = "Cat ID";
            this.CatID.Name = "CatID";
            // 
            // ItemImage
            // 
            this.ItemImage.DataPropertyName = "ItemImage";
            this.ItemImage.HeaderText = "Item Image";
            this.ItemImage.Name = "ItemImage";
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.toppanel.Controls.Add(this.label7);
            this.toppanel.Controls.Add(this.SearchtextBox);
            this.toppanel.Controls.Add(this.label6);
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Controls.Add(this.pictureBox1);
            this.toppanel.Controls.Add(this.logoutpictureBox);
            this.toppanel.Location = new System.Drawing.Point(12, 12);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1022, 78);
            this.toppanel.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(485, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Item Search";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.SearchtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchtextBox.ForeColor = System.Drawing.Color.White;
            this.SearchtextBox.Location = new System.Drawing.Point(587, 45);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(349, 26);
            this.SearchtextBox.TabIndex = 16;
            this.SearchtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchtextBox_KeyDown);
            this.SearchtextBox.MouseHover += new System.EventHandler(this.SearchtextBox_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(191, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // logoutpictureBox
            // 
            this.logoutpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoutpictureBox.Image")));
            this.logoutpictureBox.Location = new System.Drawing.Point(964, 3);
            this.logoutpictureBox.Name = "logoutpictureBox";
            this.logoutpictureBox.Size = new System.Drawing.Size(55, 50);
            this.logoutpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutpictureBox.TabIndex = 0;
            this.logoutpictureBox.TabStop = false;
            this.logoutpictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.leftpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftpanel.Controls.Add(this.loadDBbutton);
            this.leftpanel.Controls.Add(this.CatIDcomboBox);
            this.leftpanel.Controls.Add(this.Importbutton);
            this.leftpanel.Controls.Add(this.Clearbutton);
            this.leftpanel.Controls.Add(this.Deletebutton);
            this.leftpanel.Controls.Add(this.itempictureBox);
            this.leftpanel.Controls.Add(this.Savebutton);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.ItemPricetextBox);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.ItemNametextBox);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.leftpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.leftpanel.ForeColor = System.Drawing.Color.White;
            this.leftpanel.Location = new System.Drawing.Point(12, 106);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(426, 457);
            this.leftpanel.TabIndex = 1;
            // 
            // loadDBbutton
            // 
            this.loadDBbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(58)))), ((int)(((byte)(244)))));
            this.loadDBbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(2)))), ((int)(((byte)(63)))));
            this.loadDBbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(2)))), ((int)(((byte)(63)))));
            this.loadDBbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadDBbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loadDBbutton.Location = new System.Drawing.Point(19, 11);
            this.loadDBbutton.Name = "loadDBbutton";
            this.loadDBbutton.Size = new System.Drawing.Size(387, 49);
            this.loadDBbutton.TabIndex = 15;
            this.loadDBbutton.Text = "Load Database";
            this.loadDBbutton.UseVisualStyleBackColor = true;
            this.loadDBbutton.Click += new System.EventHandler(this.loadDBbutton_Click);
            // 
            // CatIDcomboBox
            // 
            this.CatIDcomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.CatIDcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatIDcomboBox.FormattingEnabled = true;
            this.CatIDcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CatIDcomboBox.Location = new System.Drawing.Point(128, 155);
            this.CatIDcomboBox.MaxLength = 2;
            this.CatIDcomboBox.Name = "CatIDcomboBox";
            this.CatIDcomboBox.Size = new System.Drawing.Size(49, 28);
            this.CatIDcomboBox.TabIndex = 14;
            // 
            // Importbutton
            // 
            this.Importbutton.BackColor = System.Drawing.Color.Aqua;
            this.Importbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(58)))), ((int)(((byte)(244)))));
            this.Importbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(2)))), ((int)(((byte)(63)))));
            this.Importbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(2)))), ((int)(((byte)(63)))));
            this.Importbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Importbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Importbutton.ForeColor = System.Drawing.Color.White;
            this.Importbutton.Image = ((System.Drawing.Image)(resources.GetObject("Importbutton.Image")));
            this.Importbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Importbutton.Location = new System.Drawing.Point(297, 219);
            this.Importbutton.Name = "Importbutton";
            this.Importbutton.Size = new System.Drawing.Size(109, 61);
            this.Importbutton.TabIndex = 13;
            this.Importbutton.Text = "Import";
            this.Importbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Importbutton.UseVisualStyleBackColor = false;
            this.Importbutton.Click += new System.EventHandler(this.Importbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.Fuchsia;
            this.Clearbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(58)))), ((int)(((byte)(244)))));
            this.Clearbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(2)))), ((int)(((byte)(63)))));
            this.Clearbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(2)))), ((int)(((byte)(63)))));
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Clearbutton.ForeColor = System.Drawing.Color.White;
            this.Clearbutton.Image = ((System.Drawing.Image)(resources.GetObject("Clearbutton.Image")));
            this.Clearbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clearbutton.Location = new System.Drawing.Point(287, 361);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(134, 70);
            this.Clearbutton.TabIndex = 12;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.Red;
            this.Deletebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(58)))), ((int)(((byte)(244)))));
            this.Deletebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(2)))), ((int)(((byte)(63)))));
            this.Deletebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(2)))), ((int)(((byte)(63)))));
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deletebutton.Location = new System.Drawing.Point(147, 361);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(134, 70);
            this.Deletebutton.TabIndex = 11;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // itempictureBox
            // 
            this.itempictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itempictureBox.Location = new System.Drawing.Point(128, 219);
            this.itempictureBox.Name = "itempictureBox";
            this.itempictureBox.Size = new System.Drawing.Size(163, 116);
            this.itempictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itempictureBox.TabIndex = 10;
            this.itempictureBox.TabStop = false;
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.Lime;
            this.Savebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(58)))), ((int)(((byte)(244)))));
            this.Savebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(2)))), ((int)(((byte)(63)))));
            this.Savebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(2)))), ((int)(((byte)(63)))));
            this.Savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Savebutton.ForeColor = System.Drawing.Color.White;
            this.Savebutton.Image = ((System.Drawing.Image)(resources.GetObject("Savebutton.Image")));
            this.Savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebutton.Location = new System.Drawing.Point(3, 361);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(138, 70);
            this.Savebutton.TabIndex = 9;
            this.Savebutton.Text = "Save";
            this.Savebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Item Image :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cat ID :";
            // 
            // ItemPricetextBox
            // 
            this.ItemPricetextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.ItemPricetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPricetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemPricetextBox.ForeColor = System.Drawing.Color.White;
            this.ItemPricetextBox.Location = new System.Drawing.Point(128, 114);
            this.ItemPricetextBox.Name = "ItemPricetextBox";
            this.ItemPricetextBox.Size = new System.Drawing.Size(144, 26);
            this.ItemPricetextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Price :";
            // 
            // ItemNametextBox
            // 
            this.ItemNametextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.ItemNametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemNametextBox.ForeColor = System.Drawing.Color.White;
            this.ItemNametextBox.Location = new System.Drawing.Point(128, 77);
            this.ItemNametextBox.Name = "ItemNametextBox";
            this.ItemNametextBox.Size = new System.Drawing.Size(144, 26);
            this.ItemNametextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name :";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Search By Name";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 586);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mydataGridView)).EndInit();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutpictureBox)).EndInit();
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itempictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.PictureBox logoutpictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView mydataGridView;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.TextBox ItemPricetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox itempictureBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Importbutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatID;
        private System.Windows.Forms.DataGridViewImageColumn ItemImage;
        private System.Windows.Forms.ComboBox CatIDcomboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadDBbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}