using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{

    enum Category
    {
        History = 1,
        Thriller = 2,
        Fantasy = 3,
        Food = 4,
        Chiildren = 5,
    }

    class Book: Item
    {


        protected internal string author;
        protected internal string isbn;
        protected internal Category category;

        protected internal Book(decimal price, int stock, string title, string author, string isbn, Category category) : base(price, stock, title)
        {
        
            this.author = author;
            this.isbn = isbn;
            this.category = category;
        }

        public override string ToString()
        {
            return $"{GetType().Name} : {title} ({author}, {category}, ({(int)category}))";
        }

    }
}
