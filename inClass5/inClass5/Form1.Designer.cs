namespace inClass5
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkedBoxList = new System.Windows.Forms.CheckedListBox();
            this.textBoxTextValue = new System.Windows.Forms.TextBox();
            this.textBoxOnOff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheckBoxList = new System.Windows.Forms.Button();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "One";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.allCheckBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Two";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.allCheckBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 90);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Three";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.allCheckBox_CheckedChanged);
            // 
            // checkedBoxList
            // 
            this.checkedBoxList.FormattingEnabled = true;
            this.checkedBoxList.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
            this.checkedBoxList.Location = new System.Drawing.Point(273, 44);
            this.checkedBoxList.Name = "checkedBoxList";
            this.checkedBoxList.Size = new System.Drawing.Size(120, 94);
            this.checkedBoxList.TabIndex = 3;
            // 
            // textBoxTextValue
            // 
            this.textBoxTextValue.Location = new System.Drawing.Point(30, 153);
            this.textBoxTextValue.Name = "textBoxTextValue";
            this.textBoxTextValue.Size = new System.Drawing.Size(149, 20);
            this.textBoxTextValue.TabIndex = 4;
            // 
            // textBoxOnOff
            // 
            this.textBoxOnOff.Location = new System.Drawing.Point(30, 198);
            this.textBoxOnOff.Name = "textBoxOnOff";
            this.textBoxOnOff.Size = new System.Drawing.Size(149, 20);
            this.textBoxOnOff.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text Value";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "On/Off";
            // 
            // buttonCheckBoxList
            // 
            this.buttonCheckBoxList.Location = new System.Drawing.Point(273, 144);
            this.buttonCheckBoxList.Name = "buttonCheckBoxList";
            this.buttonCheckBoxList.Size = new System.Drawing.Size(120, 23);
            this.buttonCheckBoxList.TabIndex = 8;
            this.buttonCheckBoxList.Text = "Get the Values";
            this.buttonCheckBoxList.UseVisualStyleBackColor = true;
            this.buttonCheckBoxList.Click += new System.EventHandler(this.buttonCheckBoxList_Click);
            this.buttonCheckBoxList.MouseHover += new System.EventHandler(this.buttonCheckBoxList_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 320);
            this.Controls.Add(this.buttonCheckBoxList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOnOff);
            this.Controls.Add(this.textBoxTextValue);
            this.Controls.Add(this.checkedBoxList);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckedListBox checkedBoxList;
        private System.Windows.Forms.TextBox textBoxTextValue;
        private System.Windows.Forms.TextBox textBoxOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCheckBoxList;
        private System.Windows.Forms.ToolTip myToolTip;
    }
}

