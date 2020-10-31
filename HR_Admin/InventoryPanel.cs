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
    public partial class InventoryPanel : Form
    {
        public InventoryPanel()
        {
            InitializeComponent();
            fetch();
            orderField.SelectedItem = "All";
            startDate.Hide();
            endDate.Hide();
            countField.Hide();
            rangeCheck.Hide();
        }
        public void fetch()
        {
            String query1= "SELECT p.*,SUM(L.qty)as sales FROM product p,purchaselog L WHERE p.id=l.itemID  GROUP BY p.product_name";//default
            DBConnect local = new DBConnect();
            List<Transucc1> x = new List<Transucc1>();
            local.getInv(x,query1);
            for (int i = 0; i < x.Count; i++)
            {
                ListViewItem item = new ListViewItem(new String[] { x[i].ID.ToString(),x[i].itemName.ToString(),x[i].prodDesc.ToString(),
                x[i].qty.ToString(),x[i].price.ToString(),x[i].category.ToString(),x[i].barCode.ToString(),x[i].sales.ToString()});
                listView1.Items.Add(item);
                if (x[i].qty < 50)
                {
                    item.ForeColor = Color.Red;
                }

            }
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void countField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void filterButton_MouseClick(object sender, MouseEventArgs e)
        {
            listView1.Items.Clear();  
            DBConnect local = new DBConnect();
            List<Transucc1> x = new List<Transucc1>();
            if (orderField.Text == "Ascending by sales")
            {
                if (!String.IsNullOrEmpty(countField.Text) && rangeCheck.Checked){ // has count and  has date
                    int count = int.Parse(countField.Text);
                    String query6 = "SELECT p.*,SUM(L.qty)as sales FROM product p,purchaseLog L WHERE L.purchaseDate BETWEEN DATE'"+ startDate.Value.Date.ToString("yyyy-MM-dd") + "' AND DATE'"+endDate.Value.Date.ToString("yyyy-MM-dd") +"' AND  p.id=l.itemID GROUP BY p.product_name ORDER BY sales ASC LIMIT " + " " + " " + count + "";//ascendnig with count and date
                    local.getInv(x, query6);
                }
                else if(String.IsNullOrEmpty(countField.Text) && rangeCheck.Checked)// no count and has date
                {
                    String query8 = "SELECT p.*,SUM(L.qty)as sales FROM product p,purchaseLog L WHERE L.purchaseDate BETWEEN DATE'" + startDate.Value.Date.ToString("yyyy-MM-dd") + "' AND DATE'" + endDate.Value.Date.ToString("yyyy-MM-dd") + "' AND  p.id=l.itemID GROUP BY p.product_name ORDER BY sales ASC ";//ASCENDING WITH DATE AND NO COUNT
                    local.getInv(x, query8);
                }
                else if(!String.IsNullOrEmpty(countField.Text) && !rangeCheck.Checked)//has count and no date
                {
                    int count = int.Parse(countField.Text);
                    String query4 = "SELECT p.*,SUM(L.qty)as sales FROM product p,purchaseLog L WHERE p.id=l.itemID GROUP BY p.product_name  ORDER BY sales ASC LIMIT " + " " + " " +count+ "";// ascending with count no date
                    local.getInv(x, query4);
                }
                else// no count and no date
                {
                    String query2 = "SELECT p.*,SUM(L.qty)as sales FROM product p,purchaseLog L WHERE p.id=l.itemID GROUP BY p.product_name  ORDER BY sales ASC";//NO COUNT AND NO DATE
                    local.getInv(x, query2);
                }
            }
            else if(orderField.Text=="Descending by sales")
            {
                if (!String.IsNullOrEmpty(countField.Text) && rangeCheck.Checked)
                { // count and date
                    int count = int.Parse(countField.Text);
                    String query7 = "SELECT p.*,SUM(L.qty)as sales FROM product p,purchaseLog L WHERE L.purchaseDate BETWEEN DATE'" + startDate.Value.Date.ToString("yyyy-MM-dd") + "' AND DATE'" + endDate.Value.Date.ToString("yyyy-MM-dd") + "' AND  p.id=l.itemID GROUP BY p.product_name ORDER BY sales DESC LIMIT " + " " + " " + count + "";//descendnig with count and date
                    local.getInv(x, query7);
                }
                else if (String.IsNullOrEmpty(countField.Text) && rangeCheck.Checked)// no count and date
                {
                    String query9 = "SELECT p.*,SUM(L.qty)as sales FROM product p,purchaseLog L WHERE L.purchaseDate BETWEEN DATE'" + startDate.Value.Date.ToString("yyyy-MM-dd") + "' AND DATE'" + endDate.Value.Date.ToString("yyyy-MM-dd") + "' AND  p.id=l.itemID GROUP BY p.product_name ORDER BY sales DESC ";//DESCENDNIG WITH DATE AND NO COUNT
                    local.getInv(x, query9);
                }
                else if (!String.IsNullOrEmpty(countField.Text) && !rangeCheck.Checked)//count and no date
                {
                    int count = int.Parse(countField.Text);
                    String query5 = "SELECT p.*,SUM(L.qty)as sales FROM product p,purchaseLog L WHERE p.id=l.itemID GROUP BY p.product_name  ORDER BY sales DESC LIMIT "+" "+" "+count+"";//descending with count no date
                    local.getInv(x, query5);
                }
                else// no count and no date
                {
                    String query3 = "SELECT p.*,SUM(L.qty)as sales FROM product p,purchaseLog L WHERE p.id=l.itemID GROUP BY p.product_name  ORDER BY sales DESC"; //NO COUNT AND NO DATE
                    local.getInv(x, query3);
                }
            }
            else
            {
                String query1 = "SELECT p.*,SUM(L.qty)as sales FROM product p,purchaseLog L WHERE p.id=l.itemID  GROUP BY p.product_name";//default
                local.getInv(x, query1);
            }
            for (int i = 0; i < x.Count; i++)
            {
                ListViewItem item = new ListViewItem(new String[] { x[i].ID.ToString(),x[i].itemName.ToString(),x[i].prodDesc.ToString(),
                x[i].qty.ToString(),x[i].price.ToString(),x[i].category.ToString(),x[i].barCode.ToString(),x[i].sales.ToString(),x[i].sales.ToString()});
                listView1.Items.Add(item);
                if (x[i].qty < 50)
                {
                    item.ForeColor = Color.Red;
                }

            }
        }

        private void rangeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rangeCheck.Checked)
            {
                startDate.Show();
                endDate.Show();
            }
            else
            {
                startDate.Hide();
                endDate.Hide();
            }
        }

        private void orderField_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void orderField_TextChanged(object sender, EventArgs e)
        {
            if (!orderField.SelectedItem.Equals("All"))
            {
                rangeCheck.Show();
                countField.Show();
                label1.Show();       
            }
            else
            {
                countField.Clear();
                countField.Hide();
                label1.Hide();
                rangeCheck.Hide();
                startDate.Hide();
                endDate.Hide();
                rangeCheck.Checked = false;
            }
        }

        private void countField_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void InventoryPanel_PaddingChanged(object sender, EventArgs e)
        {

        }
    }
}
