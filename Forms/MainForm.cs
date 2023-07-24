using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchoPA
{
    public partial class MainForm : Form
    {
        //
        // Main Form Constructor
        //
        public MainForm()
        {
            InitializeComponent();
            PartsDG.DataSource = Inventory.AllParts;
            ProductsDG.DataSource = Inventory.Products;
            ModifyPartButton.Enabled = allowPartModDel();
            DeletePartButton.Enabled = allowPartModDel();
            ModifyProductButton.Enabled = allowProdModDel();
            DeleteProductButton.Enabled = allowProdModDel();
        }
        //
        //used to determine if the program should add/modify in the part/product forms save buttons
        //
        public static bool add_mod;
        //
        // Used to check if the Part Modify and Delete Buttons should be enabled
        //
        private bool allowPartModDel()
        {
            return PartsDG.CurrentRow != null;
        }
        //
        // Used to check if the Product Modify and Delete Buttons should be enabled
        //
        private bool allowProdModDel()
        {
            return ProductsDG.CurrentRow != null;
        }
        //
        //Closes the program
        //
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //Opens the Add Part Form & Hides the Main Form
        //
        private void AddPartButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            add_mod = true;

            var openform = new PartForm();
            openform.Show();
        }
        //
        //Opens the Part Form using the Modify Constructor to populate the textbox fields & Hides the Main Form (using Lookuppart only for class)
        //
        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
                this.Hide();

                add_mod = false;

                Part modify = PartsDG.CurrentRow.DataBoundItem as Part;
                var openform = new PartForm(Inventory.lookupPart(modify.PartID));
                openform.Show();
        }
        //
        //Opens the Add Product Form & Hides the Main Form
        //
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            add_mod = true;

            var openform = new ProductForm();
            openform.Show();
        }
        //
        //Opens the Product Form using the Modify Constructor to populate the textbox fields & Hides the Main Form (using lookup product only for class)
        //
        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            add_mod = false;

            Product modify = ProductsDG.CurrentRow.DataBoundItem as Product;
            var openform = new ProductForm(Inventory.lookupProduct(modify.ProductID));
            openform.Show();
        }
        //
        //clears automatic row selection from datagrids when loaded
        //
        private void DGBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PartsDG.ClearSelection();
            ProductsDG.ClearSelection();
        }
        //
        //prompts user if they would like to delete the selected row and deletes it if true
        //
        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you would like to delete the Part with the PartID #" + PartsDG.CurrentRow.Cells["PartId"].Value + " from the database?";
            string title = "Delete Part";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Part remove = PartsDG.CurrentRow.DataBoundItem as Part;
                bool delete = Inventory.deletePart(remove);
                PartsDG.ClearSelection();
                DeletePartButton.Enabled = allowPartModDel();
                if (delete == false)
                {
                    MessageBox.Show("Selected Part was not deleted Properly.");
                }
            }
            else
            {
                PartsDG.ClearSelection();
                DeletePartButton.Enabled = allowPartModDel();
                return;
            }
        }
        //
        //prompts user if they would like to delete the selected row and deletes it if true
        //
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            Product checkNoAssParts = ProductsDG.CurrentRow.DataBoundItem as Product;
            BindingList<Part> HasAssParts = checkNoAssParts.GetAssociatedParts();
            if (HasAssParts.Count > 0)
            {
                MessageBox.Show("Cannot Delete Product because Product has Parts Associated with it.");
            }
            else
            {
                string message = "Are you sure you would like to delete the Product with ProductID#" + ProductsDG.CurrentRow.Cells["ProductId"].Value + " from the database?";
                string title = "Delete Product";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Product remove = ProductsDG.CurrentRow.DataBoundItem as Product;
                    bool delete = Inventory.removeProduct(remove.ProductID);
                    if (delete == false)
                    {
                        MessageBox.Show("Selected Product was not deleted Properly.");
                    }
                }
                else
                {
                    return;
                }
            }
        }
        //
        // Enables the Part Modify/Delete buttons when a user selects a cell(row)
        //
        private void PartsDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyPartButton.Enabled = allowPartModDel();
            DeletePartButton.Enabled = allowPartModDel();
        }
        //
        // Enabled the Product Modify/Delete buttons when a user selects a cell(row)
        //
        private void ProductsDG_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ModifyProductButton.Enabled = allowProdModDel();
            DeleteProductButton.Enabled = allowProdModDel();
        }
        //
        // Checks the text in the Search Textbox and highlights all cells that have an instance of that text in the Parts DataGridView
        //
        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            PartsDG.ClearSelection();
            PartsDG.DefaultCellStyle.SelectionBackColor = Color.Gray;
            bool found = false;
            if (PartSearchTB.Text != "")
            {
                for (var i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].PartID.ToString().Contains(PartSearchTB.Text.ToString()))
                    {
                        PartsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(PartSearchTB.Text.ToUpper()))
                    {
                        PartsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.AllParts[i].Price.ToString().Contains(PartSearchTB.Text.ToString()))
                    {
                        PartsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.AllParts[i].InStock.ToString().Contains(PartSearchTB.Text.ToString()))
                    {
                        PartsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.AllParts[i].Min.ToString().Contains(PartSearchTB.Text.ToString()))
                    {
                        PartsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.AllParts[i].Max.ToString().Contains(PartSearchTB.Text.ToString()))
                    {
                        PartsDG.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("No Results Found.");
            }
        }
        //
        // Checks the text in the Search Textbox and highlights all cells that have an instance of that text in the Products DataGridView
        //
        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            ProductsDG.ClearSelection();
            ProductsDG.DefaultCellStyle.SelectionBackColor = Color.Gray;
            bool found = false;
            if (ProductSearchTB.Text != "")
            {
                for (var i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].ProductID.ToString().Contains(ProductSearchTB.Text.ToString()))
                    {
                        ProductsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.Products[i].Name.ToUpper().Contains(ProductSearchTB.Text.ToUpper()))
                    {
                        ProductsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.Products[i].Price.ToString().Contains(ProductSearchTB.Text.ToString()))
                    {
                        ProductsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.Products[i].InStock.ToString().Contains(ProductSearchTB.Text.ToString()))
                    {
                        ProductsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.Products[i].Min.ToString().Contains(ProductSearchTB.Text.ToString()))
                    {
                        ProductsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.Products[i].Max.ToString().Contains(ProductSearchTB.Text.ToString()))
                    {
                        ProductsDG.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("No Results Found.");
            }
        }
    }
}

