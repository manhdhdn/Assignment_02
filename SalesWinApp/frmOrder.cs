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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        public IOrderRepository OrderRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Order OrderInfo { get; set; }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtOrderID.Text = OrderInfo.OrderId.ToString();
                txtMemberID.Text = OrderInfo.MemberId.ToString();
                txtOrderDate.Text =OrderInfo.OrderDate.ToString();
                txtRequiredDate.Text = OrderInfo.RequiredDate.ToString();
                txtShippedDate.Text = OrderInfo.ShippedDate.ToString();
                txtFreight.Text = OrderInfo.Freight.ToString();             
            }
            else
            {
                btnOrderDetailList.Enabled = false;
                btnAddOrderDetail.Enabled = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new Order
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };

                if (InsertOrUpdate == false)
                {
                    OrderRepository.InsertOrder(order);
                }
                else
                {
                    OrderRepository.UpdateOrder(order);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new order" : "Update order");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail
            {
                Text = "Add New Order Detal",

            };
            frmOrderDetail.ShowDialog();
        }

        private void btnOrderDetailList_Click(object sender, EventArgs e)
        {
            if(InsertOrUpdate == false)
            {
                btnOrderDetailList.Enabled = false;
            }
            else
            {
                btnOrderDetailList.Enabled = true;
                frmOderDetailManagement frmOderDetailManagement = new frmOderDetailManagement
                {
                    Text = "Order Detail List",                   
                };
                frmOderDetailManagement.ShowDialog();
            }
        }

    }
}
