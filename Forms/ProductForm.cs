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
    public partial class ProductForm : Form
    {
        // Used to datasource PartAssDG and when saving
        public BindingList<Part> PartAss = new BindingList<Part>();
        //Used when modifying so the cancel button works correctly
        public BindingList<Part> Temp = new BindingList<Part>();
        //
        //Constructor when Add Button is used in MainForm
        //
        public ProductForm()
        {
            InitializeComponent();
            CanPartsDG.DataSource = Inventory.AllParts;
            PartAssDG.DataSource = Temp;
            SaveButton.Enabled = allowSave();
            AddPartButton.Enabled = allowAdd();
            DeleteButton.Enabled = allowDelete();
            NameTB.BackColor = System.Drawing.Color.Salmon;
            InventoryTB.BackColor = System.Drawing.Color.Salmon;
            PCTB.BackColor = System.Drawing.Color.Salmon;
            MinTB.BackColor = System.Drawing.Color.Salmon;
            MaxTB.BackColor = System.Drawing.Color.Salmon;
        }
        //
        //Constructor used to load the PartForm when Modify Button Clicked in MainForm
        //
        public ProductForm(Product modify)
        {
            InitializeComponent();
            CanPartsDG.DataSource = Inventory.AllParts;
            PartAss = modify.GetAssociatedParts();
            for (var i = 0; i < PartAss.Count; i++)
            {
                Temp.Add(PartAss[i]);
            }
            PartAssDG.DataSource = Temp;
            SaveButton.Enabled = allowSave();
            AddPartButton.Enabled = allowAdd();
            DeleteButton.Enabled = allowDelete();
            IDTB.Text = modify.ProductID.ToString();
            NameTB.Text = modify.Name;
            PCTB.Text = modify.Price.ToString();
            InventoryTB.Text = modify.InStock.ToString();
            MinTB.Text = modify.Min.ToString();
            MaxTB.Text = modify.Max.ToString();
        }
        //
        // Used to check if Save Button should be enabled
        //
        private bool allowSave()
        {
            int inum;
            decimal dnum;
            //returns true if name textbox has value in it
            return !string.IsNullOrWhiteSpace(NameTB.Text) &&

                // returns true if Inventory textbox has value & is int
                !string.IsNullOrWhiteSpace(InventoryTB.Text) && (Int32.TryParse(InventoryTB.Text, out inum)) &&

                // returns true if Price/Cost textbox has value & is decimal
                !string.IsNullOrWhiteSpace(PCTB.Text) && (decimal.TryParse(PCTB.Text, out dnum)) &&

                // returns true if Max textbox has value & is int
                !string.IsNullOrWhiteSpace(MaxTB.Text) && (Int32.TryParse(MaxTB.Text, out inum)) &&

                // returns true if Min textbox has value & is int
                !string.IsNullOrWhiteSpace(MinTB.Text) && (Int32.TryParse(MinTB.Text, out inum)) &&

                // returns true if theres value in Min/Max text box and Max > Min
                Int32.Parse(MinTB.Text) < Int32.Parse(MaxTB.Text) &&

                // returns true if Min & Max are not equal
                Int32.Parse(MinTB.Text) != Int32.Parse(MaxTB.Text) &&

                //returns true if inventory falls within the min/max range
                Int32.Parse(InventoryTB.Text) <= Int32.Parse(MaxTB.Text) && Int32.Parse(InventoryTB.Text) >= Int32.Parse(MinTB.Text);
        }
        //
        // Used to check if Add Button should be enabled
        //
        private bool allowAdd()
        {
            return CanPartsDG.CurrentRow != null;
        }
        //
        // Used to check if Delete Button be enabled
        //
        private bool allowDelete()
        {
            return PartAssDG.CurrentRow != null;
        }
        //
        //Hides Product Form, Saves New Input Data to Product Class & Opens Main Form
        //
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (MainForm.add_mod == true)
            {
                Product insert;
                PartAss = Temp;
                insert = new Product(Product.ProductIDcount++, NameTB.Text, decimal.Parse(PCTB.Text), Int32.Parse(InventoryTB.Text), Int32.Parse(MinTB.Text),
                    Int32.Parse(MaxTB.Text), PartAss);
                Inventory.addProduct(insert);
            }
            else
            {
                Product insert;
                PartAss = Temp;
                insert = new Product(Int32.Parse(IDTB.Text), NameTB.Text, decimal.Parse(PCTB.Text), Int32.Parse(InventoryTB.Text), Int32.Parse(MinTB.Text), Int32.Parse(MaxTB.Text), PartAss);
                Inventory.updateProduct(Int32.Parse(IDTB.Text), insert);
            }
            PartAss.Clear();

            this.Hide();

            var openform = new MainForm();
            openform.Show();
        }
        //
        //Hides Product Form & Opens Main Form
        //
        private void CancelButton_Click(object sender, EventArgs e)
        {
            PartAssDG.DataSource = PartAss;

            this.Hide();

            var openform = new MainForm();
            openform.Show();
        }

        //
        //clears automatic row selection from datagrids when loaded
        //
        private void DGBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CanPartsDG.ClearSelection();
            PartAssDG.ClearSelection();
        }
        //
        // Adds a part from Candidate Parts to Associated Parts
        //
        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Part insert = CanPartsDG.CurrentRow.DataBoundItem as Part;
            Temp.Add(insert);
        }
        //
        // Removes an object from the Associated Parts
        //
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Part delete = PartAssDG.CurrentRow.DataBoundItem as Part;
            PartAssDG.Rows.Remove(PartAssDG.CurrentRow);
        }
        //
        // Enables the Add button for candidarte parts when a user selects a cell(row) in CanPartDG
        //
        private void CanPartsDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddPartButton.Enabled = allowAdd();
        }
        //
        // enables delete button for associated parts when a user selects a cell(row) in PartAssDG
        //
        private void PartAssDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteButton.Enabled = allowDelete();
        }
        //
        // Checks the text in the Search Textbox and highlights all cells that have an instance of that text in the Candidate Parts DataGridView
        //
        private void SearchCanPartButton_Click(object sender, EventArgs e)
        {
            CanPartsDG.ClearSelection();
            CanPartsDG.DefaultCellStyle.SelectionBackColor = Color.Gray;
            bool found = false;
            if (CanPartSearchTB.Text != "")
            {
                for (var i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].PartID.ToString().Contains(CanPartSearchTB.Text.ToString()))
                    {
                        CanPartsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(CanPartSearchTB.Text.ToUpper()))
                    {
                        CanPartsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.AllParts[i].Price.ToString().Contains(CanPartSearchTB.Text.ToString()))
                    {
                        CanPartsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.AllParts[i].InStock.ToString().Contains(CanPartSearchTB.Text.ToString()))
                    {
                        CanPartsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.AllParts[i].Min.ToString().Contains(CanPartSearchTB.Text.ToString()))
                    {
                        CanPartsDG.Rows[i].Selected = true;
                        found = true;
                    }
                    if (Inventory.AllParts[i].Max.ToString().Contains(CanPartSearchTB.Text.ToString()))
                    {
                        CanPartsDG.Rows[i].Selected = true;
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
        //Makes the textbox red when no data/wrong data is inputed & white when the correct data/data type is inputed
        //
        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTB.Text))
            {
                NameTB.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                NameTB.BackColor = System.Drawing.Color.White;
            }
        }
        //
        //Makes the textbox red when no data/wrong data is inputed & white when the correct data/data type is inputed
        //
        private void InventoryTB_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (string.IsNullOrWhiteSpace(InventoryTB.Text) || (!Int32.TryParse(InventoryTB.Text, out num)))
            {
                InventoryTB.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                InventoryTB.BackColor = System.Drawing.Color.White;
                if (!string.IsNullOrWhiteSpace(MinTB.Text) && !string.IsNullOrWhiteSpace(MaxTB.Text))
                {
                    if (Int32.Parse(MinTB.Text) < Int32.Parse(MaxTB.Text) && Int32.Parse(MinTB.Text) != Int32.Parse(MaxTB.Text))
                    {
                        if ((Int32.Parse(InventoryTB.Text) < Int32.Parse(MinTB.Text)) || (Int32.Parse(InventoryTB.Text) > Int32.Parse(MaxTB.Text)))
                        {
                            MessageBox.Show("Your Inventory must fall between the Minimum Inventory and the Maximum Inventory Numbers.");
                            InventoryTB.BackColor = System.Drawing.Color.Salmon;
                        }
                    }
                    else
                    {
                        MaxTB.BackColor = System.Drawing.Color.White;
                        MinTB.BackColor = System.Drawing.Color.White;
                    }
                }
            }
            SaveButton.Enabled = allowSave();
        }
        //
        //Makes the textbox red when no data/wrong data is inputed & white when the correct data/data type is inputed
        //
        private void PCTB_TextChanged(object sender, EventArgs e)
        {
            decimal num;
            if (string.IsNullOrWhiteSpace(PCTB.Text) || (!decimal.TryParse(PCTB.Text, out num)))
            {
                PCTB.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                PCTB.BackColor = System.Drawing.Color.White;
            }
            SaveButton.Enabled = allowSave();
        }
        //
        //Makes the textbox red when no data/wrong data is inputed & white when the correct data/data type is inputed
        //
        private void MaxTB_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (string.IsNullOrWhiteSpace(MaxTB.Text) || (!Int32.TryParse(MaxTB.Text, out num)))
            {
                MaxTB.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                MaxTB.BackColor = System.Drawing.Color.White;
                if (!string.IsNullOrWhiteSpace(MinTB.Text) && !string.IsNullOrWhiteSpace(MaxTB.Text))
                {
                    if (Int32.Parse(MinTB.Text) > (Int32.Parse(MaxTB.Text)))
                    {
                        MessageBox.Show("Max Inventory Number cannot be less than the Minimum Inventory Number.");
                        MaxTB.BackColor = System.Drawing.Color.Salmon;
                        MinTB.BackColor = System.Drawing.Color.Salmon;
                    }
                    else if (Int32.Parse(MinTB.Text) == Int32.Parse(MaxTB.Text))
                    {
                        MessageBox.Show("The Maximum Inventory Number and the Minimum Inventory Number cannot be equal.");
                        MaxTB.BackColor = System.Drawing.Color.Salmon;
                        MinTB.BackColor = System.Drawing.Color.Salmon;
                    }
                    else
                    {
                        MaxTB.BackColor = System.Drawing.Color.White;
                        MinTB.BackColor = System.Drawing.Color.White;
                        if (Int32.Parse(InventoryTB.Text) < Int32.Parse(MinTB.Text) || Int32.Parse(InventoryTB.Text) > Int32.Parse(MaxTB.Text))
                        {
                            MessageBox.Show("Your Inventory must fall between the Minimum Inventory and the Maximum Inventory Numbers.");
                            InventoryTB.BackColor = System.Drawing.Color.Salmon;
                        }
                        else
                        {
                            InventoryTB.BackColor = System.Drawing.Color.White;
                        }
                    }
                }
            }
            SaveButton.Enabled = allowSave();
        }
        //
        //Makes the textbox red when no data/wrong data is inputed & white when the correct data/data type is inputed
        //
        private void MinTB_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (string.IsNullOrWhiteSpace(MinTB.Text) || (!Int32.TryParse(MinTB.Text, out num)))
            {
                MinTB.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                MinTB.BackColor = System.Drawing.Color.White;
                if (!string.IsNullOrWhiteSpace(MinTB.Text) && !string.IsNullOrWhiteSpace(MaxTB.Text))
                {
                    if (Int32.Parse(MinTB.Text) > Int32.Parse(MaxTB.Text))
                    {
                        MessageBox.Show("Minimum Inventory Number cannot be greater than the Maximum Inventory Number.");
                        MaxTB.BackColor = System.Drawing.Color.Salmon;
                        MinTB.BackColor = System.Drawing.Color.Salmon;
                    }
                    else if (Int32.Parse(MinTB.Text) == Int32.Parse(MaxTB.Text))
                    {
                        MessageBox.Show("The Minimum Inventory Number and the Maximum Inventory Number cannot be equal.");
                        MaxTB.BackColor = System.Drawing.Color.Salmon;
                        MinTB.BackColor = System.Drawing.Color.Salmon;
                    }
                    else
                    {
                        MaxTB.BackColor = System.Drawing.Color.White;
                        MinTB.BackColor = System.Drawing.Color.White;
                        if (Int32.Parse(InventoryTB.Text) < Int32.Parse(MinTB.Text) || Int32.Parse(InventoryTB.Text) > Int32.Parse(MaxTB.Text))
                        {
                            MessageBox.Show("Your Inventory must fall between the Minimum Inventory and the Maximum Inventory Numbers.");
                            InventoryTB.BackColor = System.Drawing.Color.Salmon;
                        }
                        else
                        {
                            InventoryTB.BackColor = System.Drawing.Color.White;
                        }
                    }
                }
            }
            SaveButton.Enabled = allowSave();
        }
    }
}
