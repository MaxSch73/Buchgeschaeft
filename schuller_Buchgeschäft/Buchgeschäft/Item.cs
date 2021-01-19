using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class Item
    {
        protected internal decimal price;
        protected internal int stock;
        protected internal string title { get; }


        protected internal Item(decimal price, int stock, string title)
        {
            this.price = price;
            this.stock = stock;
            this.title = title;
        }

        protected internal bool TryPurchase(int number)
        {
            stock += number;
            return true;
        }
        protected internal bool TrySell(int number)
        {
            if (number <= stock)
            {
                stock -= number;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
