namespace WindowsFormsApplication1
{
    partial class EmployeePage
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
            this.txtActualQty2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.txtq2 = new System.Windows.Forms.TextBox();
            this.txtpn2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtpr2 = new System.Windows.Forms.TextBox();
            this.txt_Qty2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGTotal2 = new System.Windows.Forms.TextBox();
            this.btnDelRow2 = new System.Windows.Forms.Button();
            this.btnCart_Emp2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Price2 = new System.Windows.Forms.TextBox();
            this.txt_Pname2 = new System.Windows.Forms.TextBox();
            this.txt_pid2 = new System.Windows.Forms.TextBox();
            this.dgvInvoice2 = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEProduct2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEProduct2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActualQty2
            // 
            this.txtActualQty2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualQty2.Location = new System.Drawing.Point(289, 479);
            this.txtActualQty2.Name = "txtActualQty2";
            this.txtActualQty2.ReadOnly = true;
            this.txtActualQty2.Size = new System.Drawing.Size(72, 26);
            this.txtActualQty2.TabIndex = 179;
            this.txtActualQty2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 178;
            this.label10.Text = "Search Box";
            // 
            // txtSearch2
            // 
            this.txtSearch2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtSearch2.Location = new System.Drawing.Point(103, 41);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(172, 20);
            this.txtSearch2.TabIndex = 177;
            this.txtSearch2.TextChanged += new System.EventHandler(this.TxtSearch2_TextChanged);
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.ForeColor = System.Drawing.Color.White;
            this.btnSave2.Location = new System.Drawing.Point(706, 495);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(297, 35);
            this.btnSave2.TabIndex = 176;
            this.btnSave2.Text = "SAVE";
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.BtnSave2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 15);
            this.label13.TabIndex = 170;
            this.label13.Text = "PRODUCT ID";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(736, 452);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(106, 18);
            this.lblTotal.TabIndex = 168;
            this.lblTotal.Text = "TOTAL  GH¢";
            // 
            // btnLogout2
            // 
            this.btnLogout2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout2.Location = new System.Drawing.Point(476, 618);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(121, 33);
            this.btnLogout2.TabIndex = 155;
            this.btnLogout2.Text = "LOG OUT";
            this.btnLogout2.UseVisualStyleBackColor = false;
            this.btnLogout2.Click += new System.EventHandler(this.BtnLogout2_Click);
            // 
            // txtq2
            // 
            this.txtq2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtq2.Location = new System.Drawing.Point(623, 487);
            this.txtq2.Name = "txtq2";
            this.txtq2.ReadOnly = true;
            this.txtq2.Size = new System.Drawing.Size(48, 26);
            this.txtq2.TabIndex = 175;
            this.txtq2.Visible = false;
            // 
            // txtpn2
            // 
            this.txtpn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpn2.Location = new System.Drawing.Point(403, 487);
            this.txtpn2.Name = "txtpn2";
            this.txtpn2.ReadOnly = true;
            this.txtpn2.Size = new System.Drawing.Size(157, 26);
            this.txtpn2.TabIndex = 173;
            this.txtpn2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(99, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 172;
            this.label11.Text = "PRICE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 15);
            this.label12.TabIndex = 171;
            this.label12.Text = "PRODUCT NAME";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(73, 485);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 15);
            this.label14.TabIndex = 169;
            this.label14.Text = "QUANTITY";
            // 
            // txtpr2
            // 
            this.txtpr2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpr2.Location = new System.Drawing.Point(566, 487);
            this.txtpr2.Name = "txtpr2";
            this.txtpr2.ReadOnly = true;
            this.txtpr2.Size = new System.Drawing.Size(51, 26);
            this.txtpr2.TabIndex = 174;
            this.txtpr2.Visible = false;
            // 
            // txt_Qty2
            // 
            this.txt_Qty2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qty2.Location = new System.Drawing.Point(158, 479);
            this.txt_Qty2.Name = "txt_Qty2";
            this.txt_Qty2.Size = new System.Drawing.Size(111, 26);
            this.txt_Qty2.TabIndex = 161;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(736, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 167;
            this.label15.Text = "CART";
            // 
            // txtGTotal2
            // 
            this.txtGTotal2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTotal2.Location = new System.Drawing.Point(848, 444);
            this.txtGTotal2.Name = "txtGTotal2";
            this.txtGTotal2.ReadOnly = true;
            this.txtGTotal2.Size = new System.Drawing.Size(155, 26);
            this.txtGTotal2.TabIndex = 166;
            // 
            // btnDelRow2
            // 
            this.btnDelRow2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelRow2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRow2.ForeColor = System.Drawing.Color.White;
            this.btnDelRow2.Location = new System.Drawing.Point(234, 520);
            this.btnDelRow2.Name = "btnDelRow2";
            this.btnDelRow2.Size = new System.Drawing.Size(163, 47);
            this.btnDelRow2.TabIndex = 165;
            this.btnDelRow2.Text = "REMOVE FROM CART";
            this.btnDelRow2.UseVisualStyleBackColor = false;
            this.btnDelRow2.Click += new System.EventHandler(this.BtnDelRow2_Click);
            // 
            // btnCart_Emp2
            // 
            this.btnCart_Emp2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCart_Emp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCart_Emp2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart_Emp2.ForeColor = System.Drawing.Color.White;
            this.btnCart_Emp2.Location = new System.Drawing.Point(60, 520);
            this.btnCart_Emp2.Name = "btnCart_Emp2";
            this.btnCart_Emp2.Size = new System.Drawing.Size(168, 43);
            this.btnCart_Emp2.TabIndex = 163;
            this.btnCart_Emp2.Text = "ADD TO CART";
            this.btnCart_Emp2.UseVisualStyleBackColor = false;
            this.btnCart_Emp2.Click += new System.EventHandler(this.BtnCart_Emp2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(147, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 15);
            this.label16.TabIndex = 162;
            this.label16.Text = "PRODUCTS AVAILABLE";
            // 
            // txt_Price2
            // 
            this.txt_Price2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price2.Location = new System.Drawing.Point(158, 437);
            this.txt_Price2.Name = "txt_Price2";
            this.txt_Price2.ReadOnly = true;
            this.txt_Price2.Size = new System.Drawing.Size(111, 26);
            this.txt_Price2.TabIndex = 160;
            // 
            // txt_Pname2
            // 
            this.txt_Pname2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pname2.Location = new System.Drawing.Point(158, 392);
            this.txt_Pname2.Name = "txt_Pname2";
            this.txt_Pname2.ReadOnly = true;
            this.txt_Pname2.Size = new System.Drawing.Size(178, 26);
            this.txt_Pname2.TabIndex = 159;
            // 
            // txt_pid2
            // 
            this.txt_pid2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pid2.Location = new System.Drawing.Point(158, 352);
            this.txt_pid2.Name = "txt_pid2";
            this.txt_pid2.ReadOnly = true;
            this.txt_pid2.Size = new System.Drawing.Size(111, 26);
            this.txt_pid2.TabIndex = 158;
            // 
            // dgvInvoice2
            // 
            this.dgvInvoice2.AllowUserToAddRows = false;
            this.dgvInvoice2.AllowUserToDeleteRows = false;
            this.dgvInvoice2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.price,
            this.qty,
            this.amount});
            this.dgvInvoice2.Location = new System.Drawing.Point(459, 41);
            this.dgvInvoice2.Name = "dgvInvoice2";
            this.dgvInvoice2.ReadOnly = true;
            this.dgvInvoice2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice2.Size = new System.Drawing.Size(544, 392);
            this.dgvInvoice2.TabIndex = 157;
            this.dgvInvoice2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInvoice2_CellClick);
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
            // dgvEProduct2
            // 
            this.dgvEProduct2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEProduct2.Location = new System.Drawing.Point(31, 71);
            this.dgvEProduct2.Name = "dgvEProduct2";
            this.dgvEProduct2.ReadOnly = true;
            this.dgvEProduct2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEProduct2.Size = new System.Drawing.Size(387, 262);
            this.dgvEProduct2.TabIndex = 156;
            this.dgvEProduct2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEProduct2_CellClick);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.txtActualQty2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnLogout2);
            this.Controls.Add(this.txtq2);
            this.Controls.Add(this.txtpn2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtpr2);
            this.Controls.Add(this.txt_Qty2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtGTotal2);
            this.Controls.Add(this.btnDelRow2);
            this.Controls.Add(this.btnCart_Emp2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_Price2);
            this.Controls.Add(this.txt_Pname2);
            this.Controls.Add(this.txt_pid2);
            this.Controls.Add(this.dgvInvoice2);
            this.Controls.Add(this.dgvEProduct2);
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEProduct2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtActualQty2;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtSearch2;
        internal System.Windows.Forms.Button btnSave2;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLogout2;
        internal System.Windows.Forms.TextBox txtq2;
        internal System.Windows.Forms.TextBox txtpn2;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtpr2;
        internal System.Windows.Forms.TextBox txt_Qty2;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtGTotal2;
        internal System.Windows.Forms.Button btnDelRow2;
        internal System.Windows.Forms.Button btnCart_Emp2;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txt_Price2;
        internal System.Windows.Forms.TextBox txt_Pname2;
        internal System.Windows.Forms.TextBox txt_pid2;
        internal System.Windows.Forms.DataGridView dgvInvoice2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn item;
        internal System.Windows.Forms.DataGridViewTextBoxColumn price;
        internal System.Windows.Forms.DataGridViewTextBoxColumn qty;
        internal System.Windows.Forms.DataGridViewTextBoxColumn amount;
        internal System.Windows.Forms.DataGridView dgvEProduct2;
    }
}