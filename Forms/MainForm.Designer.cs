
namespace BatchoPA
{
    partial class MainForm
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
            this.PartsDG = new System.Windows.Forms.DataGridView();
            this.ProductsDG = new System.Windows.Forms.DataGridView();
            this.PartDGLabel = new System.Windows.Forms.Label();
            this.ProductDGLabel = new System.Windows.Forms.Label();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.SearchPartButton = new System.Windows.Forms.Button();
            this.SearchProductButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PartSearchTB = new System.Windows.Forms.TextBox();
            this.ProductSearchTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // PartsDG
            // 
            this.PartsDG.AllowUserToAddRows = false;
            this.PartsDG.AllowUserToDeleteRows = false;
            this.PartsDG.AllowUserToResizeColumns = false;
            this.PartsDG.AllowUserToResizeRows = false;
            this.PartsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDG.Location = new System.Drawing.Point(40, 119);
            this.PartsDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PartsDG.MultiSelect = false;
            this.PartsDG.Name = "PartsDG";
            this.PartsDG.ReadOnly = true;
            this.PartsDG.RowHeadersVisible = false;
            this.PartsDG.RowHeadersWidth = 51;
            this.PartsDG.RowTemplate.Height = 24;
            this.PartsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDG.Size = new System.Drawing.Size(459, 246);
            this.PartsDG.TabIndex = 1;
            this.PartsDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDG_CellClick);
            this.PartsDG.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGBindingComplete);
            // 
            // ProductsDG
            // 
            this.ProductsDG.AllowUserToAddRows = false;
            this.ProductsDG.AllowUserToDeleteRows = false;
            this.ProductsDG.AllowUserToResizeColumns = false;
            this.ProductsDG.AllowUserToResizeRows = false;
            this.ProductsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDG.Location = new System.Drawing.Point(667, 119);
            this.ProductsDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductsDG.MultiSelect = false;
            this.ProductsDG.Name = "ProductsDG";
            this.ProductsDG.ReadOnly = true;
            this.ProductsDG.RowHeadersVisible = false;
            this.ProductsDG.RowHeadersWidth = 51;
            this.ProductsDG.RowTemplate.Height = 24;
            this.ProductsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDG.Size = new System.Drawing.Size(459, 246);
            this.ProductsDG.TabIndex = 2;
            this.ProductsDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDG_CellClick_1);
            this.ProductsDG.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGBindingComplete);
            // 
            // PartDGLabel
            // 
            this.PartDGLabel.AutoSize = true;
            this.PartDGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDGLabel.Location = new System.Drawing.Point(40, 96);
            this.PartDGLabel.Name = "PartDGLabel";
            this.PartDGLabel.Size = new System.Drawing.Size(61, 20);
            this.PartDGLabel.TabIndex = 3;
            this.PartDGLabel.Text = "Part(s)";
            // 
            // ProductDGLabel
            // 
            this.ProductDGLabel.AutoSize = true;
            this.ProductDGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGLabel.Location = new System.Drawing.Point(667, 96);
            this.ProductDGLabel.Name = "ProductDGLabel";
            this.ProductDGLabel.Size = new System.Drawing.Size(88, 20);
            this.ProductDGLabel.TabIndex = 4;
            this.ProductDGLabel.Text = "Product(s)";
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(248, 370);
            this.AddPartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 27);
            this.AddPartButton.TabIndex = 5;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.Location = new System.Drawing.Point(329, 370);
            this.ModifyPartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(75, 27);
            this.ModifyPartButton.TabIndex = 6;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Location = new System.Drawing.Point(411, 370);
            this.DeletePartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(75, 27);
            this.DeletePartButton.TabIndex = 7;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(1031, 370);
            this.DeleteProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(75, 27);
            this.DeleteProductButton.TabIndex = 10;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.Location = new System.Drawing.Point(949, 370);
            this.ModifyProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(75, 27);
            this.ModifyProductButton.TabIndex = 9;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(869, 370);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 27);
            this.AddProductButton.TabIndex = 8;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // SearchPartButton
            // 
            this.SearchPartButton.Location = new System.Drawing.Point(242, 86);
            this.SearchPartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchPartButton.Name = "SearchPartButton";
            this.SearchPartButton.Size = new System.Drawing.Size(75, 27);
            this.SearchPartButton.TabIndex = 11;
            this.SearchPartButton.Text = "Search";
            this.SearchPartButton.UseVisualStyleBackColor = true;
            this.SearchPartButton.Click += new System.EventHandler(this.SearchPartButton_Click);
            // 
            // SearchProductButton
            // 
            this.SearchProductButton.Location = new System.Drawing.Point(869, 86);
            this.SearchProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchProductButton.Name = "SearchProductButton";
            this.SearchProductButton.Size = new System.Drawing.Size(75, 27);
            this.SearchProductButton.TabIndex = 12;
            this.SearchProductButton.Text = "Search";
            this.SearchProductButton.UseVisualStyleBackColor = true;
            this.SearchProductButton.Click += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1088, 490);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 27);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PartSearchTB
            // 
            this.PartSearchTB.Location = new System.Drawing.Point(323, 88);
            this.PartSearchTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PartSearchTB.Name = "PartSearchTB";
            this.PartSearchTB.Size = new System.Drawing.Size(176, 22);
            this.PartSearchTB.TabIndex = 14;
            // 
            // ProductSearchTB
            // 
            this.ProductSearchTB.Location = new System.Drawing.Point(949, 88);
            this.ProductSearchTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductSearchTB.Name = "ProductSearchTB";
            this.ProductSearchTB.Size = new System.Drawing.Size(176, 22);
            this.ProductSearchTB.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 529);
            this.Controls.Add(this.ProductSearchTB);
            this.Controls.Add(this.PartSearchTB);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchProductButton);
            this.Controls.Add(this.SearchPartButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ModifyProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.ModifyPartButton);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.ProductDGLabel);
            this.Controls.Add(this.PartDGLabel);
            this.Controls.Add(this.ProductsDG);
            this.Controls.Add(this.PartsDG);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.PartsDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PartsDG;
        private System.Windows.Forms.DataGridView ProductsDG;
        private System.Windows.Forms.Label PartDGLabel;
        private System.Windows.Forms.Label ProductDGLabel;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button SearchPartButton;
        private System.Windows.Forms.Button SearchProductButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox PartSearchTB;
        private System.Windows.Forms.TextBox ProductSearchTB;
    }
}

