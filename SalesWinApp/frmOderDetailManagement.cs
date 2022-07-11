using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOderDetailManagement : Form
    {
        readonly IOrderDetailRepository orderDetailRepository = new OrderDetailDetailRepository();
        BindingSource source = null!;
        public frmOderDetailManagement()
        {
            InitializeComponent();
        }

        private void frmOderDetailManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            LoadOrderDetailList();
            dgvOrderDetail.CellDoubleClick += DgvOrderDetail_CellDoubleClick;
        }

        private void DgvOrderDetail_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail
            {
                Text = "Update Order Detail",
                InsertOrUpdate = true,
                OrderDetailInfo = GetOrderDetailObject(),
                OrderDetailRepository = orderDetailRepository
            };
            if (frmOrderDetail.ShowDialog() == DialogResult.OK)
            {
                LoadOrderDetailList();
                source.Position = source.Count - 1;
            }
        }

        private OrderDetail GetOrderDetailObject()
        {
            OrderDetail orderDetailObject = null!;
            try
            {
                orderDetailObject = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(txtProductID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = double.Parse(txtDiscount.Text)
                };
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Get order detail");
            }
            return orderDetailObject;
        }
        public void LoadOrderDetailList()
        {

            try
            {
                var orderDetail = orderDetailRepository.GetOrderDetails();
                source = new BindingSource
                {
                    DataSource = orderDetail
                };

                txtOrderID.DataBindings.Clear();
                txtProductID.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtDiscount.DataBindings.Add("Text", source, "Discount");

                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = source;

                if (!orderDetail.Any())
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Detail List");
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadOrderDetailList();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var search = orderDetailRepository.GetOrderDetail(int.Parse(txtSearchOrderID.Text), int.Parse(txtSearchProductID.Text));
                source = new BindingSource
                {
                    DataSource = search
                };

                txtOrderID.DataBindings.Clear();
                txtProductID.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtDiscount.DataBindings.Add("Text", source, "Discount");

                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = source;

                if (search == null)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search By Order ID");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail
            {
                Text = "Add new Order Detail",
                InsertOrUpdate = false,
                OrderDetailRepository = orderDetailRepository
            };
            if (frmOrderDetail.ShowDialog() == DialogResult.OK)
            {
                LoadOrderDetailList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetail = GetOrderDetailObject();
                orderDetailRepository.DeleteOrderDetail(orderDetail.OrderId,orderDetail.ProductId);
                LoadOrderDetailList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Delete a order detail");
            }
        }
    }
}
