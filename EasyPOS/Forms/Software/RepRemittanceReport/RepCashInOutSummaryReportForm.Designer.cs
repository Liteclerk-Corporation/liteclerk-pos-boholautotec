﻿namespace EasyPOS.Forms.Software.RepSalesReport
{
    partial class RepCashInOutSummaryReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepCashInOutSummaryReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGenerateCSV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewSalesSummaryReport = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDisbursementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDisbursementNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDisbursementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalesListPageListFirst = new System.Windows.Forms.Button();
            this.buttonSalesListPageListNext = new System.Windows.Forms.Button();
            this.buttonSalesListPageListLast = new System.Windows.Forms.Button();
            this.buttonSalesListPageListPrevious = new System.Windows.Forms.Button();
            this.textBoxPageNumber = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesSummaryReport)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(114)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.buttonGenerateCSV);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 62);
            this.panel1.TabIndex = 8;
            // 
            // buttonGenerateCSV
            // 
            this.buttonGenerateCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(181)))));
            this.buttonGenerateCSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonGenerateCSV.FlatAppearance.BorderSize = 0;
            this.buttonGenerateCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateCSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateCSV.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateCSV.Location = new System.Drawing.Point(1175, 11);
            this.buttonGenerateCSV.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonGenerateCSV.Name = "buttonGenerateCSV";
            this.buttonGenerateCSV.Size = new System.Drawing.Size(88, 40);
            this.buttonGenerateCSV.TabIndex = 5;
            this.buttonGenerateCSV.TabStop = false;
            this.buttonGenerateCSV.Text = "CSV";
            this.buttonGenerateCSV.UseVisualStyleBackColor = false;
            this.buttonGenerateCSV.Click += new System.EventHandler(this.buttonGenerateCSV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports1;
            this.pictureBox1.Location = new System.Drawing.Point(14, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cash In/Out Summary Report";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1269, 11);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_OnClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewSalesSummaryReport);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 590);
            this.panel2.TabIndex = 9;
            // 
            // dataGridViewSalesSummaryReport
            // 
            this.dataGridViewSalesSummaryReport.AllowUserToAddRows = false;
            this.dataGridViewSalesSummaryReport.AllowUserToDeleteRows = false;
            this.dataGridViewSalesSummaryReport.AllowUserToResizeRows = false;
            this.dataGridViewSalesSummaryReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSalesSummaryReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSalesSummaryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesSummaryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnDisbursementDate,
            this.ColumnDisbursementNumber,
            this.ColumnDisbursementType,
            this.ColumnRemarks,
            this.ColumnPayType,
            this.ColumnUser,
            this.ColumnAmount});
            this.dataGridViewSalesSummaryReport.Location = new System.Drawing.Point(12, 8);
            this.dataGridViewSalesSummaryReport.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSalesSummaryReport.MultiSelect = false;
            this.dataGridViewSalesSummaryReport.Name = "dataGridViewSalesSummaryReport";
            this.dataGridViewSalesSummaryReport.ReadOnly = true;
            this.dataGridViewSalesSummaryReport.RowHeadersWidth = 51;
            this.dataGridViewSalesSummaryReport.RowTemplate.Height = 24;
            this.dataGridViewSalesSummaryReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalesSummaryReport.ShowEditingIcon = false;
            this.dataGridViewSalesSummaryReport.Size = new System.Drawing.Size(1345, 524);
            this.dataGridViewSalesSummaryReport.TabIndex = 22;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "ColumnId";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 125;
            // 
            // ColumnDisbursementDate
            // 
            this.ColumnDisbursementDate.DataPropertyName = "ColumnDisbursementDate";
            this.ColumnDisbursementDate.HeaderText = "Cash In/Out Date";
            this.ColumnDisbursementDate.MinimumWidth = 6;
            this.ColumnDisbursementDate.Name = "ColumnDisbursementDate";
            this.ColumnDisbursementDate.ReadOnly = true;
            this.ColumnDisbursementDate.Width = 150;
            // 
            // ColumnDisbursementNumber
            // 
            this.ColumnDisbursementNumber.DataPropertyName = "ColumnDisbursementNumber";
            this.ColumnDisbursementNumber.HeaderText = "Cash In/Out No.";
            this.ColumnDisbursementNumber.MinimumWidth = 6;
            this.ColumnDisbursementNumber.Name = "ColumnDisbursementNumber";
            this.ColumnDisbursementNumber.ReadOnly = true;
            this.ColumnDisbursementNumber.Width = 150;
            // 
            // ColumnDisbursementType
            // 
            this.ColumnDisbursementType.DataPropertyName = "ColumnDisbursementType";
            this.ColumnDisbursementType.HeaderText = "Type";
            this.ColumnDisbursementType.MinimumWidth = 6;
            this.ColumnDisbursementType.Name = "ColumnDisbursementType";
            this.ColumnDisbursementType.ReadOnly = true;
            this.ColumnDisbursementType.Width = 125;
            // 
            // ColumnRemarks
            // 
            this.ColumnRemarks.DataPropertyName = "ColumnRemarks";
            this.ColumnRemarks.HeaderText = "Remarks";
            this.ColumnRemarks.MinimumWidth = 6;
            this.ColumnRemarks.Name = "ColumnRemarks";
            this.ColumnRemarks.ReadOnly = true;
            this.ColumnRemarks.Width = 200;
            // 
            // ColumnPayType
            // 
            this.ColumnPayType.DataPropertyName = "ColumnPayType";
            this.ColumnPayType.FillWeight = 150F;
            this.ColumnPayType.HeaderText = "Pay Type";
            this.ColumnPayType.MinimumWidth = 6;
            this.ColumnPayType.Name = "ColumnPayType";
            this.ColumnPayType.ReadOnly = true;
            this.ColumnPayType.Width = 200;
            // 
            // ColumnUser
            // 
            this.ColumnUser.DataPropertyName = "ColumnUser";
            this.ColumnUser.FillWeight = 75F;
            this.ColumnUser.HeaderText = "User";
            this.ColumnUser.MinimumWidth = 6;
            this.ColumnUser.Name = "ColumnUser";
            this.ColumnUser.ReadOnly = true;
            this.ColumnUser.Width = 125;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.DataPropertyName = "ColumnAmount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnAmount.HeaderText = "Amount";
            this.ColumnAmount.MinimumWidth = 6;
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            this.ColumnAmount.Width = 120;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.textBoxTotalAmount);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonSalesListPageListFirst);
            this.panel4.Controls.Add(this.buttonSalesListPageListNext);
            this.panel4.Controls.Add(this.buttonSalesListPageListLast);
            this.panel4.Controls.Add(this.buttonSalesListPageListPrevious);
            this.panel4.Controls.Add(this.textBoxPageNumber);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 538);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1370, 52);
            this.panel4.TabIndex = 20;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalAmount.BackColor = System.Drawing.Color.LightGray;
            this.textBoxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(1000, 14);
            this.textBoxTotalAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(308, 23);
            this.textBoxTotalAmount.TabIndex = 15;
            this.textBoxTotalAmount.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(860, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Amount:";
            // 
            // buttonSalesListPageListFirst
            // 
            this.buttonSalesListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalesListPageListFirst.Enabled = false;
            this.buttonSalesListPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonSalesListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonSalesListPageListFirst.Location = new System.Drawing.Point(12, 9);
            this.buttonSalesListPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalesListPageListFirst.Name = "buttonSalesListPageListFirst";
            this.buttonSalesListPageListFirst.Size = new System.Drawing.Size(82, 32);
            this.buttonSalesListPageListFirst.TabIndex = 8;
            this.buttonSalesListPageListFirst.TabStop = false;
            this.buttonSalesListPageListFirst.Text = "First";
            this.buttonSalesListPageListFirst.UseVisualStyleBackColor = false;
            this.buttonSalesListPageListFirst.Click += new System.EventHandler(this.buttonSalesListPageListFirst_Click);
            // 
            // buttonSalesListPageListNext
            // 
            this.buttonSalesListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalesListPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonSalesListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesListPageListNext.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonSalesListPageListNext.Location = new System.Drawing.Point(336, 9);
            this.buttonSalesListPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalesListPageListNext.Name = "buttonSalesListPageListNext";
            this.buttonSalesListPageListNext.Size = new System.Drawing.Size(82, 32);
            this.buttonSalesListPageListNext.TabIndex = 10;
            this.buttonSalesListPageListNext.TabStop = false;
            this.buttonSalesListPageListNext.Text = "Next";
            this.buttonSalesListPageListNext.UseVisualStyleBackColor = false;
            this.buttonSalesListPageListNext.Click += new System.EventHandler(this.buttonSalesListPageListNext_Click);
            // 
            // buttonSalesListPageListLast
            // 
            this.buttonSalesListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalesListPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonSalesListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesListPageListLast.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonSalesListPageListLast.Location = new System.Drawing.Point(421, 9);
            this.buttonSalesListPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalesListPageListLast.Name = "buttonSalesListPageListLast";
            this.buttonSalesListPageListLast.Size = new System.Drawing.Size(82, 32);
            this.buttonSalesListPageListLast.TabIndex = 11;
            this.buttonSalesListPageListLast.TabStop = false;
            this.buttonSalesListPageListLast.Text = "Last";
            this.buttonSalesListPageListLast.UseVisualStyleBackColor = false;
            this.buttonSalesListPageListLast.Click += new System.EventHandler(this.buttonSalesListPageListLast_Click);
            // 
            // buttonSalesListPageListPrevious
            // 
            this.buttonSalesListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalesListPageListPrevious.Enabled = false;
            this.buttonSalesListPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonSalesListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonSalesListPageListPrevious.Location = new System.Drawing.Point(100, 9);
            this.buttonSalesListPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalesListPageListPrevious.Name = "buttonSalesListPageListPrevious";
            this.buttonSalesListPageListPrevious.Size = new System.Drawing.Size(82, 32);
            this.buttonSalesListPageListPrevious.TabIndex = 9;
            this.buttonSalesListPageListPrevious.TabStop = false;
            this.buttonSalesListPageListPrevious.Text = "Previous";
            this.buttonSalesListPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonSalesListPageListPrevious.Click += new System.EventHandler(this.buttonSalesListPageListPrevious_Click);
            // 
            // textBoxPageNumber
            // 
            this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPageNumber.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPageNumber.Location = new System.Drawing.Point(226, 14);
            this.textBoxPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPageNumber.Name = "textBoxPageNumber";
            this.textBoxPageNumber.ReadOnly = true;
            this.textBoxPageNumber.Size = new System.Drawing.Size(69, 23);
            this.textBoxPageNumber.TabIndex = 12;
            this.textBoxPageNumber.TabStop = false;
            this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RepCashInOutSummaryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1370, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "RepCashInOutSummaryReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash In/Out Summary Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesSummaryReport)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGenerateCSV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonSalesListPageListFirst;
        private System.Windows.Forms.Button buttonSalesListPageListNext;
        private System.Windows.Forms.Button buttonSalesListPageListLast;
        private System.Windows.Forms.Button buttonSalesListPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
        private System.Windows.Forms.DataGridView dataGridViewSalesSummaryReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDisbursementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDisbursementNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDisbursementType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
    }
}