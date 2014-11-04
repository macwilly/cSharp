namespace hw2
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
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.labelNameFirst = new System.Windows.Forms.Label();
            this.labelNameLast = new System.Windows.Forms.Label();
            this.textBoxNameFirst = new System.Windows.Forms.TextBox();
            this.textBoxNameLast = new System.Windows.Forms.TextBox();
            this.buttonForm1Next = new System.Windows.Forms.Button();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.labeladdressStreet = new System.Windows.Forms.Label();
            this.labelAddressCity = new System.Windows.Forms.Label();
            this.labelAddressState = new System.Windows.Forms.Label();
            this.textBoxAddressStreet = new System.Windows.Forms.TextBox();
            this.textBoxAddressCity = new System.Windows.Forms.TextBox();
            this.textBoxAddressState = new System.Windows.Forms.TextBox();
            this.groupBoxName.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.textBoxNameLast);
            this.groupBoxName.Controls.Add(this.textBoxNameFirst);
            this.groupBoxName.Controls.Add(this.labelNameLast);
            this.groupBoxName.Controls.Add(this.labelNameFirst);
            this.groupBoxName.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxName.Location = new System.Drawing.Point(12, 12);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(183, 135);
            this.groupBoxName.TabIndex = 0;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Name";
            // 
            // labelNameFirst
            // 
            this.labelNameFirst.AutoSize = true;
            this.labelNameFirst.Location = new System.Drawing.Point(18, 48);
            this.labelNameFirst.Name = "labelNameFirst";
            this.labelNameFirst.Size = new System.Drawing.Size(28, 15);
            this.labelNameFirst.TabIndex = 1;
            this.labelNameFirst.Text = "First";
            // 
            // labelNameLast
            // 
            this.labelNameLast.AutoSize = true;
            this.labelNameLast.Location = new System.Drawing.Point(18, 89);
            this.labelNameLast.Name = "labelNameLast";
            this.labelNameLast.Size = new System.Drawing.Size(27, 15);
            this.labelNameLast.TabIndex = 2;
            this.labelNameLast.Text = "Last";
            // 
            // textBoxNameFirst
            // 
            this.textBoxNameFirst.Location = new System.Drawing.Point(50, 41);
            this.textBoxNameFirst.Name = "textBoxNameFirst";
            this.textBoxNameFirst.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameFirst.TabIndex = 3;
            // 
            // textBoxNameLast
            // 
            this.textBoxNameLast.Location = new System.Drawing.Point(51, 82);
            this.textBoxNameLast.Name = "textBoxNameLast";
            this.textBoxNameLast.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameLast.TabIndex = 4;
            // 
            // buttonForm1Next
            // 
            this.buttonForm1Next.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForm1Next.Location = new System.Drawing.Point(174, 266);
            this.buttonForm1Next.Name = "buttonForm1Next";
            this.buttonForm1Next.Size = new System.Drawing.Size(194, 23);
            this.buttonForm1Next.TabIndex = 8;
            this.buttonForm1Next.Text = "Next";
            this.buttonForm1Next.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.textBoxAddressState);
            this.groupBoxAddress.Controls.Add(this.textBoxAddressCity);
            this.groupBoxAddress.Controls.Add(this.textBoxAddressStreet);
            this.groupBoxAddress.Controls.Add(this.labelAddressState);
            this.groupBoxAddress.Controls.Add(this.labelAddressCity);
            this.groupBoxAddress.Controls.Add(this.labeladdressStreet);
            this.groupBoxAddress.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddress.Location = new System.Drawing.Point(226, 12);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(272, 163);
            this.groupBoxAddress.TabIndex = 6;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Address";
            // 
            // labeladdressStreet
            // 
            this.labeladdressStreet.AutoSize = true;
            this.labeladdressStreet.Location = new System.Drawing.Point(38, 41);
            this.labeladdressStreet.Name = "labeladdressStreet";
            this.labeladdressStreet.Size = new System.Drawing.Size(36, 15);
            this.labeladdressStreet.TabIndex = 0;
            this.labeladdressStreet.Text = "Street";
            // 
            // labelAddressCity
            // 
            this.labelAddressCity.AutoSize = true;
            this.labelAddressCity.Location = new System.Drawing.Point(38, 82);
            this.labelAddressCity.Name = "labelAddressCity";
            this.labelAddressCity.Size = new System.Drawing.Size(28, 15);
            this.labelAddressCity.TabIndex = 1;
            this.labelAddressCity.Text = "City";
            // 
            // labelAddressState
            // 
            this.labelAddressState.AutoSize = true;
            this.labelAddressState.Location = new System.Drawing.Point(38, 122);
            this.labelAddressState.Name = "labelAddressState";
            this.labelAddressState.Size = new System.Drawing.Size(32, 15);
            this.labelAddressState.TabIndex = 7;
            this.labelAddressState.Text = "State";
            // 
            // textBoxAddressStreet
            // 
            this.textBoxAddressStreet.Location = new System.Drawing.Point(107, 34);
            this.textBoxAddressStreet.Name = "textBoxAddressStreet";
            this.textBoxAddressStreet.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddressStreet.TabIndex = 5;
            // 
            // textBoxAddressCity
            // 
            this.textBoxAddressCity.Location = new System.Drawing.Point(107, 75);
            this.textBoxAddressCity.Name = "textBoxAddressCity";
            this.textBoxAddressCity.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddressCity.TabIndex = 6;
            // 
            // textBoxAddressState
            // 
            this.textBoxAddressState.Location = new System.Drawing.Point(107, 115);
            this.textBoxAddressState.Name = "textBoxAddressState";
            this.textBoxAddressState.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddressState.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 403);
            this.Controls.Add(this.buttonForm1Next);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.groupBoxName);
            this.Name = "Form1";
            this.Text = "Day 2: GroupBox, Panels, Events, and New Forms";
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.TextBox textBoxNameLast;
        private System.Windows.Forms.TextBox textBoxNameFirst;
        private System.Windows.Forms.Label labelNameLast;
        private System.Windows.Forms.Label labelNameFirst;
        private System.Windows.Forms.Button buttonForm1Next;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.TextBox textBoxAddressState;
        private System.Windows.Forms.TextBox textBoxAddressCity;
        private System.Windows.Forms.TextBox textBoxAddressStreet;
        private System.Windows.Forms.Label labelAddressState;
        private System.Windows.Forms.Label labelAddressCity;
        private System.Windows.Forms.Label labeladdressStreet;
    }
}

