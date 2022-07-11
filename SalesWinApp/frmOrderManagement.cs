using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessObject;

namespace SalesWinApp
{
    public partial class frmOrderManagement : Form
    {
        readonly IOrderRepository orderRepository = new OrderRepository();
        BindingSource source = null!;
        public frmOrderManagement()
        {
            InitializeComponent();
        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvOrderList.CellDoubleClick += DgvOrderList_CellDoubleClick;
        }

        private void DgvOrderList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmOrder frmOrder = new frmOrder
            {
                Text = "Update order",
                InsertOrUpdate = true,
                OrderInfo = GetOrderObject(),
                OrderRepository = orderRepository
            };
            if (frmOrder.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                source.Position = source.Count - 1;
            }
        }

        private Order GetOrderObject()
        {
            Order orderObject = null!;
            try
            {
                orderObject = new Order
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order");
            }
            return orderObject;
        }
        public void LoadOrderList()
        {
            var orders = orderRepository.GetOrders(null, null);
            try
            {
                source = new BindingSource
                {
                    DataSource = orders
                };

                txtOrderID.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;

                if (!orders.Any())
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

                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                orderRepository.DeleteOrder(order.OrderId);
                LoadOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a order");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var search = orderRepository.GetOrder(int.Parse(txtSearch.Text));

                source = new BindingSource
                {
                    DataSource = search
                };

                txtOrderID.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;

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
            frmOrder frmOrder = new frmOrder
            {
                Text = "Add new order",
                InsertOrUpdate = false,
                OrderRepository = orderRepository
            };
            if (frmOrder.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                source.Position = source.Count - 1;
            }
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            frmOderDetailManagement frmOderDetailManagement = new frmOderDetailManagement
            {
                Text = "Order Details"
            };
            frmOderDetailManagement.ShowDialog();
        }
    }
}
