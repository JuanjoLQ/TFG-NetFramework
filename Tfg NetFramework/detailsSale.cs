using capaEntidad;
using CapaNegocio;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Tfg_NetFramework
{
    public partial class detailsSale : Form
    {
        cnSale cnSale = new cnSale();
        cnProduct cnProduct = new cnProduct();

        ceDescripcionItem descrItem = null;
        
        public detailsSale(ceDescripcionItem descriptionItem, int idSale)
        {
            InitializeComponent();
            this.descrItem = descriptionItem;

            blbDetailsSaleNameCustomer.Text = "<h4>" + descrItem.Customer.Name + "</h4>";
            blbDetailsSaleNameLead.Text = "<h4>" + descrItem.Lead.Name + "</h4>";
            blbDetailsSaleDate.Text = "<h4>" + cnSale.datetimeSale(idSale) + "</h4>";

            fillBdgvDetailsSale(cnProduct.obtainSoldProducts(idSale));

            //Labels
            blbDetailsSale.Text = "<h3>" + Res.DetailsSale + "</h3>";
        }

        private void detailsSale_Load(object sender, EventArgs e)
        {
            //Buttons
            btnClose.Text = Res.Exit;
        }

        private void fillBdgvDetailsSale(ArrayList arr)
        {
            bdgvDetailsSale.RowCount = 0;
            ceProduct p = null;
            for (int i = 0; i < arr.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                p = (ceProduct)arr[i];

                newRow.CreateCells(bdgvDetailsSale);
                newRow.Cells[0].Value = p.idProduct;
                newRow.Cells[1].Value = p.name;
                newRow.Cells[2].Value = p.pricePerUnit;
                newRow.Cells[3].Value = p.amount;
                newRow.Cells[4].Value = p.unitOfMeasure;
                newRow.Cells[5].Value = p.productCategory;
                newRow.Cells[6].Value = p.state;

                bdgvDetailsSale.Rows.Add(newRow);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
