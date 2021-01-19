using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class Audiobook: Book
    {
        protected internal int duration;

        protected internal Audiobook(decimal price, int stock, string title, string author, string isbn, int duration, Category category) : base(price, stock, title, author, isbn, category)
        {
            this.duration = duration;
            
        }

        public override string ToString()
        {
            return $"{GetType().Name} : {title} ({author}, {duration} minutes) {category}, ({(int)category}))";
        }
    }
}
