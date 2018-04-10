using System; // why u using always system namespace everywhere
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DragAndDrop
{
    public class Product
    {
        public string Name { get; set; }
        public int Qty { get; set; }
        
        

        public static ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>(new Product[] {
                    new Product { Name="Product1", Qty=10, Description="Description 1" },
                    new Product { Name="Product2", Qty=5, Description="Description 2" },
                    new Product { Name="Product3", Qty=15, Description="Description 3" }
            });
        }
    }
}
