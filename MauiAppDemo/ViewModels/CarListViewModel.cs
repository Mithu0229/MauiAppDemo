


using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppDemo.Models;
using MauiAppDemo.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiAppDemo.ViewModels
{
    public partial class CarListViewModel : BaseViewModel
    {
        private readonly CarService carService;
        
        public ObservableCollection<Car> Cars { get; private set; } = new ();

        public CarListViewModel(CarService carService)
        {
            this.carService = carService;
        }

        //[ObservableProperty]
        //bool IsRefreshing;

        [RelayCommand]
        async Task GetCarList()
        {
            if(IsLoading)return;
            try
            {
                IsLoading = true;
                if (Cars.Any()) Cars.Clear();
                var cars = carService.GetCars();
                foreach (var car in cars) { Cars.Add(car); }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("this error from "+ex);
                await Shell.Current.DisplayAlert("Error", "Faild to car list", "Ok");
            }
            finally
            {
                IsLoading = false;
                //IsRefreshing = false;
            }
        }
    }
}
