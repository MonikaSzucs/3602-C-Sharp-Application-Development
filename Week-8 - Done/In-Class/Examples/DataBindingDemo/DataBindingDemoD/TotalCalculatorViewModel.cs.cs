using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemoD 
{
    // this interface is key to allow binding events
    class TotalCalculatorViewModel : INotifyPropertyChanged
    {
        // even tmust be declared
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            Debug.WriteLine("Firing PropertyChanged event");
            // the question marks i a null conditional. If it is not null then invoke this thing
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public AmountList Amounts { get; }
        public int TotalAmount
        {
            get
            {
                return Amounts.TotalAmount;
            }
        }

        
        public TotalCalculatorViewModel()
        {
            Amounts = new AmountList();
            Debug.WriteLine("totalCalculator Constructor: Subscribing to ListChanged Event in AmountList : BindingList<T>");

            Amounts.ListChanged += Amounts_ListChanged;
        }

        //Catch the event that the BindingList<T> raises and then throw our own 
        //event to notify that TotalAmount may have changed.
        private void Amounts_ListChanged(object sender, ListChangedEventArgs e)
        {
            Debug.WriteLine("Handling ListChanged Event fired by AmountList : BindingList<T>");
            OnPropertyChanged("TotalAmount");
        }


        //We could do something like this instead - Have methods for adding
        //and removing from the list that also raise events.
        //But, that since it isn't completely obvious that this is here,
        //it may lead to issues as developers don't notice it and bypass it, 
        //adding directly to the list.
        //
        //private int currentAmount;
        //public int CurrentAmount
        //{
        //    get
        //    {
        //        return currentAmount;
        //    }
        //    set
        //    {
        //        currentAmount = value;
        //        OnPropertyChanged();
        //    }
        //}
        //public void AddCurrentAmount()
        //{
        //    this.Amounts.Add(CurrentAmount);
        //    OnPropertyChanged("TotalAmount");
        //}
    }
}
