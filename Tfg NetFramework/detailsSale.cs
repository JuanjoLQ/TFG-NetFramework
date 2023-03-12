using capaEntidad;
using CapaNegocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            blbDetailsSaleNameCustomer.Text = descrItem.Customer.Name;
            blbDetailsSaleNameLead.Text = descrItem.Lead.Name;
            blbDetailsSaleDate.Text = cnSale.datetimeSale(idSale);

            fillBdgvDetailsSale(cnProduct.obtainSoldProducts(idSale));
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
