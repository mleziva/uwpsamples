﻿using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomersApp.Base;
using WiredBrainCoffee.CustomersApp.DataProvider;
using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp.ViewModel
{
    public class MainViewModel : Observable
    {
        private ICustomerDataProvider _customerDataProvider;
        private Customer _selectedCustomer;

        public MainViewModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider;
            Customers = new ObservableCollection<Customer>();

        }

        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                if(_selectedCustomer != value)
                {
                    _selectedCustomer = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<Customer> Customers { get; }

        public async Task LoadAsync()
        {
            Customers.Clear();
            var customers = await _customerDataProvider.LoadCustomersAsync();
            foreach (var cust in customers)
            {
                Customers.Add(cust);
            }
        }


        public async Task SaveAsync()
        {
            await _customerDataProvider.SaveCustomersAsync(Customers);
        }
    }
}
