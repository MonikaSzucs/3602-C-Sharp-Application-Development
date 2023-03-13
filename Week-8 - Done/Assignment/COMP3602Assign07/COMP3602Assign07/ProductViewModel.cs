using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign07
{
    internal class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /*protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/

        public ProductViewModel()
        {
            // get the list of customers from the db
            /*products = ClientRepository.GetCustomerLocations();

            ProductSource = new BindingSource();
            ProductSource.DataSource = products;
            ProductSource.ListChanged += ProductSource_ListChanged;
            DisplayProduct*/
        }


        private void ProductSource_ListChanged(object senter, ListChangedEventArgs e)
        {
            //OnPropertyChanged("Count");
            //OnPropertyChanged("Totals");
        }
    }
}
