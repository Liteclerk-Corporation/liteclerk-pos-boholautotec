using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EasyPOS.Forms.Software.RepSalesReport
{
    public partial class RepSalesSummaryReportForm : Form
    {
        public List<Entities.DgvRepSalesReportSalesSummaryReportListEntity> salesList;
        public BindingSource dataSalesListSource = new BindingSource();
        public PagedList<Entities.DgvRepSalesReportSalesSummaryReportListEntity> pageList;
        public Int32 pageNumber = 1;
        public Int32 pageSize = 50;

        public DateTime dateStart;
        public DateTime dateEnd;
        public Int32 filterTerminalId;
        public Int32 filterCustomerId;
        public Int32 filterSalesAgentId;

        public RepSalesSummaryReportForm(DateTime startDate, DateTime endDate, Int32 terminalId, Int32 CustomerId, Int32 SalesAgentId)
        {
            InitializeComponent();

            dateStart = startDate;
            dateEnd = endDate;
            filterTerminalId = terminalId;
            filterCustomerId = CustomerId;
            filterSalesAgentId = SalesAgentId;

            GetSalesSummaryListDataSource();
            CreateSalesSummaryListDataGrid();
        }

        public List<Entities.DgvRepSalesReportSalesSummaryReportListEntity> GetSalesSummaryListData(DateTime startDate, DateTime endDate, Int32 terminalId, Int32 CustomerId, Int32 SalesAgentId)
        {
            List<Entities.DgvRepSalesReportSalesSummaryReportListEntity> rowList = new List<Entities.DgvRepSalesReportSalesSummaryReportListEntity>();

            Controllers.RepSalesReportController repSalesSummaryReportController = new Controllers.RepSalesReportController();

            var salesList = repSalesSummaryReportController.SalesSummaryReport(startDate, endDate, terminalId, CustomerId, SalesAgentId);
            if (salesList.Any())
            {
                Decimal totalAmount = 0;
                var row = from d in salesList
                          select new Entities.DgvRepSalesReportSalesSummaryReportListEntity
                          {
                              ColumnId = d.Id,
                              ColumnTerminal = d.Terminal,
                              ColumnSalesDate = d.SalesDate,
                              ColumnSalesNumber = d.SalesNumber,
                              ColumnCustomerCode = d.CustomerCode,
                              ColumnCustomer = d.Customer,
                              ColumnTerm = d.Term,
                              ColumnRemarks = d.Remarks,
                              ColumnPreparedByUserName = d.PreparedByUserName,
                              ColumnCashier = d.UpdatedUserName,
                              ColumnAmount = d.Amount.ToString("#,##0.00"),
                              ColumnEntryDateTime = d.EntryDateTime
                          };

                totalAmount = salesList.Sum(d => d.Amount);
                textBoxTotalAmount.Text = totalAmount.ToString("#,##0.00");

                rowList = row.ToList();

            }
            return rowList;
        }

        public void GetSalesSummaryListDataSource()
        {
            salesList = GetSalesSummaryListData(dateStart, dateEnd, filterTerminalId, filterCustomerId, filterSalesAgentId);
            if (salesList.Any())
            {

                pageList = new PagedList<Entities.DgvRepSalesReportSalesSummaryReportListEntity>(salesList, pageNumber, pageSize);

                if (pageList.PageCount == 1)
                {
                    buttonSalesListPageListFirst.Enabled = false;
                    buttonSalesListPageListPrevious.Enabled = false;
                    buttonSalesListPageListNext.Enabled = false;
                    buttonSalesListPageListLast.Enabled = false;
                }
                else if (pageNumber == 1)
                {
                    buttonSalesListPageListFirst.Enabled = false;
                    buttonSalesListPageListPrevious.Enabled = false;
                    buttonSalesListPageListNext.Enabled = true;
                    buttonSalesListPageListLast.Enabled = true;
                }
                else if (pageNumber == pageList.PageCount)
                {
                    buttonSalesListPageListFirst.Enabled = true;
                    buttonSalesListPageListPrevious.Enabled = true;
                    buttonSalesListPageListNext.Enabled = false;
                    buttonSalesListPageListLast.Enabled = false;
                }
                else
                {
                    buttonSalesListPageListFirst.Enabled = true;
                    buttonSalesListPageListPrevious.Enabled = true;
                    buttonSalesListPageListNext.Enabled = true;
                    buttonSalesListPageListLast.Enabled = true;
                }

                textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
                dataSalesListSource.DataSource = pageList;
            }
            else
            {
                buttonSalesListPageListFirst.Enabled = false;
                buttonSalesListPageListPrevious.Enabled = false;
                buttonSalesListPageListNext.Enabled = false;
                buttonSalesListPageListLast.Enabled = false;

                dataSalesListSource.Clear();
                textBoxPageNumber.Text = "0 / 0";
            }
        }

        public void CreateSalesSummaryListDataGrid()
        {
            dataGridViewSalesSummaryReport.DataSource = dataSalesListSource;
        }

        private void buttonSalesListPageListFirst_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvRepSalesReportSalesSummaryReportListEntity>(salesList, 1, pageSize);
            dataSalesListSource.DataSource = pageList;

            buttonSalesListPageListFirst.Enabled = false;
            buttonSalesListPageListPrevious.Enabled = false;
            buttonSalesListPageListNext.Enabled = true;
            buttonSalesListPageListLast.Enabled = true;

            pageNumber = 1;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonSalesListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (pageList.HasPreviousPage == true)
            {
                pageList = new PagedList<Entities.DgvRepSalesReportSalesSummaryReportListEntity>(salesList, --pageNumber, pageSize);
                dataSalesListSource.DataSource = pageList;
            }

            buttonSalesListPageListNext.Enabled = true;
            buttonSalesListPageListLast.Enabled = true;

            if (pageNumber == 1)
            {
                buttonSalesListPageListFirst.Enabled = false;
                buttonSalesListPageListPrevious.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonSalesListPageListNext_Click(object sender, EventArgs e)
        {
            if (pageList.HasNextPage == true)
            {
                pageList = new PagedList<Entities.DgvRepSalesReportSalesSummaryReportListEntity>(salesList, ++pageNumber, pageSize);
                dataSalesListSource.DataSource = pageList;
            }

            buttonSalesListPageListFirst.Enabled = true;
            buttonSalesListPageListPrevious.Enabled = true;

            if (pageNumber == pageList.PageCount)
            {
                buttonSalesListPageListNext.Enabled = false;
                buttonSalesListPageListLast.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonSalesListPageListLast_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvRepSalesReportSalesSummaryReportListEntity>(salesList, pageList.PageCount, pageSize);
            dataSalesListSource.DataSource = pageList;

            buttonSalesListPageListFirst.Enabled = true;
            buttonSalesListPageListPrevious.Enabled = true;
            buttonSalesListPageListNext.Enabled = false;
            buttonSalesListPageListLast.Enabled = false;

            pageNumber = pageList.PageCount;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonClose_OnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGenerateCSV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = folderBrowserDialogGenerateCSV.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    StringBuilder csv = new StringBuilder();
                    String[] header = { "Terminal", "Date", "Sales Number", "Customer Code", "Customer", "Term", "Remarks", "Teller", "Cashier", "Amount" };
                    csv.AppendLine(String.Join(",", header));

                    if (salesList.Any())
                    {
                        foreach (var sales in salesList)
                        {
                            String customerCode = "";
                            if (sales.ColumnCustomerCode != null)
                            {
                                customerCode = sales.ColumnCustomerCode.Replace(",", "");
                            }

                            String[] data = {
                                sales.ColumnTerminal,
                                sales.ColumnSalesDate,
                                sales.ColumnSalesNumber,
                                customerCode,
                                sales.ColumnCustomer.Replace("," , ""),
                                sales.ColumnTerm.Replace("," , ""),
                                sales.ColumnRemarks.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                                sales.ColumnPreparedByUserName.Replace("," , ""),
                                sales.ColumnCashier.Replace("," , ""),
                                sales.ColumnAmount.Replace("," , ""),
                                sales.ColumnEntryDateTime,
                            };

                            csv.AppendLine(String.Join(",", data));
                        }
                    }

                    String executingUser = WindowsIdentity.GetCurrent().Name;

                    DirectorySecurity securityRules = new DirectorySecurity();
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.Read, AccessControlType.Allow));
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.FullControl, AccessControlType.Allow));

                    DirectoryInfo createDirectorySTCSV = Directory.CreateDirectory(folderBrowserDialogGenerateCSV.SelectedPath, securityRules);
                    File.WriteAllText(createDirectorySTCSV.FullName + "\\SalesSummaryReport_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".csv", csv.ToString(), Encoding.GetEncoding("utf-8"));

                    MessageBox.Show("Generate CSV Successful!", "Generate CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            new RepSalesSummaryReportPDFForm(dateStart, dateEnd, filterTerminalId, filterCustomerId, filterSalesAgentId);
        }

        private void buttonXML_Click(object sender, EventArgs e)
        {
            XDocument srcTree = new XDocument(
            new XComment("Copyright 1994-2010 SYSPRO Ltd."),
            new XComment("This is an example XML instance to demonstrate use of the Sales Order Transaction Posting Business Object"),
            new XElement("SalesOrders",
                new XElement("Orders",
                    new XElement("OrderHeader",
                        new XElement("CustomerPoNumber", "C1000"),
                        new XElement("OrderActionType", "A"),
                        new XElement("NewCustomerPoNumber", ""),
                        new XElement("Supplier", ""),
                        new XElement("Customer", "STR1"),
                        new XElement("OrderDate", "2021-08-31"),
                        new XElement("InvoiceTerms", "01"),
                        new XElement("Currency", "Php"),
                        new XElement("ShippingInstrs", ""),
                        new XElement("ShippingInstrsCode", ""),
                        new XElement("CustomerName", "Store 1"),
                        new XElement("ShipAddress1", "This is the alternate delivery address 1"),
                        new XElement("ShipAddress2", "This is the alternate delivery address 2"),
                        new XElement("ShipAddress3", "This is the alternate delivery address 3"),
                        new XElement("ShipAddress3Locality", "This is the delivery address 3 location"),
                        new XElement("ShipAddress4", "This is the alternate delivery address 4"),
                        new XElement("ShipAddress5", "This is the alternate delivery address 5"),
                        new XElement("ShipPostalCode", ""),
                        new XElement("ShipGpsLat", ""),
                        new XElement("ShipGpsLong", ""),
                        new XElement("LanguageCode", ""),
                        new XElement("Warehouse", "2"),
                        new XElement("SpecialInstrs", ""),
                        new XElement("SpecialInstrs", ""),
                        new XElement("SalesOrder", ""),
                        new XElement("OrderType", "1"),
                        new XElement("MultiShipCode", ""),
                        new XElement("ShipAddressPerLine", ""),
                        new XElement("AlternateReference", ""),
                        new XElement("Salesperson", "01"),
                        new XElement("Branch", ""),
                        new XElement("Area", ""),
                        new XElement("RequestedShipDate", "")),
                    new XElement("OrderDetails",
                        new XElement("StockLine",
                            new XElement("CustomerPoLine", "1"),
                            new XElement("LineActionType", "A"),
                            new XElement("LineCancelCode", ""),
                            new XElement("StockCode", "10666"),
                            new XElement("StockDescription", "PLATE BBQ Chicken Wings"),
                            new XElement("Warehouse", "2"),
                            new XElement("CustomersPartNumber", ""),
                            new XElement("OrderQty", "10"),
                            new XElement("OrderUom", "srvg"),
                            new XElement("Price", "480"),
                            new XElement("PriceUom", "srvg"),
                            new XElement("PriceCode", ""),
                            new XElement("AlwaysUsePriceEntered", ""),
                            new XElement("Units", ""),
                            new XElement("Pieces", ""),
                            new XElement("ProductClass", ""),
                            new XElement("LineDiscPercent1", "0"),
                            new XElement("LineDiscPercent2", "0"),
                            new XElement("LineDiscPercent3", "0"),
                            new XElement("AlwaysUseDiscountEntered", "N"),
                            new XElement("CustRequestDate", "2021-08-31"),
                            new XElement("CommissionCode", ""),
                            new XElement("LineShipDate", ""),
                            new XElement("LineDiscValue", "0"),
                            new XElement("LineDiscValFlag", ""),
                            new XElement("UserDefined", "USER"))
                        )
                    )
                )
            );
            var xmlFilePath = Modules.SysCurrentModule.GetCurrentSettings().XMLFilePath;
            string fileName = @"" + xmlFilePath + "\\SalesOrder_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml";
            if (!File.Exists(fileName))
            {
                srcTree.Save(fileName);
                MessageBox.Show("Generate XML Successful!", "Generate XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
