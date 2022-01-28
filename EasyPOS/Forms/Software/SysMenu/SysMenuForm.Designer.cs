﻿namespace EasyPOS.Forms.Software.SysMenu
{
    partial class SysMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysMenuForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.imageListMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartTopSellingItems = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMonthlySales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonItem = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonPOS = new System.Windows.Forms.Button();
            this.buttonUtilities = new System.Windows.Forms.Button();
            this.buttonDiscounting = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonPOSReport = new System.Windows.Forms.Button();
            this.buttonSystemTables = new System.Windows.Forms.Button();
            this.buttonStockCount = new System.Windows.Forms.Button();
            this.buttonDisbursement = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonStockOut = new System.Windows.Forms.Button();
            this.buttonRemittanceReport = new System.Windows.Forms.Button();
            this.buttonStockIn = new System.Windows.Forms.Button();
            this.buttonSalesReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSellingItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlySales)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListMenuIcons
            // 
            this.imageListMenuIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMenuIcons.ImageStream")));
            this.imageListMenuIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMenuIcons.Images.SetKeyName(0, "Customer.png");
            this.imageListMenuIcons.Images.SetKeyName(1, "Disbursement.png");
            this.imageListMenuIcons.Images.SetKeyName(2, "Discounting.png");
            this.imageListMenuIcons.Images.SetKeyName(3, "Inventory.png");
            this.imageListMenuIcons.Images.SetKeyName(4, "Item.png");
            this.imageListMenuIcons.Images.SetKeyName(5, "POS.png");
            this.imageListMenuIcons.Images.SetKeyName(6, "Reports.png");
            this.imageListMenuIcons.Images.SetKeyName(7, "Utilities.png");
            this.imageListMenuIcons.Images.SetKeyName(8, "User.png");
            this.imageListMenuIcons.Images.SetKeyName(9, "Stock In.png");
            this.imageListMenuIcons.Images.SetKeyName(10, "Stock Out.png");
            this.imageListMenuIcons.Images.SetKeyName(11, "Settings.png");
            this.imageListMenuIcons.Images.SetKeyName(12, "Stock Count.png");
            this.imageListMenuIcons.Images.SetKeyName(13, "System Tables.png");
            this.imageListMenuIcons.Images.SetKeyName(14, "POS Touch.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.chartTopSellingItems);
            this.panel1.Controls.Add(this.chartMonthlySales);
            this.panel1.Controls.Add(this.buttonItem);
            this.panel1.Controls.Add(this.buttonUser);
            this.panel1.Controls.Add(this.buttonPOS);
            this.panel1.Controls.Add(this.buttonUtilities);
            this.panel1.Controls.Add(this.buttonDiscounting);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonCustomer);
            this.panel1.Controls.Add(this.buttonPOSReport);
            this.panel1.Controls.Add(this.buttonSystemTables);
            this.panel1.Controls.Add(this.buttonStockCount);
            this.panel1.Controls.Add(this.buttonDisbursement);
            this.panel1.Controls.Add(this.buttonInventory);
            this.panel1.Controls.Add(this.buttonStockOut);
            this.panel1.Controls.Add(this.buttonRemittanceReport);
            this.panel1.Controls.Add(this.buttonStockIn);
            this.panel1.Controls.Add(this.buttonSalesReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 560);
            this.panel1.TabIndex = 19;
            // 
            // chartTopSellingItems
            // 
            this.chartTopSellingItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTopSellingItems.BackColor = System.Drawing.Color.DarkGray;
            this.chartTopSellingItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartTopSellingItems.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartTopSellingItems.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartTopSellingItems.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chartTopSellingItems.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 50;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 110;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartTopSellingItems.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTopSellingItems.Legends.Add(legend1);
            this.chartTopSellingItems.Location = new System.Drawing.Point(22, 282);
            this.chartTopSellingItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartTopSellingItems.Name = "chartTopSellingItems";
            this.chartTopSellingItems.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "TopSelling";
            this.chartTopSellingItems.Series.Add(series1);
            this.chartTopSellingItems.Size = new System.Drawing.Size(426, 249);
            this.chartTopSellingItems.TabIndex = 17;
            this.chartTopSellingItems.Text = "chart2";
            title1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Top Selling Items";
            this.chartTopSellingItems.Titles.Add(title1);
            // 
            // chartMonthlySales
            // 
            this.chartMonthlySales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartMonthlySales.BackColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.Name = "ChartArea1";
            this.chartMonthlySales.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMonthlySales.Legends.Add(legend2);
            this.chartMonthlySales.Location = new System.Drawing.Point(22, 16);
            this.chartMonthlySales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartMonthlySales.Name = "chartMonthlySales";
            this.chartMonthlySales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartMonthlySales.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(195)))), ((int)(((byte)(84)))))};
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.LabelAngle = 15;
            series2.Legend = "Legend1";
            series2.MarkerSize = 3;
            series2.Name = "Sales";
            this.chartMonthlySales.Series.Add(series2);
            this.chartMonthlySales.Size = new System.Drawing.Size(426, 249);
            this.chartMonthlySales.TabIndex = 16;
            this.chartMonthlySales.TabStop = false;
            this.chartMonthlySales.Text = "chart1";
            title2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Titles";
            title2.Text = "Monthly Sales";
            this.chartMonthlySales.Titles.Add(title2);
            // 
            // buttonItem
            // 
            this.buttonItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.buttonItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonItem.FlatAppearance.BorderSize = 0;
            this.buttonItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonItem.ForeColor = System.Drawing.Color.White;
            this.buttonItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonItem.ImageIndex = 4;
            this.buttonItem.ImageList = this.imageListMenuIcons;
            this.buttonItem.Location = new System.Drawing.Point(470, 365);
            this.buttonItem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonItem.Name = "buttonItem";
            this.buttonItem.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonItem.Size = new System.Drawing.Size(182, 79);
            this.buttonItem.TabIndex = 0;
            this.buttonItem.Text = "Item";
            this.buttonItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonItem.UseVisualStyleBackColor = false;
            this.buttonItem.Click += new System.EventHandler(this.buttonItem_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.buttonUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonUser.ForeColor = System.Drawing.Color.White;
            this.buttonUser.ImageIndex = 8;
            this.buttonUser.ImageList = this.imageListMenuIcons;
            this.buttonUser.Location = new System.Drawing.Point(655, 447);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonUser.Size = new System.Drawing.Size(182, 84);
            this.buttonUser.TabIndex = 3;
            this.buttonUser.Text = "User";
            this.buttonUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonPOS
            // 
            this.buttonPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(195)))), ((int)(((byte)(84)))));
            this.buttonPOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonPOS.FlatAppearance.BorderSize = 0;
            this.buttonPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPOS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPOS.ForeColor = System.Drawing.Color.White;
            this.buttonPOS.ImageIndex = 5;
            this.buttonPOS.ImageList = this.imageListMenuIcons;
            this.buttonPOS.Location = new System.Drawing.Point(470, 16);
            this.buttonPOS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPOS.Name = "buttonPOS";
            this.buttonPOS.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonPOS.Size = new System.Drawing.Size(182, 171);
            this.buttonPOS.TabIndex = 4;
            this.buttonPOS.Text = "POS";
            this.buttonPOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPOS.UseVisualStyleBackColor = false;
            this.buttonPOS.Click += new System.EventHandler(this.buttonPOS_Click);
            // 
            // buttonUtilities
            // 
            this.buttonUtilities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUtilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.buttonUtilities.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonUtilities.FlatAppearance.BorderSize = 0;
            this.buttonUtilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUtilities.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonUtilities.ForeColor = System.Drawing.Color.White;
            this.buttonUtilities.ImageKey = "Utilities.png";
            this.buttonUtilities.ImageList = this.imageListMenuIcons;
            this.buttonUtilities.Location = new System.Drawing.Point(841, 365);
            this.buttonUtilities.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUtilities.Name = "buttonUtilities";
            this.buttonUtilities.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonUtilities.Size = new System.Drawing.Size(182, 79);
            this.buttonUtilities.TabIndex = 14;
            this.buttonUtilities.Text = "Utilities";
            this.buttonUtilities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUtilities.UseVisualStyleBackColor = false;
            this.buttonUtilities.Click += new System.EventHandler(this.buttonUtilities_Click);
            // 
            // buttonDiscounting
            // 
            this.buttonDiscounting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiscounting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.buttonDiscounting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonDiscounting.FlatAppearance.BorderSize = 0;
            this.buttonDiscounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscounting.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDiscounting.ForeColor = System.Drawing.Color.White;
            this.buttonDiscounting.ImageIndex = 2;
            this.buttonDiscounting.ImageList = this.imageListMenuIcons;
            this.buttonDiscounting.Location = new System.Drawing.Point(470, 447);
            this.buttonDiscounting.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDiscounting.Name = "buttonDiscounting";
            this.buttonDiscounting.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonDiscounting.Size = new System.Drawing.Size(182, 84);
            this.buttonDiscounting.TabIndex = 1;
            this.buttonDiscounting.Text = "Discounting";
            this.buttonDiscounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDiscounting.UseVisualStyleBackColor = false;
            this.buttonDiscounting.Click += new System.EventHandler(this.buttonDiscounting_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.ImageKey = "Settings.png";
            this.buttonSettings.ImageList = this.imageListMenuIcons;
            this.buttonSettings.Location = new System.Drawing.Point(841, 447);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonSettings.Size = new System.Drawing.Size(182, 84);
            this.buttonSettings.TabIndex = 13;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.buttonCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonCustomer.FlatAppearance.BorderSize = 0;
            this.buttonCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonCustomer.ImageIndex = 0;
            this.buttonCustomer.ImageList = this.imageListMenuIcons;
            this.buttonCustomer.Location = new System.Drawing.Point(655, 365);
            this.buttonCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonCustomer.Size = new System.Drawing.Size(182, 79);
            this.buttonCustomer.TabIndex = 2;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCustomer.UseVisualStyleBackColor = false;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonPOSReport
            // 
            this.buttonPOSReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPOSReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(181)))));
            this.buttonPOSReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonPOSReport.FlatAppearance.BorderSize = 0;
            this.buttonPOSReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPOSReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPOSReport.ForeColor = System.Drawing.Color.White;
            this.buttonPOSReport.ImageKey = "Reports.png";
            this.buttonPOSReport.ImageList = this.imageListMenuIcons;
            this.buttonPOSReport.Location = new System.Drawing.Point(841, 190);
            this.buttonPOSReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPOSReport.Name = "buttonPOSReport";
            this.buttonPOSReport.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonPOSReport.Size = new System.Drawing.Size(182, 84);
            this.buttonPOSReport.TabIndex = 12;
            this.buttonPOSReport.Text = "POS Report";
            this.buttonPOSReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPOSReport.UseVisualStyleBackColor = false;
            this.buttonPOSReport.Click += new System.EventHandler(this.buttonPOSReport_Click);
            // 
            // buttonSystemTables
            // 
            this.buttonSystemTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSystemTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(181)))));
            this.buttonSystemTables.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonSystemTables.FlatAppearance.BorderSize = 0;
            this.buttonSystemTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSystemTables.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSystemTables.ForeColor = System.Drawing.Color.White;
            this.buttonSystemTables.ImageIndex = 13;
            this.buttonSystemTables.ImageList = this.imageListMenuIcons;
            this.buttonSystemTables.Location = new System.Drawing.Point(841, 278);
            this.buttonSystemTables.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSystemTables.Name = "buttonSystemTables";
            this.buttonSystemTables.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonSystemTables.Size = new System.Drawing.Size(182, 84);
            this.buttonSystemTables.TabIndex = 15;
            this.buttonSystemTables.Text = "System Tables";
            this.buttonSystemTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSystemTables.UseVisualStyleBackColor = false;
            this.buttonSystemTables.Click += new System.EventHandler(this.buttonSystemTables_Click);
            // 
            // buttonStockCount
            // 
            this.buttonStockCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStockCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(195)))), ((int)(((byte)(84)))));
            this.buttonStockCount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonStockCount.FlatAppearance.BorderSize = 0;
            this.buttonStockCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStockCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonStockCount.ForeColor = System.Drawing.Color.White;
            this.buttonStockCount.ImageIndex = 12;
            this.buttonStockCount.ImageList = this.imageListMenuIcons;
            this.buttonStockCount.Location = new System.Drawing.Point(841, 16);
            this.buttonStockCount.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStockCount.Name = "buttonStockCount";
            this.buttonStockCount.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonStockCount.Size = new System.Drawing.Size(182, 84);
            this.buttonStockCount.TabIndex = 11;
            this.buttonStockCount.Text = "Stock Count";
            this.buttonStockCount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonStockCount.UseVisualStyleBackColor = false;
            this.buttonStockCount.Click += new System.EventHandler(this.buttonStockCount_Click);
            // 
            // buttonDisbursement
            // 
            this.buttonDisbursement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisbursement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(195)))), ((int)(((byte)(84)))));
            this.buttonDisbursement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonDisbursement.FlatAppearance.BorderSize = 0;
            this.buttonDisbursement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisbursement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDisbursement.ForeColor = System.Drawing.Color.White;
            this.buttonDisbursement.ImageIndex = 1;
            this.buttonDisbursement.ImageList = this.imageListMenuIcons;
            this.buttonDisbursement.Location = new System.Drawing.Point(655, 16);
            this.buttonDisbursement.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisbursement.Name = "buttonDisbursement";
            this.buttonDisbursement.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonDisbursement.Size = new System.Drawing.Size(182, 84);
            this.buttonDisbursement.TabIndex = 5;
            this.buttonDisbursement.Text = "Cash In/Out";
            this.buttonDisbursement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDisbursement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDisbursement.UseVisualStyleBackColor = false;
            this.buttonDisbursement.Click += new System.EventHandler(this.buttonDisbursement_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(181)))));
            this.buttonInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonInventory.FlatAppearance.BorderSize = 0;
            this.buttonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonInventory.ForeColor = System.Drawing.Color.White;
            this.buttonInventory.ImageIndex = 6;
            this.buttonInventory.ImageList = this.imageListMenuIcons;
            this.buttonInventory.Location = new System.Drawing.Point(470, 190);
            this.buttonInventory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonInventory.Size = new System.Drawing.Size(182, 171);
            this.buttonInventory.TabIndex = 10;
            this.buttonInventory.Text = "Inventory Report";
            this.buttonInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonStockOut
            // 
            this.buttonStockOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStockOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(195)))), ((int)(((byte)(84)))));
            this.buttonStockOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonStockOut.FlatAppearance.BorderSize = 0;
            this.buttonStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStockOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonStockOut.ForeColor = System.Drawing.Color.White;
            this.buttonStockOut.ImageIndex = 10;
            this.buttonStockOut.ImageList = this.imageListMenuIcons;
            this.buttonStockOut.Location = new System.Drawing.Point(841, 103);
            this.buttonStockOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStockOut.Name = "buttonStockOut";
            this.buttonStockOut.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonStockOut.Size = new System.Drawing.Size(182, 84);
            this.buttonStockOut.TabIndex = 7;
            this.buttonStockOut.Text = "Stock Out";
            this.buttonStockOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStockOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonStockOut.UseVisualStyleBackColor = false;
            this.buttonStockOut.Click += new System.EventHandler(this.buttonStockOut_Click);
            // 
            // buttonRemittanceReport
            // 
            this.buttonRemittanceReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemittanceReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(181)))));
            this.buttonRemittanceReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonRemittanceReport.FlatAppearance.BorderSize = 0;
            this.buttonRemittanceReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemittanceReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRemittanceReport.ForeColor = System.Drawing.Color.White;
            this.buttonRemittanceReport.ImageKey = "Reports.png";
            this.buttonRemittanceReport.ImageList = this.imageListMenuIcons;
            this.buttonRemittanceReport.Location = new System.Drawing.Point(655, 278);
            this.buttonRemittanceReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemittanceReport.Name = "buttonRemittanceReport";
            this.buttonRemittanceReport.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonRemittanceReport.Size = new System.Drawing.Size(182, 84);
            this.buttonRemittanceReport.TabIndex = 9;
            this.buttonRemittanceReport.Text = "Remittance Report";
            this.buttonRemittanceReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRemittanceReport.UseVisualStyleBackColor = false;
            this.buttonRemittanceReport.Click += new System.EventHandler(this.buttonRemittanceReport_Click);
            // 
            // buttonStockIn
            // 
            this.buttonStockIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(195)))), ((int)(((byte)(84)))));
            this.buttonStockIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonStockIn.FlatAppearance.BorderSize = 0;
            this.buttonStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStockIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonStockIn.ForeColor = System.Drawing.Color.White;
            this.buttonStockIn.ImageIndex = 9;
            this.buttonStockIn.ImageList = this.imageListMenuIcons;
            this.buttonStockIn.Location = new System.Drawing.Point(655, 103);
            this.buttonStockIn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStockIn.Name = "buttonStockIn";
            this.buttonStockIn.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonStockIn.Size = new System.Drawing.Size(182, 84);
            this.buttonStockIn.TabIndex = 6;
            this.buttonStockIn.Text = "Stock In";
            this.buttonStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonStockIn.UseVisualStyleBackColor = false;
            this.buttonStockIn.Click += new System.EventHandler(this.buttonStockIn_Click);
            // 
            // buttonSalesReport
            // 
            this.buttonSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(181)))));
            this.buttonSalesReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonSalesReport.FlatAppearance.BorderSize = 0;
            this.buttonSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSalesReport.ForeColor = System.Drawing.Color.White;
            this.buttonSalesReport.ImageKey = "Reports.png";
            this.buttonSalesReport.ImageList = this.imageListMenuIcons;
            this.buttonSalesReport.Location = new System.Drawing.Point(655, 190);
            this.buttonSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalesReport.Name = "buttonSalesReport";
            this.buttonSalesReport.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonSalesReport.Size = new System.Drawing.Size(182, 84);
            this.buttonSalesReport.TabIndex = 8;
            this.buttonSalesReport.Text = "Sales Report";
            this.buttonSalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSalesReport.UseVisualStyleBackColor = false;
            this.buttonSalesReport.Click += new System.EventHandler(this.buttonSalesReport_OnClick);
            // 
            // SysMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1096, 560);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SysMenuForm";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSellingItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlySales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonItem;
        private System.Windows.Forms.ImageList imageListMenuIcons;
        private System.Windows.Forms.Button buttonPOS;
        private System.Windows.Forms.Button buttonDiscounting;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonSystemTables;
        private System.Windows.Forms.Button buttonDisbursement;
        private System.Windows.Forms.Button buttonStockOut;
        private System.Windows.Forms.Button buttonStockIn;
        private System.Windows.Forms.Button buttonSalesReport;
        private System.Windows.Forms.Button buttonRemittanceReport;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonStockCount;
        private System.Windows.Forms.Button buttonPOSReport;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonUtilities;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthlySales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopSellingItems;
    }
}