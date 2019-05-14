﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp.Controls
{
    public sealed partial class CustomerDetailsControl : UserControl
    {
        public static readonly DependencyProperty CustomerProperty =
          DependencyProperty.Register("Customer", typeof(Customer), typeof(CustomerDetailsControl), new PropertyMetadata(null));
        public CustomerDetailsControl()
        {
            this.InitializeComponent();
        }
        public Customer Customer
        {
            get { return (Customer)GetValue(CustomerProperty); }
            set { SetValue(CustomerProperty, value); }
        }
    }
}
