namespace WindowsFormsApplication1
{
    partial class mainPage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PointOfSale = new System.Windows.Forms.TabPage();
            this.txtActualQty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtq1 = new System.Windows.Forms.TextBox();
            this.txtpn1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtpr1 = new System.Windows.Forms.TextBox();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGTotal = new System.Windows.Forms.TextBox();
            this.btnDelRow = new System.Windows.Forms.Button();
            this.btnCart_Emp = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Pname = new System.Windows.Forms.TextBox();
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEProduct = new System.Windows.Forms.DataGridView();
            this.employees = new System.Windows.Forms.TabPage();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpDod = new System.Windows.Forms.DateTimePicker();
            this.cmbSQ = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtStaff_id = new System.Windows.Forms.TextBox();
            this.products = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.btnU_Price = new System.Windows.Forms.Button();
            this.btnU_Quantity = new System.Windows.Forms.Button();
            this.btnDeleP = new System.Windows.Forms.Button();
            this.btnInsertP = new System.Windows.Forms.Button();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.dgvPDBase = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.PointOfSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEProduct)).BeginInit();
            this.employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDBase)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PointOfSale);
            this.tabControl1.Controls.Add(this.employees);
            this.tabControl1.Controls.Add(this.products);
            this.tabControl1.Location = new System.Drawing.Point(13, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 612);
            this.tabControl1.TabIndex = 0;
            // 
            // PointOfSale
            // 
            this.PointOfSale.Controls.Add(this.txtActualQty);
            this.PointOfSale.Controls.Add(this.label10);
            this.PointOfSale.Controls.Add(this.txtSearch);
            this.PointOfSale.Controls.Add(this.btnSave);
            this.PointOfSale.Controls.Add(this.txtq1);
            this.PointOfSale.Controls.Add(this.txtpn1);
            this.PointOfSale.Controls.Add(this.label11);
            this.PointOfSale.Controls.Add(this.label12);
            this.PointOfSale.Controls.Add(this.label13);
            this.PointOfSale.Controls.Add(this.label14);
            this.PointOfSale.Controls.Add(this.txtpr1);
            this.PointOfSale.Controls.Add(this.txt_Qty);
            this.PointOfSale.Controls.Add(this.lblTotal);
            this.PointOfSale.Controls.Add(this.label15);
            this.PointOfSale.Controls.Add(this.txtGTotal);
            this.PointOfSale.Controls.Add(this.btnDelRow);
            this.PointOfSale.Controls.Add(this.btnCart_Emp);
            this.PointOfSale.Controls.Add(this.label16);
            this.PointOfSale.Controls.Add(this.txt_Price);
            this.PointOfSale.Controls.Add(this.txt_Pname);
            this.PointOfSale.Controls.Add(this.txt_pid);
            this.PointOfSale.Controls.Add(this.dgvInvoice);
            this.PointOfSale.Controls.Add(this.dgvEProduct);
            this.PointOfSale.Location = new System.Drawing.Point(4, 22);
            this.PointOfSale.Name = "PointOfSale";
            this.PointOfSale.Padding = new System.Windows.Forms.Padding(3);
            this.PointOfSale.Size = new System.Drawing.Size(1016, 586);
            this.PointOfSale.TabIndex = 0;
            this.PointOfSale.Text = "Point Of Sale";
            this.PointOfSale.UseVisualStyleBackColor = true;
            this.PointOfSale.Click += new System.EventHandler(this.PointOfSale_Click);
            // 
            // txtActualQty
            // 
            this.txtActualQty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualQty.Location = new System.Drawing.Point(280, 482);
            this.txtActualQty.Name = "txtActualQty";
            this.txtActualQty.ReadOnly = true;
            this.txtActualQty.Size = new System.Drawing.Size(72, 26);
            this.txtActualQty.TabIndex = 154;
            this.txtActualQty.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 153;
            this.label10.Text = "Search Box";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtSearch.Location = new System.Drawing.Point(94, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 20);
            this.txtSearch.TabIndex = 152;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(697, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(297, 35);
            this.btnSave.TabIndex = 150;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtq1
            // 
            this.txtq1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtq1.Location = new System.Drawing.Point(614, 490);
            this.txtq1.Name = "txtq1";
            this.txtq1.ReadOnly = true;
            this.txtq1.Size = new System.Drawing.Size(48, 26);
            this.txtq1.TabIndex = 149;
            this.txtq1.Visible = false;
            // 
            // txtpn1
            // 
            this.txtpn1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpn1.Location = new System.Drawing.Point(394, 490);
            this.txtpn1.Name = "txtpn1";
            this.txtpn1.ReadOnly = true;
            this.txtpn1.Size = new System.Drawing.Size(157, 26);
            this.txtpn1.TabIndex = 147;
            this.txtpn1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(90, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 146;
            this.label11.Text = "PRICE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 15);
            this.label12.TabIndex = 145;
            this.label12.Text = "PRODUCT NAME";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 15);
            this.label13.TabIndex = 144;
            this.label13.Text = "PRODUCT ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(64, 488);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 15);
            this.label14.TabIndex = 143;
            this.label14.Text = "QUANTITY";
            // 
            // txtpr1
            // 
            this.txtpr1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpr1.Location = new System.Drawing.Point(557, 490);
            this.txtpr1.Name = "txtpr1";
            this.txtpr1.ReadOnly = true;
            this.txtpr1.Size = new System.Drawing.Size(51, 26);
            this.txtpr1.TabIndex = 148;
            this.txtpr1.Visible = false;
            // 
            // txt_Qty
            // 
            this.txt_Qty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qty.Location = new System.Drawing.Point(149, 482);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(111, 26);
            this.txt_Qty.TabIndex = 135;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(727, 455);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(106, 18);
            this.lblTotal.TabIndex = 142;
            this.lblTotal.Text = "TOTAL  GH¢";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(727, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 141;
            this.label15.Text = "CART";
            // 
            // txtGTotal
            // 
            this.txtGTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTotal.Location = new System.Drawing.Point(839, 447);
            this.txtGTotal.Name = "txtGTotal";
            this.txtGTotal.ReadOnly = true;
            this.txtGTotal.Size = new System.Drawing.Size(155, 26);
            this.txtGTotal.TabIndex = 140;
            // 
            // btnDelRow
            // 
            this.btnDelRow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelRow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRow.ForeColor = System.Drawing.Color.White;
            this.btnDelRow.Location = new System.Drawing.Point(225, 523);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(163, 47);
            this.btnDelRow.TabIndex = 139;
            this.btnDelRow.Text = "REMOVE FROM CART";
            this.btnDelRow.UseVisualStyleBackColor = false;
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // btnCart_Emp
            // 
            this.btnCart_Emp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCart_Emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCart_Emp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart_Emp.ForeColor = System.Drawing.Color.White;
            this.btnCart_Emp.Location = new System.Drawing.Point(51, 523);
            this.btnCart_Emp.Name = "btnCart_Emp";
            this.btnCart_Emp.Size = new System.Drawing.Size(168, 43);
            this.btnCart_Emp.TabIndex = 137;
            this.btnCart_Emp.Text = "ADD TO CART";
            this.btnCart_Emp.UseVisualStyleBackColor = false;
            this.btnCart_Emp.Click += new System.EventHandler(this.btnCart_Emp_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(138, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 15);
            this.label16.TabIndex = 136;
            this.label16.Text = "PRODUCTS AVAILABLE";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(149, 440);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.ReadOnly = true;
            this.txt_Price.Size = new System.Drawing.Size(111, 26);
            this.txt_Price.TabIndex = 134;
            // 
            // txt_Pname
            // 
            this.txt_Pname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pname.Location = new System.Drawing.Point(149, 395);
            this.txt_Pname.Name = "txt_Pname";
            this.txt_Pname.ReadOnly = true;
            this.txt_Pname.Size = new System.Drawing.Size(178, 26);
            this.txt_Pname.TabIndex = 133;
            // 
            // txt_pid
            // 
            this.txt_pid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pid.Location = new System.Drawing.Point(149, 355);
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.ReadOnly = true;
            this.txt_pid.Size = new System.Drawing.Size(111, 26);
            this.txt_pid.TabIndex = 132;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.price,
            this.qty,
            this.amount});
            this.dgvInvoice.Location = new System.Drawing.Point(450, 44);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(544, 392);
            this.dgvInvoice.TabIndex = 131;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            // 
            // item
            // 
            this.item.HeaderText = "ITEM";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "QUANTITY";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "AMOUNT (GH¢)";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // dgvEProduct
            // 
            this.dgvEProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEProduct.Location = new System.Drawing.Point(22, 74);
            this.dgvEProduct.Name = "dgvEProduct";
            this.dgvEProduct.ReadOnly = true;
            this.dgvEProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEProduct.Size = new System.Drawing.Size(387, 262);
            this.dgvEProduct.TabIndex = 130;
            this.dgvEProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEProduct_CellClick);
            this.dgvEProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEProduct_CellContentClick);
            // 
            // employees
            // 
            this.employees.Controls.Add(this.cmbUserType);
            this.employees.Controls.Add(this.btnDelete);
            this.employees.Controls.Add(this.btnAdd);
            this.employees.Controls.Add(this.dgvEmployee);
            this.employees.Controls.Add(this.Label9);
            this.employees.Controls.Add(this.Label8);
            this.employees.Controls.Add(this.Label7);
            this.employees.Controls.Add(this.Label6);
            this.employees.Controls.Add(this.Label5);
            this.employees.Controls.Add(this.Label4);
            this.employees.Controls.Add(this.Label3);
            this.employees.Controls.Add(this.Label2);
            this.employees.Controls.Add(this.Label1);
            this.employees.Controls.Add(this.dtpDod);
            this.employees.Controls.Add(this.cmbSQ);
            this.employees.Controls.Add(this.cmbGender);
            this.employees.Controls.Add(this.txtAnswer);
            this.employees.Controls.Add(this.txtPassword);
            this.employees.Controls.Add(this.txtLName);
            this.employees.Controls.Add(this.txtFName);
            this.employees.Controls.Add(this.txtStaff_id);
            this.employees.Location = new System.Drawing.Point(4, 22);
            this.employees.Name = "employees";
            this.employees.Padding = new System.Windows.Forms.Padding(3);
            this.employees.Size = new System.Drawing.Size(1016, 586);
            this.employees.TabIndex = 1;
            this.employees.Text = "Employees";
            this.employees.UseVisualStyleBackColor = true;
            // 
            // cmbUserType
            // 
            this.cmbUserType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cmbUserType.Location = new System.Drawing.Point(173, 253);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(250, 26);
            this.cmbUserType.TabIndex = 89;
            this.cmbUserType.Text = "Admin";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(242, 445);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 36);
            this.btnDelete.TabIndex = 87;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(50, 445);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 36);
            this.btnAdd.TabIndex = 86;
            this.btnAdd.Text = "INSERT";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(438, 33);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(571, 354);
            this.dgvEmployee.TabIndex = 85;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // Label9
            // 
            this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(8, 392);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(150, 25);
            this.Label9.TabIndex = 84;
            this.Label9.Text = "ANSWER";
            // 
            // Label8
            // 
            this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(8, 327);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(150, 50);
            this.Label8.TabIndex = 83;
            this.Label8.Text = "SECURITY\r\nQUESTION";
            // 
            // Label7
            // 
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(8, 290);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(150, 25);
            this.Label7.TabIndex = 82;
            this.Label7.Text = "USER PASSWORD";
            // 
            // Label6
            // 
            this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(8, 251);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(150, 25);
            this.Label6.TabIndex = 81;
            this.Label6.Text = "USER TYPE";
            // 
            // Label5
            // 
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(8, 213);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(150, 25);
            this.Label5.TabIndex = 80;
            this.Label5.Text = "DATE OF BIRTH";
            // 
            // Label4
            // 
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(8, 175);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(150, 25);
            this.Label4.TabIndex = 79;
            this.Label4.Text = "GENDER";
            // 
            // Label3
            // 
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(8, 138);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(150, 25);
            this.Label3.TabIndex = 78;
            this.Label3.Text = "LAST NAME";
            // 
            // Label2
            // 
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(8, 101);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(150, 25);
            this.Label2.TabIndex = 77;
            this.Label2.Text = "FIRST NAME";
            // 
            // Label1
            // 
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(8, 63);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(150, 25);
            this.Label1.TabIndex = 76;
            this.Label1.Text = "STAFF ID";
            // 
            // dtpDod
            // 
            this.dtpDod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDod.Location = new System.Drawing.Point(173, 218);
            this.dtpDod.Name = "dtpDod";
            this.dtpDod.Size = new System.Drawing.Size(250, 26);
            this.dtpDod.TabIndex = 75;
            // 
            // cmbSQ
            // 
            this.cmbSQ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSQ.FormattingEnabled = true;
            this.cmbSQ.Items.AddRange(new object[] {
            "WHAT IS YOUR NICKNAME?",
            "WHAT IS YOUR FAVOURITE FOOD?",
            "WHAT IS YOUR UNCLE\'S NAME?",
            "WHAT IS YOUR FIRST PHONE NUMBER?",
            "WHAT IS THE NAME OF YOUR FAVOURITE PET?",
            "WHAT IS THE TITLE OF YOUR FAVOURITE MOVIE?",
            "WHAT IS THE TITLE OF YOUR FAVOURITE SONG?",
            "WHAT IS THE NAME OF YOUR FAVOURITE MUSICIAN?",
            "WHAT IS THE NAME OF YOUR FAVOURITE ACTOR?",
            "WHAT IS THE NAME OF YOUR FAVOURITE ACTRESS?"});
            this.cmbSQ.Location = new System.Drawing.Point(173, 331);
            this.cmbSQ.Name = "cmbSQ";
            this.cmbSQ.Size = new System.Drawing.Size(250, 26);
            this.cmbSQ.TabIndex = 74;
            this.cmbSQ.Text = "Security Question";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGender.Location = new System.Drawing.Point(173, 181);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(250, 26);
            this.cmbGender.TabIndex = 73;
            this.cmbGender.Text = "M";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(173, 393);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(250, 25);
            this.txtAnswer.TabIndex = 72;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(173, 291);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 25);
            this.txtPassword.TabIndex = 71;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(173, 138);
            this.txtLName.Multiline = true;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(250, 25);
            this.txtLName.TabIndex = 70;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(173, 101);
            this.txtFName.Multiline = true;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(250, 25);
            this.txtFName.TabIndex = 69;
            // 
            // txtStaff_id
            // 
            this.txtStaff_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff_id.Location = new System.Drawing.Point(173, 63);
            this.txtStaff_id.Multiline = true;
            this.txtStaff_id.Name = "txtStaff_id";
            this.txtStaff_id.Size = new System.Drawing.Size(250, 25);
            this.txtStaff_id.TabIndex = 68;
            // 
            // products
            // 
            this.products.Controls.Add(this.label17);
            this.products.Controls.Add(this.label18);
            this.products.Controls.Add(this.label19);
            this.products.Controls.Add(this.label20);
            this.products.Controls.Add(this.label21);
            this.products.Controls.Add(this.txtPrice);
            this.products.Controls.Add(this.txtQty);
            this.products.Controls.Add(this.txtPName);
            this.products.Controls.Add(this.btnU_Price);
            this.products.Controls.Add(this.btnU_Quantity);
            this.products.Controls.Add(this.btnDeleP);
            this.products.Controls.Add(this.btnInsertP);
            this.products.Controls.Add(this.txtPID);
            this.products.Controls.Add(this.dgvPDBase);
            this.products.Location = new System.Drawing.Point(4, 22);
            this.products.Name = "products";
            this.products.Padding = new System.Windows.Forms.Padding(3);
            this.products.Size = new System.Drawing.Size(1016, 586);
            this.products.TabIndex = 2;
            this.products.Text = "Products";
            this.products.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(202, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 24);
            this.label17.TabIndex = 76;
            this.label17.Text = "PRODUCT TABLE";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(564, 268);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 25);
            this.label18.TabIndex = 75;
            this.label18.Text = "PRICE";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(564, 224);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 25);
            this.label19.TabIndex = 74;
            this.label19.Text = "QUANTITY";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(564, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 25);
            this.label20.TabIndex = 73;
            this.label20.Text = "PRODUCT NAME";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(564, 129);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 25);
            this.label21.TabIndex = 72;
            this.label21.Text = "PRODUCT ID";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(687, 268);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(250, 25);
            this.txtPrice.TabIndex = 71;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(687, 224);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(250, 25);
            this.txtQty.TabIndex = 70;
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(687, 178);
            this.txtPName.Multiline = true;
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(250, 25);
            this.txtPName.TabIndex = 69;
            // 
            // btnU_Price
            // 
            this.btnU_Price.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnU_Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU_Price.ForeColor = System.Drawing.Color.White;
            this.btnU_Price.Location = new System.Drawing.Point(833, 368);
            this.btnU_Price.Name = "btnU_Price";
            this.btnU_Price.Size = new System.Drawing.Size(90, 50);
            this.btnU_Price.TabIndex = 68;
            this.btnU_Price.Text = "UPDATE\r\nPRICE";
            this.btnU_Price.UseVisualStyleBackColor = false;
            this.btnU_Price.Click += new System.EventHandler(this.btnU_Price_Click);
            // 
            // btnU_Quantity
            // 
            this.btnU_Quantity.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnU_Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU_Quantity.ForeColor = System.Drawing.Color.White;
            this.btnU_Quantity.Location = new System.Drawing.Point(732, 368);
            this.btnU_Quantity.Name = "btnU_Quantity";
            this.btnU_Quantity.Size = new System.Drawing.Size(90, 50);
            this.btnU_Quantity.TabIndex = 67;
            this.btnU_Quantity.Text = "UPDATE\r\nQTY";
            this.btnU_Quantity.UseVisualStyleBackColor = false;
            this.btnU_Quantity.Click += new System.EventHandler(this.btnU_Quantity_Click);
            // 
            // btnDeleP
            // 
            this.btnDeleP.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleP.ForeColor = System.Drawing.Color.White;
            this.btnDeleP.Location = new System.Drawing.Point(833, 319);
            this.btnDeleP.Name = "btnDeleP";
            this.btnDeleP.Size = new System.Drawing.Size(90, 32);
            this.btnDeleP.TabIndex = 66;
            this.btnDeleP.Text = "DELETE";
            this.btnDeleP.UseVisualStyleBackColor = false;
            this.btnDeleP.Click += new System.EventHandler(this.btnDeleP_Click);
            // 
            // btnInsertP
            // 
            this.btnInsertP.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInsertP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertP.ForeColor = System.Drawing.Color.White;
            this.btnInsertP.Location = new System.Drawing.Point(732, 319);
            this.btnInsertP.Name = "btnInsertP";
            this.btnInsertP.Size = new System.Drawing.Size(90, 32);
            this.btnInsertP.TabIndex = 65;
            this.btnInsertP.Text = "INSERT";
            this.btnInsertP.UseVisualStyleBackColor = false;
            this.btnInsertP.Click += new System.EventHandler(this.btnInsertP_Click);
            // 
            // txtPID
            // 
            this.txtPID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.Location = new System.Drawing.Point(687, 129);
            this.txtPID.Multiline = true;
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(250, 25);
            this.txtPID.TabIndex = 64;
            // 
            // dgvPDBase
            // 
            this.dgvPDBase.AllowUserToAddRows = false;
            this.dgvPDBase.AllowUserToDeleteRows = false;
            this.dgvPDBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPDBase.Location = new System.Drawing.Point(79, 95);
            this.dgvPDBase.Name = "dgvPDBase";
            this.dgvPDBase.ReadOnly = true;
            this.dgvPDBase.Size = new System.Drawing.Size(444, 432);
            this.dgvPDBase.TabIndex = 63;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(467, 621);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(121, 33);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainPage";
            this.Text = "mainPage";
            this.tabControl1.ResumeLayout(false);
            this.PointOfSale.ResumeLayout(false);
            this.PointOfSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEProduct)).EndInit();
            this.employees.ResumeLayout(false);
            this.employees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.products.ResumeLayout(false);
            this.products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PointOfSale;
        private System.Windows.Forms.TabPage employees;
        private System.Windows.Forms.TabPage products;
        internal System.Windows.Forms.ComboBox cmbUserType;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.DataGridView dgvEmployee;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpDod;
        internal System.Windows.Forms.ComboBox cmbSQ;
        internal System.Windows.Forms.ComboBox cmbGender;
        internal System.Windows.Forms.TextBox txtAnswer;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtLName;
        internal System.Windows.Forms.TextBox txtFName;
        internal System.Windows.Forms.TextBox txtStaff_id;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtq1;
        internal System.Windows.Forms.TextBox txtpn1;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtpr1;
        internal System.Windows.Forms.TextBox txt_Qty;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtGTotal;
        internal System.Windows.Forms.Button btnDelRow;
        internal System.Windows.Forms.Button btnCart_Emp;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txt_Price;
        internal System.Windows.Forms.TextBox txt_Pname;
        internal System.Windows.Forms.TextBox txt_pid;
        internal System.Windows.Forms.DataGridView dgvInvoice;
        internal System.Windows.Forms.DataGridViewTextBoxColumn item;
        internal System.Windows.Forms.DataGridViewTextBoxColumn price;
        internal System.Windows.Forms.DataGridViewTextBoxColumn qty;
        internal System.Windows.Forms.DataGridViewTextBoxColumn amount;
        internal System.Windows.Forms.DataGridView dgvEProduct;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.TextBox txtPName;
        internal System.Windows.Forms.Button btnU_Price;
        internal System.Windows.Forms.Button btnU_Quantity;
        internal System.Windows.Forms.Button btnDeleP;
        internal System.Windows.Forms.Button btnInsertP;
        internal System.Windows.Forms.TextBox txtPID;
        internal System.Windows.Forms.DataGridView dgvPDBase;
        private System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.TextBox txtActualQty;
    }
}