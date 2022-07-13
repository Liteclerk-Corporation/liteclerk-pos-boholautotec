
namespace EasyPOS.Forms.Software.MstCustomer
{
    partial class MstCustomerWithdrawalReceiptForm
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
            this.printDocumentWithdrawalReceipt = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // printDocumentWithdrawalReceipt
            // 
            this.printDocumentWithdrawalReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentWithdrawalReceipt_PrintPage);
            // 
            // MstCustomerWithdrawalReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 53);
            this.ControlBox = false;
            this.Name = "MstCustomerWithdrawalReceiptForm";
            this.Text = "Customer Withdrawal Receipt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocumentWithdrawalReceipt;
    }
}