namespace WithdrawMoneyApp
{
    partial class Withdraw
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
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.customerNametextBox = new System.Windows.Forms.TextBox();
            this.customerAddresstextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.amountlabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.totalAmountlabel = new System.Windows.Forms.Label();
            this.totalAmounttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(56, 33);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(165, 25);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Customer Name: ";
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressLabel.Location = new System.Drawing.Point(56, 82);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(186, 25);
            this.customerAddressLabel.TabIndex = 0;
            this.customerAddressLabel.Text = "Customer Address: ";
            // 
            // customerNametextBox
            // 
            this.customerNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNametextBox.Location = new System.Drawing.Point(310, 37);
            this.customerNametextBox.Name = "customerNametextBox";
            this.customerNametextBox.Size = new System.Drawing.Size(251, 30);
            this.customerNametextBox.TabIndex = 1;
            // 
            // customerAddresstextBox
            // 
            this.customerAddresstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddresstextBox.Location = new System.Drawing.Point(310, 82);
            this.customerAddresstextBox.Name = "customerAddresstextBox";
            this.customerAddresstextBox.Size = new System.Drawing.Size(251, 30);
            this.customerAddresstextBox.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(61, 141);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(136, 43);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.amountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlabel.Location = new System.Drawing.Point(56, 231);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(91, 25);
            this.amountlabel.TabIndex = 0;
            this.amountlabel.Text = "Amount: ";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(310, 231);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(251, 30);
            this.amountTextBox.TabIndex = 1;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.Location = new System.Drawing.Point(61, 305);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(136, 43);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(256, 305);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(136, 43);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // totalAmountlabel
            // 
            this.totalAmountlabel.AutoSize = true;
            this.totalAmountlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalAmountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountlabel.Location = new System.Drawing.Point(56, 398);
            this.totalAmountlabel.Name = "totalAmountlabel";
            this.totalAmountlabel.Size = new System.Drawing.Size(140, 25);
            this.totalAmountlabel.TabIndex = 0;
            this.totalAmountlabel.Text = "Total Amount: ";
            // 
            // totalAmounttextBox
            // 
            this.totalAmounttextBox.AllowDrop = true;
            this.totalAmounttextBox.Enabled = false;
            this.totalAmounttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmounttextBox.Location = new System.Drawing.Point(310, 393);
            this.totalAmounttextBox.Name = "totalAmounttextBox";
            this.totalAmounttextBox.Size = new System.Drawing.Size(251, 30);
            this.totalAmounttextBox.TabIndex = 1;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.customerAddresstextBox);
            this.Controls.Add(this.totalAmounttextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.customerNametextBox);
            this.Controls.Add(this.totalAmountlabel);
            this.Controls.Add(this.amountlabel);
            this.Controls.Add(this.customerAddressLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.TextBox customerNametextBox;
        private System.Windows.Forms.TextBox customerAddresstextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label amountlabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Label totalAmountlabel;
        private System.Windows.Forms.TextBox totalAmounttextBox;
    }
}