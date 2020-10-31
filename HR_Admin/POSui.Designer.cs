namespace HR_Admin
{
    partial class POSui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSui));
            this.listView1 = new System.Windows.Forms.ListView();
            this.itemCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.barcodeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDfield = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qtyField = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkOutfield = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.holdCust = new System.Windows.Forms.Button();
            this.invButton = new System.Windows.Forms.Button();
            this.itemLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.totalField = new System.Windows.Forms.Label();
            this.itemNamefield = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qtyField)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemCol,
            this.barcodeCol,
            this.qtyCol,
            this.priceCol});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(107, 7);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeftLayout = true;
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(512, 722);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // itemCol
            // 
            this.itemCol.Text = "Item";
            this.itemCol.Width = 200;
            // 
            // barcodeCol
            // 
            this.barcodeCol.Text = "Barcode";
            this.barcodeCol.Width = 65;
            // 
            // qtyCol
            // 
            this.qtyCol.Text = "Qty";
            this.qtyCol.Width = 50;
            // 
            // priceCol
            // 
            this.priceCol.Text = "Total";
            this.priceCol.Width = 119;
            // 
            // IDfield
            // 
            this.IDfield.Location = new System.Drawing.Point(635, 295);
            this.IDfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDfield.Name = "IDfield";
            this.IDfield.Size = new System.Drawing.Size(176, 22);
            this.IDfield.TabIndex = 1;
            this.IDfield.TextChanged += new System.EventHandler(this.IDlabel_TextChanged);
            this.IDfield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IDfield_KeyDown);
            this.IDfield.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDfield_KeyPress);
            this.IDfield.Leave += new System.EventHandler(this.IDfield_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode";
            // 
            // qtyField
            // 
            this.qtyField.Location = new System.Drawing.Point(923, 326);
            this.qtyField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qtyField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyField.Name = "qtyField";
            this.qtyField.Size = new System.Drawing.Size(56, 22);
            this.qtyField.TabIndex = 3;
            this.qtyField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyField.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(920, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qty";
            // 
            // checkOutfield
            // 
            this.checkOutfield.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkOutfield.BackgroundImage")));
            this.checkOutfield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkOutfield.Location = new System.Drawing.Point(935, 421);
            this.checkOutfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkOutfield.Name = "checkOutfield";
            this.checkOutfield.Size = new System.Drawing.Size(81, 75);
            this.checkOutfield.TabIndex = 5;
            this.checkOutfield.UseVisualStyleBackColor = true;
            this.checkOutfield.Click += new System.EventHandler(this.checkOutfield_Click);
            this.checkOutfield.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkOutfield_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1011, 340);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // holdCust
            // 
            this.holdCust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("holdCust.BackgroundImage")));
            this.holdCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.holdCust.Location = new System.Drawing.Point(12, 313);
            this.holdCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.holdCust.Name = "holdCust";
            this.holdCust.Size = new System.Drawing.Size(68, 66);
            this.holdCust.TabIndex = 13;
            this.holdCust.UseVisualStyleBackColor = true;
            this.holdCust.Click += new System.EventHandler(this.holdCust_Click_1);
            this.holdCust.MouseClick += new System.Windows.Forms.MouseEventHandler(this.holdCust_MouseClick);
            // 
            // invButton
            // 
            this.invButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invButton.BackgroundImage")));
            this.invButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.invButton.Location = new System.Drawing.Point(12, 122);
            this.invButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invButton.Name = "invButton";
            this.invButton.Size = new System.Drawing.Size(71, 71);
            this.invButton.TabIndex = 14;
            this.invButton.UseVisualStyleBackColor = true;
            this.invButton.Click += new System.EventHandler(this.invButton_Click);
            this.invButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.invButton_MouseClick);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.ForeColor = System.Drawing.Color.White;
            this.itemLabel.Location = new System.Drawing.Point(627, 22);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(317, 46);
            this.itemLabel.TabIndex = 7;
            this.itemLabel.Text = "XXXXXXXXXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Barcode";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(629, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(632, 149);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(125, 17);
            this.IDlabel.TabIndex = 10;
            this.IDlabel.Text = "XXXXXXXXXXXXX";
            this.IDlabel.TextChanged += new System.EventHandler(this.IDlabel_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(632, 209);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 17);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "0.00";
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.invButton);
            this.panel1.Controls.Add(this.holdCust);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 551);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 758);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 55);
            this.label5.TabIndex = 16;
            this.label5.Text = "TOTAL";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // totalField
            // 
            this.totalField.AutoSize = true;
            this.totalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalField.ForeColor = System.Drawing.Color.ForestGreen;
            this.totalField.Location = new System.Drawing.Point(300, 758);
            this.totalField.Name = "totalField";
            this.totalField.Size = new System.Drawing.Size(118, 55);
            this.totalField.TabIndex = 17;
            this.totalField.Text = "0.00";
            // 
            // itemNamefield
            // 
            this.itemNamefield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.itemNamefield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.itemNamefield.Location = new System.Drawing.Point(636, 352);
            this.itemNamefield.Name = "itemNamefield";
            this.itemNamefield.Size = new System.Drawing.Size(175, 22);
            this.itemNamefield.TabIndex = 18;
            this.itemNamefield.TextChanged += new System.EventHandler(this.itemNamefield_TextChanged);
            this.itemNamefield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemNamefield_KeyDown);
            this.itemNamefield.Leave += new System.EventHandler(this.itemNamefield_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Item Name";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(1011, 307);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 20;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // POSui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1416, 846);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemNamefield);
            this.Controls.Add(this.totalField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.checkOutfield);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qtyField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDfield);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1061, 820);
            this.Name = "POSui";
            this.Text = "POSui";
            this.Load += new System.EventHandler(this.POSui_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.POSui_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.POSui_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.POSui_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.qtyField)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader itemCol;
        private System.Windows.Forms.ColumnHeader qtyCol;
        private System.Windows.Forms.ColumnHeader priceCol;
        private System.Windows.Forms.TextBox IDfield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown qtyField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkOutfield;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button holdCust;
        private System.Windows.Forms.Button invButton;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalField;
        private System.Windows.Forms.TextBox itemNamefield;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader barcodeCol;
        private System.Windows.Forms.Button returnButton;
    }
}