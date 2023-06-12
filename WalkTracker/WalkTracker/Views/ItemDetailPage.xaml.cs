using System.ComponentModel;
using WalkTracker.ViewModels;
using Xamarin.Forms;

namespace WalkTracker.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}