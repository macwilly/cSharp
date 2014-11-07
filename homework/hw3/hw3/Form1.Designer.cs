namespace hw3
{
    partial class formFileRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFileRead));
            this.groupBoxTxt = new System.Windows.Forms.GroupBox();
            this.groupBoxXML = new System.Windows.Forms.GroupBox();
            this.groupBoxJSON = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxTxt = new System.Windows.Forms.ComboBox();
            this.comboBoxXML = new System.Windows.Forms.ComboBox();
            this.comboBoxJSON = new System.Windows.Forms.ComboBox();
            this.buttonPopTxt = new System.Windows.Forms.Button();
            this.buttonPopXML = new System.Windows.Forms.Button();
            this.buttonPopJSON = new System.Windows.Forms.Button();
            this.buttonClearTxt = new System.Windows.Forms.Button();
            this.groupBoxTxt.SuspendLayout();
            this.groupBoxXML.SuspendLayout();
            this.groupBoxJSON.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTxt
            // 
            this.groupBoxTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxTxt.Controls.Add(this.buttonClearTxt);
            this.groupBoxTxt.Controls.Add(this.buttonPopTxt);
            this.groupBoxTxt.Controls.Add(this.comboBoxTxt);
            this.groupBoxTxt.Location = new System.Drawing.Point(12, 43);
            this.groupBoxTxt.Name = "groupBoxTxt";
            this.groupBoxTxt.Size = new System.Drawing.Size(200, 236);
            this.groupBoxTxt.TabIndex = 0;
            this.groupBoxTxt.TabStop = false;
            this.groupBoxTxt.Text = "Text";
            // 
            // groupBoxXML
            // 
            this.groupBoxXML.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxXML.Controls.Add(this.buttonPopXML);
            this.groupBoxXML.Controls.Add(this.comboBoxXML);
            this.groupBoxXML.Location = new System.Drawing.Point(218, 43);
            this.groupBoxXML.Name = "groupBoxXML";
            this.groupBoxXML.Size = new System.Drawing.Size(200, 236);
            this.groupBoxXML.TabIndex = 0;
            this.groupBoxXML.TabStop = false;
            this.groupBoxXML.Text = "XML";
            // 
            // groupBoxJSON
            // 
            this.groupBoxJSON.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxJSON.Controls.Add(this.buttonPopJSON);
            this.groupBoxJSON.Controls.Add(this.comboBoxJSON);
            this.groupBoxJSON.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxJSON.Location = new System.Drawing.Point(424, 43);
            this.groupBoxJSON.Name = "groupBoxJSON";
            this.groupBoxJSON.Size = new System.Drawing.Size(200, 236);
            this.groupBoxJSON.TabIndex = 1;
            this.groupBoxJSON.TabStop = false;
            this.groupBoxJSON.Text = "JSON";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // comboBoxTxt
            // 
            this.comboBoxTxt.FormattingEnabled = true;
            this.comboBoxTxt.Location = new System.Drawing.Point(6, 41);
            this.comboBoxTxt.Name = "comboBoxTxt";
            this.comboBoxTxt.Size = new System.Drawing.Size(121, 25);
            this.comboBoxTxt.TabIndex = 0;
            // 
            // comboBoxXML
            // 
            this.comboBoxXML.FormattingEnabled = true;
            this.comboBoxXML.Location = new System.Drawing.Point(6, 41);
            this.comboBoxXML.Name = "comboBoxXML";
            this.comboBoxXML.Size = new System.Drawing.Size(121, 25);
            this.comboBoxXML.TabIndex = 1;
            // 
            // comboBoxJSON
            // 
            this.comboBoxJSON.FormattingEnabled = true;
            this.comboBoxJSON.Location = new System.Drawing.Point(6, 41);
            this.comboBoxJSON.Name = "comboBoxJSON";
            this.comboBoxJSON.Size = new System.Drawing.Size(121, 25);
            this.comboBoxJSON.TabIndex = 2;
            // 
            // buttonPopTxt
            // 
            this.buttonPopTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPopTxt.Location = new System.Drawing.Point(52, 177);
            this.buttonPopTxt.Name = "buttonPopTxt";
            this.buttonPopTxt.Size = new System.Drawing.Size(75, 23);
            this.buttonPopTxt.TabIndex = 3;
            this.buttonPopTxt.Text = "Populate";
            this.buttonPopTxt.UseVisualStyleBackColor = true;
            this.buttonPopTxt.Click += new System.EventHandler(this.buttonPopTxt_Click);
            // 
            // buttonPopXML
            // 
            this.buttonPopXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPopXML.Location = new System.Drawing.Point(52, 177);
            this.buttonPopXML.Name = "buttonPopXML";
            this.buttonPopXML.Size = new System.Drawing.Size(75, 23);
            this.buttonPopXML.TabIndex = 4;
            this.buttonPopXML.Text = "Populate";
            this.buttonPopXML.UseVisualStyleBackColor = true;
            // 
            // buttonPopJSON
            // 
            this.buttonPopJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPopJSON.Location = new System.Drawing.Point(52, 177);
            this.buttonPopJSON.Name = "buttonPopJSON";
            this.buttonPopJSON.Size = new System.Drawing.Size(75, 23);
            this.buttonPopJSON.TabIndex = 4;
            this.buttonPopJSON.Text = "Populate";
            this.buttonPopJSON.UseVisualStyleBackColor = true;
            // 
            // buttonClearTxt
            // 
            this.buttonClearTxt.Location = new System.Drawing.Point(63, 206);
            this.buttonClearTxt.Name = "buttonClearTxt";
            this.buttonClearTxt.Size = new System.Drawing.Size(52, 23);
            this.buttonClearTxt.TabIndex = 3;
            this.buttonClearTxt.Text = "Clear";
            this.buttonClearTxt.UseVisualStyleBackColor = true;
            this.buttonClearTxt.Click += new System.EventHandler(this.buttonClearTxt_Click);
            // 
            // formFileRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.groupBoxJSON);
            this.Controls.Add(this.groupBoxXML);
            this.Controls.Add(this.groupBoxTxt);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formFileRead";
            this.Text = "File Read";
            this.groupBoxTxt.ResumeLayout(false);
            this.groupBoxXML.ResumeLayout(false);
            this.groupBoxJSON.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTxt;
        private System.Windows.Forms.GroupBox groupBoxXML;
        private System.Windows.Forms.GroupBox groupBoxJSON;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBoxTxt;
        private System.Windows.Forms.ComboBox comboBoxXML;
        private System.Windows.Forms.ComboBox comboBoxJSON;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button buttonPopTxt;
        private System.Windows.Forms.Button buttonPopXML;
        private System.Windows.Forms.Button buttonPopJSON;
        private System.Windows.Forms.Button buttonClearTxt;
    }
}

