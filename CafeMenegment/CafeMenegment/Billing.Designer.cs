namespace CafeMenegment
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CakeBtn = new System.Windows.Forms.RadioButton();
            this.SaladBtn = new System.Windows.Forms.RadioButton();
            this.CoockieBtn = new System.Windows.Forms.RadioButton();
            this.CinnamonbunBtn = new System.Windows.Forms.RadioButton();
            this.CoffewithmilkBtn = new System.Windows.Forms.RadioButton();
            this.CoffeBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SettingsBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.GrandTotalLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1295, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 689);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "LogOut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 738);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(145, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cafe managment system";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CakeBtn);
            this.panel2.Controls.Add(this.SaladBtn);
            this.panel2.Controls.Add(this.CoockieBtn);
            this.panel2.Controls.Add(this.CinnamonbunBtn);
            this.panel2.Controls.Add(this.CoffewithmilkBtn);
            this.panel2.Controls.Add(this.CoffeBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(153, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 402);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // CakeBtn
            // 
            this.CakeBtn.AutoSize = true;
            this.CakeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CakeBtn.Location = new System.Drawing.Point(25, 336);
            this.CakeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CakeBtn.Name = "CakeBtn";
            this.CakeBtn.Size = new System.Drawing.Size(100, 35);
            this.CakeBtn.TabIndex = 20;
            this.CakeBtn.TabStop = true;
            this.CakeBtn.Text = "Cake";
            this.CakeBtn.UseVisualStyleBackColor = true;
            this.CakeBtn.CheckedChanged += new System.EventHandler(this.CakeBtn_CheckedChanged);
            // 
            // SaladBtn
            // 
            this.SaladBtn.AutoSize = true;
            this.SaladBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaladBtn.Location = new System.Drawing.Point(25, 286);
            this.SaladBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaladBtn.Name = "SaladBtn";
            this.SaladBtn.Size = new System.Drawing.Size(106, 35);
            this.SaladBtn.TabIndex = 23;
            this.SaladBtn.TabStop = true;
            this.SaladBtn.Text = "Salad";
            this.SaladBtn.UseVisualStyleBackColor = true;
            this.SaladBtn.CheckedChanged += new System.EventHandler(this.SaladBtn_CheckedChanged);
            // 
            // CoockieBtn
            // 
            this.CoockieBtn.AutoSize = true;
            this.CoockieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoockieBtn.Location = new System.Drawing.Point(25, 235);
            this.CoockieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CoockieBtn.Name = "CoockieBtn";
            this.CoockieBtn.Size = new System.Drawing.Size(138, 35);
            this.CoockieBtn.TabIndex = 22;
            this.CoockieBtn.TabStop = true;
            this.CoockieBtn.Text = "Coockie";
            this.CoockieBtn.UseVisualStyleBackColor = true;
            this.CoockieBtn.CheckedChanged += new System.EventHandler(this.CoockieBtn_CheckedChanged);
            // 
            // CinnamonbunBtn
            // 
            this.CinnamonbunBtn.AutoSize = true;
            this.CinnamonbunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CinnamonbunBtn.Location = new System.Drawing.Point(25, 185);
            this.CinnamonbunBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CinnamonbunBtn.Name = "CinnamonbunBtn";
            this.CinnamonbunBtn.Size = new System.Drawing.Size(219, 35);
            this.CinnamonbunBtn.TabIndex = 21;
            this.CinnamonbunBtn.TabStop = true;
            this.CinnamonbunBtn.Text = "Cinnamon bun";
            this.CinnamonbunBtn.UseVisualStyleBackColor = true;
            this.CinnamonbunBtn.CheckedChanged += new System.EventHandler(this.CinnamonbunBtn_CheckedChanged);
            // 
            // CoffewithmilkBtn
            // 
            this.CoffewithmilkBtn.AutoSize = true;
            this.CoffewithmilkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoffewithmilkBtn.Location = new System.Drawing.Point(25, 134);
            this.CoffewithmilkBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CoffewithmilkBtn.Name = "CoffewithmilkBtn";
            this.CoffewithmilkBtn.Size = new System.Drawing.Size(224, 35);
            this.CoffewithmilkBtn.TabIndex = 20;
            this.CoffewithmilkBtn.TabStop = true;
            this.CoffewithmilkBtn.Text = "Coffe with milk";
            this.CoffewithmilkBtn.UseVisualStyleBackColor = true;
            this.CoffewithmilkBtn.CheckedChanged += new System.EventHandler(this.CoffewithmilkBtn_CheckedChanged);
            // 
            // CoffeBtn
            // 
            this.CoffeBtn.AutoSize = true;
            this.CoffeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoffeBtn.Location = new System.Drawing.Point(25, 84);
            this.CoffeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CoffeBtn.Name = "CoffeBtn";
            this.CoffeBtn.Size = new System.Drawing.Size(103, 35);
            this.CoffeBtn.TabIndex = 19;
            this.CoffeBtn.TabStop = true;
            this.CoffeBtn.Text = "Coffe";
            this.CoffeBtn.UseVisualStyleBackColor = true;
            this.CoffeBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(153, -1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "Select Item";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.Location = new System.Drawing.Point(245, 583);
            this.OrderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.PeachPuff;
            this.OrderBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.PeachPuff;
            this.OrderBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.OrderBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.OrderBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.OrderBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OrderBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.OrderBtn.OverrideDefault.Border.Rounding = 10;
            this.OrderBtn.OverrideDefault.Border.Width = 1;
            this.OrderBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.OrderBtn.Size = new System.Drawing.Size(267, 62);
            this.OrderBtn.StateCommon.Back.Color1 = System.Drawing.Color.SandyBrown;
            this.OrderBtn.StateCommon.Back.Color2 = System.Drawing.Color.SandyBrown;
            this.OrderBtn.StateCommon.Back.ColorAngle = 45F;
            this.OrderBtn.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.OrderBtn.StateCommon.Border.ColorAngle = 45F;
            this.OrderBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OrderBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.OrderBtn.StateCommon.Border.Rounding = 10;
            this.OrderBtn.StateCommon.Border.Width = 1;
            this.OrderBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.OrderBtn.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.OrderBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderBtn.StatePressed.Back.Color1 = System.Drawing.Color.PeachPuff;
            this.OrderBtn.StatePressed.Back.Color2 = System.Drawing.Color.PeachPuff;
            this.OrderBtn.StatePressed.Back.ColorAngle = 135F;
            this.OrderBtn.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.OrderBtn.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.OrderBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OrderBtn.StatePressed.Border.Rounding = 10;
            this.OrderBtn.StatePressed.Border.Width = 1;
            this.OrderBtn.StateTracking.Back.Color1 = System.Drawing.Color.PeachPuff;
            this.OrderBtn.StateTracking.Back.Color2 = System.Drawing.Color.PeachPuff;
            this.OrderBtn.StateTracking.Back.ColorAngle = 45F;
            this.OrderBtn.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.OrderBtn.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.OrderBtn.StateTracking.Border.ColorAngle = 45F;
            this.OrderBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OrderBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.OrderBtn.StateTracking.Border.Rounding = 10;
            this.OrderBtn.StateTracking.Border.Width = 1;
            this.OrderBtn.TabIndex = 24;
            this.OrderBtn.Values.Text = "Add to order";
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // BillDGV
            // 
            this.BillDGV.BackgroundColor = System.Drawing.Color.Wheat;
            this.BillDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.BillDGV.GridColor = System.Drawing.Color.Black;
            this.BillDGV.Location = new System.Drawing.Point(725, 82);
            this.BillDGV.Margin = new System.Windows.Forms.Padding(4);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.Size = new System.Drawing.Size(544, 401);
            this.BillDGV.TabIndex = 25;
            this.BillDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillDGV_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // QtyTb
            // 
            this.QtyTb.Location = new System.Drawing.Point(330, 526);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(100, 22);
            this.QtyTb.TabIndex = 26;
            this.QtyTb.TextChanged += new System.EventHandler(this.QtyTb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(335, 498);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(314, 678);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.PeachPuff;
            this.SettingsBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.PeachPuff;
            this.SettingsBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.SettingsBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.SettingsBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.SettingsBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SettingsBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SettingsBtn.OverrideDefault.Border.Rounding = 10;
            this.SettingsBtn.OverrideDefault.Border.Width = 1;
            this.SettingsBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SettingsBtn.Size = new System.Drawing.Size(119, 47);
            this.SettingsBtn.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.SettingsBtn.StateCommon.Back.Color2 = System.Drawing.Color.SandyBrown;
            this.SettingsBtn.StateCommon.Back.ColorAngle = 45F;
            this.SettingsBtn.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.SettingsBtn.StateCommon.Border.ColorAngle = 45F;
            this.SettingsBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SettingsBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SettingsBtn.StateCommon.Border.Rounding = 10;
            this.SettingsBtn.StateCommon.Border.Width = 1;
            this.SettingsBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.SettingsBtn.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.SettingsBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsBtn.StatePressed.Back.Color1 = System.Drawing.Color.PeachPuff;
            this.SettingsBtn.StatePressed.Back.Color2 = System.Drawing.Color.PeachPuff;
            this.SettingsBtn.StatePressed.Back.ColorAngle = 135F;
            this.SettingsBtn.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.SettingsBtn.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.SettingsBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SettingsBtn.StatePressed.Border.Rounding = 10;
            this.SettingsBtn.StatePressed.Border.Width = 1;
            this.SettingsBtn.StateTracking.Back.Color1 = System.Drawing.Color.PeachPuff;
            this.SettingsBtn.StateTracking.Back.Color2 = System.Drawing.Color.PeachPuff;
            this.SettingsBtn.StateTracking.Back.ColorAngle = 45F;
            this.SettingsBtn.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.SettingsBtn.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.SettingsBtn.StateTracking.Border.ColorAngle = 45F;
            this.SettingsBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SettingsBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SettingsBtn.StateTracking.Border.Rounding = 10;
            this.SettingsBtn.StateTracking.Border.Width = 1;
            this.SettingsBtn.TabIndex = 29;
            this.SettingsBtn.Values.Text = "Set price";
            this.SettingsBtn.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // GrandTotalLbl
            // 
            this.GrandTotalLbl.AutoSize = true;
            this.GrandTotalLbl.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrandTotalLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GrandTotalLbl.Location = new System.Drawing.Point(840, 550);
            this.GrandTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrandTotalLbl.Name = "GrandTotalLbl";
            this.GrandTotalLbl.Size = new System.Drawing.Size(327, 64);
            this.GrandTotalLbl.TabIndex = 30;
            this.GrandTotalLbl.Text = "Grand Total:";
            this.GrandTotalLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GrandTotalLbl.Click += new System.EventHandler(this.GrandTotalLbl_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.GrandTotalLbl);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.BillDGV);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton CoffeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton CakeBtn;
        private System.Windows.Forms.RadioButton SaladBtn;
        private System.Windows.Forms.RadioButton CoockieBtn;
        private System.Windows.Forms.RadioButton CinnamonbunBtn;
        private System.Windows.Forms.RadioButton CoffewithmilkBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton OrderBtn;
        private System.Windows.Forms.DataGridView BillDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SettingsBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label GrandTotalLbl;
    }
}