using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessObject;
using DataAccess;

namespace BusinessLogic
{
    public class UserBL
    {
        public int checkAdmin(UserBO ObjBO2)
        {
            UserDA DA = new UserDA();
            return DA.CheckAdmin(ObjBO2);
        }

        public int VendorSave(UserBO ObjBO2)
        {
            UserDA DA = new UserDA();
            return DA.SaveVendor(ObjBO2);
        }


        public SqlDataReader venname()
        {
            UserDA DA = new UserDA();
            return DA.vendorname();
        }
        public SqlDataReader VendorN()
        {
            UserDA DA = new UserDA();
            return DA.VendorNN();
        }
        public SqlDataReader ven()
        {
            UserDA DA = new UserDA();
            return DA.vendor();
        }

        public SqlDataReader venfind(UserBO ObjBo2)
        {
            UserDA DA = new UserDA();
            return DA.vendorfind(ObjBo2);
        }

        public int deleteven(UserBO ObjBo2)
        {
            UserDA DA = new UserDA();
            return DA.deleteVendor(ObjBo2);
        }

        public int updateven(UserBO ObjBo2)
        {
            UserDA DA = new UserDA();
            return DA.updateVendor(ObjBo2);
        }

        public SqlDataReader product()
        {
            UserDA DA = new UserDA();
            return DA.pro();
        }

        public void mobile(UserBO ObjBO2)
        {
            UserDA DA = new UserDA();
            DA.mo(ObjBO2);
        }

        public void TotalStock(UserBO ObjBO2)
        {
            UserDA DA = new UserDA();
            DA.TStock(ObjBO2);
        }

        public int StockSave(UserBO ObjBO2)
        {
            UserDA DA = new UserDA();
            return DA.SSave(ObjBO2);
        }

        public void StockSaveS(UserBO ObjBO2)
        {
            UserDA DA = new UserDA();
            DA.SSSave(ObjBO2);
        }

        public SqlDataReader sstock()
        {
            UserDA DA = new UserDA();
            return DA.stockS();
        }

        public SqlDataReader s(UserBO ObjBO2)
        {
            UserDA DA = new UserDA();
            return DA.stock(ObjBO2);
        }

        public void UpdateStock(UserBO ObjBO2)
        {
            UserDA DA = new UserDA();
            DA.stockUpdate(ObjBO2);
        }



        public int saveSell(UserBO ObjBO2)
        {
            UserDA DA = new UserDA();
            return DA.saveSell(ObjBO2);
        }

        public SqlDataReader sel()
        {
            UserDA DA = new UserDA();
            return DA.sell();
        }

        public SqlDataReader sel2(UserBO ObjBO2)
        {
            UserDA DA = new UserDA();
            return DA.sell2(ObjBO2);
        }

        public void updatesell(UserBO ObjBO2)
        {
            UserDA DA = new UserDA();
            DA.updatesel(ObjBO2);
        }
    }
}
