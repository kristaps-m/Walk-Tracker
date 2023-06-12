using System;
using System.Collections.Generic;
using System.ComponentModel;
using WalkTracker.Models;
using WalkTracker.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalkTracker.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}