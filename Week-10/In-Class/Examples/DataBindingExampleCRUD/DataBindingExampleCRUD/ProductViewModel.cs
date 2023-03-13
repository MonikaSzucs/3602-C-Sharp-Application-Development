using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingExampleCRUD
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ProductViewModel()
        {
            Products = ProductRepository.GetProducts();
            DisplayProduct = new Product();
        }

        private Product displayProduct;
        public Product DisplayProduct
        {
            get { return displayProduct; }
            set
            {
                displayProduct = new Product
                {
                    Quantity = value.Quantity,
                    ProductId = value.ProductId,
                    Sku = value.Sku,
                    Description = value.Description,
                    Cost = value.Cost,
                    Taxable = value.Taxable
                };
                OnPropertyChanged();
            }
        }
        public ProductList Products { get; set; }
    }
}
