using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation
{
    public partial class frmHotel : Form
    {
        public frmHotel()
        {
            InitializeComponent();
        }

        private void frmHotel_Load(object sender, EventArgs e)
        {
            groupAccomodation.Enabled = false;
            groupDiscount.Enabled = false;
            btnCalculate.Enabled = false;
            txtPayment.Enabled = false;
            txtDiscount.Enabled = false;
            txtAmount.Enabled = false;
            txtEnterPayment.Enabled = false;

            txtName.Focus();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)) { 
                groupAccomodation.Enabled = false;
            } else
            {
                groupAccomodation.Enabled = true;
            } 
        }

        private void txtPaymentt_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtEnterPayment.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal enteredPayment))
            {
                decimal amountDue = decimal.Parse(txtAmount.Text, NumberStyles.Currency);
                if (enteredPayment >= amountDue)
                {
                    btnCalculate.Enabled = true;
                }
                else
                {
                    btnCalculate.Enabled = true;
                }
                
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void UpdateDiscountAndAmountDue()
        {
            if (decimal.TryParse(txtPayment.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalPayment))
            {
                decimal totalDiscount = 0;
                decimal amountDue = totalPayment;

                if (radioEmployee.Checked)
                {
                    decimal discountPercentage = 0.05m; // Employee discount is 5%
                    totalDiscount = totalPayment * discountPercentage;
                }
                else if (radioPWD.Checked)
                {
                    decimal discountPercentage = 0.15m; // PWD discount is 15%
                    totalDiscount = totalPayment * discountPercentage;
                }
                else if (radioSenior.Checked)
                {
                    decimal discountPercentage = 0.20m; // Senior discount is 20%
                    totalDiscount = totalPayment * discountPercentage;
                }

                txtDiscount.Text = totalDiscount.ToString("C");
                amountDue = totalPayment - totalDiscount;
                txtAmount.Text = amountDue.ToString("C");
            }
            else
            {
                // Handle invalid total payment value
                MessageBox.Show("Invalid total payment value.");
            }
        }

        private string GetSelectedAccommodation()
        {
            if (radioDeluxe.Checked)
            {
                return "Deluxe Suite";
            }
            else if (radioQueen.Checked)
            {
                return "Queen Suite";
            }
            else if (radioExecutive.Checked)
            {
                return "Executive Suite";
            }
            else if (radioPresidential.Checked)
            {
                return "Presidential Suite";
            }
            else
            {
                return "No Room Selected";
            }
        }

        private void radioDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            int deluxe = 400;
            if (radioDeluxe.Checked)
            {
                txtPayment.Text = deluxe.ToString("C");
                groupDiscount.Enabled = true;
                UpdateDiscountAndAmountDue();
            }
            else
            {
                groupDiscount.Enabled = false;
            }
        }

        private void radioQueen_CheckedChanged(object sender, EventArgs e)
        {
            int queen = 550;
            if(radioQueen.Checked)
            {
                txtPayment.Text = queen.ToString("C");
                groupDiscount.Enabled = true;
                UpdateDiscountAndAmountDue();
            }
            else
            {
                groupDiscount.Enabled = false;
            }
        }

        private void radioExecutive_CheckedChanged(object sender, EventArgs e)
        {
            int executive = 650;
            if (radioExecutive.Checked)
            {
                txtPayment.Text = executive.ToString("C");
                groupDiscount.Enabled = true;
                UpdateDiscountAndAmountDue();
            }
            else
            {
                groupDiscount.Enabled = false;
            }
        }

        private void radioPresidential_CheckedChanged(object sender, EventArgs e)
        {
            int presidential = 750;
            if (radioPresidential.Checked)
            {
                txtPayment.Text = presidential.ToString("C");
                groupDiscount.Enabled = true;
                UpdateDiscountAndAmountDue();
            }
            else
            {
                groupDiscount.Enabled = false;
            }
        }

        private string GetSelectedDiscount()
        {
            if (radioRegular.Checked)
            {
                return "Regular";
            }
            else if (radioEmployee.Checked)
            {
                return "Employee";
            }
            else if (radioPWD.Checked)
            {
                return "PWD";
            }
            else if (radioSenior.Checked)
            {
                return "Senior Citizen";
            }
            else
            {
                return "No Discount Selected";
            }
        }

        private void radioRegular_CheckedChanged(object sender, EventArgs e)
        {
            int totalPayment = int.Parse(txtPayment.Text, NumberStyles.Currency);
            int totalDiscount = 0;
            txtDiscount.Text = totalDiscount.ToString("C");

            decimal amountDue = totalPayment - totalDiscount;
            txtAmount.Text = amountDue.ToString("C");
            txtEnterPayment.Enabled = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            int totalPayment = int.Parse(txtPayment.Text, NumberStyles.Currency);
            decimal discountPercentage = 0.05m;
            decimal totalDiscount = totalPayment * discountPercentage;
            txtDiscount.Text = totalDiscount.ToString("C");

            decimal amountDue = totalPayment - totalDiscount;
            txtAmount.Text = amountDue.ToString("C");
            txtEnterPayment.Enabled = true;
        }

        private void radioPWD_CheckedChanged(object sender, EventArgs e)
        {
            int totalPayment = int.Parse(txtPayment.Text, NumberStyles.Currency);
            decimal discountPercentage = 0.15m;
            decimal totalDiscount = totalPayment * discountPercentage;
            txtDiscount.Text = totalDiscount.ToString("C");

            decimal amountDue = totalPayment - totalDiscount;
            txtAmount.Text = amountDue.ToString("C");
            txtEnterPayment.Enabled = true;
        }

        private void radioSenior_CheckedChanged(object sender, EventArgs e)
        {
            int totalPayment = int.Parse(txtPayment.Text, NumberStyles.Currency);
            decimal discountPercentage = 0.20m;
            decimal totalDiscount = totalPayment * discountPercentage;
            txtDiscount.Text = totalDiscount.ToString("C");

            decimal amountDue = totalPayment - totalDiscount;
            txtAmount.Text = amountDue.ToString("C");
            txtEnterPayment.Enabled = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtEnterPayment.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal enteredPayment))
            {
                decimal amountDue = decimal.Parse(txtAmount.Text, NumberStyles.Currency);
                
                if (string.IsNullOrEmpty(txtName.Text)|| string.IsNullOrEmpty(txtContact.Text))
                {
                    MessageBox.Show("Please complete the personal information");
                }
                else if (enteredPayment >= amountDue)
                {
                    decimal change = enteredPayment - amountDue;

                    MessageBox.Show("Payment Successful!!! \n"
                        + $"__________________________________\n"
                        + $"Name                        {txtName.Text}\n"
                        + $"Contact                     {txtContact.Text}\n"
                        + $"Room                        {GetSelectedAccommodation()}\n"
                        + $"Discount                    {GetSelectedDiscount()}\n"
                        + $"Total Amount            {txtPayment.Text}\n" 
                        + $"Total Discount          {txtDiscount.Text}\n"
                        + $"Amount Due              {txtAmount.Text}\n"
                        + $"__________________________________\n"
                        + $"Payment                 {txtEnterPayment.Text:C}\n"
                        + $"Change                  {change:C}\n"
                        + $"__________________________________\n"
                        + $"Thank you for booking with us!");
                    txtName.Clear();
                    txtContact.Clear();
                    radioDeluxe.Checked = false;
                    radioQueen.Checked = false;
                    radioExecutive.Checked = false;
                    radioPresidential.Checked = false;
                    txtPayment.Clear();
                    txtDiscount.Clear();
                    txtAmount.Clear();
                    txtEnterPayment.Clear();

                }
                else
                {
                    txtEnterPayment.Clear();
                    MessageBox.Show("Insufficient Money", "Payment");
                }
            }
            else
            {
                // Handle invalid entered payment value
                MessageBox.Show("Invalid Payment Amount", "Payment");
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtEnterPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
    }
}
