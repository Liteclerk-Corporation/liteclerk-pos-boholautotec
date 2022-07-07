using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.SysMenu
{
    public partial class SysMenuForm : Form
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        public SysSoftwareForm sysSoftwareForm;
        private Modules.SysUserRightsModule sysUserRights;

        public List<Entities.SysLanguageEntity> sysLanguageEntities = new List<Entities.SysLanguageEntity>();

        public SysMenuForm(SysSoftwareForm softwareForm)
        {
            InitializeComponent();

            GetInventoryListStockLevelAlert();

            var logoFilePath = Modules.SysCurrentModule.GetCurrentSettings().LogoFilePath;
            pictureBoxLogo.Image = Image.FromFile(@"" + logoFilePath);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            buttonItem.Text = SetLabel(buttonItem.Text);
            buttonDiscounting.Text = SetLabel(buttonDiscounting.Text);
            buttonCustomer.Text = SetLabel(buttonCustomer.Text);
            buttonUser.Text = SetLabel(buttonUser.Text);
            buttonPOS.Text = SetLabel(buttonPOS.Text);
            buttonDisbursement.Text = SetLabel(buttonDisbursement.Text);
            buttonStockIn.Text = SetLabel(buttonStockIn.Text);
            buttonStockOut.Text = SetLabel(buttonStockOut.Text);
            buttonSalesReport.Text = SetLabel(buttonSalesReport.Text);
            buttonRemittanceReport.Text = SetLabel(buttonRemittanceReport.Text);
            buttonInventory.Text = SetLabel(buttonInventory.Text);
            buttonStockCount.Text = SetLabel(buttonStockCount.Text);
            buttonPOSReport.Text = SetLabel(buttonPOSReport.Text);
            buttonSettings.Text = SetLabel(buttonSettings.Text);
            buttonUtilities.Text = SetLabel(buttonUtilities.Text);
            buttonSystemTables.Text = SetLabel(buttonSystemTables.Text);

            sysSoftwareForm = softwareForm;

            sysUserRights = new Modules.SysUserRightsModule("SysMenu");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var sysCurrent = Modules.SysCurrentModule.GetCurrentSettings();
            if (sysCurrent.POSType == "POS Touch")
            {
                buttonPOS.ImageIndex = 17;
            }

            MenuForm();
            InventoryModuleButtonLocation();
        }
        public List<Entities.DgvStockLevelReportEntity> GetInventoryListStockLevelAlert()
        {

            List<Entities.DgvStockLevelReportEntity> rowList = new List<Entities.DgvStockLevelReportEntity>();

            Controllers.RepInventoryReportController repInvetoryReportController = new Controllers.RepInventoryReportController();

            var inventoryListReport = repInvetoryReportController.GetInventoryListStockLevelAlert();
            if (inventoryListReport.Any())
            {
                if (Modules.SysCurrentModule.GetCurrentSettings().StockLevelAlert == true)
                {
                    RepInventoryReport.RepInventoryStockLevelReportForm repInventoryReportStockLevel = new RepInventoryReport.RepInventoryStockLevelReportForm();
                    repInventoryReportStockLevel.ShowDialog();
                }
            }
            return rowList;
        }

        public string SetLabel(string label)
        {
            Controllers.SysLanguageController sysLabel = new Controllers.SysLanguageController();
            var language = Modules.SysCurrentModule.GetCurrentSettings().Language;
            sysLanguageEntities = sysLabel.ListLanguage("");
            if (sysLanguageEntities.Any())
            {

                if (sysLabel.ListLanguage("").Any())
                {

                    foreach (var displayedLabel in sysLanguageEntities)
                    {
                        if (language != "English")
                        {
                            if (displayedLabel.Label == label)
                            {
                                return displayedLabel.DisplayedLabel;
                            }

                        }
                        else
                        {
                            if (displayedLabel.Label == label)
                            {
                                return displayedLabel.Label;
                            }
                        }
                    }
                }
            }
            return label;
        }

        public void MenuForm()
        {
            var menuForms = from d in db.SysMenuForms
                            select d;
            var form = menuForms.FirstOrDefault();

            if (form.Item == false)
            {
                buttonItem.Visible = false;
            }
            if (form.Discounting == false)
            {
                buttonDiscounting.Visible = false;
            }
            if (form.Customer == false)
            {
                buttonCustomer.Visible = false;
            }
            if (form.UserAccount == false)
            {
                buttonUser.Visible = false;
            }
            if (form.POS == false)
            {
                buttonPOS.Visible = false;
            }
            if (form.CashInOut == false)
            {
                buttonDisbursement.Visible = false;
            }
            if (form.StockIn == false)
            {
                buttonStockIn.Visible = false;
            }
            if (form.StockOut == false)
            {
                buttonStockOut.Visible = false;
            }
            if (form.SalesReport == false)
            {
                buttonSalesReport.Visible = false;
            }
            if (form.RemittanceReport == false)
            {
                buttonRemittanceReport.Visible = false;
            }
            if (form.InventoryReport == false)
            {
                buttonInventory.Visible = false;
            }
            if (form.StockCount == false)
            {
                buttonStockCount.Visible = false;
            }
            if (form.POSReport == false)
            {
                buttonPOSReport.Visible = false;
            }
            if (form.Settings == false)
            {
                buttonSettings.Visible = false;
            }
            if (form.SystemTables == false)
            {
                buttonSystemTables.Visible = false;
            }
        }

        public void InventoryModuleButtonLocation()
        {
            var menuForms = from d in db.SysMenuForms
                            select d;
            var form = menuForms.FirstOrDefault();

            if (form.Discounting == false)
            {
                buttonUser.Location = new Point(10, 112);
            }
            if (form.POS == false)
            {
                if (form.CashInOut == false)
                {
                    buttonStockIn.Location = new Point(197, 10);
                    buttonStockOut.Location = new Point(197, 112);
                }
            }
            if (form.SalesReport == false)
            {
                if (form.RemittanceReport == false)
                {
                    buttonInventory.Location = new Point(384, 10);
                    buttonStockCount.Location = new Point(384, 112);
                }
            }
            if (form.POSReport == false)
            {
                buttonSettings.Location = new Point(572, 10);
                buttonUtilities.Location = new Point(572, 112);
                buttonSystemTables.Location = new Point(572, 215);
            }
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("MstItem");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageItemList();
                buttonItem.Focus();
            }
        }

        private void buttonPOS_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("TrnSales");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var sysCurrent = Modules.SysCurrentModule.GetCurrentSettings();
                if (sysCurrent.POSType == "POS Touch")
                {
                    sysUserRights = new Modules.SysUserRightsModule("TrnRestaurant");
                    if (sysUserRights.GetUserRights() == null)
                    {
                        MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        sysSoftwareForm.AddTabPagePOSTouchSalesList();
                    }
                }
                else
                {
                    sysSoftwareForm.AddTabPagePOSSalesList();
                }
            }
        }

        private void buttonDiscounting_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("MstDiscount");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageDiscountingList();
            }
        }

        private void buttonPOSReport_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("RepPOS");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPagePOSReport();
            }
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("MstUser");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageUserList();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("SysSettings");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageSettings();
            }
        }

        private void buttonSalesReport_OnClick(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("RepSales");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageSalesReport();
            }
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("MstCustomer");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageCustomerList();
            }
        }

        private void buttonStockIn_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("TrnStockIn");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageStockInList();
            }
        }

        private void buttonStockOut_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("TrnStockOut");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageStockOutList();
            }
        }

        private void buttonDisbursement_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("TrnDisbursement");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageDisbursementList();
            }
        }

        private void buttonSystemTables_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("SysTables");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageSystemTables();
            }
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("RepInventory");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageInventoryReports();
            }
        }

        private void buttonRemittanceReport_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("RepDisbursement");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageRemittanceReports();
            }
        }

        private void buttonStockCount_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("TrnStockCount");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageStockCountList();
            }
        }

        private void buttonUtilities_Click(object sender, EventArgs e)
        {
            sysUserRights = new Modules.SysUserRightsModule("SysUtilities");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sysSoftwareForm.AddTabPageUtilities();
            }

        }
        public void SalesSummaryPerMonth()
        {
            // ============
            // Data Context
            // ============
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            Int32 currentYear = Convert.ToInt32(DateTime.Now.Year);
            Decimal januaryAmount = 0;
            Decimal februaryAmount = 0;
            Decimal marchAmount = 0;
            Decimal aprilAmount = 0;
            Decimal mayAmount = 0;
            Decimal juneAmount = 0;
            Decimal julyAmount = 0;
            Decimal augustAmount = 0;
            Decimal septemberAmount = 0;
            Decimal octoberAmount = 0;
            Decimal novemberAmount = 0;
            Decimal decemberAmount = 0;

            var sales = from d in db.TrnSales
                        where d.SalesDate.Year >= currentYear
                        && d.IsLocked == true
                        && d.IsCancelled == false
                        select d;
            // =================
            // Sales for January
            // =================
            var salesJanuary = from d in sales
                               where d.SalesDate.Month == 1
                               select d;
            if (salesJanuary.Any())
            {
                januaryAmount = salesJanuary.Sum(d => d.Amount);
            }
            // ==================
            // Sales for February
            // ==================
            var salesFebruary = from d in sales
                                where d.SalesDate.Month == 2
                                select d;
            if (salesFebruary.Any())
            {
                februaryAmount = salesFebruary.Sum(d => d.Amount);
            }
            // ===============
            // Sales for March
            // ===============
            var salesMarch = from d in sales
                             where d.SalesDate.Month == 3
                             select d;
            if (salesMarch.Any())
            {
                marchAmount = salesMarch.Sum(d => d.Amount);
            }
            // ===============
            // Sales for April
            // ===============
            var salesApril = from d in sales
                             where d.SalesDate.Month == 4
                             select d;
            if (salesApril.Any())
            {
                aprilAmount = salesApril.Sum(d => d.Amount);
            }
            // =============
            // Sales for May
            // =============
            var salesMay = from d in sales
                           where d.SalesDate.Month == 5
                           select d;
            if (salesMay.Any())
            {
                mayAmount = salesMay.Sum(d => d.Amount);
            }
            // ==============
            // Sales for June
            // ==============
            var salesJune = from d in sales
                            where d.SalesDate.Month == 6
                            select d;
            if (salesJune.Any())
            {
                juneAmount = salesJune.Sum(d => d.Amount);
            }
            // ==============
            // Sales for July
            // ==============
            var salesJuly = from d in sales
                            where d.SalesDate.Month == 7
                            select d;
            if (salesJuly.Any())
            {
                julyAmount = salesJuly.Sum(d => d.Amount);
            }
            // ================
            // Sales for August
            // ================
            var salesAugust = from d in sales
                              where d.SalesDate.Month == 8
                              select d;
            if (salesAugust.Any())
            {
                augustAmount = salesAugust.Sum(d => d.Amount);
            }
            // ===================
            // Sales for September
            // ===================
            var salesSeptember = from d in sales
                                 where d.SalesDate.Month == 9
                                 select d;
            if (salesSeptember.Any())
            {
                septemberAmount = salesSeptember.Sum(d => d.Amount);
            }
            // =================
            // Sales for October
            // =================
            var salesOctober = from d in sales
                               where d.SalesDate.Month == 10
                               select d;
            if (salesOctober.Any())
            {
                octoberAmount = salesOctober.Sum(d => d.Amount);
            }
            // ==================
            // Sales for November
            // ==================
            var salesNovember = from d in sales
                                where d.SalesDate.Month == 11
                                select d;
            if (salesNovember.Any())
            {
                novemberAmount = salesNovember.Sum(d => d.Amount);
            }
            // ==================
            // Sales for December
            // ==================
            var salesDecember = from d in sales
                                where d.SalesDate.Month == 12
                                select d;
            if (salesDecember.Any())
            {
                decemberAmount = salesDecember.Sum(d => d.Amount);
            }

            chartMonthlySales.Series["Sales"].LabelFormat = "0.00";
            chartMonthlySales.Series["Sales"].Points.AddXY("Jan.", januaryAmount);
            chartMonthlySales.Series["Sales"].Points.AddXY("Feb.", februaryAmount);
            chartMonthlySales.Series["Sales"].Points.AddXY("March", marchAmount);
            chartMonthlySales.Series["Sales"].Points.AddXY("April", aprilAmount);
            chartMonthlySales.Series["Sales"].Points.AddXY("May", mayAmount);
            chartMonthlySales.Series["Sales"].Points.AddXY("June", juneAmount);
            chartMonthlySales.Series["Sales"].Points.AddXY("July", julyAmount);
            chartMonthlySales.Series["Sales"].Points.AddXY("Aug.", augustAmount);
            chartMonthlySales.Series["Sales"].Points.AddXY("Sept.", septemberAmount);
            chartMonthlySales.Series["Sales"].Points.AddXY("Oct.", octoberAmount);
            chartMonthlySales.Series["Sales"].Points.AddXY("Nov.", novemberAmount);
            chartMonthlySales.Series["Sales"].Points.AddXY("Dec.", decemberAmount);
            chartMonthlySales.Series["Sales"].Color = ColorTranslator.FromHtml("#91C354");

        }

        public void TopSellingChart()
        {
            Int32 itemCounter = 0;
            Controllers.RepSalesReportController repTopSellingItemsReportController = new Controllers.RepSalesReportController();
            var topSellingItems = repTopSellingItemsReportController.TopSellingItemsReportPieChart();
            if (topSellingItems.Any())
            {
                Decimal totalQuantity = 0;
                totalQuantity = topSellingItems.Sum(d => d.Quantity);

                foreach (var topSellingItem in topSellingItems)
                {
                    if (itemCounter < 10)
                    {
                        Decimal percentage = (topSellingItem.Quantity * Convert.ToDecimal(1.0) / totalQuantity);
                        chartTopSellingItems.Series["TopSelling"].IsValueShownAsLabel = true;
                        chartTopSellingItems.Series["TopSelling"].LabelFormat = "#.##%";
                        chartTopSellingItems.Series["TopSelling"].Points.AddXY(topSellingItem.ItemDescription, percentage);
                        itemCounter += 1;
                    }
                }
            }
        }

        private void radioButtonSales_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxLogo.Hide();
            SalesSummaryPerMonth();
            TopSellingChart();
            radioButtonSales.Enabled = false;
        }
    }
}
