﻿namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSTenderSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSTenderSalesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTenderSalesCustomer = new System.Windows.Forms.ComboBox();
            this.textBoxTenderSalesRewardAvailable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustomerCode = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTenderSalesUsers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTenderSalesRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTenderSalesTerms = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 63);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(63, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(462, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(368, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 40);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Reward Available:";
            // 
            // comboBoxTenderSalesCustomer
            // 
            this.comboBoxTenderSalesCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxTenderSalesCustomer.FormattingEnabled = true;
            this.comboBoxTenderSalesCustomer.Location = new System.Drawing.Point(183, 49);
            this.comboBoxTenderSalesCustomer.Name = "comboBoxTenderSalesCustomer";
            this.comboBoxTenderSalesCustomer.Size = new System.Drawing.Size(367, 36);
            this.comboBoxTenderSalesCustomer.TabIndex = 17;
            this.comboBoxTenderSalesCustomer.TabStop = false;
            this.comboBoxTenderSalesCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenderSalesCustomer_SelectedIndexChanged);
            // 
            // textBoxTenderSalesRewardAvailable
            // 
            this.textBoxTenderSalesRewardAvailable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxTenderSalesRewardAvailable.Location = new System.Drawing.Point(183, 91);
            this.textBoxTenderSalesRewardAvailable.Name = "textBoxTenderSalesRewardAvailable";
            this.textBoxTenderSalesRewardAvailable.ReadOnly = true;
            this.textBoxTenderSalesRewardAvailable.Size = new System.Drawing.Size(367, 34);
            this.textBoxTenderSalesRewardAvailable.TabIndex = 15;
            this.textBoxTenderSalesRewardAvailable.TabStop = false;
            this.textBoxTenderSalesRewardAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(77, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Customer:";
            // 
            // textBoxCustomerCode
            // 
            this.textBoxCustomerCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomerCode.BackColor = System.Drawing.Color.White;
            this.textBoxCustomerCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCustomerCode.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold);
            this.textBoxCustomerCode.Location = new System.Drawing.Point(12, 6);
            this.textBoxCustomerCode.Name = "textBoxCustomerCode";
            this.textBoxCustomerCode.Size = new System.Drawing.Size(538, 37);
            this.textBoxCustomerCode.TabIndex = 0;
            this.textBoxCustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCustomerCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCustomerCode_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxCustomerCode);
            this.panel2.Controls.Add(this.comboBoxTenderSalesUsers);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxTenderSalesRemarks);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBoxTenderSalesTerms);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxTenderSalesCustomer);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxTenderSalesRewardAvailable);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 348);
            this.panel2.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.POS;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(59, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sales Agent:";
            // 
            // comboBoxTenderSalesUsers
            // 
            this.comboBoxTenderSalesUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxTenderSalesUsers.FormattingEnabled = true;
            this.comboBoxTenderSalesUsers.Location = new System.Drawing.Point(183, 302);
            this.comboBoxTenderSalesUsers.Name = "comboBoxTenderSalesUsers";
            this.comboBoxTenderSalesUsers.Size = new System.Drawing.Size(367, 36);
            this.comboBoxTenderSalesUsers.TabIndex = 25;
            this.comboBoxTenderSalesUsers.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(88, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Remarks:";
            // 
            // textBoxTenderSalesRemarks
            // 
            this.textBoxTenderSalesRemarks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxTenderSalesRemarks.Location = new System.Drawing.Point(183, 175);
            this.textBoxTenderSalesRemarks.Multiline = true;
            this.textBoxTenderSalesRemarks.Name = "textBoxTenderSalesRemarks";
            this.textBoxTenderSalesRemarks.Size = new System.Drawing.Size(367, 121);
            this.textBoxTenderSalesRemarks.TabIndex = 22;
            this.textBoxTenderSalesRemarks.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(111, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Terms:";
            // 
            // comboBoxTenderSalesTerms
            // 
            this.comboBoxTenderSalesTerms.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxTenderSalesTerms.FormattingEnabled = true;
            this.comboBoxTenderSalesTerms.Location = new System.Drawing.Point(183, 131);
            this.comboBoxTenderSalesTerms.Name = "comboBoxTenderSalesTerms";
            this.comboBoxTenderSalesTerms.Size = new System.Drawing.Size(367, 36);
            this.comboBoxTenderSalesTerms.TabIndex = 21;
            this.comboBoxTenderSalesTerms.TabStop = false;
            // 
            // TrnPOSTenderSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(562, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TrnPOSTenderSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTenderSalesCustomer;
        private System.Windows.Forms.TextBox textBoxTenderSalesRewardAvailable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustomerCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxTenderSalesUsers;
        private System.Windows.Forms.TextBox textBoxTenderSalesRemarks;
        private System.Windows.Forms.ComboBox comboBoxTenderSalesTerms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}