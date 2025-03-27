namespace CursovWork_
{
    partial class TravelTicketInformation
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
            this.name = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.NameOfRecipient = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.PriceForOne = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrganizationName = new System.Windows.Forms.Label();
            this.OrganizationsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(26, 52);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(177, 20);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(26, 91);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(177, 20);
            this.Number.TabIndex = 0;
            this.Number.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // Price
            // 
            this.Price.Enabled = false;
            this.Price.Location = new System.Drawing.Point(26, 130);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(177, 20);
            this.Price.TabIndex = 0;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // NameOfRecipient
            // 
            this.NameOfRecipient.Location = new System.Drawing.Point(26, 166);
            this.NameOfRecipient.Name = "NameOfRecipient";
            this.NameOfRecipient.Size = new System.Drawing.Size(177, 20);
            this.NameOfRecipient.TabIndex = 0;
            this.NameOfRecipient.TextChanged += new System.EventHandler(this.NameOfRecipient_TextChanged);
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(26, 206);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(177, 20);
            this.Adress.TabIndex = 0;
            this.Adress.TextChanged += new System.EventHandler(this.Adress_TextChanged);
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(26, 258);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(177, 20);
            this.Type.TabIndex = 0;
            this.Type.TextChanged += new System.EventHandler(this.Type_TextChanged);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(26, 348);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(177, 20);
            this.Quantity.TabIndex = 0;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // PriceForOne
            // 
            this.PriceForOne.Location = new System.Drawing.Point(26, 299);
            this.PriceForOne.Name = "PriceForOne";
            this.PriceForOne.Size = new System.Drawing.Size(177, 20);
            this.PriceForOne.TabIndex = 0;
            this.PriceForOne.TextChanged += new System.EventHandler(this.PriceForOne_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(50, 458);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(112, 48);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of ticket:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name of recipient:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(5, 190);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(48, 13);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type of the ticket:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price for one ticket:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quantity:";
            // 
            // OrganizationName
            // 
            this.OrganizationName.AutoSize = true;
            this.OrganizationName.Location = new System.Drawing.Point(3, 375);
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.Size = new System.Drawing.Size(112, 13);
            this.OrganizationName.TabIndex = 11;
            this.OrganizationName.Text = "Name of Organization:";
            // 
            // OrganizationsComboBox
            // 
            this.OrganizationsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrganizationsComboBox.FormattingEnabled = true;
            this.OrganizationsComboBox.Location = new System.Drawing.Point(26, 391);
            this.OrganizationsComboBox.Name = "OrganizationsComboBox";
            this.OrganizationsComboBox.Size = new System.Drawing.Size(177, 21);
            this.OrganizationsComboBox.TabIndex = 12;
            // 
            // TravelTicketInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 518);
            this.Controls.Add(this.OrganizationsComboBox);
            this.Controls.Add(this.OrganizationName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.PriceForOne);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.NameOfRecipient);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.name);
            this.Name = "TravelTicketInformation";
            this.Text = "TravelTicketInformation";
            this.Load += new System.EventHandler(this.TravelTicketInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox NameOfRecipient;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox PriceForOne;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label OrganizationName;
        private System.Windows.Forms.ComboBox OrganizationsComboBox;
    }
}