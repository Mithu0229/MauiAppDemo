using CommunityToolkit.Mvvm.ComponentModel;
using MauiAppDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppDemo.ViewModels
{
    [QueryProperty(nameof(Car),"Car")]
    public partial class CarDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Car car;
    }
}
