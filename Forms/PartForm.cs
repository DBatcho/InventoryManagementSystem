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
    public partial class PartForm : Form
    {
        
        //
        //Constructor used to load the PartForm when Add Button Clicked
        //
        public PartForm()
        {
            InitializeComponent();
            SaveButton.Enabled = allowSave();
            NameTB.BackColor = System.Drawing.Color.Salmon;
            InventoryTB.BackColor = System.Drawing.Color.Salmon;
            PCTB.BackColor = System.Drawing.Color.Salmon;
            MinTB.BackColor = System.Drawing.Color.Salmon;
            MaxTB.BackColor = System.Drawing.Color.Salmon;
            MachCompTB.BackColor = System.Drawing.Color.Salmon;
        }
        //
        //Constructor used to load the PartForm when Modify Button Clicked
        //
        public PartForm(Part modify)
        {
            if (modify is Inhouse)
            {
                InitializeComponent();
                Inhouse mod = (Inhouse)modify;
                IDTB.Text = mod.PartID.ToString();
                NameTB.Text = mod.Name;
                PCTB.Text = mod.Price.ToString();
                InventoryTB.Text = mod.InStock.ToString();
                MinTB.Text = mod.Min.ToString();
                MaxTB.Text = mod.Max.ToString();
                MachCompTB.Text = mod.MachineID.ToString();
                InHouseRadio.Checked = true;
            }
            else if (modify is Outsourced)
            {
                InitializeComponent();
                Outsourced mod = (Outsourced)modify;
                IDTB.Text = mod.PartID.ToString();
                NameTB.Text = mod.Name;
                PCTB.Text = mod.Price.ToString();
                InventoryTB.Text = mod.InStock.ToString();
                MinTB.Text = mod.Min.ToString();
                MaxTB.Text = mod.Max.ToString();
                MachCompTB.Text = mod.CompanyName.ToString();
                OutsourcedRadio.Checked = true;
            }
        }
        //
        //Makes the save button unclickable unless all textboxs are filled in with the correct data type
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
                Int32.Parse(InventoryTB.Text) <= Int32.Parse(MaxTB.Text) && Int32.Parse(InventoryTB.Text) >= Int32.Parse(MinTB.Text) &&

                // returns true if Machine Id/Company Name text box has a value & if Machine ID is an int
                !string.IsNullOrWhiteSpace(MachCompTB.Text) &&
                (((InHouseRadio.Checked == true) && (Int32.TryParse(MachCompTB.Text, out inum))) ||
                ((OutsourcedRadio.Checked == true) && !string.IsNullOrWhiteSpace(MachCompLabel.Text)));
        }
        //
        //Hides Product Form, Saves New Input Data to Product Class & Opens Main Form
        //
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (MainForm.add_mod == true)
            {
                if (InHouseRadio.Checked == true)
                {
                    Inhouse insert;
                    insert = new Inhouse(Inhouse.PartIDcount++, NameTB.Text, decimal.Parse(PCTB.Text), Int32.Parse(InventoryTB.Text), Int32.Parse(MinTB.Text), Int32.Parse(MaxTB.Text), Int32.Parse(MachCompTB.Text));
                    Inventory.addPart(insert);
                }
                else if (OutsourcedRadio.Checked == true)
                {
                    Outsourced insert;
                    insert = new Outsourced(Outsourced.PartIDcount++, NameTB.Text, decimal.Parse(PCTB.Text), Int32.Parse(InventoryTB.Text), Int32.Parse(MinTB.Text), Int32.Parse(MaxTB.Text), MachCompTB.Text);
                    Inventory.addPart(insert);
                }
            }
            else
            {
                if (InHouseRadio.Checked == true)
                {
                    Inhouse insert;
                    insert = new Inhouse(Int32.Parse(IDTB.Text), NameTB.Text, decimal.Parse(PCTB.Text), Int32.Parse(InventoryTB.Text), Int32.Parse(MinTB.Text), Int32.Parse(MaxTB.Text), Int32.Parse(MachCompTB.Text));
                    Inventory.updatePart(Int32.Parse(IDTB.Text), insert);
                }
                else if (OutsourcedRadio.Checked == true)
                {
                    Outsourced insert;
                    insert = new Outsourced(Int32.Parse(IDTB.Text), NameTB.Text, decimal.Parse(PCTB.Text), Int32.Parse(InventoryTB.Text), Int32.Parse(MinTB.Text), Int32.Parse(MaxTB.Text), MachCompTB.Text);
                    Inventory.updatePart(Int32.Parse(IDTB.Text), insert);
                }
            }

            this.Hide();

            var openform = new MainForm();
            openform.Show();
        }
        //
        //Hides Product Form & Opens Main Form
        //
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var openform = new MainForm();
            openform.Show();
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
            SaveButton.Enabled = allowSave();
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
        //Makes the textbox red when no data/wrong data is inputed (checking that inventory is between the min/max amounts & white when the correct data/data type is inputed
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
        //Makes the textbox red when no data/wrong data is inputed (checks min !> & != max and that inventory falls in range) & white when the correct data/data type is inputed
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
        //
        //Makes the textbox red when no data/wrong data is inputed (checks max !< & != max and that inventory falls in range) & white when the correct data/data type is inputed
        //
        private void MachCompTB_TextChanged(object sender, EventArgs e)
        {
            int num;
            if ((string.IsNullOrWhiteSpace(MachCompTB.Text)) || (InHouseRadio.Checked && (!Int32.TryParse(MachCompTB.Text, out num))))
                {
                    MachCompTB.BackColor = System.Drawing.Color.Salmon;
                }
                else
                {
                    MachCompTB.BackColor = System.Drawing.Color.White;
                }
            SaveButton.Enabled = allowSave();
        }
        //
        //Changes label text & checks text box for proper input (changed color/save button) based on which Radio Button is checked
        //
        private void InOutRadio_Click(object sender, EventArgs e)
        {
            if (InHouseRadio.Checked == true)
            {
                MachCompLabel.Text = "Machine ID";
                int num;
                if (string.IsNullOrWhiteSpace(MachCompTB.Text) || (!Int32.TryParse(MachCompTB.Text, out num)))
                {
                    MachCompTB.BackColor = System.Drawing.Color.Salmon;
                }
                else
                {
                    MachCompTB.BackColor = System.Drawing.Color.White;
                }
                SaveButton.Enabled = allowSave();

            }
            else
            {
                MachCompLabel.Text = "Company Name";

                if (string.IsNullOrWhiteSpace(MachCompTB.Text))
                {
                    MachCompTB.BackColor = System.Drawing.Color.Salmon;
                }
                else
                {
                    MachCompTB.BackColor = System.Drawing.Color.White;
                }
                SaveButton.Enabled = allowSave();
            }
        }
    }
}
