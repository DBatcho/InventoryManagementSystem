
namespace BatchoPA
{
    partial class PartForm
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
            this.PartHeaderLabel = new System.Windows.Forms.Label();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.PriceCostLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MachCompLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.InventoryTB = new System.Windows.Forms.TextBox();
            this.PCTB = new System.Windows.Forms.TextBox();
            this.MachCompTB = new System.Windows.Forms.TextBox();
            this.MaxTB = new System.Windows.Forms.TextBox();
            this.MinTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PartHeaderLabel
            // 
            this.PartHeaderLabel.AutoSize = true;
            this.PartHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartHeaderLabel.Location = new System.Drawing.Point(13, 13);
            this.PartHeaderLabel.Name = "PartHeaderLabel";
            this.PartHeaderLabel.Size = new System.Drawing.Size(88, 25);
            this.PartHeaderLabel.TabIndex = 0;
            this.PartHeaderLabel.Text = "Add Part";
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Location = new System.Drawing.Point(132, 16);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(86, 21);
            this.InHouseRadio.TabIndex = 1;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            this.InHouseRadio.Click += new System.EventHandler(this.InOutRadio_Click);
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(237, 16);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(103, 21);
            this.OutsourcedRadio.TabIndex = 2;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.Click += new System.EventHandler(this.InOutRadio_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(71, 73);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(26, 20);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(44, 138);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 20);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLabel.Location = new System.Drawing.Point(21, 203);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(76, 20);
            this.InventoryLabel.TabIndex = 5;
            this.InventoryLabel.Text = "Inventory";
            // 
            // PriceCostLabel
            // 
            this.PriceCostLabel.AutoSize = true;
            this.PriceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCostLabel.Location = new System.Drawing.Point(-1, 268);
            this.PriceCostLabel.Name = "PriceCostLabel";
            this.PriceCostLabel.Size = new System.Drawing.Size(98, 20);
            this.PriceCostLabel.TabIndex = 6;
            this.PriceCostLabel.Text = "Price / Cost";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLabel.Location = new System.Drawing.Point(25, 333);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(40, 20);
            this.MaxLabel.TabIndex = 7;
            this.MaxLabel.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLabel.Location = new System.Drawing.Point(180, 333);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(36, 20);
            this.MinLabel.TabIndex = 8;
            this.MinLabel.Text = "Min";
            // 
            // MachCompLabel
            // 
            this.MachCompLabel.AutoSize = true;
            this.MachCompLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachCompLabel.Location = new System.Drawing.Point(3, 398);
            this.MachCompLabel.Name = "MachCompLabel";
            this.MachCompLabel.Size = new System.Drawing.Size(128, 20);
            this.MachCompLabel.TabIndex = 9;
            this.MachCompLabel.Text = "Company Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(183, 466);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 27);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(265, 466);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 27);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IDTB
            // 
            this.IDTB.Enabled = false;
            this.IDTB.Location = new System.Drawing.Point(112, 70);
            this.IDTB.Name = "IDTB";
            this.IDTB.ReadOnly = true;
            this.IDTB.Size = new System.Drawing.Size(214, 22);
            this.IDTB.TabIndex = 12;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(112, 141);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(214, 22);
            this.NameTB.TabIndex = 13;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // InventoryTB
            // 
            this.InventoryTB.Location = new System.Drawing.Point(111, 201);
            this.InventoryTB.Name = "InventoryTB";
            this.InventoryTB.Size = new System.Drawing.Size(214, 22);
            this.InventoryTB.TabIndex = 14;
            this.InventoryTB.TextChanged += new System.EventHandler(this.InventoryTB_TextChanged);
            // 
            // PCTB
            // 
            this.PCTB.Location = new System.Drawing.Point(112, 266);
            this.PCTB.Name = "PCTB";
            this.PCTB.Size = new System.Drawing.Size(214, 22);
            this.PCTB.TabIndex = 15;
            this.PCTB.TextChanged += new System.EventHandler(this.PCTB_TextChanged);
            // 
            // MachCompTB
            // 
            this.MachCompTB.Location = new System.Drawing.Point(158, 398);
            this.MachCompTB.Name = "MachCompTB";
            this.MachCompTB.Size = new System.Drawing.Size(214, 22);
            this.MachCompTB.TabIndex = 18;
            this.MachCompTB.TextChanged += new System.EventHandler(this.MachCompTB_TextChanged);
            // 
            // MaxTB
            // 
            this.MaxTB.Location = new System.Drawing.Point(71, 332);
            this.MaxTB.Name = "MaxTB";
            this.MaxTB.Size = new System.Drawing.Size(89, 22);
            this.MaxTB.TabIndex = 16;
            this.MaxTB.TextChanged += new System.EventHandler(this.MaxTB_TextChanged);
            // 
            // MinTB
            // 
            this.MinTB.Location = new System.Drawing.Point(219, 332);
            this.MinTB.Name = "MinTB";
            this.MinTB.Size = new System.Drawing.Size(89, 22);
            this.MinTB.TabIndex = 17;
            this.MinTB.TextChanged += new System.EventHandler(this.MinTB_TextChanged);
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 521);
            this.Controls.Add(this.MinTB);
            this.Controls.Add(this.MaxTB);
            this.Controls.Add(this.MachCompTB);
            this.Controls.Add(this.PCTB);
            this.Controls.Add(this.InventoryTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MachCompLabel);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.PriceCostLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InHouseRadio);
            this.Controls.Add(this.PartHeaderLabel);
            this.Name = "PartForm";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PartHeaderLabel;
        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label PriceCostLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MachCompLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox InventoryTB;
        private System.Windows.Forms.TextBox PCTB;
        private System.Windows.Forms.TextBox MachCompTB;
        private System.Windows.Forms.TextBox MaxTB;
        private System.Windows.Forms.TextBox MinTB;
    }
}