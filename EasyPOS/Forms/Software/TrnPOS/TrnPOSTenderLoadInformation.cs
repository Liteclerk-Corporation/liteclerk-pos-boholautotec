using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnPOSTenderLoadInformation : Form
    {
        public TrnPOSTenderForm trnPOSTenderForm;
        public DataGridView mstDataGridViewTenderPayType;

        public TrnPOSTenderLoadInformation(TrnPOSTenderForm POSTenderForm, DataGridView dataGridViewTenderPayType, Decimal totalSalesAmount)
        {
            InitializeComponent();

            trnPOSTenderForm = POSTenderForm;
            mstDataGridViewTenderPayType = dataGridViewTenderPayType;

            textBoxAmount.Text = totalSalesAmount.ToString("#,##0.00");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            String customerCode = textBoxCardNumber.Text;
            Decimal amount = Convert.ToDecimal(textBoxAmount.Text);

            Controllers.MstCustomerController mstCustomerController = new Controllers.MstCustomerController();
            if (mstCustomerController.DetailCustomerPerCustomerCode(customerCode) != null)
            {

                Decimal loadAmount = mstCustomerController.DetailCustomerPerCustomerCode(customerCode).LoadAmount;
                if (loadAmount >= amount)
                {
                    LoadPay();
                    Close();
                }
                else
                {
                    MessageBox.Show("Insufficient Balance! Please Reload.", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid card number!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadPay()
        {
            try
            {
                Decimal currentAmount = Convert.ToDecimal(textBoxAmount.Text);
                if (currentAmount >= 0)
                {
                    if (mstDataGridViewTenderPayType.Rows.Contains(mstDataGridViewTenderPayType.CurrentRow))
                    {
                        Int32 id = Convert.ToInt32(mstDataGridViewTenderPayType.CurrentRow.Cells[0].Value);
                        String payTypeCode = mstDataGridViewTenderPayType.CurrentRow.Cells[1].Value.ToString();
                        String payType = mstDataGridViewTenderPayType.CurrentRow.Cells[2].Value.ToString();
                        Decimal amount = Convert.ToDecimal(textBoxAmount.Text);
                        String otherInformation = "Load Payment " + DateTime.Now.ToLongDateString();
                        String LoadNumber = textBoxCardNumber.Text;

                        mstDataGridViewTenderPayType.CurrentRow.Cells[0].Value = id;
                        mstDataGridViewTenderPayType.CurrentRow.Cells[1].Value = payTypeCode;
                        mstDataGridViewTenderPayType.CurrentRow.Cells[2].Value = payType;
                        mstDataGridViewTenderPayType.CurrentRow.Cells[4].Value = amount.ToString("#,##0.00");
                        mstDataGridViewTenderPayType.CurrentRow.Cells[5].Value = otherInformation;
                        mstDataGridViewTenderPayType.CurrentRow.Cells[6].Value = null;
                        mstDataGridViewTenderPayType.CurrentRow.Cells[7].Value = "";
                        mstDataGridViewTenderPayType.CurrentRow.Cells[8].Value = "NA";
                        mstDataGridViewTenderPayType.CurrentRow.Cells[9].Value = null;
                        mstDataGridViewTenderPayType.CurrentRow.Cells[10].Value = "NA";
                        mstDataGridViewTenderPayType.CurrentRow.Cells[11].Value = "NA";
                        mstDataGridViewTenderPayType.CurrentRow.Cells[12].Value = "NA";
                        mstDataGridViewTenderPayType.CurrentRow.Cells[13].Value = "NA";
                        mstDataGridViewTenderPayType.CurrentRow.Cells[14].Value = "NA";
                        mstDataGridViewTenderPayType.CurrentRow.Cells[15].Value = "NA";
                        mstDataGridViewTenderPayType.CurrentRow.Cells[16].Value = "NA";
                        mstDataGridViewTenderPayType.CurrentRow.Cells[17].Value = "NA";
                        mstDataGridViewTenderPayType.CurrentRow.Cells[18].Value = LoadNumber;
                    }

                    mstDataGridViewTenderPayType.Refresh();
                    Close();

                    mstDataGridViewTenderPayType.Focus();
                    mstDataGridViewTenderPayType.CurrentRow.Cells[2].Selected = true;

                    trnPOSTenderForm.ComputeAmount();
                    trnPOSTenderForm.CreateCollection(null);

                    String _customerCode = textBoxCardNumber.Text;
                    Decimal _amount = Convert.ToDecimal(textBoxAmount.Text);
                    Controllers.MstCustomerController mstCustomerController = new Controllers.MstCustomerController();
                    Entities.MstCustomerLoadEntity newCustomerLoad = new Entities.MstCustomerLoadEntity()
                    {
                        Id = 0,
                        CustomerId = mstCustomerController.DetailCustomerPerCustomerCode(_customerCode).Id,
                        CardNumber = _customerCode,
                        LoadDate = DateTime.Today.ToShortDateString(),
                        Type = "Sales",
                        Amount = _amount * -1,
                        Remarks = "Sales Number: " + trnPOSTenderForm.trnSalesEntity.SalesNumber + ",\n Sales Date: " + trnPOSTenderForm.trnSalesEntity.SalesDate
                    };

                    Controllers.MstCustomerLoadController mstCustomerLoadController = new Controllers.MstCustomerLoadController();
                    String[] addCustomerLoad = mstCustomerLoadController.AddCustomerLoad(newCustomerLoad);
                }
                else
                {
                    MessageBox.Show("Cannot pay if amount is zero.", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAmount_Leave(object sender, EventArgs e)
        {
            textBoxAmount.Text = Convert.ToDecimal(textBoxAmount.Text).ToString("#,##0.00");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    {
                        if (buttonOK.Enabled == true)
                        {
                            buttonOK.PerformClick();
                        }

                        break;
                    }
                case Keys.Escape:
                    {
                        Close();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
