using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class Newspaper : Item
    {
        protected internal DateTime dateOfIssue;

        protected internal Newspaper(decimal price, int stock, string title, DateTime dateOfIssue) : base(price, stock, title)
        {
            this.dateOfIssue = dateOfIssue.Date;
        }


        public override string ToString()
        {
            return $"{GetType().Name} : {title} ({dateOfIssue})";
        }
    }
}
