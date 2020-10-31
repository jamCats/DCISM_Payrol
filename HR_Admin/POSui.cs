using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel;

namespace HR_Admin
{
    public partial class POSui : Form

    {
    List<Transucc1> trans = new List<Transucc1>();//customer's transaction
    List<Transucc1> copy = new List<Transucc1>();//copy of the entire inventory for real time searching
    globals data = new globals();   //total price, transaction ID, and cashier ID put here
        public POSui()
        {
            InitializeComponent();
            data.sum = 0;
            data.check = 0;
            int holder;
            DBConnect initial = new DBConnect();
            String query = "SELECT *,(product_qty*product_price)as sales FROM product GROUP BY product_name";
            String trans = "INSERT INTO transactionlog(transactionDate) VALUES(NOW()); SELECT transactionID,transactionDate FROM transactionlog WHERE transactionDate=NOW();";
            initial.getTransID(trans,out holder);//retrieves transID for foreign key assignment and deletion
            initial.getInv(copy,query);
            this.ActiveControl = IDfield;
            data.transID = holder;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            for (int i = copy.Count - 1; i >= 0; i--)
            {
                col.Add(copy[i].itemName);
            }
            itemNamefield.AutoCompleteCustomSource = col;
        }
        public POSui(int x)
        {
            //CONSTRUCTOR FOR HOLD
            InitializeComponent();
            data.sum = 0;
            data.check = x;
            int holder;
            DBConnect initial = new DBConnect();
            String query = "SELECT *,(product_qty*product_price)as sales FROM product GROUP BY product_name";
            String trans = "INSERT INTO transactionlog(transactionDate) VALUES(NOW()); SELECT transactionID,transactionDate FROM transactionlog WHERE transactionDate=NOW();";
            initial.getTransID(trans, out holder);//retrieves ID for foreign key assignment and deletion
            initial.getInv(copy, query);
            this.ActiveControl = IDfield;
            data.transID = holder;
            holdCust.Hide();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnect peepee = new DBConnect();
            Transucc1 local = new Transucc1();
            int check = Convert.ToInt32(qtyField.Value);
            String query;
            query = "SELECT*FROM product WHERE bar_code='" + IDfield.Text + "'";  //GETS BARCODE FROM DB AND STORES IN LOCAL CLASS
            peepee.getItem(local, query);
            String log = "INSERT INTO purchaselog(itemID,purchaseDate,qty,transactionID) VALUES("+local.ID+",curdate(),"+check+","+data.transID+")";
            if (local.qty-check>=0)
            {
                String purchase = IDfield.Text;
                int qty = (int)qtyField.Value;
                double price = local.price * qty;   //variable computes price times qty
                data.sum += price; //updates global price
                local.qty = check; //assigns the item holder qty to it's right value
                local.price = price; //assigns the item prices to it's right value
                peepee.transaction(this.trans, purchase, qty,local); //changes quantity then puts item in transaction global
                totalField.Text = data.sum.ToString();
                //reset fields
                IDfield.Clear();
                qtyField.Value = 1;
                IDlabel.Text = local.ID.ToString();
                itemLabel.Text = local.itemName.ToString();
                itemNamefield.Clear();
                int holder = local.barCode;
                int i;
                for (i = 0; i < copy.Count && holder != copy[i].barCode; i++) { }//finds item in inventory copy
                if (i < copy.Count)
                {
                    int x;
                    for (x = listView1.Items.Count - 1; x >= 0 && listView1.Items[x].SubItems[1].Text != copy[i].barCode.ToString(); x--) { }//finds item in list view
                    if (x >= 0)
                    {
                        incrementSubItem(x,local);//increments list view and purchase log when item already exists
                    }
                    else
                    {
                        updateList(local.itemName.ToString(), price, qty, local.barCode);    //FUNCTION ADDS TO LISTVIEW
                        peepee.insertLog(log);//inserts item into log
                    }
                }
            }
            else if (String.IsNullOrEmpty(IDfield.Text))
            {
                MessageBox.Show("Please enter barcode/name");
            }
            else
            {
                MessageBox.Show("Insufficient stocks");
            }

        }
        private void updateList(String x,Double y,int qty,int barCode)
        {
            //updates viewList content
            String itemName = x;
            String barcode = barCode.ToString();
            String poop = qty.ToString();
            String price = y.ToString();
            ListViewItem item = new ListViewItem(new String[] { itemName,barcode,poop, price });
            listView1.Items.Add(item);
        }


        private void holdCust_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void holdCust_Click(object sender, EventArgs e)
        {
        }

        private void holdCust_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkOutfield_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void POSui_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void invButton_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void IDfield_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button2_Click(sender,e);
            }
            if (e.KeyData == Keys.R)
            {
                button1_Click(sender, e);
            }
            if (e.KeyData == Keys.Up)
            {
                this.ActiveControl = qtyField;
                if (qtyField.Value + 1 <= 100)
                {
                    qtyField.Value++;
                }
            }
            if (e.KeyData == Keys.Down)
            {
                this.ActiveControl = qtyField;
                if (qtyField.Value-1>=1) 
                {
                    qtyField.Value--;
                }
            }
            if (e.KeyData == Keys.H&&data.check!=1)
            {
                holdCust_Click_1(sender, e);
            }
            if (e.KeyData == Keys.I)
            {
                invButton_Click(sender, e);
            }

            this.ActiveControl = IDfield;
            if (e.KeyData == Keys.N)
            {
                this.ActiveControl = itemNamefield;
            }

            if (e.KeyData == Keys.C)
            {
                checkOutfield_Click(sender, e);
            }
        }

        private void IDfield_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IDlabel_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDfield.Text))
            {
                itemLabel.Text = "XXXXXXXXXXX";
                IDlabel.Text = "XXXXXXXXXXX";
                priceLabel.Text = "0.00";
            }
            else
            {
                int holder = int.Parse(IDfield.Text);
                int i;
                for (i = 0; i < copy.Count && holder != copy[i].barCode; i++) { }
                if (i < copy.Count)
                {
                    itemLabel.Text = copy[i].itemName;
                    IDlabel.Text = copy[i].barCode.ToString();
                    priceLabel.Text = copy[i].price.ToString();
                }
                else
                {
                    itemLabel.Text = "ITEM NOT FOUND";
                }
            }
        }
        private void incrementSubItem(int indx, Transucc1 x)
        {
            DBConnect update = new DBConnect();
            int qty = int.Parse(listView1.Items[indx].SubItems[2].Text);
            String query = "UPDATE purchaselog SET qty=qty+'"+qty+"'WHERE itemID='"+x.ID+"' AND transactionID='"+data.transID+"'";
            double total = Double.Parse(listView1.Items[indx].SubItems[3].Text);
            qty += x.qty;
            total += x.price;
            listView1.Items[indx].SubItems[2].Text = qty.ToString();
            listView1.Items[indx].SubItems[3].Text = total.ToString();
            update.insertLog(query);//increments purchase log quantity


        }

        private void POSui_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void POSui_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            
        }

        private void POSui_Load(object sender, EventArgs e)
        {
           
        }

        private void checkOutfield_Click(object sender, EventArgs e)
        {
            DBConnect transaction = new DBConnect();
            if (data.check != 0)
            {
                data.check = 0;
            }
            if (listView1.Items.Count>0)
            {
                String totalQuery = "UPDATE transactionlog SET total="+data.sum+"WHERE transactionID="+data.transID+"";
                double total = Double.Parse(totalField.Text);
                checkoutscreen last = new checkoutscreen(total);
                last.Show();
                transaction.insertLog(totalQuery);// repurposed code
                last.FormClosing += (obj, args) => { this.Close(); };
            }
            else
            {
                //deleting transaction when it has no items
                String query = "UPDATE transactionlog SET remark='RETURNED' WHERE transactionID="+data.transID+"";
                transaction.insertLog(query);//repurposed code
                this.Close();
            }
        }

        private void holdCust_Click_1(object sender, EventArgs e)
        {
            if (data.check == 0)
            {
                int i = 1;
                POSui hold = new POSui(i);
                data.check = 1;
                hold.Show();
                this.Hide();
                hold.FormClosing += (obj, args) => {data.check=0; this.Show(); };
            }
        }

        private void invButton_Click(object sender, EventArgs e)
        {
            InventoryPanel x = new InventoryPanel();
            x.Show();
        }

        private void IDfield_Leave(object sender, EventArgs e)
        {
            
        }

        private void itemNamefield_Leave(object sender, EventArgs e)
        {
            
        }

        private void itemNamefield_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(itemNamefield.Text))
            {
                itemLabel.Text = "XXXXXXXXXXX";
                IDlabel.Text = "XXXXXXXXXXX";
                priceLabel.Text = "0.00";
                IDfield.Clear();
            }
            else
            {
                String holder =itemNamefield.Text.ToString();
                int i;
                for (i = 0; i < copy.Count && !holder.Equals(copy[i].itemName); i++) { }
                if (i < copy.Count)
                {
                    IDfield.Text = copy[i].barCode.ToString();
                    IDlabel.Text = copy[i].ID.ToString();
                    priceLabel.Text = copy[i].price.ToString();
                    itemLabel.Text = copy[i].itemName;
                }
                else
                {
                    IDfield.Clear();
                    itemLabel.Text = "ITEM NOT FOUND";
                }
            }
        }

        private void itemNamefield_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                this.ActiveControl = qtyField;
                if (qtyField.Value + 1 <= 100)
                {
                    qtyField.Value++;
                }
            }
            if (e.KeyData == Keys.Down)
            {
                this.ActiveControl = qtyField;
                if (qtyField.Value - 1 >= 1)
                {
                    qtyField.Value--;
                }
            }
            if (e.KeyData == Keys.Left)
            {
                this.ActiveControl = IDfield;
            }
            if (e.KeyData == Keys.Enter)
            {
                button2_Click(sender, e);
                this.ActiveControl = IDfield;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect edit = new DBConnect();
            int barcode;
            if (!String.IsNullOrEmpty(IDfield.Text)){
                barcode = int.Parse(IDfield.Text);
                int qty = (int)qtyField.Value;
                int x;
                int i;
                for (i = 0; i < copy.Count && barcode != copy[i].barCode; i++) { }//finds item in inventory copy
                if (i < copy.Count)
                {
                    
                    for (x = listView1.Items.Count - 1; x >= 0 && listView1.Items[x].SubItems[1].Text != barcode.ToString(); x--) { }//finds item in list view
                    if (x >= 0)
                    {
                        int qtyDec = int.Parse(listView1.Items[x].SubItems[2].Text);//gets qty purchased
                        double priceDec = Double.Parse(listView1.Items[x].SubItems[3].Text);//gets total price of purchased item
                        String query = "INSERT INTO purchaselog(itemID, purchaseDate, qty, transactionID,remark) VALUES(" + copy[i].ID + ", curdate(), " + qty + ", " + data.transID + ",'RETURNED')";
                        String query2= "UPDATE product SET product_qty = product_qty + '" + qty + "'WHERE bar_code = '" + barcode + "'";
                        if (qtyDec - qty > 0)
                        {

                            qtyDec -= qty;
                            priceDec -= (copy[i].price * qty);
                            listView1.Items[x].SubItems[2].Text = qtyDec.ToString();
                            listView1.Items[x].SubItems[3].Text = priceDec.ToString();
                            data.sum -=(double)(copy[i].price * qty);
                            totalField.Text = data.sum.ToString();
                            edit.insertLog(query);
                            edit.insertLog(query2);
                            IDfield.Clear();
                            qtyField.Value = 1;
                            itemNamefield.Clear();

                        }
                        else if (qtyDec - qty == 0)
                        {
                            listView1.Items[x].Remove();
                            edit.insertLog(query);
                            data.sum -= (copy[i].price * qty);
                            totalField.Text = data.sum.ToString();
                            edit.insertLog(query);
                            edit.insertLog(query2);
                            IDfield.Clear();
                            qtyField.Value = 1;
                            itemNamefield.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Amount");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item not purchased");
                    }
                }
                else
                {
                    MessageBox.Show("Item not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter barcode/name");
            }
        }
    }
}
