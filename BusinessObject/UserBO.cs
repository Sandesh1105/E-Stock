using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class UserBO
    {
        private string _Username, _Password;
        private string _Vendor, _City, _Address, _Mobile, _Status, _Product;
        private int _VId, _STd, _Cost, _Quentity, _TotalStock, _TotalAmount, _TA, _TS, _CId, _Max, _Sell;
        public string UserName
        { get { return _Username; } set { _Username = value; } }

        public string Password
        { get { return _Password; } set { _Password = value; } }

        public int VId
        { get { return _VId; } set { _VId = value; } }

        public int Sell
        { get { return _Sell; } set { _Sell = value; } }


        public int CId
        { get { return _CId; } set { _CId = value; } }
        public int Max
        { get { return _Max; } set { _Max = value; } }

        public string Vendor
        { get { return _Vendor; } set { _Vendor = value; } }

        public string City
        { get { return _City; } set { _City = value; } }

        public string Address
        { get { return _Address; } set { _Address = value; } }

        public string Mobile
        { get { return _Mobile; } set { _Mobile = value; } }

        public string Status
        { get { return _Status; } set { _Status = value; } }


        public string Product
        { get { return _Product; } set { _Product = value; } }

        public int SId
        { get { return _STd; } set { _STd = value; } }

        public int Cost
        { get { return _Cost; } set { _Cost = value; } }

        public int Quentity
        {
            get { return _Quentity; }
            set { _Quentity = value; }
        }

        public int TotalStock
        {
            get { return _TotalStock; }
            set { _TotalStock = value; }
        }

        public int TotalAmount
        {
            get { return _TotalAmount; }
            set { _TotalAmount = value; }
        }

        public int TA
        {
            get { return _TA; }
            set { _TA = value; }
        }

        public int TS
        {
            get { return _TS; }
            set { _TS = value; }
        }
    }
}
