using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingDemoF
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
            products = DataGenerator.CreateProducts();
            ProductsSource = new BindingSource();
            ProductsSource.DataSource = products;
            ProductsSource.ListChanged += ProductSource_ListChanged;
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
                    IsTaxable = value.IsTaxable
                };
                OnPropertyChanged();
            }
        }
        private readonly ProductList products;

        //** Set up the Binding Source
        public BindingSource ProductsSource { get; }

        //Can't access count directly when databinding
        public int Count { 
            get { 
                return products.Count; 
            } 
        }

        private void ProductSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            OnPropertyChanged("Count");
        }

    }
}
