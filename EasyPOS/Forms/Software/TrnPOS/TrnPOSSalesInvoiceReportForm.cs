﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnPOSSalesInvoiceReportForm : Form
    {
        public Int32 trnSalesId = 0;

        public TrnPOSSalesInvoiceReportForm(Int32 salesId, String printerName)
        {
            InitializeComponent();
            trnSalesId = salesId;

            if (String.IsNullOrEmpty(printerName) == false)
            {
                printDocumentSalesInvoiceReport.PrinterSettings.PrinterName = printerName;
                printDocumentSalesInvoiceReport.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 850, 1100);

                printDocumentSalesInvoiceReport.Print();
            }
            else
            {
                if (Modules.SysCurrentModule.GetCurrentSettings().SalesOrderPrinterType == "Letter Printer")
                {
                    printDocumentSalesInvoiceReport.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 850, 1100);
                    printDocumentSalesInvoiceReport.Print();
                }
                //else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
                //{
                //    printDocumentSalesInvoiceReport.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 270, 38500);
                //    printDocumentSalesInvoiceReport.Print();
                //}
                //else
                //{
                //    printDocumentSalesInvoiceReport.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 175, 38500);
                //    printDocumentSalesInvoiceReport.Print();
                //}
            }
        }

        private void printDocumentSalesInvoiceReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // ============
            // Data Context
            // ============
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            // =============
            // Font Settings
            // =============
            Font fontArial20Bold = new Font("Leelawadee UI", 18, FontStyle.Bold);
            Font fontArial20Regular = new Font("Arial", 18, FontStyle.Regular);
            Font fontArial12Bold = new Font("Arial", 12, FontStyle.Bold);
            Font fontArial12Regular = new Font("Arial", 12, FontStyle.Regular);
            Font fontArial11Bold = new Font("Arial", 11, FontStyle.Bold);
            Font fontArial11Regular = new Font("Arial", 11, FontStyle.Regular);
            Font fontArial8Bold = new Font("Arial", 8, FontStyle.Bold);
            Font fontArial8Regular = new Font("Arial", 8, FontStyle.Regular);
            Font fontArial7Bold = new Font("Arial", 7, FontStyle.Bold);
            Font fontArial7Regular = new Font("Arial", 7, FontStyle.Regular);

            // ==================
            // Alignment Settings
            // ==================
            StringFormat drawFormatCenter = new StringFormat { Alignment = StringAlignment.Center };
            StringFormat drawFormatLeft = new StringFormat { Alignment = StringAlignment.Near };
            StringFormat drawFormatRight = new StringFormat { Alignment = StringAlignment.Far };

            float x, y;
            float width, height;
            if (Modules.SysCurrentModule.GetCurrentSettings().SalesOrderPrinterType == "Letter Printer")
            {
                x = 5; y = 5;
                width = 850; height = 0F;
            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
            {
                x = 5; y = 5;
                width = 260.0F; height = 0F;
            }
            else
            {
                x = 5; y = 5;
                width = 170.0F; height = 0F;
            }
            // ==============
            // Tools Settings
            // ==============
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black, 1);
            Pen whitePen = new Pen(Color.White, 1);

            // ========
            // Graphics
            // ========
            Graphics graphics = e.Graphics;

            // ==============
            // System Current
            // ==============
            var systemCurrent = Modules.SysCurrentModule.GetCurrentSettings();

            // ============
            // Company Name
            // ============
            String companyName = systemCurrent.CompanyName;
            RectangleF companyNameRectangle = new RectangleF
            {
                X = x,
                Y = y,
                Size = new Size(245, ((int)graphics.MeasureString(companyName, fontArial8Bold, 245, StringFormat.GenericDefault).Height))
            };

            graphics.DrawString(companyName, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += companyNameRectangle.Size.Height + 1.0F;

            // ===============
            // Company Address
            // ===============

            String companyAddress = systemCurrent.Address;

            float adjuctHeight = 1;
            if (companyAddress.Length > 43)
            {
                adjuctHeight = 3;
            }

            graphics.DrawString(companyAddress, fontArial12Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += (graphics.MeasureString(companyAddress, fontArial12Regular).Height * adjuctHeight);

            // ==========
            // TIN Number
            // ==========
            //String TINNumber = systemCurrent.TIN;
            //graphics.DrawString("TIN: " + TINNumber, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += graphics.MeasureString(companyAddress, fontArial8Regular).Height;

            // =============
            // Serial Number
            // =============
            //String serialNo = systemCurrent.SerialNo;
            //graphics.DrawString("SN: " + serialNo, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += graphics.MeasureString(companyAddress, fontArial8Regular).Height;

            // ==============
            // Machine Number
            // ==============
            //String machineNo = systemCurrent.MachineNo;
            //graphics.DrawString("MIN: " + machineNo, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += graphics.MeasureString(companyAddress, fontArial8Regular).Height;

            // =================
            // Sales Order Title
            // =================
            String officialReceiptTitle = "Sales Invoice";
            graphics.DrawString(officialReceiptTitle, fontArial20Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(officialReceiptTitle, fontArial20Bold).Height;

            // ============
            // Sales Header
            // ============
            var sales = from d in db.TrnSales
                        where d.Id == trnSalesId
                        select d;

            if (sales.Any())
            {
                String terminalText = "Terminal: " + sales.FirstOrDefault().MstTerminal.Terminal;
                graphics.DrawString(terminalText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(terminalText, fontArial8Regular).Height;

                String collectionNumberText = sales.FirstOrDefault().SalesNumber;
                graphics.DrawString(collectionNumberText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(collectionNumberText, fontArial8Regular).Height;

                String collectionDateText = sales.FirstOrDefault().SalesDate.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                graphics.DrawString(collectionDateText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(collectionDateText, fontArial8Regular).Height;

                String collectionTimeText = sales.FirstOrDefault().UpdateDateTime.ToString("H:mm:ss", CultureInfo.InvariantCulture);
                graphics.DrawString(collectionTimeText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(collectionTimeText, fontArial8Regular).Height;

                // ========
                // 1st Line
                // ========
                Point firstLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point firstLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, firstLineFirstPoint, firstLineSecondPoint);

                if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "58mm Printer")
                {
                    // ==========
                    // Sales Line
                    // ==========
                    Decimal totalAmount = 0;
                    Decimal totalNumberOfItems = 0;

                    String itemLabel = "\nITEM";
                    String amountLabel = "\nAMOUNT";
                    graphics.DrawString(itemLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(amountLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(itemLabel, fontArial7Regular).Height + 5.0F;

                    Decimal totalServiceCharge = 0;
                    Boolean hasServiceCharge = false;

                    var salesLines = from d in db.TrnSalesLines where d.SalesId == trnSalesId select d;
                    if (salesLines.Any())
                    {
                        var salesLineGroupbyItem = from s in salesLines
                                                   group s by new
                                                   {
                                                       s.SalesId,
                                                       s.ItemId,
                                                       s.MstItem,
                                                       s.UnitId,
                                                       s.MstUnit,
                                                       s.NetPrice,
                                                       s.Price,
                                                       s.TaxId,
                                                       s.MstTax,
                                                       s.DiscountId,
                                                       s.DiscountRate,
                                                       s.SalesAccountId,
                                                       s.AssetAccountId,
                                                       s.CostAccountId,
                                                       s.TaxAccountId,
                                                       s.SalesLineTimeStamp,
                                                       s.UserId,
                                                       s.Preparation,
                                                       s.Price1,
                                                       s.Price2,
                                                       s.Price2LessTax,
                                                       s.PriceSplitPercentage
                                                   } into g
                                                   select new
                                                   {
                                                       g.Key.ItemId,
                                                       g.Key.MstItem,
                                                       g.Key.MstItem.ItemDescription,
                                                       g.Key.MstUnit.Unit,
                                                       g.Key.Price,
                                                       g.Key.NetPrice,
                                                       g.Key.DiscountId,
                                                       g.Key.DiscountRate,
                                                       g.Key.TaxId,
                                                       g.Key.MstTax,
                                                       g.Key.MstTax.Tax,
                                                       Amount = g.Sum(a => a.Amount),
                                                       Quantity = g.Sum(a => a.Quantity),
                                                       DiscountAmount = g.Sum(a => a.DiscountAmount * a.Quantity),
                                                       TaxAmount = g.Sum(a => a.TaxAmount)
                                                   };

                        if (salesLineGroupbyItem.Any())
                        {
                            foreach (var salesLine in salesLineGroupbyItem.ToList())
                            {
                                totalNumberOfItems += 1;

                                totalAmount += salesLine.Amount;

                                if (salesLine.MstItem.BarCode != "0000000001")
                                {
                                    String itemData = salesLine.ItemDescription + "\n" + salesLine.Quantity.ToString("#,##0.00") + " " + salesLine.Unit + " @ " + salesLine.Price.ToString("#,##0.00") + " - " + salesLine.MstTax.Code[0];
                                    String itemAmountData = (salesLine.Amount + salesLine.DiscountAmount).ToString("#,##0.00");
                                    RectangleF itemDataRectangle = new RectangleF
                                    {
                                        X = x,
                                        Y = y,
                                        Size = new Size(150, ((int)graphics.MeasureString(itemData, fontArial7Regular, 150, StringFormat.GenericDefault).Height))
                                    };
                                    graphics.DrawString(itemData, fontArial7Regular, Brushes.Black, itemDataRectangle, drawFormatLeft);
                                    graphics.DrawString(itemAmountData, fontArial7Regular, drawBrush, new RectangleF(x, y, 170.0F, height), drawFormatRight);
                                    y += itemDataRectangle.Size.Height + 3.0F;
                                }
                                else
                                {
                                    hasServiceCharge = true;
                                    totalServiceCharge += salesLine.Amount;
                                }
                            }
                        }
                    }

                    // ========
                    // 2nd Line
                    // ========
                    Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);

                    // ============
                    // Total Amount
                    // ============
                    if (hasServiceCharge == true)
                    {
                        String totalServiceChangeLabel = "\nService Charge";
                        String totalServiceChangeAmount = "\n" + totalServiceCharge.ToString("#,##0.00");
                        graphics.DrawString(totalServiceChangeLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        graphics.DrawString(totalServiceChangeAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                        y += graphics.MeasureString(totalServiceChangeAmount, fontArial7Regular).Height;


                        String totalSalesLabel = "Total Amount";
                        String totalSalesAmount = totalAmount.ToString("#,##0.00");
                        graphics.DrawString(totalSalesLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        graphics.DrawString(totalSalesAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                        y += graphics.MeasureString(totalSalesAmount, fontArial7Regular).Height;
                    }
                    else
                    {
                        String totalSalesLabel = "\nTotal Amount";
                        String totalSalesAmount = "\n" + totalAmount.ToString("#,##0.00");
                        graphics.DrawString(totalSalesLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        graphics.DrawString(totalSalesAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                        y += graphics.MeasureString(totalSalesAmount, fontArial7Regular).Height;
                    }

                    String totalNumberOfItemsLabel = "Total No. of Item(s)";
                    String totalNumberOfItemsQuantity = totalNumberOfItems.ToString("#,##0.00");
                    graphics.DrawString(totalNumberOfItemsLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalNumberOfItemsQuantity, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalNumberOfItemsQuantity, fontArial7Regular).Height;

                    // ========
                    // 3rd Line
                    // ========
                    Point thirdLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    Point thirdLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    graphics.DrawLine(blackPen, thirdLineFirstPoint, thirdLineSecondPoint);

                    String remarks = "\nRemarks: \n\n " + salesLines.FirstOrDefault().TrnSale.Remarks;
                    graphics.DrawString(remarks, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(remarks, fontArial7Regular).Height;

                    //// ========
                    //// 4th Line
                    //// ========
                    //Point forththLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    //Point forthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    //graphics.DrawLine(blackPen, forththLineFirstPoint, forthLineSecondPoint);

                    //String orderNumber = "\nOrder Number: \n\n " + salesLines.FirstOrDefault().TrnSale.SalesNumber;
                    //graphics.DrawString(orderNumber, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    //y += graphics.MeasureString(orderNumber, fontArial8Regular).Height;

                    // ========
                    // 5th Line
                    // ========
                    Point fifthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    Point fifthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    graphics.DrawLine(blackPen, fifthLineFirstPoint, fifthLineSecondPoint);

                    // =======
                    // Cashier
                    // =======
                    String cashier = sales.FirstOrDefault().MstUser5.UserName;

                    String cashierLabel = "\nTeller";
                    String cashierUserData = "\n" + cashier;
                    graphics.DrawString(cashierLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(cashierUserData, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(cashierUserData, fontArial7Regular).Height;

                    // ========
                    // 6th Line
                    // ========
                    Point sixthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    Point sixthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    graphics.DrawLine(blackPen, sixthLineFirstPoint, sixthLineSecondPoint);

                    String salesInvoiceFooter = "\n" + systemCurrent.InvoiceFooter;
                    graphics.DrawString(salesInvoiceFooter, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString(salesInvoiceFooter, fontArial7Regular).Height;
                }
                else
                {
                    // ==========
                    // Sales Line
                    // ==========
                    Decimal totalAmount = 0;
                    Decimal totalNumberOfItems = 0;

                    String itemLabel = "\nITEM";
                    String amountLabel = "\nAMOUNT";
                    graphics.DrawString(itemLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(amountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(itemLabel, fontArial8Regular).Height + 5.0F;

                    Decimal totalServiceCharge = 0;
                    Boolean hasServiceCharge = false;

                    var salesLines = from d in db.TrnSalesLines where d.SalesId == trnSalesId select d;
                    if (salesLines.Any())
                    {
                        var salesLineGroupbyItem = from s in salesLines
                                                   group s by new
                                                   {
                                                       s.SalesId,
                                                       s.ItemId,
                                                       s.MstItem,
                                                       s.UnitId,
                                                       s.MstUnit,
                                                       s.NetPrice,
                                                       s.Price,
                                                       s.TaxId,
                                                       s.MstTax,
                                                       s.DiscountId,
                                                       s.DiscountRate,
                                                       s.SalesAccountId,
                                                       s.AssetAccountId,
                                                       s.CostAccountId,
                                                       s.TaxAccountId,
                                                       s.SalesLineTimeStamp,
                                                       s.UserId,
                                                       s.Preparation,
                                                       s.Price1,
                                                       s.Price2,
                                                       s.Price2LessTax,
                                                       s.PriceSplitPercentage
                                                   } into g
                                                   select new
                                                   {
                                                       g.Key.ItemId,
                                                       g.Key.MstItem,
                                                       g.Key.MstItem.ItemDescription,
                                                       g.Key.MstUnit.Unit,
                                                       g.Key.Price,
                                                       g.Key.NetPrice,
                                                       g.Key.DiscountId,
                                                       g.Key.DiscountRate,
                                                       g.Key.TaxId,
                                                       g.Key.MstTax,
                                                       g.Key.MstTax.Tax,
                                                       Amount = g.Sum(a => a.Amount),
                                                       Quantity = g.Sum(a => a.Quantity),
                                                       DiscountAmount = g.Sum(a => a.DiscountAmount * a.Quantity),
                                                       TaxAmount = g.Sum(a => a.TaxAmount)
                                                   };

                        if (salesLineGroupbyItem.Any())
                        {
                            foreach (var salesLine in salesLineGroupbyItem.ToList())
                            {
                                totalNumberOfItems += 1;

                                totalAmount += salesLine.Amount;


                                if (salesLine.MstItem.BarCode != "0000000001")
                                {
                                    String itemData = salesLine.ItemDescription + "\n" + salesLine.Quantity.ToString("#,##0.00") + " " + salesLine.Unit + " @ " + salesLine.Price.ToString("#,##0.00") + " - " + salesLine.MstTax.Code[0];
                                    String itemAmountData = (salesLine.Amount + salesLine.DiscountAmount).ToString("#,##0.00");
                                    RectangleF itemDataRectangle = new RectangleF
                                    {
                                        X = x,
                                        Y = y,
                                        Size = new Size(150, ((int)graphics.MeasureString(itemData, fontArial8Regular, 150, StringFormat.GenericDefault).Height))
                                    };
                                    graphics.DrawString(itemData, fontArial8Regular, Brushes.Black, itemDataRectangle, drawFormatLeft);

                                    if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
                                    {
                                        graphics.DrawString(itemAmountData, fontArial8Regular, drawBrush, new RectangleF(x, y, 245.0F, height), drawFormatRight);
                                    }
                                    else
                                    {
                                        graphics.DrawString(itemAmountData, fontArial8Regular, drawBrush, new RectangleF(x, y, 255.0F, height), drawFormatRight);
                                    }

                                    y += itemDataRectangle.Size.Height + 3.0F;
                                }
                                else
                                {
                                    hasServiceCharge = true;
                                    totalServiceCharge += salesLine.Amount;
                                }
                            }
                        }
                    }

                    // ========
                    // 2nd Line
                    // ========
                    Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);

                    // ============
                    // Total Amount
                    // ============
                    if (hasServiceCharge == true)
                    {
                        String totalServiceChangeLabel = "\nService Charge";
                        String totalServiceChangeAmount = "\n" + totalServiceCharge.ToString("#,##0.00");
                        graphics.DrawString(totalServiceChangeLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        graphics.DrawString(totalServiceChangeAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                        y += graphics.MeasureString(totalServiceChangeAmount, fontArial7Regular).Height;

                        String totalSalesLabel = "Total Amount";
                        String totalSalesAmount = totalAmount.ToString("#,##0.00");
                        graphics.DrawString(totalSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        graphics.DrawString(totalSalesAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                        y += graphics.MeasureString(totalSalesAmount, fontArial8Regular).Height;
                    }
                    else
                    {
                        String totalSalesLabel = "\nTotal Amount";
                        String totalSalesAmount = "\n" + totalAmount.ToString("#,##0.00");
                        graphics.DrawString(totalSalesLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        graphics.DrawString(totalSalesAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                        y += graphics.MeasureString(totalSalesAmount, fontArial7Regular).Height;
                    }

                    String totalNumberOfItemsLabel = "Total No. of Item(s)";
                    String totalNumberOfItemsQuantity = totalNumberOfItems.ToString("#,##0.00");
                    graphics.DrawString(totalNumberOfItemsLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalNumberOfItemsQuantity, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalNumberOfItemsQuantity, fontArial8Regular).Height;

                    // ========
                    // 3rd Line
                    // ========
                    Point thirdLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    Point thirdLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    graphics.DrawLine(blackPen, thirdLineFirstPoint, thirdLineSecondPoint);

                    String remarks = "\nRemarks: \n\n " + salesLines.FirstOrDefault().TrnSale.Remarks;
                    graphics.DrawString(remarks, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(remarks, fontArial8Regular).Height;

                    //// ========
                    //// 4th Line
                    //// ========
                    //Point forththLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    //Point forthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    //graphics.DrawLine(blackPen, forththLineFirstPoint, forthLineSecondPoint);

                    //String orderNumber = "\nOrder Number: \n\n " + salesLines.FirstOrDefault().TrnSale.SalesNumber;
                    //graphics.DrawString(orderNumber, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    //y += graphics.MeasureString(orderNumber, fontArial8Regular).Height;

                    // ========
                    // 5th Line
                    // ========
                    Point fifthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    Point fifthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    graphics.DrawLine(blackPen, fifthLineFirstPoint, fifthLineSecondPoint);

                    // =======
                    // Cashier
                    // =======
                    String cashier = sales.FirstOrDefault().MstUser5.UserName;

                    String cashierLabel = "\nTeller";
                    String cashierUserData = "\n" + cashier;
                    graphics.DrawString(cashierLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(cashierUserData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(cashierUserData, fontArial8Regular).Height;

                    // ========
                    // 6th Line
                    // ========
                    Point sixthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    Point sixthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    graphics.DrawLine(blackPen, sixthLineFirstPoint, sixthLineSecondPoint);

                    String salesInvoiceFooter = "\n" + systemCurrent.InvoiceFooter;
                    graphics.DrawString(salesInvoiceFooter, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString(salesInvoiceFooter, fontArial8Regular).Height;
                }
            }
        }
    }
}
