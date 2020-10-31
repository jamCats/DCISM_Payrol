namespace HR_Admin
{
    partial class InventoryPanel
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bar_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sales_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderField = new System.Windows.Forms.ComboBox();
            this.rangeCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.countField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.product_name,
            this.product_description,
            this.product_qty,
            this.product_price,
            this.bar_code,
            this.category_id,
            this.sales_id});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(42, 242);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1150, 337);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 41;
            // 
            // product_name
            // 
            this.product_name.Text = "Product Name";
            this.product_name.Width = 105;
            // 
            // product_description
            // 
            this.product_description.Text = "Product Description";
            this.product_description.Width = 138;
            // 
            // product_qty
            // 
            this.product_qty.Text = "Product Qty";
            this.product_qty.Width = 90;
            // 
            // product_price
            // 
            this.product_price.Text = "Product Price";
            this.product_price.Width = 121;
            // 
            // bar_code
            // 
            this.bar_code.Text = "Bar code";
            this.bar_code.Width = 108;
            // 
            // category_id
            // 
            this.category_id.Text = "Category ID";
            this.category_id.Width = 129;
            // 
            // sales_id
            // 
            this.sales_id.Text = "Sales";
            this.sales_id.Width = 322;
            // 
            // orderField
            // 
            this.orderField.FormattingEnabled = true;
            this.orderField.Items.AddRange(new object[] {
            "All",
            "Ascending by sales",
            "Descending by sales"});
            this.orderField.Location = new System.Drawing.Point(42, 56);
            this.orderField.Name = "orderField";
            this.orderField.Size = new System.Drawing.Size(169, 24);
            this.orderField.TabIndex = 1;
            this.orderField.ValueMemberChanged += new System.EventHandler(this.orderField_ValueMemberChanged);
            this.orderField.TextChanged += new System.EventHandler(this.orderField_TextChanged);
            // 
            // rangeCheck
            // 
            this.rangeCheck.AutoSize = true;
            this.rangeCheck.Location = new System.Drawing.Point(253, 119);
            this.rangeCheck.Name = "rangeCheck";
            this.rangeCheck.Size = new System.Drawing.Size(119, 21);
            this.rangeCheck.TabIndex = 5;
            this.rangeCheck.Text = "Date Inclusion";
            this.rangeCheck.UseVisualStyleBackColor = true;
            this.rangeCheck.CheckedChanged += new System.EventHandler(this.rangeCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item Count";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(42, 176);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(100, 23);
            this.filterButton.TabIndex = 8;
            this.filterButton.Text = "Add Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filterButton_MouseClick);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(413, 119);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 22);
            this.startDate.TabIndex = 9;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(672, 119);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 22);
            this.endDate.TabIndex = 10;
            // 
            // countField
            // 
            this.countField.Location = new System.Drawing.Point(42, 127);
            this.countField.Name = "countField";
            this.countField.Size = new System.Drawing.Size(169, 22);
            this.countField.TabIndex = 11;
            this.countField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countField_KeyPress_1);
            // 
            // InventoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 591);
            this.Controls.Add(this.countField);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rangeCheck);
            this.Controls.Add(this.orderField);
            this.Controls.Add(this.listView1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "InventoryPanel";
            this.Text = "Inventory";
            this.PaddingChanged += new System.EventHandler(this.InventoryPanel_PaddingChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader product_name;
        private System.Windows.Forms.ColumnHeader product_description;
        private System.Windows.Forms.ColumnHeader product_qty;
        private System.Windows.Forms.ColumnHeader product_price;
        private System.Windows.Forms.ColumnHeader bar_code;
        private System.Windows.Forms.ColumnHeader category_id;
        private System.Windows.Forms.ComboBox orderField;
        private System.Windows.Forms.CheckBox rangeCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.ColumnHeader sales_id;
        private System.Windows.Forms.TextBox countField;
    }
}