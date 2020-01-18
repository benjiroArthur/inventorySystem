namespace WindowsFormsApplication1
{
    partial class PrintArea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintArea));
            this.txtCInfo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvPrintF = new System.Windows.Forms.DataGridView();
            this.item1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrintTotal = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintF)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCInfo
            // 
            this.txtCInfo.BackColor = System.Drawing.Color.White;
            this.txtCInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCInfo.Location = new System.Drawing.Point(209, 12);
            this.txtCInfo.Multiline = true;
            this.txtCInfo.Name = "txtCInfo";
            this.txtCInfo.ReadOnly = true;
            this.txtCInfo.Size = new System.Drawing.Size(376, 103);
            this.txtCInfo.TabIndex = 10;
            this.txtCInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(399, 569);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(133, 23);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "TOTAL:  GH¢";
            // 
            // dgvPrintF
            // 
            this.dgvPrintF.AllowUserToAddRows = false;
            this.dgvPrintF.AllowUserToDeleteRows = false;
            this.dgvPrintF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrintF.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrintF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPrintF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item1,
            this.price1,
            this.qty1,
            this.amount1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrintF.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPrintF.GridColor = System.Drawing.Color.White;
            this.dgvPrintF.Location = new System.Drawing.Point(129, 159);
            this.dgvPrintF.Name = "dgvPrintF";
            this.dgvPrintF.ReadOnly = true;
            this.dgvPrintF.RowHeadersVisible = false;
            this.dgvPrintF.RowHeadersWidth = 20;
            this.dgvPrintF.Size = new System.Drawing.Size(547, 387);
            this.dgvPrintF.TabIndex = 8;
            // 
            // item1
            // 
            this.item1.HeaderText = "ITEM";
            this.item1.Name = "item1";
            this.item1.ReadOnly = true;
            // 
            // price1
            // 
            this.price1.HeaderText = "PRICE";
            this.price1.Name = "price1";
            this.price1.ReadOnly = true;
            // 
            // qty1
            // 
            this.qty1.HeaderText = "QUANTITY";
            this.qty1.Name = "qty1";
            this.qty1.ReadOnly = true;
            // 
            // amount1
            // 
            this.amount1.HeaderText = "AMOUNT GH¢";
            this.amount1.Name = "amount1";
            this.amount1.ReadOnly = true;
            // 
            // txtPrintTotal
            // 
            this.txtPrintTotal.BackColor = System.Drawing.Color.White;
            this.txtPrintTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrintTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrintTotal.Location = new System.Drawing.Point(538, 564);
            this.txtPrintTotal.Multiline = true;
            this.txtPrintTotal.Name = "txtPrintTotal";
            this.txtPrintTotal.ReadOnly = true;
            this.txtPrintTotal.Size = new System.Drawing.Size(138, 28);
            this.txtPrintTotal.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(129, 133);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(547, 20);
            this.txtDate.TabIndex = 12;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 640);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // PrintArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtPrintTotal);
            this.Controls.Add(this.txtCInfo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgvPrintF);
            this.Name = "PrintArea";
            this.Text = "PrintArea";
            this.Load += new System.EventHandler(this.PrintArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintF)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtCInfo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgvPrintF;
        internal System.Windows.Forms.DataGridViewTextBoxColumn item1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn price1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn qty1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn amount1;
        internal System.Windows.Forms.TextBox txtPrintTotal;
        internal System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}