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
            this.comboBoxTxt = new System.Windows.Forms.ComboBox();
            this.buttonGetTxt = new System.Windows.Forms.Button();
            this.comboBoxGenaric = new System.Windows.Forms.ComboBox();
            this.buttonGetXML = new System.Windows.Forms.Button();
            this.comboBoxXML = new System.Windows.Forms.ComboBox();
            this.comboBoxJSon = new System.Windows.Forms.ComboBox();
            this.buttonJSon = new System.Windows.Forms.Button();
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
            this.Name = "Form1";
            this.Text = "butt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTxt;
        private System.Windows.Forms.Button buttonGetTxt;
        private System.Windows.Forms.ComboBox comboBoxGenaric;
        private System.Windows.Forms.Button buttonGetXML;
        private System.Windows.Forms.ComboBox comboBoxXML;
        private System.Windows.Forms.ComboBox comboBoxJSon;
        private System.Windows.Forms.Button buttonJSon;
    }
}

