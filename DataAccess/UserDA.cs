using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using BusinessObject;
using System.Data;

namespace DataAccess
{
    public class UserDA
    {
        SqlConnection con;
        //SqlConnection con = new SqlConnection(@"")
        //SqlConnection con; = new SqlConnection();
        //UserBO BO;
        public int CheckAdmin(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            SqlCommand cmd = new SqlCommand("CheckLogin", con);

            cmd.Parameters.AddWithValue("User", ObjBO.UserName);
            cmd.Parameters.AddWithValue("Pass", ObjBO.Password);
            con.Open();

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            if (dr.Read())
            {
                dr.Close();
                return 1;
            }
            else
            {
                dr.Close();
                return 0;
            }
        }
        public int SaveVendor(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            SqlCommand cmd;
            cmd = new SqlCommand("CheckVendor", con);

            cmd.Parameters.AddWithValue("ID1", ObjBO.VId);
            con.Open();

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            if (dr.Read())
            {
                dr.Close();
                return 0;
            }
            else
            {
                dr.Close();

                cmd = new SqlCommand("SaveVendor", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID1", ObjBO.VId);
                cmd.Parameters.AddWithValue("Name1", ObjBO.Vendor);
                cmd.Parameters.AddWithValue("City1", ObjBO.City);
                cmd.Parameters.AddWithValue("Address1", ObjBO.Address);
                cmd.Parameters.AddWithValue("Mobile1", ObjBO.Mobile);
                cmd.Parameters.AddWithValue("Status1", ObjBO.Status);

                cmd.ExecuteNonQuery();

                return 1;
            }
        }

        public SqlDataReader vendor()
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            string query = "select * from VendorDB";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            return dr;
        }

        public SqlDataReader vendorname()
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            string query = "select Name from VendorDB where Status=@Status1";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("Status1", "UNBLOCK");
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            return dr;
        }

        public SqlDataReader VendorNN()
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            string query = "select Vendor from StockDB where Status=@Status1";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("Status1", "UNBLOCK");
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            return dr;
        }

        public SqlDataReader vendorfind(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            string query = "select * from VendorDB where Name = @Name1";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("Name1", ObjBO.Vendor);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            return dr;
        }

        public int deleteVendor(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            int r;
            SqlCommand cmd = new SqlCommand("deletevendor", con);

            cmd.Parameters.AddWithValue("Name", ObjBO.Vendor);
            con.Open();

            cmd.CommandType = CommandType.StoredProcedure;


            r = cmd.ExecuteNonQuery();
            cmd.Dispose();

            return r;
        }

        public int updateVendor(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            int r;
            SqlCommand cmd = new SqlCommand("updatevendor", con);

            cmd.Parameters.AddWithValue("Name", ObjBO.Vendor);
            cmd.Parameters.AddWithValue("Status", ObjBO.Status);
            con.Open();

            cmd.CommandType = CommandType.StoredProcedure;


            r = cmd.ExecuteNonQuery();
            cmd.Dispose();

            return r;
        }

        public SqlDataReader pro()
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            string query = "select Product from Stock_Summery";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            return dr;
        }

        public void mo(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            string query = "select * from VendorDB where Name = @Name";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("Name", ObjBO.Vendor);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            if (dr.Read())
            {
                ObjBO.Mobile = dr["mobile"].ToString();
            }
        }

        public void TStock(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            string query = "select * from stock_summary where product = @pro";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("pro", ObjBO.Product);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            if (dr.Read())
            {
                ObjBO.TotalStock = int.Parse(dr["stock"].ToString());
            }
            else
            {
                ObjBO.TotalStock = 0;
            }
        }

        public int SSave(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            int r = 0;
            SqlCommand cmd;
            string q = "select * from stock where id=@id";
            cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("id", ObjBO.SId);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                return 0;
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("savestock", con);

                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("id", ObjBO.SId);
                cmd.Parameters.AddWithValue("vendor", ObjBO.Vendor);
                cmd.Parameters.AddWithValue("mobile", ObjBO.Mobile);
                cmd.Parameters.AddWithValue("product", ObjBO.Product);
                cmd.Parameters.AddWithValue("cost", ObjBO.Cost);
                cmd.Parameters.AddWithValue("qun", ObjBO.Quentity);
                cmd.Parameters.AddWithValue("total", ObjBO.TotalAmount);
                cmd.Parameters.AddWithValue("scount", ObjBO.TotalStock);
                cmd.Parameters.AddWithValue("date", DateTime.Now.ToString("dd/MM/yyyy"));

                con.Open();
                r = cmd.ExecuteNonQuery();
                cmd.Dispose();

                return r;
            }
        }

        public void SSSave(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            SqlCommand cmd;
            string q = "select * from stock_summary where product = @product";
            cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("product", ObjBO.Product);
            con.Open();



            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            if (dr.Read())
            {
                dr.Close();

                string q1 = "select sum(total) from stock_summary where product = @product";

                cmd = new SqlCommand(q1, con);

                cmd.Parameters.AddWithValue("product", ObjBO.Product);
                int t = int.Parse(cmd.ExecuteScalar().ToString());


                string q2 = "update stock_summary set stock=@stock,total=@total where product = @pro";
                cmd = new SqlCommand(q2, con);


                cmd.Parameters.AddWithValue("pro", ObjBO.Product);
                cmd.Parameters.AddWithValue("stock", ObjBO.TotalStock);
                cmd.Parameters.AddWithValue("total", t + ObjBO.TotalAmount);

                cmd.ExecuteNonQuery();
            }
            else
            {
                dr.Close();

                string q3 = "insert into stock_summary values(@pro,@stock,@total)";
                cmd = new SqlCommand(q3, con);


                cmd.Parameters.AddWithValue("pro", ObjBO.Product);
                cmd.Parameters.AddWithValue("stock", ObjBO.TotalStock);
                cmd.Parameters.AddWithValue("total", ObjBO.TotalAmount);

                cmd.ExecuteNonQuery();

            }
        }



        public SqlDataReader stockS()
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            SqlCommand cmd;
            SqlDataReader dr;

            con.Open();

            string query = "select * from stock_summary";
            cmd = new SqlCommand(query, con);



            dr = cmd.ExecuteReader();
            cmd.Dispose();

            return dr;
        }

        public SqlDataReader stock(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            string query = "select * from stock where product = @pro";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("pro", ObjBO.Product);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            return dr;
        }


        public int saveSell(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            int r = 0;

            string q = "select * from sell where id=@id";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("id", ObjBO.CId);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                return 0;
            }
            else
            {
                dr.Close();
                string query = "insert into sell values(@id,@product,@max,@sell,@scount,@date)";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("id", ObjBO.CId);
                cmd.Parameters.AddWithValue("product", ObjBO.Product);
                cmd.Parameters.AddWithValue("max", ObjBO.Max);
                cmd.Parameters.AddWithValue("sell", ObjBO.Sell);
                cmd.Parameters.AddWithValue("scount", ObjBO.Quentity);
                cmd.Parameters.AddWithValue("date", DateTime.Now.ToString("dd/MM/yyyy"));

                con.Open();
                r = cmd.ExecuteNonQuery();
                cmd.Dispose();

                return r;
            }
        }



        public SqlDataReader sell()
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            string query = "select * from sell";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            return dr;
        }

        public SqlDataReader sell2(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            string query = "select * from sell where product = @pro";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("pro", ObjBO.Product);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            return dr;
        }

        public void updatesel(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            string query = "update sell set sell=@sell where id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", ObjBO.SId);
            cmd.Parameters.AddWithValue("sell", ObjBO.Sell);
            con.Open();

            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }


        public void stockUpdate(UserBO ObjBO)
        {
            string path = @"Data Source=DESKTOP-7HSIJCL;Initial Catalog=E_Stock;Integrated Security=True;";
            con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd;

            string q = "select * from stock_summary where product=@pro";
            cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("pro", ObjBO.Product);

            SqlDataReader dr = cmd.ExecuteReader();

            int ts = 0, total = 0;
            if (dr.Read())
            {
                ts = int.Parse(dr["stock"].ToString());
                total = int.Parse(dr["total"].ToString());
            }
            dr.Close();

            ts += ObjBO.Quentity;
            total += ObjBO.TotalAmount;

            string q2 = "update stock_summary set stock=@stock, total=@total  where product=@pro";
            cmd = new SqlCommand(q2, con);
            cmd.Parameters.AddWithValue("pro", ObjBO.Product);
            cmd.Parameters.AddWithValue("stock", ts);
            cmd.Parameters.AddWithValue("total", total);

            cmd.ExecuteNonQuery();

            dr.Close();



            string q3 = "select * from stock where id=@id";
            cmd = new SqlCommand(q3, con);
            cmd.Parameters.AddWithValue("id", ObjBO.SId);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                ts = int.Parse(dr["quentity"].ToString());
                total = int.Parse(dr["total"].ToString());
            }
            dr.Close();

            ts += ObjBO.Quentity;
            total += ObjBO.TotalAmount;

            string q4 = "update stock set quentity=@stock, total=@total  where id=@id";
            cmd = new SqlCommand(q4, con);
            cmd.Parameters.AddWithValue("id", ObjBO.SId);
            cmd.Parameters.AddWithValue("stock", ts);
            cmd.Parameters.AddWithValue("total", total);

            cmd.ExecuteNonQuery();

            dr.Close();
        }
    }
}
