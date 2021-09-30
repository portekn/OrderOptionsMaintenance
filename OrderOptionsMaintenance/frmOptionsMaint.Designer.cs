namespace OrderOptionsMaintenance
{
    partial class frmOptionsMaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShipFirstBook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShipAddlBook = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales tax rate:";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(269, 19);
            this.txtSalesTax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.Size = new System.Drawing.Size(121, 27);
            this.txtSalesTax.TabIndex = 1;
            this.txtSalesTax.Tag = "Sales tax rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shipping charge - first book:";
            // 
            // txtShipFirstBook
            // 
            this.txtShipFirstBook.Location = new System.Drawing.Point(269, 56);
            this.txtShipFirstBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtShipFirstBook.Name = "txtShipFirstBook";
            this.txtShipFirstBook.Size = new System.Drawing.Size(121, 27);
            this.txtShipFirstBook.TabIndex = 3;
            this.txtShipFirstBook.Tag = "First book shipping charge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shipping charge - each add\'l book:";
            // 
            // txtShipAddlBook
            // 
            this.txtShipAddlBook.Location = new System.Drawing.Point(269, 93);
            this.txtShipAddlBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtShipAddlBook.Name = "txtShipAddlBook";
            this.txtShipAddlBook.Size = new System.Drawing.Size(121, 27);
            this.txtShipAddlBook.TabIndex = 5;
            this.txtShipAddlBook.Tag = "Add\'l book shipping charge";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 143);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(269, 143);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 33);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmOptionsMaint
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(421, 199);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtShipAddlBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShipFirstBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalesTax);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmOptionsMaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelli Porter\'s Order Options Thingy";
            this.Load += new System.EventHandler(this.frmOptionsMaint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShipFirstBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShipAddlBook;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}

