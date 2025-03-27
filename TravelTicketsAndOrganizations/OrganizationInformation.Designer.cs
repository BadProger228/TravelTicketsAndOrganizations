namespace CursovWork_
{
    partial class OrganizationInformation
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
            this.NameText = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.DateBalance = new System.Windows.Forms.TextBox();
            this.BalanceText = new System.Windows.Forms.TextBox();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(38, 48);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(173, 20);
            this.NameText.TabIndex = 0;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(38, 111);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(173, 36);
            this.DescriptionText.TabIndex = 1;
            this.DescriptionText.TextChanged += new System.EventHandler(this.DescriptionText_TextChanged);
            // 
            // QuantityText
            // 
            this.QuantityText.Location = new System.Drawing.Point(38, 179);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.ReadOnly = true;
            this.QuantityText.Size = new System.Drawing.Size(173, 20);
            this.QuantityText.TabIndex = 2;
            this.QuantityText.TextChanged += new System.EventHandler(this.QuantityText_TextChanged);
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(38, 222);
            this.PriceText.Name = "PriceText";
            this.PriceText.ReadOnly = true;
            this.PriceText.Size = new System.Drawing.Size(173, 20);
            this.PriceText.TabIndex = 3;
            this.PriceText.TextChanged += new System.EventHandler(this.PriceText_TextChanged);
            // 
            // DateBalance
            // 
            this.DateBalance.Location = new System.Drawing.Point(38, 271);
            this.DateBalance.Name = "DateBalance";
            this.DateBalance.ReadOnly = true;
            this.DateBalance.Size = new System.Drawing.Size(173, 20);
            this.DateBalance.TabIndex = 4;
            this.DateBalance.TextChanged += new System.EventHandler(this.DateBalance_TextChanged);
            // 
            // BalanceText
            // 
            this.BalanceText.Location = new System.Drawing.Point(38, 319);
            this.BalanceText.Name = "BalanceText";
            this.BalanceText.ReadOnly = true;
            this.BalanceText.Size = new System.Drawing.Size(173, 20);
            this.BalanceText.TabIndex = 5;
            this.BalanceText.TextChanged += new System.EventHandler(this.BalanceText_TextChanged);
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.Location = new System.Drawing.Point(20, 32);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(113, 13);
            this.OrganizationLabel.TabIndex = 6;
            this.OrganizationLabel.Text = "Name of organization: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description:";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(20, 163);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(49, 13);
            this.Quantity.TabIndex = 8;
            this.Quantity.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date of balance:";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(23, 303);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(49, 13);
            this.Balance.TabIndex = 11;
            this.Balance.Text = "Balance:";
            this.Balance.Click += new System.EventHandler(this.Balance_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(52, 423);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(132, 36);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveInformation
            // 
            this.SaveInformation.Location = new System.Drawing.Point(52, 380);
            this.SaveInformation.Name = "SaveInformation";
            this.SaveInformation.Size = new System.Drawing.Size(132, 37);
            this.SaveInformation.TabIndex = 13;
            this.SaveInformation.Text = "Save information";
            this.SaveInformation.UseVisualStyleBackColor = true;
            this.SaveInformation.Click += new System.EventHandler(this.SaveInformation_Click);
            // 
            // OrganizationInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 497);
            this.Controls.Add(this.SaveInformation);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrganizationLabel);
            this.Controls.Add(this.BalanceText);
            this.Controls.Add(this.DateBalance);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.QuantityText);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.NameText);
            this.Name = "OrganizationInformation";
            this.Text = "Organization information";
            this.Load += new System.EventHandler(this.OrganizationInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox DateBalance;
        private System.Windows.Forms.TextBox BalanceText;
        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SaveInformation;
    }
}