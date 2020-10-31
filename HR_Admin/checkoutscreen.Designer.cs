namespace HR_Admin
{
    partial class checkoutscreen
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.cashLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.changeField = new System.Windows.Forms.TextBox();
            this.checkOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(33, 31);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(241, 69);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "TOTAL:";
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.Location = new System.Drawing.Point(33, 109);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(213, 69);
            this.cashLabel.TabIndex = 1;
            this.cashLabel.Text = "CASH:";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(33, 192);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(303, 69);
            this.changeLabel.TabIndex = 2;
            this.changeLabel.Text = "CHANGE:";
            this.changeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(340, 31);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(350, 69);
            this.totalOutput.TabIndex = 3;
            this.totalOutput.Text = "XXXXXXXX";
            this.totalOutput.Click += new System.EventHandler(this.label4_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(340, 194);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(350, 69);
            this.changeOutput.TabIndex = 5;
            this.changeOutput.Text = "XXXXXXXX";
            // 
            // changeField
            // 
            this.changeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeField.Location = new System.Drawing.Point(352, 109);
            this.changeField.Name = "changeField";
            this.changeField.Size = new System.Drawing.Size(338, 75);
            this.changeField.TabIndex = 6;
            this.changeField.Enter += new System.EventHandler(this.changeField_Enter);
            this.changeField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changeField_KeyDown);
            this.changeField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.changeField_KeyPress);
            // 
            // checkOut
            // 
            this.checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut.Location = new System.Drawing.Point(438, 329);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(311, 77);
            this.checkOut.TabIndex = 7;
            this.checkOut.Text = "Checkout";
            this.checkOut.UseVisualStyleBackColor = true;
            this.checkOut.Click += new System.EventHandler(this.checkOut_Click);
            this.checkOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkOut_KeyDown);
            this.checkOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // checkoutscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.changeField);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.totalLabel);
            this.Name = "checkoutscreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.TextBox changeField;
        private System.Windows.Forms.Button checkOut;
    }
}