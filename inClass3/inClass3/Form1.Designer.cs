namespace inClass3
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
            this.comboBoxTxt = new System.Windows.Forms.ComboBox();
            this.buttonGetTxt = new System.Windows.Forms.Button();
            this.comboBoxGenaric = new System.Windows.Forms.ComboBox();
            this.buttonGetXML = new System.Windows.Forms.Button();
            this.comboBoxXML = new System.Windows.Forms.ComboBox();
            this.comboBoxJSon = new System.Windows.Forms.ComboBox();
            this.buttonJSon = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somethingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTxt
            // 
            this.comboBoxTxt.FormattingEnabled = true;
            this.comboBoxTxt.Location = new System.Drawing.Point(12, 35);
            this.comboBoxTxt.Name = "comboBoxTxt";
            this.comboBoxTxt.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTxt.TabIndex = 0;
            // 
            // buttonGetTxt
            // 
            this.buttonGetTxt.Location = new System.Drawing.Point(12, 86);
            this.buttonGetTxt.Name = "buttonGetTxt";
            this.buttonGetTxt.Size = new System.Drawing.Size(75, 23);
            this.buttonGetTxt.TabIndex = 1;
            this.buttonGetTxt.Text = "Get txt";
            this.buttonGetTxt.UseVisualStyleBackColor = true;
            this.buttonGetTxt.Click += new System.EventHandler(this.buttonGetTxt_Click);
            // 
            // comboBoxGenaric
            // 
            this.comboBoxGenaric.FormattingEnabled = true;
            this.comboBoxGenaric.Items.AddRange(new object[] {
            "From an",
            "internal",
            "items ",
            "collection"});
            this.comboBoxGenaric.Location = new System.Drawing.Point(198, 310);
            this.comboBoxGenaric.Name = "comboBoxGenaric";
            this.comboBoxGenaric.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenaric.TabIndex = 2;
            // 
            // buttonGetXML
            // 
            this.buttonGetXML.Location = new System.Drawing.Point(188, 86);
            this.buttonGetXML.Name = "buttonGetXML";
            this.buttonGetXML.Size = new System.Drawing.Size(75, 23);
            this.buttonGetXML.TabIndex = 3;
            this.buttonGetXML.Text = "Get Xml";
            this.buttonGetXML.UseVisualStyleBackColor = true;
            this.buttonGetXML.Click += new System.EventHandler(this.buttonGetXML_Click);
            // 
            // comboBoxXML
            // 
            this.comboBoxXML.FormattingEnabled = true;
            this.comboBoxXML.Location = new System.Drawing.Point(188, 35);
            this.comboBoxXML.Name = "comboBoxXML";
            this.comboBoxXML.Size = new System.Drawing.Size(121, 21);
            this.comboBoxXML.TabIndex = 4;
            // 
            // comboBoxJSon
            // 
            this.comboBoxJSon.FormattingEnabled = true;
            this.comboBoxJSon.Location = new System.Drawing.Point(349, 35);
            this.comboBoxJSon.Name = "comboBoxJSon";
            this.comboBoxJSon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxJSon.TabIndex = 5;
            // 
            // buttonJSon
            // 
            this.buttonJSon.Location = new System.Drawing.Point(349, 97);
            this.buttonJSon.Name = "buttonJSon";
            this.buttonJSon.Size = new System.Drawing.Size(75, 23);
            this.buttonJSon.TabIndex = 6;
            this.buttonJSon.Text = "Get JSon";
            this.buttonJSon.UseVisualStyleBackColor = true;
            this.buttonJSon.Click += new System.EventHandler(this.buttonJSon_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.newToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somethingToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otherToolStripMenuItem.Text = "Other";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // somethingToolStripMenuItem
            // 
            this.somethingToolStripMenuItem.Name = "somethingToolStripMenuItem";
            this.somethingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.somethingToolStripMenuItem.Text = "Something";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 376);
            this.Controls.Add(this.buttonJSon);
            this.Controls.Add(this.comboBoxJSon);
            this.Controls.Add(this.comboBoxXML);
            this.Controls.Add(this.buttonGetXML);
            this.Controls.Add(this.comboBoxGenaric);
            this.Controls.Add(this.buttonGetTxt);
            this.Controls.Add(this.comboBoxTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "butt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTxt;
        private System.Windows.Forms.Button buttonGetTxt;
        private System.Windows.Forms.ComboBox comboBoxGenaric;
        private System.Windows.Forms.Button buttonGetXML;
        private System.Windows.Forms.ComboBox comboBoxXML;
        private System.Windows.Forms.ComboBox comboBoxJSon;
        private System.Windows.Forms.Button buttonJSon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somethingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

