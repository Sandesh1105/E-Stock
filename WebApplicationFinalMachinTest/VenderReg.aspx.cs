using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BusinessLogic;
using BusinessObject;

namespace WebApplicationFinalMachinTest
{
    public partial class VenderReg : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        UserBO Bo = new UserBO();
        UserBL BL = new UserBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //    string path = ConfigurationManager.AppSettings["MyDB"];
            //    con = new SqlConnection(path);
            //    con.Open();

            //    cmd = new SqlCommand("SaveVendor", con);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    cmd.Parameters.AddWithValue("@ID1", txtID.Text);
            //    cmd.Parameters.AddWithValue("@Name1", txtVender.Text);
            //    cmd.Parameters.AddWithValue("@City1", ddlCity.SelectedValue);
            //    cmd.Parameters.AddWithValue("@Address1", txtAddress.Text);
            //    cmd.Parameters.AddWithValue("@Mobile1", txtMobile.Text);
            //    cmd.Parameters.AddWithValue("@Status",);
            if (txtID.Text == "" || txtVender.Text == "" || txtMobile.Text == "" || txtAddress.Text == "" || ddlCity.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Fill Complete form first');</script>");
            }
            else
            {
                Bo.VId = int.Parse(txtID.Text);
                Bo.Vendor = txtVender.Text;
                Bo.Mobile = txtMobile.Text;
                Bo.Status = "UNBLOCK";
                Bo.Address = txtAddress.Text;
                Bo.City = ddlCity.SelectedValue;

                int r = BL.VendorSave(Bo);

                if (r > 0)
                {
                    Response.Write("<script>alert('Save Successfully');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Duplicate Vendor Id');</script>");
                }
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            ddlVMN.Visible = true;
            btnFind.Visible = true;

            dr = BL.venname();

            ddlVMN.DataSource = dr;
            ddlVMN.DataTextField = "Name";
            ddlVMN.DataBind();

            ddlVMN.Items.Insert(0,"All");

            //dr.Close();

            dr = BL.ven();

            GridView1.DataSource = dr;
            GridView1.DataBind();

            dr.Close();
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;

            if (ddlVMN.SelectedValue == "All")
            {
                dr = BL.ven();

                GridView1.DataSource = dr;
                GridView1.DataBind();

                dr.Close();
            }
            else
            {
                Bo.Vendor = ddlVMN.SelectedValue;
                dr = BL.venfind(Bo);

                GridView1.DataSource = dr;
                GridView1.DataBind();
            }
        }

        protected void btnE_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox txtVendor = (TextBox)r1.FindControl("txtN");
            DropDownList ddlStatus = (DropDownList)r1.FindControl("ddlS");

            Bo.Vendor = txtVendor.Text;
            Bo.Status = ddlStatus.SelectedValue;
            int r = BL.updateven(Bo);

            if (r > 0)
            {
                Response.Write("<script>alert('Update Successfully');</script>");
            }
        }

        protected void btnD_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox txtNV = (TextBox)r1.FindControl("txtN");

            Bo.Vendor = txtNV.Text;
            int r = BL.deleteven(Bo);

            if (r > 0)
            {
                Response.Write("<script>alert('Delete Successfully');</script>");
            }
        }
    }
}