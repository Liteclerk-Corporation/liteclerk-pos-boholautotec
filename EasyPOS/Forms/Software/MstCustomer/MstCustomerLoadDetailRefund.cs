using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.MstCustomer
{
    public partial class MstCustomerLoadDetailRefund : Form
    {
        MstCustomerDetailForm mstCustomerDetailForm;
        Entities.MstCustomerLoadEntity mstCustomerLoadEntity;
        public MstCustomerLoadDetailRefund(MstCustomerDetailForm customerDetailForm, Entities.MstCustomerLoadEntity customerLoadEntity)
        {
            InitializeComponent();
            mstCustomerDetailForm = customerDetailForm;
            mstCustomerLoadEntity = customerLoadEntity;

            textBoxAmount.Text = "0.00";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult closeDialogResult = MessageBox.Show("Confirm refund?", "Liteclerk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (closeDialogResult == DialogResult.Yes)
            {
                if (Convert.ToDecimal(textBoxAmount.Text) > 0)
                {
                    if (mstCustomerLoadEntity.Id == 0)
                    {
                        Entities.MstCustomerLoadEntity newCustomerLoad = new Entities.MstCustomerLoadEntity()
                        {
                            Id = mstCustomerLoadEntity.Id,
                            CustomerId = mstCustomerLoadEntity.CustomerId,
                            CardNumber = mstCustomerDetailForm.mstCustomerEntity.CustomerCode,
                            LoadDate = DateTime.Today.ToShortDateString(),
                            Type = "Refund",
                            Amount = Convert.ToDecimal(textBoxAmount.Text) * -1,
                            Remarks = "Load Refund"
                        };

                        if (newCustomerLoad.Amount < 0)
                        {
                            Controllers.MstCustomerLoadController mstCustomerLoadController = new Controllers.MstCustomerLoadController();
                            String[] addCustomerLoad = mstCustomerLoadController.AddCustomerLoad(newCustomerLoad);

                            if (addCustomerLoad[1].Equals("0") == true)
                            {
                                MessageBox.Show(addCustomerLoad[0], "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                mstCustomerDetailForm.UpdateCustomerLoadListDataSource();
                                Close();

                                DialogResult tenderPrinterReadyDialogResult = MessageBox.Show("Is printer ready?", "Liteclerk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (tenderPrinterReadyDialogResult == DialogResult.Yes)
                                {
                                    new MstCustomerRefundReceiptForm(mstCustomerLoadEntity.CustomerId, newCustomerLoad);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Unable to process refund request!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Unable to process refund request!", "Liteclerk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
