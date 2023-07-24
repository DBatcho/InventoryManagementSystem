
namespace BatchoPA
{
    partial class ProductForm
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
            this.ProductHeaderLabel = new System.Windows.Forms.Label();
            this.MinTB = new System.Windows.Forms.TextBox();
            this.MaxTB = new System.Windows.Forms.TextBox();
            this.PCTB = new System.Windows.Forms.TextBox();
            this.InventoryTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.PriceCostLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CanPartsDG = new System.Windows.Forms.DataGridView();
            this.CanPartDGLabel = new System.Windows.Forms.Label();
            this.CanPartSearchTB = new System.Windows.Forms.TextBox();
            this.SearchCanPartButton = new System.Windows.Forms.Button();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PartAssLabel = new System.Windows.Forms.Label();
            this.PartAssDG = new System.Windows.Forms.DataGridView();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CanPartsDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartAssDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductHeaderLabel
            // 
            this.ProductHeaderLabel.AutoSize = true;
            this.ProductHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductHeaderLabel.Location = new System.Drawing.Point(13, 13);
            this.ProductHeaderLabel.Name = "ProductHeaderLabel";
            this.ProductHeaderLabel.Size = new System.Drawing.Size(120, 25);
            this.ProductHeaderLabel.TabIndex = 0;
            this.ProductHeaderLabel.Text = "Add Product";
            // 
            // MinTB
            // 
            this.MinTB.Location = new System.Drawing.Point(288, 513);
            this.MinTB.Name = "MinTB";
            this.MinTB.Size = new System.Drawing.Size(89, 22);
            this.MinTB.TabIndex = 32;
            this.MinTB.TextChanged += new System.EventHandler(this.MinTB_TextChanged);
            // 
            // MaxTB
            // 
            this.MaxTB.Location = new System.Drawing.Point(140, 513);
            this.MaxTB.Name = "MaxTB";
            this.MaxTB.Size = new System.Drawing.Size(89, 22);
            this.MaxTB.TabIndex = 31;
            this.MaxTB.TextChanged += new System.EventHandler(this.MaxTB_TextChanged);
            // 
            // PCTB
            // 
            this.PCTB.Location = new System.Drawing.Point(173, 447);
            this.PCTB.Name = "PCTB";
            this.PCTB.Size = new System.Drawing.Size(214, 22);
            this.PCTB.TabIndex = 29;
            this.PCTB.TextChanged += new System.EventHandler(this.PCTB_TextChanged);
            // 
            // InventoryTB
            // 
            this.InventoryTB.Location = new System.Drawing.Point(172, 382);
            this.InventoryTB.Name = "InventoryTB";
            this.InventoryTB.Size = new System.Drawing.Size(214, 22);
            this.InventoryTB.TabIndex = 28;
            this.InventoryTB.TextChanged += new System.EventHandler(this.InventoryTB_TextChanged);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(173, 317);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(214, 22);
            this.NameTB.TabIndex = 27;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // IDTB
            // 
            this.IDTB.BackColor = System.Drawing.SystemColors.Control;
            this.IDTB.Enabled = false;
            this.IDTB.Location = new System.Drawing.Point(173, 251);
            this.IDTB.Name = "IDTB";
            this.IDTB.ReadOnly = true;
            this.IDTB.Size = new System.Drawing.Size(214, 22);
            this.IDTB.TabIndex = 26;
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLabel.Location = new System.Drawing.Point(249, 514);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(36, 20);
            this.MinLabel.TabIndex = 24;
            this.MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLabel.Location = new System.Drawing.Point(94, 514);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(40, 20);
            this.MaxLabel.TabIndex = 23;
            this.MaxLabel.Text = "Max";
            // 
            // PriceCostLabel
            // 
            this.PriceCostLabel.AutoSize = true;
            this.PriceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCostLabel.Location = new System.Drawing.Point(68, 449);
            this.PriceCostLabel.Name = "PriceCostLabel";
            this.PriceCostLabel.Size = new System.Drawing.Size(98, 20);
            this.PriceCostLabel.TabIndex = 22;
            this.PriceCostLabel.Text = "Price / Cost";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLabel.Location = new System.Drawing.Point(90, 384);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(76, 20);
            this.InventoryLabel.TabIndex = 21;
            this.InventoryLabel.Text = "Inventory";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(113, 319);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 20);
            this.NameLabel.TabIndex = 20;
            this.NameLabel.Text = "Name";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(140, 254);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(26, 20);
            this.IDLabel.TabIndex = 19;
            this.IDLabel.Text = "ID";
            // 
            // CanPartsDG
            // 
            this.CanPartsDG.AllowUserToAddRows = false;
            this.CanPartsDG.AllowUserToDeleteRows = false;
            this.CanPartsDG.AllowUserToResizeColumns = false;
            this.CanPartsDG.AllowUserToResizeRows = false;
            this.CanPartsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CanPartsDG.Location = new System.Drawing.Point(543, 107);
            this.CanPartsDG.MultiSelect = false;
            this.CanPartsDG.Name = "CanPartsDG";
            this.CanPartsDG.ReadOnly = true;
            this.CanPartsDG.RowHeadersVisible = false;
            this.CanPartsDG.RowHeadersWidth = 51;
            this.CanPartsDG.RowTemplate.Height = 24;
            this.CanPartsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CanPartsDG.Size = new System.Drawing.Size(459, 246);
            this.CanPartsDG.TabIndex = 33;
            this.CanPartsDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CanPartsDG_CellClick);
            this.CanPartsDG.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGBindingComplete);
            // 
            // CanPartDGLabel
            // 
            this.CanPartDGLabel.AutoSize = true;
            this.CanPartDGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanPartDGLabel.Location = new System.Drawing.Point(539, 84);
            this.CanPartDGLabel.Name = "CanPartDGLabel";
            this.CanPartDGLabel.Size = new System.Drawing.Size(165, 20);
            this.CanPartDGLabel.TabIndex = 34;
            this.CanPartDGLabel.Text = "All Candidate Part(s)";
            // 
            // CanPartSearchTB
            // 
            this.CanPartSearchTB.Location = new System.Drawing.Point(826, 70);
            this.CanPartSearchTB.Name = "CanPartSearchTB";
            this.CanPartSearchTB.Size = new System.Drawing.Size(176, 22);
            this.CanPartSearchTB.TabIndex = 36;
            // 
            // SearchCanPartButton
            // 
            this.SearchCanPartButton.Location = new System.Drawing.Point(744, 70);
            this.SearchCanPartButton.Name = "SearchCanPartButton";
            this.SearchCanPartButton.Size = new System.Drawing.Size(75, 27);
            this.SearchCanPartButton.TabIndex = 35;
            this.SearchCanPartButton.Text = "Search";
            this.SearchCanPartButton.UseVisualStyleBackColor = true;
            this.SearchCanPartButton.Click += new System.EventHandler(this.SearchCanPartButton_Click);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(911, 359);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 27);
            this.AddPartButton.TabIndex = 37;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(911, 679);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 27);
            this.DeleteButton.TabIndex = 42;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PartAssLabel
            // 
            this.PartAssLabel.AutoSize = true;
            this.PartAssLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartAssLabel.Location = new System.Drawing.Point(539, 404);
            this.PartAssLabel.Name = "PartAssLabel";
            this.PartAssLabel.Size = new System.Drawing.Size(279, 20);
            this.PartAssLabel.TabIndex = 39;
            this.PartAssLabel.Text = "Part(s) Associated with this Product";
            // 
            // PartAssDG
            // 
            this.PartAssDG.AllowUserToAddRows = false;
            this.PartAssDG.AllowUserToDeleteRows = false;
            this.PartAssDG.AllowUserToResizeColumns = false;
            this.PartAssDG.AllowUserToResizeRows = false;
            this.PartAssDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartAssDG.Location = new System.Drawing.Point(543, 427);
            this.PartAssDG.MultiSelect = false;
            this.PartAssDG.Name = "PartAssDG";
            this.PartAssDG.ReadOnly = true;
            this.PartAssDG.RowHeadersVisible = false;
            this.PartAssDG.RowHeadersWidth = 51;
            this.PartAssDG.RowTemplate.Height = 24;
            this.PartAssDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartAssDG.Size = new System.Drawing.Size(459, 246);
            this.PartAssDG.TabIndex = 38;
            this.PartAssDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartAssDG_CellClick);
            this.PartAssDG.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGBindingComplete);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(985, 742);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 27);
            this.CancelButton.TabIndex = 44;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(903, 742);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 27);
            this.SaveButton.TabIndex = 43;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 781);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PartAssLabel);
            this.Controls.Add(this.PartAssDG);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.CanPartSearchTB);
            this.Controls.Add(this.SearchCanPartButton);
            this.Controls.Add(this.CanPartDGLabel);
            this.Controls.Add(this.CanPartsDG);
            this.Controls.Add(this.MinTB);
            this.Controls.Add(this.MaxTB);
            this.Controls.Add(this.PCTB);
            this.Controls.Add(this.InventoryTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.PriceCostLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.ProductHeaderLabel);
            this.Name = "ProductForm";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.CanPartsDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartAssDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductHeaderLabel;
        private System.Windows.Forms.TextBox MinTB;
        private System.Windows.Forms.TextBox MaxTB;
        private System.Windows.Forms.TextBox PCTB;
        private System.Windows.Forms.TextBox InventoryTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label PriceCostLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.DataGridView CanPartsDG;
        private System.Windows.Forms.Label CanPartDGLabel;
        private System.Windows.Forms.TextBox CanPartSearchTB;
        private System.Windows.Forms.Button SearchCanPartButton;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label PartAssLabel;
        private System.Windows.Forms.DataGridView PartAssDG;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}