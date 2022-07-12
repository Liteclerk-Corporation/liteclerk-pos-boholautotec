using System;
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

namespace EasyPOS.Forms.Software._80mmReport
{
    public partial class RepLoadSummaryReport80mmForm : Form
    {
        public DateTime dateStart;
        public DateTime dateEnd;
        public Int32 filterCustomerId;
        public RepLoadSummaryReport80mmForm(DateTime startDate, DateTime endDate, Int32 customerId)
        {
            InitializeComponent();
            dateStart = startDate;
            dateEnd = endDate;
            filterCustomerId = customerId;

            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                printDocumentLoadSummaryReport.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 255, 38500);
            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
            {
                printDocumentLoadSummaryReport.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 270, 38500);
            }
            else
            {
                printDocumentLoadSummaryReport.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 175, 38500);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDialogLoadSummaryReport.Document = printDocumentLoadSummaryReport;
            printDocumentLoadSummaryReport.PrinterSettings = printDialogLoadSummaryReport.PrinterSettings;

            DialogResult printerDialogResult = printDialogLoadSummaryReport.ShowDialog();
            if (printerDialogResult == DialogResult.OK)
            {
                PrintReport();
                Close();
            }
        }
        public void PrintReport()
        {
            printDocumentLoadSummaryReport.Print();
        }
        private void printDocumentLoadSummaryReport_PrintPage(object sender, PrintPageEventArgs e)
        {
            // ============
            // Data Context
            // ============
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            // =============
            // Font Settings
            // =============
            Font fontArial12Bold = new Font("Arial", 12, FontStyle.Bold);
            Font fontArial12Regular = new Font("Arial", 12, FontStyle.Regular);
            Font fontArial11Bold = new Font("Arial", 11, FontStyle.Bold);
            Font fontArial11Regular = new Font("Arial", 11, FontStyle.Regular);
            Font fontArial8Bold = new Font("Arial", 8, FontStyle.Bold);
            Font fontArial9Bold = new Font("Arial", 9, FontStyle.Bold);
            Font fontArial8Regular = new Font("Arial", 8, FontStyle.Regular);
            Font fontArial10Bold = new Font("Arial", 10, FontStyle.Bold);
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
            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                x = 5; y = 5;
                width = 245.0F; height = 0F;
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
            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "58mm Printer")
            {
                // =================
                // 80mm Report Title
                // =================
                String title = "Load Summary Report";
                graphics.DrawString(title, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(title, fontArial8Bold).Height;

                // ==================
                // Date Range Header
                // ==================
                String RangeDateText = "FROM" + " " + dateStart.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) + " " + "TO" + " " + dateEnd.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                graphics.DrawString(RangeDateText, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(RangeDateText, fontArial7Regular).Height;

                // ========
                // 1st Line
                // ========
                Point firstLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point firstLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, firstLineFirstPoint, firstLineSecondPoint);

                // ==================
                // Customer Load Line
                // ==================

                String loadDate = "\nDate";
                String customer = "\nCustomer";
                String amount = "\nAmount";
                graphics.DrawString(loadDate, fontArial7Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(customer, fontArial7Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                graphics.DrawString(amount, fontArial7Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(loadDate, fontArial7Regular).Height + 3.0F;

                // ========
                // 2nd Line
                // ========
                Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) + 3);
                Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) + 3);
                graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);
                Decimal totalLoadAmount = 0;

                var loads = from s in db.MstCustomerLoads
                            where s.LoadDate >= dateStart
                             && s.LoadDate <= dateEnd
                             && s.CustomerId == filterCustomerId
                            select s;

                if (filterCustomerId == 0)
                {
                    loads = from s in db.MstCustomerLoads
                            where s.LoadDate >= dateStart
                             && s.LoadDate <= dateEnd
                            select s;
                }

                if (loads.Any())
                {
                    foreach (var load in loads)
                    {
                        RectangleF itemDataRectangle = new RectangleF
                        {
                            X = x,
                            Y = y,
                            Size = new Size(240, ((int)graphics.MeasureString(load.LoadDate + load.MstCustomer.Customer + load.Amount, fontArial8Regular, 150, StringFormat.GenericDefault).Height))
                        };
                        graphics.DrawString("\n" + load.LoadDate.ToShortDateString(), fontArial7Regular, Brushes.Black, new RectangleF(x, y + 5, 120, height), drawFormatLeft);
                        graphics.DrawString("\n" + load.MstCustomer.Customer, fontArial7Regular, Brushes.Black, new RectangleF(x, y + 20, width, height), drawFormatRight);
                        graphics.DrawString("\n" + load.Amount.ToString("#,##0.00"), fontArial7Regular, Brushes.Black, new RectangleF(x, y + 20, width, height), drawFormatRight);
                        y += itemDataRectangle.Size.Height;
                        totalLoadAmount += load.Amount;
                    }
                }
                // ========
                // 3rd Line
                // ========
                Point fourthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 17);
                Point fourthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 17);
                graphics.DrawLine(blackPen, fourthLineFirstPoint, fourthLineSecondPoint);

                String totalLoadAmounts = "\n" + totalLoadAmount.ToString("#,##0.00");
                String amountLabesl = "\n Total";
                graphics.DrawString(amountLabesl, fontArial8Bold, drawBrush, new RectangleF(x, y + 6, width, height), drawFormatLeft);
                graphics.DrawString(totalLoadAmounts, fontArial8Bold, drawBrush, new RectangleF(x, y + 5, width, height), drawFormatRight);
            }
            else
            {
                // =================
                // 80mm Report Title
                // =================
                String title = "Load Summary Report";
                graphics.DrawString(title, fontArial11Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(title, fontArial11Bold).Height;

                // ==================
                // Date Range Header
                // ==================
                String RangeDateText = "FROM" + " " + dateStart.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) + " " + "TO" + " " + dateEnd.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                graphics.DrawString(RangeDateText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(RangeDateText, fontArial8Regular).Height;

                // ========
                // 1st Line
                // ========
                Point firstLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point firstLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, firstLineFirstPoint, firstLineSecondPoint);

                // ==================
                // Customer Load Line
                // ==================

                String loadDate = "\nDate";
                String customer = "\nCustomer";
                String amount = "\nAmount";
                graphics.DrawString(loadDate, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(customer, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                graphics.DrawString(amount, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(loadDate, fontArial7Regular).Height + 3.0F;

                // ========
                // 2nd Line
                // ========
                Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) + 3);
                Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) + 3);
                graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);
                Decimal totalLoadAmount = 0;

                var loads = from s in db.MstCustomerLoads
                            where s.LoadDate >= dateStart
                             && s.LoadDate <= dateEnd
                             && s.CustomerId == filterCustomerId
                            select s;

                if (filterCustomerId == 0)
                {
                    loads = from s in db.MstCustomerLoads
                            where s.LoadDate >= dateStart
                             && s.LoadDate <= dateEnd
                            select s;
                }

                if (loads.Any())
                {
                    foreach (var load in loads)
                    {
                        RectangleF itemDataRectangle = new RectangleF
                        {
                            X = x,
                            Y = y,
                            Size = new Size(240, ((int)graphics.MeasureString(load.LoadDate + load.MstCustomer.Customer + load.Amount, fontArial8Regular, 150, StringFormat.GenericDefault).Height))
                        };
                        graphics.DrawString("\n" + load.LoadDate.ToShortDateString(), fontArial8Regular, Brushes.Black, new RectangleF(x, y + 5, 120, height), drawFormatLeft);
                        graphics.DrawString(load.MstCustomer.Customer, fontArial8Regular, Brushes.Black, new RectangleF(x, y + 20, width, height), drawFormatCenter);
                        graphics.DrawString(load.Amount.ToString("#,##0.00"), fontArial8Regular, Brushes.Black, new RectangleF(x, y + 20, width, height), drawFormatRight);
                        y += itemDataRectangle.Size.Height;
                        totalLoadAmount += load.Amount;
                    }
                }
                // ========
                // 3rd Line
                // ========
                Point fourthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 17);
                Point fourthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 17);
                graphics.DrawLine(blackPen, fourthLineFirstPoint, fourthLineSecondPoint);

                String totalLoadAmounts = "\n" + totalLoadAmount.ToString("#,##0.00");
                String amountLabesl = "\n Total";
                graphics.DrawString(amountLabesl, fontArial9Bold, drawBrush, new RectangleF(x, y + 6, width, height), drawFormatLeft);
                graphics.DrawString(totalLoadAmounts, fontArial9Bold, drawBrush, new RectangleF(x, y + 5, width, height), drawFormatRight);
            }
        }
    }
}
