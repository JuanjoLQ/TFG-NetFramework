using capaEntidad;
using CapaNegocio;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Tfg_NetFramework
{
    public partial class newInventoryItem : Form
    {
        cnProduct cnProduct = new cnProduct();
        cnWarehouse cnWarehouse = new cnWarehouse();
        ArrayList arr = new ArrayList();
        public newInventoryItem()
        {
            InitializeComponent();
        }

        private void newInventoryItem_Load(object sender, EventArgs e)
        {
            
        }

        private void bdInventoryItemState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bdInventoryItemState.SelectedItem.ToString() == "No")
            {
                bdInventoryItemStore.Visible = false;
            }
            else
            {
                bdInventoryItemStore.Items.Clear();
                bdInventoryItemStore.Visible = true;
                arr = cnWarehouse.getWarehouses();
                foreach (ceWarehouse i in arr)
                {
                    bdInventoryItemStore.Items.Add(i.Name);
                }
            }
        }

        private void bbInventoryItemCreate_Click(object sender, EventArgs e)
        {
            string unitMeasure = bdNewInventoryItemUnitOfMeasure.SelectedItem == null ? String.Empty :
                    bdNewInventoryItemUnitOfMeasure.SelectedItem.ToString();

            string productCategory = bdNewInventoryItemProductCategory.SelectedItem == null ? String.Empty :
                    bdNewInventoryItemProductCategory.SelectedItem.ToString();

            string stored = bdInventoryItemState.SelectedItem == null ? String.Empty :
                    bdInventoryItemState.SelectedItem.ToString();

            string nameWarehouse = bdInventoryItemStore.SelectedItem == null ? String.Empty :
                    bdInventoryItemStore.SelectedItem.ToString();

            if (btbInventoryItemAmount.Text != string.Empty && btbInventoryItemPricePerItem.Text != string.Empty &&
                btbInventoryItemAmount.Text != string.Empty && unitMeasure != string.Empty 
                && productCategory != string.Empty && stored != string.Empty)
            {
                string itemName = btbInventoryItemName.Text;
                float pricePerUnit = float.Parse(btbInventoryItemPricePerItem.Text);
                float amount = float.Parse(btbInventoryItemAmount.Text);
                
                if (nameWarehouse == string.Empty)
                {
                    ceProduct product = new ceProduct(itemName, pricePerUnit, amount, unitMeasure, productCategory, "No stored");
                    cnProduct.addProduct(product);
                }
                else
                {
                    int idWarehouse = cnWarehouse.idWarehouse(nameWarehouse);

                    ceProduct product = new ceProduct(idWarehouse, itemName, pricePerUnit, amount, unitMeasure, productCategory, "Stored");
                    cnWarehouse.addProductWarehouse(product);
                }
            }
            else
            {
                MessageBox.Show("Faltan por introducir datos");
            }
                
        }

        private void bbInventoryItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
