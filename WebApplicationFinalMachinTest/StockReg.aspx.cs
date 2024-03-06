using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BusinessLogic;
using BusinessObject;

namespace WebApplicationFinalMachinTest
{
    public partial class StockReg : System.Web.UI.Page
    {
        UserBL BL = new UserBL ();
        UserBO Bo = new UserBO();
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Display();
            }
        }

        public void Display()
        {
            dr = BL.VendorN();

            ddlVName.DataSource = dr;
            ddlVName.DataTextField = "Vender";
            ddlVName.DataBind();

            ddlVName.Items.Insert(0, "Select");

            dr.Close();

            dr = BL.product();

            ddlProduct.DataSource = dr;
            ddlProduct.DataTextField = "product";
            ddlProduct.DataBind();

            ddlProduct.Items.Insert(0, "Select");
            ddlProduct.Items.Insert(1, "Add New Product");

            dr.Close();
        }

        protected void ddlVName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bo.Vendor = ddlVName.SelectedValue;
            BL.mobile(Bo);

            txtVMobile.Text = Bo.Mobile;
        }
    }
}