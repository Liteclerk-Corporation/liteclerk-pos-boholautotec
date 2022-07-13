
namespace EasyPOS.Forms.Software.MstCustomer
{
    partial class MstCustomerRefundReceiptForm
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
            this.printDocumentRefundReceipt = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // printDocumentRefundReceipt
            // 
            this.printDocumentRefundReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentRefundReceipt_PrintPage);
            // 
            // MstCustomerRefundReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 53);
            this.ControlBox = false;
            this.Name = "MstCustomerRefundReceiptForm";
            this.Text = "Customer Refund Receipt Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocumentRefundReceipt;
    }
}