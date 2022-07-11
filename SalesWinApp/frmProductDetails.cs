using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetails : Form
    {
        public IProductRepository? ProductRepository { get; set; }
        public frmProductDetails()
        {
            InitializeComponent();
        }
        public bool InsertOrUpdate { get; set; }
        public Product? ProductInfo { get; set; }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            txtProductId.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtProductId.Text = ProductInfo.ProductId.ToString();
                txtCategoryId.Text = ProductInfo.CategoryId.ToString();
                txtProductName.Text = ProductInfo.ProductName;
                txtWeight.Text = ProductInfo.Weight;
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtUnitInStock.Text = ProductInfo.UnitInStock.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                    UnitInStock = int.Parse(txtUnitInStock.Text),
                };
                if (InsertOrUpdate == false)
                {
                    ProductRepository.InsertProduct(product);

                }
                else
                {
                    ProductRepository.UpdateProduct(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new product" : "Update product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        
    }
}
