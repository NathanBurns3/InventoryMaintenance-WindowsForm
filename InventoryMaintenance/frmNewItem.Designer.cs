namespace InventoryMaintenance
{
    partial class frmNewItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboSizeOrManufacturer = new System.Windows.Forms.ComboBox();
            this.lblSizeOrManufacturer = new System.Windows.Forms.Label();
            this.rdoPlant = new System.Windows.Forms.RadioButton();
            this.rdoSupply = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item no:";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(201, 100);
            this.txtItemNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(193, 39);
            this.txtItemNo.TabIndex = 3;
            this.txtItemNo.Tag = "Item no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(201, 162);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(349, 39);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Tag = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(201, 290);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(193, 39);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Tag = "Price";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 384);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 53);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(407, 384);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 53);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboSizeOrManufacturer
            // 
            this.cboSizeOrManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSizeOrManufacturer.FormattingEnabled = true;
            this.cboSizeOrManufacturer.Location = new System.Drawing.Point(201, 226);
            this.cboSizeOrManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.cboSizeOrManufacturer.Name = "cboSizeOrManufacturer";
            this.cboSizeOrManufacturer.Size = new System.Drawing.Size(236, 40);
            this.cboSizeOrManufacturer.TabIndex = 7;
            // 
            // lblSizeOrManufacturer
            // 
            this.lblSizeOrManufacturer.AutoSize = true;
            this.lblSizeOrManufacturer.Location = new System.Drawing.Point(33, 228);
            this.lblSizeOrManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSizeOrManufacturer.Name = "lblSizeOrManufacturer";
            this.lblSizeOrManufacturer.Size = new System.Drawing.Size(62, 32);
            this.lblSizeOrManufacturer.TabIndex = 9;
            this.lblSizeOrManufacturer.Text = "Size:";
            // 
            // rdoPlant
            // 
            this.rdoPlant.AutoSize = true;
            this.rdoPlant.Checked = true;
            this.rdoPlant.Location = new System.Drawing.Point(201, 30);
            this.rdoPlant.Margin = new System.Windows.Forms.Padding(4);
            this.rdoPlant.Name = "rdoPlant";
            this.rdoPlant.Size = new System.Drawing.Size(98, 36);
            this.rdoPlant.TabIndex = 0;
            this.rdoPlant.TabStop = true;
            this.rdoPlant.Text = "Plant";
            this.rdoPlant.UseVisualStyleBackColor = true;
            this.rdoPlant.CheckedChanged += new System.EventHandler(this.rdoPlant_CheckedChanged);
            // 
            // rdoSupply
            // 
            this.rdoSupply.AutoSize = true;
            this.rdoSupply.Location = new System.Drawing.Point(357, 30);
            this.rdoSupply.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSupply.Name = "rdoSupply";
            this.rdoSupply.Size = new System.Drawing.Size(118, 36);
            this.rdoSupply.TabIndex = 1;
            this.rdoSupply.TabStop = true;
            this.rdoSupply.Text = "Supply";
            this.rdoSupply.UseVisualStyleBackColor = true;
            // 
            // frmNewItem
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(636, 498);
            this.ControlBox = false;
            this.Controls.Add(this.rdoSupply);
            this.Controls.Add(this.rdoPlant);
            this.Controls.Add(this.lblSizeOrManufacturer);
            this.Controls.Add(this.cboSizeOrManufacturer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Inventory Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboSizeOrManufacturer;
        private System.Windows.Forms.Label lblSizeOrManufacturer;
        private System.Windows.Forms.RadioButton rdoPlant;
        private System.Windows.Forms.RadioButton rdoSupply;
    }
}