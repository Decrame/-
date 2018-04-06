using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSproject
{
    class Item
    {
        public string name
        {
            get { return mName; }
            private set { }
        }

        public double price
        {
            get { return mPrice; }
            private set { }
        }
        //members
        private string mName;
        private double mPrice;
        private User   mSeller;
        private int mLikeCnt;
        private int mDislikeCnt;
        private Category mCategory;

    }
}
