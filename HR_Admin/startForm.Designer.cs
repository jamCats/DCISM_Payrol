namespace HR_Admin
{
    partial class startForm
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
            this.checkOutfield = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkOutfield
            // 
            this.checkOutfield.BackColor = System.Drawing.Color.Transparent;
            this.checkOutfield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkOutfield.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkOutfield.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkOutfield.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.checkOutfield.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutfield.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutfield.Location = new System.Drawing.Point(194, 138);
            this.checkOutfield.Name = "checkOutfield";
            this.checkOutfield.Size = new System.Drawing.Size(236, 57);
            this.checkOutfield.TabIndex = 0;
            this.checkOutfield.Text = "Start Transaction";
            this.checkOutfield.UseVisualStyleBackColor = false;
            this.checkOutfield.Click += new System.EventHandler(this.checkOutfield_Click);
            this.checkOutfield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkOutfield_KeyDown);
            this.checkOutfield.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            this.checkOutfield.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(645, 329);
            this.Controls.Add(this.checkOutfield);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "startForm";
            this.Text = "startForm";
            this.Load += new System.EventHandler(this.startForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkOutfield;
    }
}