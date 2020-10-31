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
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = checkOutfield;
            checkOutfield.Select();
            pdfTest x = new pdfTest();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            
        }

        private void startForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                checkOutfield.PerformClick();
            }
        }

        private void startForm_Load(object sender, EventArgs e)
        {
        }

        private void checkOutfield_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                checkOutfield_Click(sender,e);
            }
        }

        private void checkOutfield_Click(object sender, EventArgs e)
        {
            POSui peepee = new POSui();
            peepee.Show();
            this.Hide();
            peepee.FormClosing += (obj, args) => { this.Show(); };

        }
    }
}
