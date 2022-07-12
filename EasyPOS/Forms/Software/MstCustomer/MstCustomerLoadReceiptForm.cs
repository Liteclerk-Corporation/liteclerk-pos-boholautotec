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

namespace EasyPOS.Forms.Software.MstCustomer
{
    public partial class MstCustomerLoadReceiptForm : Form
    {
        public Int32 customerId = 0;
        public Entities.MstCustomerLoadEntity mstCustomerLoadEntity;

        public MstCustomerLoadReceiptForm(Int32 customerId_, Entities.MstCustomerLoadEntity customerLoadEntity)
        {
            InitializeComponent();

            mstCustomerLoadEntity = customerLoadEntity;
            customerId = customerId_;

            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                printDocumentLoadReceipt.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 255, 38500);
                printDocumentLoadReceipt.Print();

            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
            {
                printDocumentLoadReceipt.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 280, 38500);
                printDocumentLoadReceipt.Print();
            }
            else
            {
                printDocumentLoadReceipt.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 175, 38500);
                printDocumentLoadReceipt.Print();
            }
        }

        private void printDocumentLoadReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            Font fontArial8Regular = new Font("Arial", 8, FontStyle.Regular);
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
                width = 270.0F; height = 0F;
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
                // ============
                // Company Name
                // ============
                String companyName = systemCurrent.CompanyName;
                RectangleF companyNameRectangle = new RectangleF

                {
                    X = x,
                    Y = y,
                    Size = new Size(170, ((int)graphics.MeasureString(companyName, fontArial8Bold, 170, StringFormat.GenericDefault).Height))
                };

                graphics.DrawString(companyName, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += companyNameRectangle.Size.Height + 1.0F;

                // ===============
                // Company Address
                // ===============
                String companyAddress = systemCurrent.Address;
                RectangleF companyAddressRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(170, ((int)graphics.MeasureString(companyAddress, fontArial8Regular, 170, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(companyAddress, fontArial8Regular, Brushes.Black, companyAddressRectangle, drawFormatCenter);
                y += companyAddressRectangle.Size.Height;
            }
            else
            {
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
                RectangleF companyAddressRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(companyAddress, fontArial8Regular, 245, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(companyAddress, fontArial8Regular, Brushes.Black, companyAddressRectangle, drawFormatCenter);
                y += companyAddressRectangle.Size.Height;
            }

            // ======================
            // Official Receipt Title
            // ======================
            String officialReceiptTitle = "R E L O A D";
            graphics.DrawString(officialReceiptTitle, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(officialReceiptTitle, fontArial8Bold).Height;

            String billDateText = "\n" + DateTime.Now.ToShortDateString();
            graphics.DrawString(billDateText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            String billTimeText = "\n" + DateTime.Now.ToString("hh:mm:ss:tt", CultureInfo.InvariantCulture);
            graphics.DrawString(billTimeText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(billTimeText, fontArial8Regular).Height;


            // ====================
            // Customer Load Detail
            // ====================

            var customer = from d in db.MstCustomers
                           where d.Id == customerId
                           select d;

            var customerLoad = from d in db.MstCustomerLoads
                               where d.CustomerId == mstCustomerLoadEntity.CustomerId
                               select d;

            // ========
            // 1st Line
            // ========
            Point firstLineFirstPoint = new Point(0, Convert.ToInt32(y) + 10);
            Point firstLineSecondPoint = new Point(500, Convert.ToInt32(y) + 10);
            graphics.DrawLine(blackPen, firstLineFirstPoint, firstLineSecondPoint);

            String customerLabel = "\nNAME";
            String amountLabel = "\nAMOUNT";
            graphics.DrawString(customerLabel, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(amountLabel, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(customerLabel, fontArial8Bold).Height + 2.0F;

            String customerName = "\n" + customer.FirstOrDefault().Customer.ToString(CultureInfo.InvariantCulture);
            graphics.DrawString(customerName, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            String customerLoadAmount = "\n" + customerLoad.FirstOrDefault().Amount.ToString("#,##0.00", CultureInfo.InvariantCulture);
            graphics.DrawString(customerLoadAmount, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(customerLoadAmount, fontArial8Bold).Height;

            // ========
            // 2nd Line
            // ========
            Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) + 10);
            Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) + 10);
            graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);

            // ==============================
            // Total Sales and Total Discount
            // ==============================

            String totalLoadLabel = "\nLoad Balance";
            String totalLoadAmount = "\n" + customer.FirstOrDefault().LoadAmount.ToString("#,##0.00");
            graphics.DrawString(totalLoadLabel, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalLoadAmount, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalLoadAmount, fontArial8Bold).Height;
        }
    }
}
