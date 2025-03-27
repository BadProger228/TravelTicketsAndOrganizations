namespace CursovWork_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Organization = new System.Windows.Forms.ListBox();
            this.TravelTicket = new System.Windows.Forms.ListBox();
            this.OrganizationText = new System.Windows.Forms.Label();
            this.OrganizationListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TravelTicketContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrganizationListContextMenu.SuspendLayout();
            this.TravelTicketContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Organization
            // 
            this.Organization.FormattingEnabled = true;
            this.Organization.Location = new System.Drawing.Point(276, 75);
            this.Organization.Name = "Organization";
            this.Organization.Size = new System.Drawing.Size(224, 342);
            this.Organization.TabIndex = 0;
            this.Organization.SelectedIndexChanged += new System.EventHandler(this.Organization_SelectedIndexChanged);
            this.Organization.DoubleClick += new System.EventHandler(this.Organization_DoubleClick);
            // 
            // TravelTicket
            // 
            this.TravelTicket.FormattingEnabled = true;
            this.TravelTicket.Location = new System.Drawing.Point(12, 75);
            this.TravelTicket.Name = "TravelTicket";
            this.TravelTicket.Size = new System.Drawing.Size(206, 342);
            this.TravelTicket.TabIndex = 1;
            this.TravelTicket.SelectedIndexChanged += new System.EventHandler(this.TravelTicket_SelectedIndexChanged);
            this.TravelTicket.DoubleClick += new System.EventHandler(this.TravelTicket_DoubleClick);
            // 
            // OrganizationText
            // 
            this.OrganizationText.AutoSize = true;
            this.OrganizationText.Location = new System.Drawing.Point(273, 58);
            this.OrganizationText.Name = "OrganizationText";
            this.OrganizationText.Size = new System.Drawing.Size(72, 13);
            this.OrganizationText.TabIndex = 2;
            this.OrganizationText.Text = "Organization: ";
            // 
            // OrganizationListContextMenu
            // 
            this.OrganizationListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.OrganizationListContextMenu.Name = "OrganizationListContextMenu";
            this.OrganizationListContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // TravelTicketContextMenu
            // 
            this.TravelTicketContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.TravelTicketContextMenu.Name = "TravelTicketContextMenu";
            this.TravelTicketContextMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(551, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(58, 59);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Travel Tickets: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.OrganizationText);
            this.Controls.Add(this.TravelTicket);
            this.Controls.Add(this.Organization);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OrganizationListContextMenu.ResumeLayout(false);
            this.TravelTicketContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Organization;
        private System.Windows.Forms.ListBox TravelTicket;
        private System.Windows.Forms.Label OrganizationText;
        private System.Windows.Forms.ContextMenuStrip OrganizationListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip TravelTicketContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label1;
    }
}

