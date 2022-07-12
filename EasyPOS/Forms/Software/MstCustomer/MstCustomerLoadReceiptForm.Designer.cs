
namespace EasyPOS.Forms.Software.MstCustomer
{
    partial class MstCustomerLoadReceiptForm
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
            this.printDocumentLoadReceipt = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // printDocumentLoadReceipt
            // 
            this.printDocumentLoadReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentLoadReceipt_PrintPage);
            // 
            // MstCustomerLoadReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 53);
            this.ControlBox = false;
            this.Name = "MstCustomerLoadReceiptForm";
            this.Text = "Customer Load Receipt Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocumentLoadReceipt;
    }
}