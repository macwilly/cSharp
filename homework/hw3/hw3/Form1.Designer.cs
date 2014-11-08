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
            this.buttonClearTxt = new System.Windows.Forms.Button();
            this.buttonPopTxt = new System.Windows.Forms.Button();
            this.comboBoxTxt = new System.Windows.Forms.ComboBox();
            this.groupBoxXML = new System.Windows.Forms.GroupBox();
            this.buttonPopXML = new System.Windows.Forms.Button();
            this.comboBoxXML = new System.Windows.Forms.ComboBox();
            this.groupBoxJSON = new System.Windows.Forms.GroupBox();
            this.buttonPopJSON = new System.Windows.Forms.Button();
            this.comboBoxJSON = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonXmlClear = new System.Windows.Forms.Button();
            this.buttonJsonClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // buttonClearTxt
            // 
            this.buttonClearTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearTxt.Location = new System.Drawing.Point(64, 207);
            this.buttonClearTxt.Name = "buttonClearTxt";
            this.buttonClearTxt.Size = new System.Drawing.Size(52, 23);
            this.buttonClearTxt.TabIndex = 3;
            this.buttonClearTxt.Text = "Clear";
            this.buttonClearTxt.UseVisualStyleBackColor = true;
            this.buttonClearTxt.Click += new System.EventHandler(this.buttonClearTxt_Click);
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
            // comboBoxTxt
            // 
            this.comboBoxTxt.FormattingEnabled = true;
            this.comboBoxTxt.Location = new System.Drawing.Point(6, 41);
            this.comboBoxTxt.Name = "comboBoxTxt";
            this.comboBoxTxt.Size = new System.Drawing.Size(121, 25);
            this.comboBoxTxt.TabIndex = 0;
            // 
            // groupBoxXML
            // 
            this.groupBoxXML.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxXML.Controls.Add(this.buttonXmlClear);
            this.groupBoxXML.Controls.Add(this.buttonPopXML);
            this.groupBoxXML.Controls.Add(this.comboBoxXML);
            this.groupBoxXML.Location = new System.Drawing.Point(218, 43);
            this.groupBoxXML.Name = "groupBoxXML";
            this.groupBoxXML.Size = new System.Drawing.Size(200, 236);
            this.groupBoxXML.TabIndex = 0;
            this.groupBoxXML.TabStop = false;
            this.groupBoxXML.Text = "XML";
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
            this.buttonPopXML.Click += new System.EventHandler(this.buttonPopXML_Click);
            // 
            // comboBoxXML
            // 
            this.comboBoxXML.FormattingEnabled = true;
            this.comboBoxXML.Location = new System.Drawing.Point(6, 41);
            this.comboBoxXML.Name = "comboBoxXML";
            this.comboBoxXML.Size = new System.Drawing.Size(121, 25);
            this.comboBoxXML.TabIndex = 1;
            // 
            // groupBoxJSON
            // 
            this.groupBoxJSON.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxJSON.Controls.Add(this.buttonJsonClear);
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
            // buttonPopJSON
            // 
            this.buttonPopJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPopJSON.Location = new System.Drawing.Point(52, 177);
            this.buttonPopJSON.Name = "buttonPopJSON";
            this.buttonPopJSON.Size = new System.Drawing.Size(75, 23);
            this.buttonPopJSON.TabIndex = 4;
            this.buttonPopJSON.Text = "Populate";
            this.buttonPopJSON.UseVisualStyleBackColor = true;
            this.buttonPopJSON.Click += new System.EventHandler(this.buttonPopJSON_Click);
            // 
            // comboBoxJSON
            // 
            this.comboBoxJSON.FormattingEnabled = true;
            this.comboBoxJSON.Location = new System.Drawing.Point(6, 41);
            this.comboBoxJSON.Name = "comboBoxJSON";
            this.comboBoxJSON.Size = new System.Drawing.Size(121, 25);
            this.comboBoxJSON.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
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
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // buttonXmlClear
            // 
            this.buttonXmlClear.Location = new System.Drawing.Point(69, 207);
            this.buttonXmlClear.Name = "buttonXmlClear";
            this.buttonXmlClear.Size = new System.Drawing.Size(49, 23);
            this.buttonXmlClear.TabIndex = 5;
            this.buttonXmlClear.Text = "Clear";
            this.buttonXmlClear.UseVisualStyleBackColor = true;
            this.buttonXmlClear.Click += new System.EventHandler(this.buttonXmlClear_Click);
            // 
            // buttonJsonClear
            // 
            this.buttonJsonClear.Location = new System.Drawing.Point(69, 206);
            this.buttonJsonClear.Name = "buttonJsonClear";
            this.buttonJsonClear.Size = new System.Drawing.Size(49, 23);
            this.buttonJsonClear.TabIndex = 6;
            this.buttonJsonClear.Text = "Clear";
            this.buttonJsonClear.UseVisualStyleBackColor = true;
            this.buttonJsonClear.Click += new System.EventHandler(this.buttonJsonClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hide";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formFileRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 428);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button buttonXmlClear;
        private System.Windows.Forms.Button buttonJsonClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

