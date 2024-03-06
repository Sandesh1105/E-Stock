using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessObject;

namespace WebApplicationFinalMachinTest
{
    public partial class Default : System.Web.UI.Page
    {
        UserBO BO = new UserBO();
        UserBL BL = new UserBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {         
            if (txtPass.Text == "" || txtUN.Text == "")
            {
                Response.Write("<script>alert('Fill Complete form first');</script>");
            }
            else
            {
                BO.UserName = txtUN.Text;
                BO.Password = txtPass.Text;

                int r = BL.checkAdmin(BO);

                if (r > 0)
                {
                    Response.Redirect("AdminPanel.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Wrong UserName amd Password');</script>");
                }
            }
        }
    }
}