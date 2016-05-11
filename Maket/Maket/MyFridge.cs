using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace Maket
{
    class MyFridge : DataContext
    {
        public Table<Products> products;
        public MyFridge(string connection) : base(connection) { }
    }
    
    [Table(Name = "ProductsTable")]
    public class Products
    {
        [Column(IsPrimaryKey = true)]
        public string Title;
        [Column]
        public string Type;
    }

    public class Product
    {
        public string Title;
        public string Type;
        public Product(string t, string type)
        {
            Title = t;
            Type = type;
        }
    }
}
