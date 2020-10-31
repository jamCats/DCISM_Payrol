using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Admin
{
    public partial class checkoutscreen : Form
    {
        public checkoutscreen()
        {
            InitializeComponent();
        }
        public checkoutscreen(double x)
        {
            InitializeComponent();
            totalOutput.Text = x.ToString();
            this.ActiveControl = changeField;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void changeField_Enter(object sender, EventArgs e)
        {
            
        }

        private void changeField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                checkOut_Click(sender, e);
            }
        }

        private void changeField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                double total = Double.Parse(totalOutput.Text);
                double change;
                if (!String.IsNullOrEmpty(changeField.Text))
                {
                    change = Double.Parse(changeField.Text);
                    if (change < total)
                    {
                        MessageBox.Show("Invalid Amount");
                    }
                    else
                    {
                        change -= (double)total;
                        changeOutput.Text = change.ToString();
                        this.ActiveControl = checkOut;
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Cash");
                }
            }
        }
    }
}
