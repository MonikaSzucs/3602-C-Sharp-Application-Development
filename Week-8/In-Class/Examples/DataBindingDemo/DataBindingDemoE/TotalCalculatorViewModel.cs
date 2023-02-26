using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingDemoE
{
    class TotalCalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private readonly AmountList amounts;
        public BindingSource Amounts { get; }
        public int TotalAmount => amounts.TotalAmount;
        public int Count => amounts.Count;
        public decimal Average => amounts.Average;
        public TotalCalculatorViewModel()
        {
            amounts = new AmountList();
            Amounts = new BindingSource();
            Amounts.DataSource = amounts;
            Amounts.ListChanged += Amounts_ListChanged;
        }

        private void Amounts_ListChanged(object sender, ListChangedEventArgs e)
        {


            OnPropertyChanged("TotalAmount"); 
            OnPropertyChanged("Count"); 
            OnPropertyChanged("Average");
        }
    }
}
