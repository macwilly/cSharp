namespace inClass4
{
    partial class formBeer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxXMLRPC = new System.Windows.Forms.GroupBox();
            this.buttonXMLRPC = new System.Windows.Forms.Button();
            this.comboBoxXMLRPC = new System.Windows.Forms.ComboBox();
            this.groupBoxSOAP = new System.Windows.Forms.GroupBox();
            this.buttonSOAP = new System.Windows.Forms.Button();
            this.comboBoxSOAP = new System.Windows.Forms.ComboBox();
            this.groupBoxRESTFUL = new System.Windows.Forms.GroupBox();
            this.buttonRESTFUL = new System.Windows.Forms.Button();
            this.comboBoxRESTFUL = new System.Windows.Forms.ComboBox();
            this.buttonGetPrice = new System.Windows.Forms.Button();
            this.textBoxGetPrice = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxXMLRPC.SuspendLayout();
            this.groupBoxSOAP.SuspendLayout();
            this.groupBoxRESTFUL.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(638, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // groupBoxXMLRPC
            // 
            this.groupBoxXMLRPC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxXMLRPC.Controls.Add(this.buttonXMLRPC);
            this.groupBoxXMLRPC.Controls.Add(this.comboBoxXMLRPC);
            this.groupBoxXMLRPC.Location = new System.Drawing.Point(12, 75);
            this.groupBoxXMLRPC.Name = "groupBoxXMLRPC";
            this.groupBoxXMLRPC.Size = new System.Drawing.Size(200, 215);
            this.groupBoxXMLRPC.TabIndex = 1;
            this.groupBoxXMLRPC.TabStop = false;
            this.groupBoxXMLRPC.Text = "XML-RPC";
            // 
            // buttonXMLRPC
            // 
            this.buttonXMLRPC.Location = new System.Drawing.Point(52, 113);
            this.buttonXMLRPC.Name = "buttonXMLRPC";
            this.buttonXMLRPC.Size = new System.Drawing.Size(75, 23);
            this.buttonXMLRPC.TabIndex = 3;
            this.buttonXMLRPC.Text = "Populate";
            this.buttonXMLRPC.UseVisualStyleBackColor = true;
            this.buttonXMLRPC.Click += new System.EventHandler(this.buttonXMLRPC_Click);
            // 
            // comboBoxXMLRPC
            // 
            this.comboBoxXMLRPC.FormattingEnabled = true;
            this.comboBoxXMLRPC.Location = new System.Drawing.Point(6, 50);
            this.comboBoxXMLRPC.Name = "comboBoxXMLRPC";
            this.comboBoxXMLRPC.Size = new System.Drawing.Size(121, 26);
            this.comboBoxXMLRPC.Sorted = true;
            this.comboBoxXMLRPC.TabIndex = 0;
            // 
            // groupBoxSOAP
            // 
            this.groupBoxSOAP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxSOAP.Controls.Add(this.buttonSOAP);
            this.groupBoxSOAP.Controls.Add(this.comboBoxSOAP);
            this.groupBoxSOAP.Location = new System.Drawing.Point(218, 75);
            this.groupBoxSOAP.Name = "groupBoxSOAP";
            this.groupBoxSOAP.Size = new System.Drawing.Size(200, 215);
            this.groupBoxSOAP.TabIndex = 0;
            this.groupBoxSOAP.TabStop = false;
            this.groupBoxSOAP.Text = "SOAP";
            // 
            // buttonSOAP
            // 
            this.buttonSOAP.Location = new System.Drawing.Point(52, 113);
            this.buttonSOAP.Name = "buttonSOAP";
            this.buttonSOAP.Size = new System.Drawing.Size(75, 23);
            this.buttonSOAP.TabIndex = 4;
            this.buttonSOAP.Text = "Populate";
            this.buttonSOAP.UseVisualStyleBackColor = true;
            this.buttonSOAP.Click += new System.EventHandler(this.buttonSOAP_Click);
            // 
            // comboBoxSOAP
            // 
            this.comboBoxSOAP.FormattingEnabled = true;
            this.comboBoxSOAP.Location = new System.Drawing.Point(6, 50);
            this.comboBoxSOAP.Name = "comboBoxSOAP";
            this.comboBoxSOAP.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSOAP.Sorted = true;
            this.comboBoxSOAP.TabIndex = 1;
            // 
            // groupBoxRESTFUL
            // 
            this.groupBoxRESTFUL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxRESTFUL.Controls.Add(this.buttonRESTFUL);
            this.groupBoxRESTFUL.Controls.Add(this.comboBoxRESTFUL);
            this.groupBoxRESTFUL.Location = new System.Drawing.Point(424, 75);
            this.groupBoxRESTFUL.Name = "groupBoxRESTFUL";
            this.groupBoxRESTFUL.Size = new System.Drawing.Size(200, 215);
            this.groupBoxRESTFUL.TabIndex = 2;
            this.groupBoxRESTFUL.TabStop = false;
            this.groupBoxRESTFUL.Text = "RESTFUL";
            // 
            // buttonRESTFUL
            // 
            this.buttonRESTFUL.Location = new System.Drawing.Point(52, 113);
            this.buttonRESTFUL.Name = "buttonRESTFUL";
            this.buttonRESTFUL.Size = new System.Drawing.Size(75, 23);
            this.buttonRESTFUL.TabIndex = 4;
            this.buttonRESTFUL.Text = "Populate";
            this.buttonRESTFUL.UseVisualStyleBackColor = true;
            this.buttonRESTFUL.Click += new System.EventHandler(this.buttonRESTFUL_Click);
            // 
            // comboBoxRESTFUL
            // 
            this.comboBoxRESTFUL.FormattingEnabled = true;
            this.comboBoxRESTFUL.Location = new System.Drawing.Point(6, 50);
            this.comboBoxRESTFUL.Name = "comboBoxRESTFUL";
            this.comboBoxRESTFUL.Size = new System.Drawing.Size(121, 26);
            this.comboBoxRESTFUL.Sorted = true;
            this.comboBoxRESTFUL.TabIndex = 1;
            // 
            // buttonGetPrice
            // 
            this.buttonGetPrice.Location = new System.Drawing.Point(424, 406);
            this.buttonGetPrice.Name = "buttonGetPrice";
            this.buttonGetPrice.Size = new System.Drawing.Size(95, 23);
            this.buttonGetPrice.TabIndex = 3;
            this.buttonGetPrice.Text = "Get Price";
            this.buttonGetPrice.UseVisualStyleBackColor = true;
            this.buttonGetPrice.Click += new System.EventHandler(this.buttonGetPrice_Click);
            // 
            // textBoxGetPrice
            // 
            this.textBoxGetPrice.Enabled = false;
            this.textBoxGetPrice.Location = new System.Drawing.Point(424, 366);
            this.textBoxGetPrice.Name = "textBoxGetPrice";
            this.textBoxGetPrice.Size = new System.Drawing.Size(202, 25);
            this.textBoxGetPrice.TabIndex = 4;
            // 
            // formBeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(638, 441);
            this.Controls.Add(this.textBoxGetPrice);
            this.Controls.Add(this.buttonGetPrice);
            this.Controls.Add(this.groupBoxRESTFUL);
            this.Controls.Add(this.groupBoxSOAP);
            this.Controls.Add(this.groupBoxXMLRPC);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formBeer";
            this.Text = "Get  Beers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxXMLRPC.ResumeLayout(false);
            this.groupBoxSOAP.ResumeLayout(false);
            this.groupBoxRESTFUL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxXMLRPC;
        private System.Windows.Forms.GroupBox groupBoxSOAP;
        private System.Windows.Forms.GroupBox groupBoxRESTFUL;
        private System.Windows.Forms.Button buttonXMLRPC;
        private System.Windows.Forms.ComboBox comboBoxXMLRPC;
        private System.Windows.Forms.Button buttonSOAP;
        private System.Windows.Forms.ComboBox comboBoxSOAP;
        private System.Windows.Forms.Button buttonRESTFUL;
        private System.Windows.Forms.ComboBox comboBoxRESTFUL;
        private System.Windows.Forms.Button buttonGetPrice;
        private System.Windows.Forms.TextBox textBoxGetPrice;
    }
}

