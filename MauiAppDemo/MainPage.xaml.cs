
using MauiAppDemo.ViewModels;

namespace MauiAppDemo
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage(CarListViewModel carListView)
        {
            Title = "Car list1";
            InitializeComponent();
            BindingContext = carListView;
        }

        
    }

}
