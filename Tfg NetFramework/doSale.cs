using capaEntidad;
using CapaNegocio;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace Tfg_NetFramework
{
    public partial class doSale : Form
    {
        cnWarehouse cnWarehouse = new cnWarehouse();
        cnSale cnSale = new cnSale();
        cnLead cnLead = new cnLead();
        ceDescripcionItem descrItem = null;

        public doSale(ceDescripcionItem descripcionItem)
        {
            InitializeComponent();
            descrItem = descripcionItem;

            ArrayList arr = null;
            arr = cnWarehouse.obtainAllProductsFromWarehouses();

            fillBdgvProductsIntoWarehouse(arr);

        }

        private void doSale_Load(object sender, EventArgs e)
        {
            //Labels
            blbTitleDoSale.Text = "<h2>" + Res.DoSale + "</h2>";
            blbTitleTableToSale.Text = "<h3>" + Res.ProductsIncludedInTheSale + "</h3>";
            blbTitleProductsIntoWarehouses.Text = "<h3>" + Res.ProductsIntoWarehouses + "</h3>";

            //Buttons
            bbtnDoSale.Text = Res.DoSale;
            btnClose.Text = Res.Exit;

        }

        private void fillBdgvProductsIntoWarehouse(ArrayList arr)
        {
            bdgvProductsIntoWarehouse.RowCount = 0;
            ceProduct p = null;
            for (int i = 0; i < arr.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                p = (ceProduct) arr[i];

                newRow.CreateCells(bdgvProductsIntoWarehouse);
                newRow.Cells[0].Value = p.idProduct;
                newRow.Cells[1].Value = p.name;
                newRow.Cells[2].Value = p.pricePerUnit;
                newRow.Cells[3].Value = p.amount;
                newRow.Cells[4].Value = p.unitOfMeasure;
                newRow.Cells[5].Value = p.productCategory;
                newRow.Cells[6].Value = p.state;

                bdgvProductsIntoWarehouse.Rows.Add(newRow);
            }
        }


        private void bbtnDoSale_Click(object sender, EventArgs e)
        {
            int idProduct;
            if (bdgvProductsIntoSale.Rows.Count > 0)
            {
                string dt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //MessageBox.Show("Datetime today: " + dt);
                cnSale.createSale(dt);
                int idSale = cnSale.idSale(dt);
                //MessageBox.Show("idSale:" + idSale);
                foreach (DataGridViewRow row in bdgvProductsIntoSale.Rows)
                {
                    idProduct = int.Parse(row.Cells[0].Value.ToString());
                    //MessageBox.Show("idProduct: " + idProduct);
                    cnSale.addSale(idProduct, idSale);
                }
                cnLead.leadToSale(descrItem.Lead.Idlead,idSale);
            }
            
        }

        private void bdgvProductsIntoWarehouse_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selRow in bdgvProductsIntoWarehouse.SelectedRows.OfType<DataGridViewRow>().ToArray())
            {
                bdgvProductsIntoWarehouse.Rows.Remove(selRow);
                bdgvProductsIntoSale.Rows.Add(selRow);
            }
        }

        private void bdgvProductsIntoSale_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selRow in bdgvProductsIntoSale.SelectedRows.OfType<DataGridViewRow>().ToArray())
            {
                bdgvProductsIntoSale.Rows.Remove(selRow);
                bdgvProductsIntoWarehouse.Rows.Add(selRow);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
